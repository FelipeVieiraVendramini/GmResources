// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - Hibernate Data Row.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

// #define WEBSITE

using System;
using System.Collections.Generic;
using NHibernate;

#endregion

namespace MyCore.Database
{
    /// <summary>
    ///     This class encapsulates an object from the .NET Hibernate database management system. It includes the
    ///     base of all objects in the database that can be altered by the server. It contains methods for saving
    ///     and deleting the data row the object represents.
    /// </summary>
    public abstract class HibernateDataRow<T> where T : class
    {
#if DEBUG || !WEBSITE
        private readonly LogWriter m_log = new LogWriter("C:\\");
#endif
        private readonly ISessionFactory m_useSession;

        protected HibernateDataRow()
        {
            m_useSession = SessionFactory.GameConnection;
        }

        protected HibernateDataRow(ISessionFactory session)
        {
            m_useSession =
                session ?? SessionFactory.GameConnection ?? throw new ArgumentNullException(nameof(session),
                    @"Cannot start an instance without a session.");
        }

        protected ISession GetSession()
        {
            return m_useSession.OpenSession();
        }

        /// <summary>
        ///     This method saves the object to the database. If the object exists already, then this method will
        ///     update that object. If the object does not exist, then it will be inserted into the database.
        /// </summary>
        public virtual bool Save(T obj)
        {
            try
            {
                using (ISession pSession = m_useSession.OpenSession())
                {
                    using (var transaction = pSession.BeginTransaction())
                    {
                        pSession.SaveOrUpdate(obj);
                        transaction.Commit();
                    }

                    pSession.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
#if DEBUG || !WEBSITE
                m_log.SaveLog(ex.ToString(), LogWriter.STR_SYSLOG_DATABASE, LogType.EXCEPTION);
#endif
                return false;
            }
        }

        public virtual bool Save(T[] objs)
        {
            try
            {
                using (ISession pSession = m_useSession.OpenSession())
                {
                    using (var transaction = pSession.BeginTransaction())
                    {
                        foreach (var obj in objs)
                            pSession.SaveOrUpdate(obj);
                        transaction.Commit();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
#if DEBUG || !WEBSITE
                m_log.SaveLog(ex.ToString(), LogWriter.STR_SYSLOG_DATABASE, LogType.EXCEPTION);
#endif
                return false;
            }
        }

        /// <summary>
        ///     This method attempts to delete the object from the database. If the object exists and can be deleted
        ///     successfully, then this method returns true; else, it returns false.
        /// </summary>
        public virtual bool Delete(T obj)
        {
            try
            {
                using (ISession pSession = m_useSession.OpenSession())
                {
                    // Attempt to insert the value. Throws exception if the value exists.
                    using (var transaction = pSession.BeginTransaction())
                    {
                        pSession.Delete(obj);
                        transaction.Commit();
                    }
                }

                return true;
            }
            catch (Exception e)
            {
#if DEBUG || !WEBSITE
                m_log.SaveLog(e.ToString(), LogWriter.STR_SYSLOG_DATABASE, LogType.EXCEPTION);
#endif
                return false;
            }
        }

        public virtual bool Delete(T[] objs)
        {
            try
            {
                using (ISession pSession = m_useSession.OpenSession())
                {
                    using (var transaction = pSession.BeginTransaction())
                    {
                        foreach (var obj in objs)
                            pSession.Delete(obj);
                        transaction.Commit();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
#if DEBUG || !WEBSITE
                m_log.SaveLog(ex.ToString(), LogWriter.STR_SYSLOG_DATABASE, LogType.EXCEPTION);
#endif
                return false;
            }
        }

        public virtual bool Refresh(T obj)
        {
            try
            {
                using (ISession pSession = m_useSession.OpenSession())
                {
                    using (var transaction = pSession.BeginTransaction())
                    {
                        pSession.Refresh(obj);
                        transaction.Commit();
                    }
                }

                return true;
            }
            catch (Exception e)
            {
#if DEBUG || !WEBSITE
                m_log.SaveLog(e.ToString(), LogWriter.STR_SYSLOG_DATABASE, LogType.EXCEPTION);
#endif
                return false;
            }
        }

        /// <summary>
        ///     This method accepts a SQL query as a formatted string from the method's arguments, and executes the
        ///     query. Error handling should be handled by the parent function.
        /// </summary>
        /// <param name="query">The formatted SQL query string.</param>
        /// <param name="pSession"></param>
        public virtual int ExecuteProcedure(string query, ISession pSession)
        {
            return pSession.GetNamedQuery(query).ExecuteUpdate();
        }

        /// <summary>
        ///     This method accepts a SQL query as a formatted string from the method's arguments, and executes the
        ///     query. Error handling should be handled by the parent function.
        /// </summary>
        /// <param name="query">The formatted SQL query string.</param>
        public virtual object ExecuteQuery(string query)
        {
            string loQuery = query.ToLower();
            if (!ValidateQuery(loQuery))
                return null;

            using (ISession pSession = m_useSession.OpenSession())
            {
                var pQuery = pSession.CreateSQLQuery(query);
                try
                {
                    //if (loQuery.StartsWith("insert into"))
                    //throw new Exception("Cannot execute INSERT INTO queries from ExecuteQuery method.");
                    if (loQuery.StartsWith("update") || loQuery.StartsWith("delete"))
                        return pQuery.ExecuteUpdate();
                    if (loQuery.StartsWith("insert into") || loQuery.StartsWith("select"))
                        return pQuery.UniqueResult();
                    throw new Exception("Query type not handled by ExecuteQuery method.");
                }
                catch (Exception e)
                {
#if DEBUG || !WEBSITE
                    m_log.SaveLog($"Could not execute query [{query}]", LogWriter.STR_SYSLOG_DATABASE, LogType.ERROR);
                    m_log.SaveLog(e.ToString(), LogWriter.STR_SYSLOG_DATABASE, LogType.EXCEPTION);
#endif
                    return null;
                }
            }
        }

        /// <summary>
        ///     This method doesn't clean the query string. Be careful.
        ///     The other one also don't, but it will avoid deletion and drop.
        /// </summary>
        public virtual object ExecutePureQuery(string query)
        {
            string loQuery = query.ToLower();
            using (ISession pSession = m_useSession.OpenSession())
            {
                var pQuery = pSession.CreateSQLQuery(query);
                try
                {
                    if (loQuery.StartsWith("update") || loQuery.StartsWith("delete"))
                        return pQuery.ExecuteUpdate();
                    if (loQuery.StartsWith("insert into") || loQuery.StartsWith("select"))
                        return pQuery.UniqueResult();
                    throw new Exception("Query type not handled by ExecuteQuery method.");
                }
                catch (Exception e)
                {
#if DEBUG || !WEBSITE
                    m_log.SaveLog($"Could not execute query [{query}]", LogWriter.STR_SYSLOG_DATABASE, LogType.ERROR);
                    m_log.SaveLog(e.ToString(), LogWriter.STR_SYSLOG_DATABASE, LogType.EXCEPTION);
#endif
                    return null;
                }
            }
        }

        public virtual IList<T> ExecuteSelect(string query)
        {
            using (ISession pSession = m_useSession.OpenSession())
            {
                var pQuery = pSession.CreateSQLQuery(query);
                try
                {
                    return pQuery.List<T>();
                }
                catch (Exception e)
                {
#if DEBUG || !WEBSITE
                    m_log.SaveLog($"Could not execute query [{query}]", LogWriter.STR_SYSLOG_DATABASE, LogType.ERROR);
                    m_log.SaveLog(e.ToString(), LogWriter.STR_SYSLOG_DATABASE, LogType.EXCEPTION);
#endif
                    return null;
                }
            }
        }

        public bool ValidateQuery(string query)
        {
            string loQuery = query.ToLower();
            if (loQuery.StartsWith("update") || loQuery.StartsWith("delete"))
            {
                if (!loQuery.Contains("where") || !loQuery.Contains("limit"))
                {
#if DEBUG || !WEBSITE
                    m_log.SaveLog($"Cannot execute query [{query}] because it has no [where] or [limit] clause.");
#endif
                    return false;
                }
            }
            else if (loQuery.StartsWith("select"))
            {
                if (!loQuery.Contains("where") || !loQuery.Contains("limit"))
                {
#if DEBUG || !WEBSITE
                    m_log.SaveLog($"Cannot execute query [{query}] because it has no [where] or [limit] clause.");
#endif
                    return false;
                }

                if (loQuery[8] == '*')
                {
#if DEBUG || !WEBSITE
                    m_log.SaveLog(
                        $"Cannot execute query [{query}] because you can only select ONE value per execution.");
#endif
                    return false;
                }
            }

            if (loQuery.Contains("drop table") || loQuery.Contains("drop database") ||
                loQuery.Contains("truncate table")
                || loQuery.Contains("alter table")) // todo check for more :)
                return false;

            return true;
        }
    }
}