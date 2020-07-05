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

using FluentNHibernate.Mapping;

#endregion

namespace MyCore.Database.Entities
{
    public class MonstertypeEntity
    {
        public virtual uint Id { get; set; }
        public virtual string Name { get; set; }
        public virtual uint Type { get; set; }
        public virtual ushort Lookface { get; set; }
        public virtual int Life { get; set; }
        public virtual uint Mana { get; set; }
        public virtual int AttackMax { get; set; }
        public virtual int AttackMin { get; set; }
        public virtual int Defence { get; set; }
        public virtual uint Dexterity { get; set; }
        public virtual uint Dodge { get; set; }
        public virtual uint HelmetType { get; set; }
        public virtual uint ArmorType { get; set; }
        public virtual uint WeaponrType { get; set; }
        public virtual uint WeaponlType { get; set; }
        public virtual int AttackRange { get; set; }
        public virtual int ViewRange { get; set; }
        public virtual int EscapeLife { get; set; }
        public virtual int AttackSpeed { get; set; }
        public virtual int MoveSpeed { get; set; }
        public virtual ushort Level { get; set; }
        public virtual uint AttackUser { get; set; }
        public virtual uint DropMoney { get; set; }
        public virtual uint DropItemtype { get; set; }
        public virtual uint SizeAdd { get; set; }
        public virtual uint Action { get; set; }
        public virtual uint RunSpeed { get; set; }
        public virtual byte DropArmet { get; set; }
        public virtual byte DropNecklace { get; set; }
        public virtual byte DropArmor { get; set; }
        public virtual byte DropRing { get; set; }
        public virtual byte DropWeapon { get; set; }
        public virtual byte DropShield { get; set; }
        public virtual byte DropShoes { get; set; }
        public virtual uint DropHp { get; set; }
        public virtual uint DropMp { get; set; }
        public virtual uint MagicType { get; set; }
        public virtual int MagicDef { get; set; }
        public virtual uint MagicHitrate { get; set; }
        public virtual uint AiType { get; set; }
        public virtual uint Defence2 { get; set; }
        public virtual ushort StcType { get; set; }
        public virtual byte AntiMonster { get; set; }
        public virtual ushort ExtraBattlelev { get; set; }
        public virtual short ExtraExp { get; set; }
        public virtual short ExtraDamage { get; set; }
        public virtual int WaterAtk { get; set; }
        public virtual int FireAtk { get; set; }
        public virtual int EarthAtk { get; set; }
        public virtual int WoodAtk { get; set; }
        public virtual int MetalAtk { get; set; }
        public virtual byte WaterDef { get; set; }
        public virtual byte FireDef { get; set; }
        public virtual byte EarthDef { get; set; }
        public virtual byte WoodDef { get; set; }
        public virtual byte MetalDef { get; set; }
        public virtual byte Boss { get; set; }
    }

    internal class MonstertypeMapping : ClassMap<MonstertypeEntity>
    {
        public MonstertypeMapping()
        {
            Table(TableName.MONSTERTYPE);
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("id");
            Map(x => x.Name).Column("name").Not.Nullable();
            Map(x => x.Type).Column("type").Not.Nullable();
            Map(x => x.Lookface).Column("lookface").Not.Nullable();
            Map(x => x.Life).Column("life").Not.Nullable();
            Map(x => x.Mana).Column("mana").Not.Nullable();
            Map(x => x.AttackMax).Column("attack_max").Not.Nullable();
            Map(x => x.AttackMin).Column("attack_min").Not.Nullable();
            Map(x => x.Defence).Column("defence").Not.Nullable();
            Map(x => x.Dexterity).Column("dexterity").Not.Nullable();
            Map(x => x.Dodge).Column("dodge").Not.Nullable();
            Map(x => x.HelmetType).Column("helmet_type").Not.Nullable();
            Map(x => x.ArmorType).Column("armor_type").Not.Nullable();
            Map(x => x.WeaponrType).Column("weaponr_type").Not.Nullable();
            Map(x => x.WeaponlType).Column("weaponl_type").Not.Nullable();
            Map(x => x.AttackRange).Column("attack_range").Not.Nullable();
            Map(x => x.ViewRange).Column("view_range").Not.Nullable();
            Map(x => x.EscapeLife).Column("escape_life").Not.Nullable();
            Map(x => x.AttackSpeed).Column("attack_speed").Not.Nullable();
            Map(x => x.MoveSpeed).Column("move_speed").Not.Nullable();
            Map(x => x.Level).Column("level").Not.Nullable();
            Map(x => x.AttackUser).Column("attack_user").Not.Nullable();
            Map(x => x.DropMoney).Column("drop_money").Not.Nullable();
            Map(x => x.DropItemtype).Column("drop_itemtype").Not.Nullable();
            Map(x => x.SizeAdd).Column("size_add").Not.Nullable();
            Map(x => x.Action).Column("action").Not.Nullable();
            Map(x => x.RunSpeed).Column("run_speed").Not.Nullable();
            Map(x => x.DropArmet).Column("drop_armet").Not.Nullable();
            Map(x => x.DropNecklace).Column("drop_necklace").Not.Nullable();
            Map(x => x.DropArmor).Column("drop_armor").Not.Nullable();
            Map(x => x.DropRing).Column("drop_ring").Not.Nullable();
            Map(x => x.DropWeapon).Column("drop_weapon").Not.Nullable();
            Map(x => x.DropShield).Column("drop_shield").Not.Nullable();
            Map(x => x.DropShoes).Column("drop_shoes").Not.Nullable();
            Map(x => x.DropHp).Column("drop_hp").Not.Nullable();
            Map(x => x.DropMp).Column("drop_mp").Not.Nullable();
            Map(x => x.MagicType).Column("magic_type").Not.Nullable();
            Map(x => x.MagicDef).Column("magic_def").Not.Nullable();
            Map(x => x.MagicHitrate).Column("magic_hitrate").Not.Nullable();
            Map(x => x.AiType).Column("ai_type").Not.Nullable();
            Map(x => x.Defence2).Column("defence2").Not.Nullable();
            Map(x => x.StcType).Column("stc_type").Not.Nullable();
            Map(x => x.AntiMonster).Column("anti_monster").Not.Nullable();
            Map(x => x.ExtraBattlelev).Column("extra_battlelev").Not.Nullable();
            Map(x => x.ExtraExp).Column("extra_exp").Not.Nullable();
            Map(x => x.ExtraDamage).Column("extra_damage").Not.Nullable();
            Map(x => x.WaterAtk).Column("water_atk").Not.Nullable();
            Map(x => x.FireAtk).Column("fire_atk").Not.Nullable();
            Map(x => x.EarthAtk).Column("earth_atk").Not.Nullable();
            Map(x => x.WoodAtk).Column("wood_atk").Not.Nullable();
            Map(x => x.MetalAtk).Column("metal_atk").Not.Nullable();
            Map(x => x.WaterDef).Column("water_def").Not.Nullable();
            Map(x => x.FireDef).Column("fire_def").Not.Nullable();
            Map(x => x.EarthDef).Column("earth_def").Not.Nullable();
            Map(x => x.WoodDef).Column("wood_def").Not.Nullable();
            Map(x => x.MetalDef).Column("metal_def").Not.Nullable();
            Map(x => x.Boss).Column("boss").Not.Nullable();
        }
    }
}