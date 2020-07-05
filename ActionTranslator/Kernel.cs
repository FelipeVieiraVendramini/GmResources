// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// GmResources - ActionTranslator - Kernel.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using MyCore.Database;

namespace ActionTranslator
{
    public static class Kernel
    {
        /// <summary>
        ///     The database configuration for accessing account information.
        /// </summary>
        public static MySqlConfig AccountDbConfig = default;

        /// <summary>
        ///     The database configuration for accessing logging data.
        /// </summary>
        public static MySqlConfig LogDbConfig = default;

        /// <summary>
        ///     The database configuration for accessing user data on the game.
        /// </summary>
        public static MySqlConfig GameDbConfig = default;

        /// <summary>
        ///     The database configuration for accessing game data as NPCs, actions, AI and other kind of ingame
        ///     information.
        /// </summary>
        public static MySqlConfig ResourceDbConfig = default;
    }
}