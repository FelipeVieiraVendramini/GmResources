// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - Npc.cs
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
    public sealed class NpcRepository : HibernateDataRow<NpcEntity>
    {
        public NpcRepository()
            : base(SessionFactory.ResourceConnection)
        {
        }

        public IList<NpcEntity> FetchAll()
        {
            using (var pSession = GetSession())
                return pSession
                    .CreateCriteria<NpcEntity>()
                    .List<NpcEntity>();
        }
    }
}