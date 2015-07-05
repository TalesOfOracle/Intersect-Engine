/*
    Intersect Game Engine (Server)
    Copyright (C) 2015  JC Snider, Joe Bridges
    
    Website: http://ascensiongamedev.com
    Contact Email: admin@ascensiongamedev.com 

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/
using System;
using System.Collections.Generic;
using System.Threading;

namespace Intersect_Server.Classes
{
	public static class Globals
	{

        //Options
        public static int ServerPort = 4501;
        public static string MySqlHost = "localhost";
        public static int MySqlPort = 3306;
        public static string MySqlUser = "root";
        public static string MySqlPass = "pass";
        public static string MySqldb = "IntersectDB";

        //Game Maps
		public static MapStruct[] GameMaps;
		public static int MapCount;

        //Game Items
        public static ItemStruct[] GameItems;

        //Game Spells
        public static SpellStruct[] GameSpells;

        //Game Npcs
        public static NpcStruct[] GameNpcs;

        //Game Resources
        public static ResourceStruct[] GameResources;

        //Game Animations
        public static AnimationStruct[] GameAnimations;

		public static List<Client> Clients = new List<Client>();
		public static List<Thread> ClientThread = new List<Thread>();
		public static List<Entity> Entities = new List<Entity>();
		public static string[] Tilesets;

        //Game helping stuff
        public static Random Rand = new Random();

        public static int GameTime = 0;

        public static int FindOpenEntity()
        {
            for (var i = 0; i < Entities.Count; i++)
            {
                if (Entities[i] == null)
                {
                    return i;
                }
                else if (i == Entities.Count - 1)
                {
                    Entities.Add(null);
                    return Entities.Count - 1;
                }
            }
            Entities.Add(null);
            return Entities.Count - 1;
        }

        public static void AddEntity(Entity newEntity)
        {
            var slot = FindOpenEntity();
            Entities[slot] = newEntity;
        }
	}
}

