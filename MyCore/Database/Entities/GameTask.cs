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

using FluentNHibernate.Mapping;

#endregion

namespace MyCore.Database.Entities
{
    public class GameTaskEntity
    {
        public virtual uint Id { get; set; }
        public virtual uint IdNext { get; set; }
        public virtual uint IdNextfail { get; set; }
        public virtual string Itemname1 { get; set; }
        public virtual string Itemname2 { get; set; }
        public virtual uint Money { get; set; }
        public virtual uint Profession { get; set; }
        public virtual uint Sex { get; set; }
        public virtual int MinPk { get; set; }
        public virtual int MaxPk { get; set; }
        public virtual uint Team { get; set; }
        public virtual uint Metempsychosis { get; set; }
        public virtual ushort Query { get; set; }
        public virtual short Marriage { get; set; }
        public virtual ushort ClientActive { get; set; }
    }

    internal class GameTaskMapping : ClassMap<GameTaskEntity>
    {
        public GameTaskMapping()
        {
            Table(TableName.TASK);
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.IdNext).Column("id_next");
            Map(x => x.IdNextfail).Column("id_nextfail");
            Map(x => x.Itemname1).Column("itemname1");
            Map(x => x.Itemname2).Column("itemname2");
            Map(x => x.Money).Column("money");
            Map(x => x.Profession).Column("profession");
            Map(x => x.Sex).Column("sex");
            Map(x => x.MinPk).Column("min_pk");
            Map(x => x.MaxPk).Column("max_pk");
            Map(x => x.Team).Column("team");
            Map(x => x.Metempsychosis).Column("metempsychosis");
            Map(x => x.Query).Column("query").Not.Nullable();
            Map(x => x.Marriage).Column("marriage").Not.Nullable();
            Map(x => x.ClientActive).Column("client_active").Not.Nullable();
        }
    }
}