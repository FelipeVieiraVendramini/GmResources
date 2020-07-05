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

using FluentNHibernate.Mapping;

#endregion

namespace MyCore.Database.Entities
{
    public class GameActionEntity
    {
        public virtual uint Identity { get; set; }
        public virtual uint IdNext { get; set; }
        public virtual uint IdNextfail { get; set; }
        public virtual uint Type { get; set; }
        public virtual uint Data { get; set; }
        public virtual string Param { get; set; }
    }

    internal class GameActionMapping : ClassMap<GameActionEntity>
    {
        public GameActionMapping()
        {
            Table(TableName.ACTION);
            LazyLoad();
            Id(x => x.Identity).GeneratedBy.Identity().Column("id");
            Map(x => x.IdNext).Column("id_next").Not.Nullable().Default("0");
            Map(x => x.IdNextfail).Column("id_nextfail").Not.Nullable().Default("0");
            Map(x => x.Type).Column("type").Not.Nullable().Default("0");
            Map(x => x.Data).Column("data").Not.Nullable().Default("0");
            Map(x => x.Param).Column("param").Not.Nullable().Default("");
        }
    }
}