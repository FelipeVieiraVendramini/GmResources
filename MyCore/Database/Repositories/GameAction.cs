// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - GameAction.cs
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
    public sealed class GameActionRepository : HibernateDataRow<GameActionEntity>
    {
        public GameActionRepository()
            : base(SessionFactory.ResourceConnection)
        {
        }

        public IList<GameActionEntity> FetchAll()
        {
            using (var pSession = GetSession())
                return pSession
                    .CreateCriteria<GameActionEntity>()
                    .List<GameActionEntity>();
        }

        public GameActionEntity GetById(uint id)
        {
            using (var pSession = GetSession())
                return pSession
                    .CreateCriteria<GameActionEntity>()
                    .Add(Restrictions.Eq("Identity", id))
                    .SetMaxResults(1)
                    .UniqueResult<GameActionEntity>();
        }
    }
}