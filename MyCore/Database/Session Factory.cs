// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - Session Factory.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System;
using System.Collections;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

#endregion

namespace MyCore.Database
{
    public sealed class SessionFactory
    {
        /// <summary>
        ///     The connection to the database which holds login information.
        /// </summary>
        internal static ISessionFactory AccountConnection;

        /// <summary>
        ///     The connection to the database which will store all log information.
        /// </summary>
        internal static ISessionFactory LogConnection;

        /// <summary>
        ///     Stores static data with events, items and global things.
        /// </summary>
        internal static ISessionFactory ResourceConnection;

        /// <summary>
        ///     The information of players, items, skills etc.
        /// </summary>
        internal static ISessionFactory GameConnection;

        public static ISession MyAccountConnection => AccountConnection.OpenSession();

        public static string LastException { get; private set; }

        public static bool StartAccountConnection(string host, string user, string pass, string data,
            int port = 3306)
        {
            try
            {
                AccountConnection = CreateSessionFactory(host, user, pass, data, port);
                return true;
            }
            catch (Exception ex)
            {
                LastException = ex.ToString();
                return false;
            }
        }

        public static bool StartAccountConnection(string connectionString)
        {
            try
            {
                AccountConnection = CreateSessionFactory(connectionString);
                return true;
            }
            catch (Exception ex)
            {
                LastException = ex.ToString();
                return false;
            }
        }

        public static bool StartLogConnection(string host, string user, string pass, string data,
            int port = 3306)
        {
            try
            {
                LogConnection = CreateSessionFactory(host, user, pass, data, port);
                return true;
            }
            catch (Exception ex)
            {
                LastException = ex.ToString();
                return false;
            }
        }

        public static bool StartLogConnection(string connectionString)
        {
            try
            {
                LogConnection = CreateSessionFactory(connectionString);
                return true;
            }
            catch (Exception ex)
            {
                LastException = ex.ToString();
                return false;
            }
        }

        public static bool StartGameConnection(string host, string user, string pass, string data,
            int port = 3306)
        {
            try
            {
                GameConnection = CreateSessionFactory(host, user, pass, data, port);
                return true;
            }
            catch (Exception ex)
            {
                LastException = ex.ToString();
                return false;
            }
        }

        public static bool StartGameConnection(string connectionString)
        {
            try
            {
                GameConnection = CreateSessionFactory(connectionString);
                return true;
            }
            catch (Exception ex)
            {
                LastException = ex.ToString();
                return false;
            }
        }

        public static bool StartResourceConnection(string host, string user, string pass, string data,
            int port = 3306)
        {
            try
            {
                ResourceConnection = CreateSessionFactory(host, user, pass, data, port);
                return true;
            }
            catch (Exception ex)
            {
                LastException = ex.ToString();
                return false;
            }
        }

        public static bool StartResourceConnection(string connectionString)
        {
            try
            {
                ResourceConnection = CreateSessionFactory(connectionString);
                return true;
            }
            catch (Exception ex)
            {
                LastException = ex.ToString();
                return false;
            }
        }

        /// <summary>
        ///     Configure NHibernate. This method returns an ISessionFactory instance that is
        ///     populated with mappings created by Fluent NHibernate.
        /// </summary>
        /// <returns>The SessionFactory so you can use it to Mappings and w/e.</returns>
        public static ISessionFactory CreateSessionFactory(string host, string user, string pass, string data,
            int port = 3306)
        {
            var session = Fluently
                .Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(
                    $"Server={host};Port={port};Database={data};Uid={user};Password={pass};charset=utf8;")
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SessionFactory>())
                .ExposeConfiguration(x => x.SetProperty("hbm2ddl.keywords", "auto-quote"));
            return session.BuildSessionFactory();
        }

        public static ISessionFactory CreateSessionFactory(string connectionString)
        {
            var session = Fluently
                .Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SessionFactory>())
                .ExposeConfiguration(x => x.SetProperty("hbm2ddl.keywords", "auto-quote"));
            return session.BuildSessionFactory();
        }

        public static IList Query(string pstrQuery)
        {
            using (var session = GameConnection.OpenSession())
            {
                ISQLQuery query = session.CreateSQLQuery(pstrQuery);
                if (query != null)
                    return query.List();
            }

            return null;
        }
    }
}