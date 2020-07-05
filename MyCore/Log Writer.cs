// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - Log Writer.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System;
using System.IO;

#endregion

namespace MyCore
{
    public class LogWriter
    {
        public const string STR_CONSOLE_MSG = "{0} - {1}";

        public const string STR_GMLOG_FORMAT = "{0} - {1}"; // {0} is message {1} is date
        public const string STR_GMLOG_FOLDER = @"gmlog\";
        public const string STR_GMLOG_SUBFOLDER = "yyyyMM";

        public const string STR_SYSLOG_FORMAT = "{0} [{1}] - {2}";
        public const string STR_SYSLOG_FOLDER = @"syslog\";
        public const string STR_SYSLOG_ACCOUNTSERVER = "Account_Server";
        public const string STR_SYSLOG_GAMESERVER = "CQ_Server";
        public const string STR_SYSLOG_NPCSERVER = "NPC_Server";
        public const string STR_SYSLOG_ANALYTIC = "Analytic";
        public const string STR_SYSLOG_DATABASE = "Database";

        private readonly string m_szMainDirectory;

        /// <summary>
        ///     Start a new instance and create the necessary folders.
        /// </summary>
        public LogWriter(string szPath)
        {
            if (!szPath.EndsWith("\\"))
                szPath += "\\";

            m_szMainDirectory = szPath;
            CheckFolders();
        }

        /// <summary>
        ///     This method will write the message to the log in the main file and wont show
        ///     it on the console.
        /// </summary>
        /// <param name="szMessage">The message buffer that will be written.</param>
        public string SaveLog(string szMessage)
        {
            return SaveLog(szMessage, LogType.MESSAGE);
        }

        /// <summary>
        ///     This method will write the message to the default file with the required log type.
        /// </summary>
        /// <param name="szMessage">The message that will be written.</param>
        /// <param name="ltLog">The kind of message that will be shown.</param>
        public string SaveLog(string szMessage, LogType ltLog)
        {
            return SaveLog(szMessage, STR_SYSLOG_GAMESERVER, ltLog);
        }

        /// <summary>
        ///     This method should be used when it should not show date time settings.
        /// </summary>
        /// <param name="szMessage"></param>
        /// <param name="szFileName"></param>
        public string SavePureLog(string szMessage, string szFileName)
        {
            CheckFolders();
            string szFilePath = m_szMainDirectory + STR_SYSLOG_FOLDER + szFileName;
            WriteToFile(szMessage = FormatSysString(szMessage, 0, false), szFilePath);
            return szMessage;
        }

        /// <summary>
        ///     This method will write the message on the required file with the defined parameters.
        /// </summary>
        /// <param name="szMessage">The message that will be written.</param>
        /// <param name="szFileName">The file name where the log will be written.</param>
        /// <param name="ltLog">The kind of message that will be shown.</param>
        public string SaveLog(string szMessage, string szFileName, LogType ltLog = LogType.MESSAGE)
        {
            CheckFolders();

            string szDefault = szMessage;
            szMessage = FormatSysString(szMessage, ltLog);

            string szFilePath = m_szMainDirectory + STR_SYSLOG_FOLDER + szFileName;
            WriteToFile(szMessage, szFilePath);
            return szMessage;
        }

        public void GmLog(string szFileName, string szMessage)
        {
            CheckFolders();

            szFileName = GetGmFolder() + szFileName;

            string szOriginal = szMessage;
            szMessage = FormatGmString(szOriginal);

            WriteToFile(szMessage, szFileName);
        }

        public void WriteToFile(string szFullMessage, string szFilePath)
        {
            bool bStop = false;

            szFilePath = szFilePath + DateTime.Now.ToString("yyyy-M-dd") + ".log";

            if (!File.Exists(szFilePath))
                File.Create(szFilePath).Close();

            while (!bStop)
            {
                try
                {
                    var pWriter = File.AppendText(szFilePath);
                    pWriter.WriteLine(szFullMessage);
                    pWriter.Close();
                    bStop = true;
                }
                catch
                {
                }
            }
        }

        private string FormatSysString(string szMessage, LogType ltType, bool bTime = true)
        {
            if (bTime)
                return string.Format(STR_SYSLOG_FORMAT, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ltType,
                    szMessage);
            return szMessage;
        }

        private string FormatGmString(string szMessage)
        {
            return string.Format(STR_GMLOG_FORMAT, szMessage, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private string GetGmFolder()
        {
            return m_szMainDirectory + STR_GMLOG_FOLDER + DateTime.Now.ToString(STR_GMLOG_SUBFOLDER) + @"\";
        }

        /// <summary>
        ///     This method will check if the folders are created to avoid a exception while
        ///     writing to the log.
        /// </summary>
        private void CheckFolders()
        {
            try
            {
                if (!Directory.Exists(m_szMainDirectory + STR_GMLOG_FOLDER))
                    Directory.CreateDirectory(m_szMainDirectory + STR_GMLOG_FOLDER);
                if (!Directory.Exists(m_szMainDirectory + STR_GMLOG_FOLDER +
                                      DateTime.Now.ToString(STR_GMLOG_SUBFOLDER) + @"\"))
                    Directory.CreateDirectory(m_szMainDirectory + STR_GMLOG_FOLDER +
                                              DateTime.Now.ToString(STR_GMLOG_SUBFOLDER) + @"\");
                if (!Directory.Exists(m_szMainDirectory + STR_SYSLOG_FOLDER))
                    Directory.CreateDirectory(m_szMainDirectory + STR_SYSLOG_FOLDER);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    public enum LogType
    {
        MESSAGE,
        DEBUG,
        WARNING,
        ERROR,
        EXCEPTION,
        CONSOLE
    }
}