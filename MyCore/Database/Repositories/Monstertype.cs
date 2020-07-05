// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - Monstertype.cs
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

#endregion

namespace MyCore.Database.Repositories
{
    public sealed class MonstertypeRepository : HibernateDataRow<MonstertypeEntity>
    {
        public MonstertypeRepository()
            : base(SessionFactory.ResourceConnection)
        {
        }

        public IList<MonstertypeEntity> FetchAll()
        {
            using (var pSession = GetSession())
                return pSession
                    .CreateCriteria<MonstertypeEntity>()
                    .List<MonstertypeEntity>();
        }
    }
}