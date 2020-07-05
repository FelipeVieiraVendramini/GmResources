// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - ActionTranslator - FrmMain.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleTranslateFreeApi;
using MyCore;
using MyCore.Database;
using MyCore.Database.Entities;
using MyCore.Database.Repositories;

#endregion

namespace ActionTranslator
{
    public partial class FrmMain : Form
    {
        private const string _GAME_SERVER_CONFIG_S = "GameServer.xml";
        private const string _ACCOUNT_SERVER_CONFIG_S = "AccountServer.xml";

        private GoogleTranslator m_translator = new GoogleTranslator();
        private List<GameActionEntity> m_entities = new List<GameActionEntity>();
        private List<GameActionEntity> m_newEntities = new List<GameActionEntity>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MyXml xml = new MyXml(_GAME_SERVER_CONFIG_S);
            string hostname = xml.GetStr("GameServerConfiguration", "GameMySQL", "Hostname");
            string username = xml.GetStr("GameServerConfiguration", "GameMySQL", "Username");
            string password = xml.GetStr("GameServerConfiguration", "GameMySQL", "Password");
            string database = xml.GetStr("GameServerConfiguration", "GameMySQL", "Database");
            string szPort = xml.GetStr("GameServerConfiguration", "GameMySQL", "Port");
            if (ushort.TryParse(szPort, out ushort usPort))
                usPort = 3306;
            Kernel.GameDbConfig = new MySqlConfig(hostname, username, password, database, usPort);

            hostname = xml.GetStr("GameServerConfiguration", "LogMySQL", "Hostname");
            username = xml.GetStr("GameServerConfiguration", "LogMySQL", "Username");
            password = xml.GetStr("GameServerConfiguration", "LogMySQL", "Password");
            database = xml.GetStr("GameServerConfiguration", "LogMySQL", "Database");
            szPort = xml.GetStr("GameServerConfiguration", "LogMySQL", "Port");
            if (ushort.TryParse(szPort, out usPort))
                usPort = 3306;
            Kernel.LogDbConfig = new MySqlConfig(hostname, username, password, database, usPort);

            hostname = xml.GetStr("GameServerConfiguration", "ResourceMySQL", "Hostname");
            username = xml.GetStr("GameServerConfiguration", "ResourceMySQL", "Username");
            password = xml.GetStr("GameServerConfiguration", "ResourceMySQL", "Password");
            database = xml.GetStr("GameServerConfiguration", "ResourceMySQL", "Database");
            szPort = xml.GetStr("GameServerConfiguration", "ResourceMySQL", "Port");
            if (ushort.TryParse(szPort, out usPort))
                usPort = 3306;
            Kernel.ResourceDbConfig = new MySqlConfig(hostname, username, password, database, usPort);

            xml = new MyXml(_ACCOUNT_SERVER_CONFIG_S);
            hostname = xml.GetStr("AccountServerConfiguration", "MySQL", "Hostname");
            username = xml.GetStr("AccountServerConfiguration", "MySQL", "Username");
            password = xml.GetStr("AccountServerConfiguration", "MySQL", "Password");
            database = xml.GetStr("AccountServerConfiguration", "MySQL", "Database");
            szPort = xml.GetStr("AccountServerConfiguration", "MySQL", "Port");
            if (ushort.TryParse(szPort, out usPort))
                usPort = 3306;
            Kernel.AccountDbConfig = new MySqlConfig(hostname, username, password, database, usPort);

            SessionFactory.StartAccountConnection(Kernel.AccountDbConfig.Host,
                Kernel.AccountDbConfig.User,
                Kernel.AccountDbConfig.Pass,
                Kernel.AccountDbConfig.Database,
                Kernel.AccountDbConfig.Port);
            SessionFactory.StartGameConnection(Kernel.GameDbConfig.Host,
                Kernel.GameDbConfig.User,
                Kernel.GameDbConfig.Pass,
                Kernel.GameDbConfig.Database,
                Kernel.GameDbConfig.Port);
            SessionFactory.StartLogConnection(Kernel.LogDbConfig.Host,
                Kernel.LogDbConfig.User,
                Kernel.LogDbConfig.Pass,
                Kernel.LogDbConfig.Database,
                Kernel.LogDbConfig.Port);
            SessionFactory.StartResourceConnection(Kernel.ResourceDbConfig.Host,
                Kernel.ResourceDbConfig.User,
                Kernel.ResourceDbConfig.Pass,
                Kernel.ResourceDbConfig.Database,
                Kernel.ResourceDbConfig.Port);
        }

        private async void btnGetActions_Click(object sender, EventArgs e)
        {
            dgvOriginal.Rows.Clear();
            dgvNew.Rows.Clear();
            m_entities.Clear();
            m_newEntities.Clear();

            await GetActions();
        }

        private Task GetActions()
        {
            string[] getActions = txtTranslateTypes.Text.Split(';');
            var allActions = new GameActionRepository().FetchAll();
            foreach (var action in allActions)
            {
                if (getActions.All(x => int.Parse(x) != action.Type))
                    continue;

                m_entities.Add(action);
                dgvOriginal.Rows.Add(action.Identity, action.IdNext, action.IdNextfail, action.Type, action.Data,
                    action.Param);
            }

            int characters = m_entities.Sum(x => x.Param.Length);
            lblEstimatedTime.Text =
                $@"ms. Total translation will last {characters / 700d * (int) numMs.Value / 1000d} seconds. {m_entities.Count:N0} rows. {characters:N0} characters.";
            return Task.CompletedTask;
        }

        private async void btnTranslateAction_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("cq_action_cn_to_en.SQL", true)
            {
                AutoFlush = true
            };
            try
            {
                BlockControls();

                m_newEntities.Clear();
                pbProgressAction.Value = 0;
                pbProgressAction.Maximum = m_entities.Count;

                int rowCount = 0;
                string currentlyTranslating = "";

                
#if PROXY
                int proxyCount = 0;
                int currentProxy = 0;
                var proxy = new Proxy(new Uri(ProxyUrls[currentProxy]));
                m_translator.Proxy = proxy;
#endif
                foreach (var entity in m_entities.OrderBy(x => x.Identity))
                {
                    ParseCommand(entity.Param, out string noCommands);
                    string format = $"{entity.Identity}►{noCommands}|||";
                    if (currentlyTranslating.Length + format.Length <= 700)
                    {
                        currentlyTranslating += format;
                    }
                    else
                    {
                        Translate(currentlyTranslating, writer);
                        currentlyTranslating = format;
                        rowCount = 0;
                        writer.Flush();
                        await Task.Delay((int)numMs.Value);
#if PROXY
                        if (proxyCount++ > 10)
                        {
                            m_translator.Proxy = new Proxy(new Uri(ProxyUrls[++currentProxy]));
                            currentProxy = currentProxy % ProxyUrls.Length;
                            proxyCount = 0;
                        }
#endif

                        #region Old

                        //TranslationResult result = await m_translator.TranslateAsync(entity.Param, cn, en);
                        //GameActionEntity newEntity;
                        //m_newEntities.Add(newEntity = new GameActionEntity
                        //{
                        //    Identity = entity.Identity,
                        //    IdNext = entity.IdNext,
                        //    IdNextfail = entity.IdNextfail,
                        //    Type = entity.Type,
                        //    Data = entity.Data,
                        //    Param = result.MergedTranslation
                        //});
                        //dgvNew.Rows.Add(newEntity.Identity, newEntity.IdNext, newEntity.IdNextfail, newEntity.Type,
                        //    newEntity.Data, newEntity.Param);
                        //pbProgressAction.Value++;
                        //dgvNew.FirstDisplayedScrollingRowIndex = dgvNew.RowCount - 1;
                        //await writer.WriteLineAsync($"INSERT INTO cq_action VALUES ('{newEntity.Identity}','{newEntity.IdNext}','{newEntity.IdNextfail}'," +
                        //                            $"'{newEntity.Type}','{newEntity.Data}','{newEntity.Param}');");

                        #endregion
                    }
                }

                if (!string.IsNullOrWhiteSpace(currentlyTranslating))
                    Translate(currentlyTranslating, writer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), ex.Message);
            }
            finally
            {
                writer.Close();
                writer.Dispose();
                UnblockControls();
            }
        }

        private async void Translate(string currentlyTranslating, StreamWriter writer)
        {
            Language cn = Language.ChineseTraditional;
            Language en = Language.English;
            TranslationResult result = await m_translator.TranslateAsync(currentlyTranslating, cn, en);
            foreach (string res in result.MergedTranslation.Split(new string[] { "|||" },
                StringSplitOptions.RemoveEmptyEntries))
            {
                uint idAction = uint.Parse(res.Split('►')[0].Trim());
                string param = res.Split(new char[] { '►' }, 2, StringSplitOptions.RemoveEmptyEntries)[1]
                    .Trim();
                param = BackCommand(param);

                GameActionEntity old = m_entities.FirstOrDefault(x => x.Identity == idAction);
                GameActionEntity newAction = new GameActionEntity
                {
                    Identity = old.Identity,
                    IdNext = old.IdNext,
                    IdNextfail = old.IdNextfail,
                    Type = old.Type,
                    Data = old.Data,
                    Param = param
                };

                m_newEntities.Add(newAction);
                dgvNew.Rows.Add(newAction.Identity, newAction.IdNext, newAction.IdNextfail, newAction.Type,
                    newAction.Data, newAction.Param);
                pbProgressAction.Value++;
                dgvNew.FirstDisplayedScrollingRowIndex = dgvNew.RowCount - 1;
                await writer.WriteLineAsync(
                    $"INSERT INTO cq_action VALUES ('{newAction.Identity}','{newAction.IdNext}','{newAction.IdNextfail}'," +
                    $"'{newAction.Type}','{newAction.Data}','{newAction.Param}');");
            }
        }

        private bool ApplyStringSignal(int type)
        {
            switch (type)
            {
                case 101:
                case 102:
                    return true;
                default:
                    return false;
            }
        }

        private void BlockControls()
        {
            tabControl1.Enabled = false;
        }

        private void UnblockControls()
        {
            tabControl1.Enabled = true;
        }

        private void ParseCommand(string param, out string output)
        {
            List<string> commands = GetCommandsFromLine(param);
            output = param;
            foreach (var command in commands)
            {
                string ncommand = command.Replace("%", "PERCENT");
                output = output.Replace(command, ncommand);
            }
        }

        private string BackCommand(string param)
        {
            return param.Replace("PERCENT", "%");
        }

        public List<string> GetCommandsFromLine(string param)
        {
            List<string> commands = new List<string>();

            bool isCommand = false;
            string command = "";
            foreach (char c in param)
            {
                if (c == '%')
                {
                    command += c;
                    isCommand = true;
                    continue;
                }
                if (isCommand)
                {
                    if (char.IsLetterOrDigit(c) || c == '_')
                    {
                        command += c;
                    }
                    else
                    {
                        if (command.Length > 1 && !commands.Contains(command))
                            commands.Add(command);

                        command = "";
                        isCommand = false;
                    }
                }
            }

            return commands;
        }

#if PROXY
        private string[] ProxyUrls =
        {
            "http://3.81.157.53:3128",
            "http://200.89.178.209:8080",
            "http://51.159.30.209:80",
            "http://193.19.165.222:53281",
            "http://47.52.79.132:80",
            "http://93.76.211.56:50743",
            "http://45.123.25.113:37761",
            "http://176.118.49.54:53281",
            "http://197.242.206.64:34576",
            "http://117.196.239.154:35823",
            "http://94.101.141.245:80",
            "http://34.67.212.218:80",
            "http://117.102.104.131:61988",
            "http://165.73.128.217:56975",
            "http://51.159.30.208:80",
            "http://103.42.253.210:38141",
        };
#endif
    }
}