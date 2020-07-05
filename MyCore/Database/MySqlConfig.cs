// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - MySqlConfig.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace MyCore.Database
{
    public struct MySqlConfig
    {
        public MySqlConfig(string host, string user, string pass, string db, int port)
        {
            Host = host;
            User = user;
            Pass = pass;
            Database = db;
            Port = port;
        }

        public string Host;
        public string User;
        public string Pass;
        public string Database;
        public int Port;
    }
}