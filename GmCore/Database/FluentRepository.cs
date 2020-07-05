// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - GmCore - FluentRepository.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Data.Entity;
using MySql.Data.MySqlClient;

namespace GmCore.Database
{
    public abstract class FluentRepository<T> where T : DbContext
    {
        private ConnectionType m_type = ConnectionType.Account;

        protected FluentRepository()
        {
        }

        protected FluentRepository(ConnectionType type)
        {
            m_type = type;
        }

        protected string ConnectionString => DatabaseManager.Settings[m_type].ConnectionString;

        public bool Save(T obj)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        obj.Database.Log = (string message) => { Console.WriteLine($"Database: {message}"); };
                        obj.Database.UseTransaction(transaction);
                        obj.SaveChanges();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}