// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - MyCore - TableName.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace MyCore.Database
{
    public class TableName
    {
        // Table prefix
        public const string GAME_TABLE_PREFIX = "cq_";
        public const string ACCOUNT_TABLE_PREFIX = "ftw_";

        // Table names
        public const string ACCOUNT_TABLE = "account";
        public const string FTW_ACCOUNT_TABLE = ACCOUNT_TABLE_PREFIX + "account";
        public const string FTW_ONLINE_PLAYERS = ACCOUNT_TABLE_PREFIX + "online_players";
        public const string SECURITY_QUESTION = ACCOUNT_TABLE_PREFIX + "security_question";

        public const string AD_LOG = "ad_log";
        public const string AD_QUEUE = "ad_queue";
        public const string ACHIEVEMENTS = GAME_TABLE_PREFIX + "achievements";
        public const string ACTION = GAME_TABLE_PREFIX + "action";
        public const string ARENA = GAME_TABLE_PREFIX + "arena";
        public const string BONUS = GAME_TABLE_PREFIX + "bonus";
        public const string BUSINESS = GAME_TABLE_PREFIX + "business";
        public const string CARRY = GAME_TABLE_PREFIX + "carry";
        public const string CONFIG = GAME_TABLE_PREFIX + "config";
        public const string DAILY_UPDATE = GAME_TABLE_PREFIX + "daily_update";
        public const string DELUSER = GAME_TABLE_PREFIX + "deluser";
        public const string DISDAIN = GAME_TABLE_PREFIX + "disdain";
        public const string DYNAMAP = GAME_TABLE_PREFIX + "dynamap";
        public const string DYNANPC = GAME_TABLE_PREFIX + "dynanpc";
        public const string ENEMY = GAME_TABLE_PREFIX + "enemy";
        public const string FATE_RANK = GAME_TABLE_PREFIX + "fate_rank";
        public const string FRIEND = GAME_TABLE_PREFIX + "friend";
        public const string FAMILY = GAME_TABLE_PREFIX + "family";
        public const string FAMILY_ATTR = GAME_TABLE_PREFIX + "family_attr";
        public const string FLOWER = GAME_TABLE_PREFIX + "flower";
        public const string FUSE = GAME_TABLE_PREFIX + "fuse";
        public const string GAME_LOGIN_RCD = GAME_TABLE_PREFIX + "login_rcd";
        public const string GENERATOR = GAME_TABLE_PREFIX + "generator";
        public const string GOODS = GAME_TABLE_PREFIX + "goods";
        public const string ITEM = GAME_TABLE_PREFIX + "item";
        public const string ITEMADDITION = GAME_TABLE_PREFIX + "itemaddition";
        public const string ITEMTYPE = GAME_TABLE_PREFIX + "itemtype";
        public const string KILL_DEATH = GAME_TABLE_PREFIX + "killdeath";
        public const string KONGFU = GAME_TABLE_PREFIX + "kongfu";
        public const string KONGFU_ATTR = GAME_TABLE_PREFIX + "kongfu_attr";
        public const string KONGFU_LOG = GAME_TABLE_PREFIX + "kongfu_log";
        public const string LEVEXP = GAME_TABLE_PREFIX + "levexp";
        public const string LOTTERY = GAME_TABLE_PREFIX + "lottery";
        public const string MAIL = GAME_TABLE_PREFIX + "mail";
        public const string MAIL_ATTACHMENT = GAME_TABLE_PREFIX + "mail_attachment";
        public const string MAGIC = GAME_TABLE_PREFIX + "magic";
        public const string MAGICTYPE = GAME_TABLE_PREFIX + "magictype";
        public const string MAGICTYPEOP = GAME_TABLE_PREFIX + "magictypeop";
        public const string MONARCHY = GAME_TABLE_PREFIX + "monarchy";
        public const string MONARCHY_CONFIG = GAME_TABLE_PREFIX + "monarchy_config";
        public const string MONSTERTYPE = GAME_TABLE_PREFIX + "monstertype";
        public const string MONSTER_MAGIC = GAME_TABLE_PREFIX + "monster_magic";
        public const string MAP = GAME_TABLE_PREFIX + "map";
        public const string NPC = GAME_TABLE_PREFIX + "npc";
        public const string PASSWAY = GAME_TABLE_PREFIX + "passway";
        public const string PK_BONUS = GAME_TABLE_PREFIX + "pk_bonus";
        public const string PK_EXPLOIT = GAME_TABLE_PREFIX + "pk_exploit";
        public const string PK_ITEM = GAME_TABLE_PREFIX + "pk_item";
        public const string POINT_ALLOT = GAME_TABLE_PREFIX + "point_allot";
        public const string PORTAL = GAME_TABLE_PREFIX + "portal";
        public const string REFINERY = GAME_TABLE_PREFIX + "refinery";
        public const string REBIRTH = GAME_TABLE_PREFIX + "rebirth";
        public const string REGION = GAME_TABLE_PREFIX + "region";
        public const string REPORT = GAME_TABLE_PREFIX + "report";
        public const string QUIZ = GAME_TABLE_PREFIX + "quiz";
        public const string STATISTIC = GAME_TABLE_PREFIX + "statistic";
        public const string STATUS = GAME_TABLE_PREFIX + "status";
        public const string SUBCLASS = GAME_TABLE_PREFIX + "subclass";
        public const string SUPERMAN = GAME_TABLE_PREFIX + "superman";
        public const string SYNDICATE = GAME_TABLE_PREFIX + "syndicate";
        public const string SYNDICATE_WAR = GAME_TABLE_PREFIX + "syndicate_war";
        public const string SYNDICATE_ADVERTISE = GAME_TABLE_PREFIX + "syn_advertise";
        public const string SYNDICATE_ALLY = GAME_TABLE_PREFIX + "syn_ally";
        public const string SYNDICATE_ATTR = GAME_TABLE_PREFIX + "synattr";
        public const string SYNDICATE_ENEMY = GAME_TABLE_PREFIX + "syn_enemy";
        public const string SYNDICATE_TOTEM = GAME_TABLE_PREFIX + "syntotem";
        public const string SYNDICATE_TOTEM_ENHANCE = GAME_TABLE_PREFIX + "syntotem_enhance";
        public const string TASK = GAME_TABLE_PREFIX + "task";
        public const string TITLE = GAME_TABLE_PREFIX + "title";
        public const string TRADE = GAME_TABLE_PREFIX + "trade";
        public const string TRADE_ITEM = GAME_TABLE_PREFIX + "trade_item";
        public const string TRAINING_VITALITY = GAME_TABLE_PREFIX + "training_vitality";
        public const string TRAP = GAME_TABLE_PREFIX + "trap";
        public const string TRAP_TYPE = GAME_TABLE_PREFIX + "traptype";
        public const string TUTOR = GAME_TABLE_PREFIX + "tutor";
        public const string TUTOR_ACCESS = GAME_TABLE_PREFIX + "tutor_access";
        public const string TUTOR_BATTLE_LIMIT_TYPE = GAME_TABLE_PREFIX + "tutor_battle_limit_type";
        public const string TUTOR_CONTRIBUTION = GAME_TABLE_PREFIX + "tutor_contributions";
        public const string TUTOR_TYPE = GAME_TABLE_PREFIX + "tutor_type";
        public const string USER = GAME_TABLE_PREFIX + "user";
        public const string NAME_CHANGE_LOG = GAME_TABLE_PREFIX + "user_name_log";
        public const string WEAPON_SKILL = GAME_TABLE_PREFIX + "weapon_skill";
        public const string DYNA_RANK_REC = "dyna_rank_rec";
        public const string DYNA_RANK_TYPE = "dyna_rank_type";
        public const string DYNAMICRANKREC = "dynamic_rank";
        public const string DYNAMICRANKTYPE = "dynamic_rank_type"; // this table wont load, just for reference
        public const string EMONEY = "e_money";
    }
}