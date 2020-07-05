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

using FluentNHibernate.Mapping;

#endregion

namespace MyCore.Database.Entities
{
    public class NpcEntity
    {
        public virtual uint Id { get; set; }
        public virtual uint Ownerid { get; set; }
        public virtual uint Playerid { get; set; }
        public virtual string Name { get; set; }
        public virtual ushort Type { get; set; }
        public virtual ushort Lookface { get; set; }
        public virtual int Idxserver { get; set; }
        public virtual uint Mapid { get; set; }
        public virtual ushort Cellx { get; set; }
        public virtual ushort Celly { get; set; }
        public virtual uint Task0 { get; set; }
        public virtual uint Task1 { get; set; }
        public virtual uint Task2 { get; set; }
        public virtual uint Task3 { get; set; }
        public virtual uint Task4 { get; set; }
        public virtual uint Task5 { get; set; }
        public virtual uint Task6 { get; set; }
        public virtual uint Task7 { get; set; }
        public virtual int Data0 { get; set; }
        public virtual int Data1 { get; set; }
        public virtual int Data2 { get; set; }
        public virtual int Data3 { get; set; }
        public virtual string Datastr { get; set; }
        public virtual uint Linkid { get; set; }
        public virtual ushort Life { get; set; }
        public virtual ushort Maxlife { get; set; }
        public virtual uint Base { get; set; }
        public virtual ushort Sort { get; set; }
        public virtual uint Itemid { get; set; }
        public virtual ushort Defence { get; set; }
        public virtual ushort MagicDef { get; set; }
    }

    internal class Npc : ClassMap<NpcEntity>
    {
        public Npc()
        {
            Table(TableName.NPC);
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Ownerid).Column("ownerid");
            Map(x => x.Playerid).Column("playerid");
            Map(x => x.Name).Column("name").Not.Nullable();
            Map(x => x.Type).Column("type");
            Map(x => x.Lookface).Column("lookface");
            Map(x => x.Idxserver).Column("idxserver");
            Map(x => x.Mapid).Column("mapid");
            Map(x => x.Cellx).Column("cellx");
            Map(x => x.Celly).Column("celly");
            Map(x => x.Task0).Column("task0");
            Map(x => x.Task1).Column("task1");
            Map(x => x.Task2).Column("task2");
            Map(x => x.Task3).Column("task3");
            Map(x => x.Task4).Column("task4");
            Map(x => x.Task5).Column("task5");
            Map(x => x.Task6).Column("task6");
            Map(x => x.Task7).Column("task7");
            Map(x => x.Data0).Column("data0").Not.Nullable();
            Map(x => x.Data1).Column("data1").Not.Nullable();
            Map(x => x.Data2).Column("data2").Not.Nullable();
            Map(x => x.Data3).Column("data3").Not.Nullable();
            Map(x => x.Datastr).Column("datastr");
            Map(x => x.Linkid).Column("linkid").Not.Nullable();
            Map(x => x.Life).Column("life").Not.Nullable();
            Map(x => x.Maxlife).Column("maxlife").Not.Nullable();
            Map(x => x.Base).Column("base").Not.Nullable();
            Map(x => x.Sort).Column("sort").Not.Nullable();
            Map(x => x.Itemid).Column("itemid");
        }
    }
}