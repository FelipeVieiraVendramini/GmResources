// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - GameTask.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region References

using System.Collections.Generic;
using MyCore.Database.Entities;
using NHibernate.Criterion;

#endregion

namespace MyCore.Database.Repositories
{
    public sealed class GameTaskRepository : HibernateDataRow<GameTaskEntity>
    {
        public GameTaskRepository()
            : base(SessionFactory.ResourceConnection)
        {
        }

        public GameTaskEntity GetById(uint idTask)
        {
            using (var pSession = GetSession())
                return pSession
                    .CreateCriteria<GameTaskEntity>()
                    .Add(Restrictions.Eq("Id", idTask))
                    .SetMaxResults(1)
                    .UniqueResult<GameTaskEntity>();
        }

        public IList<GameTaskEntity> FetchAll()
        {
            using (var pSession = GetSession())
                return pSession
                    .CreateCriteria<GameTaskEntity>()
                    .List<GameTaskEntity>();
        }
    }
}