﻿
/*
    ▓█████▄  ▄▄▄       ██▀███   ██ ▄█▀ ██▓     █    ██  ▄▄▄▄   
    ▒██▀ ██▌▒████▄    ▓██ ▒ ██▒ ██▄█▒ ▓██▒     ██  ▓██▒▓█████▄ 
    ░██   █▌▒██  ▀█▄  ▓██ ░▄█ ▒▓███▄░ ▒██░    ▓██  ▒██░▒██▒ ▄██
    ░▓█▄   ▌░██▄▄▄▄██ ▒██▀▀█▄  ▓██ █▄ ▒██░    ▓▓█  ░██░▒██░█▀  
    ░▒████▓  ▓█   ▓██▒░██▓ ▒██▒▒██▒ █▄░██████▒▒▒█████▓ ░▓█  ▀█▓
     ▒▒▓  ▒  ▒▒   ▓▒█░░ ▒▓ ░▒▓░▒ ▒▒ ▓▒░ ▒░▓  ░░▒▓▒ ▒ ▒ ░▒▓███▀▒
     ░ ▒  ▒   ▒   ▒▒ ░  ░▒ ░ ▒░░ ░▒ ▒░░ ░ ▒  ░░░▒░ ░ ░ ▒░▒   ░ 
     ░ ░  ░   ░   ▒     ░░   ░ ░ ░░ ░   ░ ░    ░░░ ░ ░  ░    ░ 
       ░          ░  ░   ░     ░  ░       ░  ░   ░      ░      
     ░                                                       ░ 

     WorldEdit by Herb9. (pksxtm@gmail.com, Telegram @Herb9)
*/

using WorldEdit.Commands;

using MiNET.Utils;
using MiNET.Plugins.Attributes;
using MiNET.Plugins;
using MiNET;

using System.Collections.Generic;
using System.Text;
using System;

namespace WorldEdit
{
    [Plugin(PluginName = "WorldEdit", Description = "Simple and fastest world editing tools for MiNET.", PluginVersion = "1.0", Author = "Herb9")]
    public class WorldEdit : Plugin
    {
        public const string Prefix = "\x5b\x57\x6f\x72\x6c\x64\x45\x64\x69\x74\x5d";

        public Dictionary<Player, BlockCoordinates> Pos1 = new Dictionary<Player, BlockCoordinates>();

        protected override void OnEnable()
        {
            RegisterCommands();

            Console.WriteLine(Prefix + Encoding.UTF8.GetString(Convert.FromBase64String("IFdvcmxkRWRpdCB2MS4wIGJ5IEhlcmI5LiAocGtzeHRtQGdtYWlsLmNvbSwgVGVsZWdyYW0gQEhlcmI5KQ==")));
        }

        private void RegisterCommands()
        {
            Context.PluginManager.LoadCommands(new Pos1(this));
        }

        /*
             ▄▄▄       ██▓███   ██▓
            ▒████▄    ▓██░  ██▒▓██▒
            ▒██  ▀█▄  ▓██░ ██▓▒▒██▒
            ░██▄▄▄▄██ ▒██▄█▓▒ ▒░██░
             ▓█   ▓██▒▒██▒ ░  ░░██░
             ▒▒   ▓▒█░▒▓▒░ ░  ░░▓  
              ▒   ▒▒ ░░▒ ░      ▒ ░
              ░   ▒   ░░        ▒ ░
                  ░  ░          ░  
        */

        public bool IsFirstPosition(Player player) => Pos1.ContainsKey(player);

        public void SetFirstPosition(Player player)
        {
            Pos1[player] = new BlockCoordinates(player.KnownPosition);
        }

        public void RemoveFirstPosition(Player player)
        {
            Pos1.Remove(player);
        }
    }
}
