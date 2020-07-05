// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - GmCore - DatabaseManager.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System.Collections.Concurrent;
using System.Data.Entity;
using MySql.Data.Entity;

#endregion

namespace GmCore.Database
{
    public static class DatabaseManager
    {
        public static ConcurrentDictionary<ConnectionType, ConnectionSettings> Settings = new ConcurrentDictionary<ConnectionType, ConnectionSettings>();

        static DatabaseManager()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());

            Settings.TryAdd(ConnectionType.Account, new ConnectionSettings("localhost", "root", "1234", "account_cq", 3306));
            Settings.TryAdd(ConnectionType.Game, new ConnectionSettings("localhost", "root", "1234", "cq", 3306));
            Settings.TryAdd(ConnectionType.Log, new ConnectionSettings("localhost", "root", "1234", "cq", 3306));
        }

        
    }

    public struct ConnectionSettings
    {
        public ConnectionSettings(string host, string user, string pass, string db, int port)
        {
            Hostname = host;
            Username = user;
            Password = pass;
            Database = db;
            Port = port;
        }

        public string Hostname;
        public string Username;
        public string Password;
        public string Database;
        public int Port;

        public string ConnectionString =>
            $"server={Hostname};port={Port};database={Database};uid={Username};password={Password};";
    }

    public enum ConnectionType
    {
        Account,
        Log,
        Game
    }
}