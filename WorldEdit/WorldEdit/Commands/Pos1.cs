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

using MiNET.Utils;
using MiNET.Plugins.Attributes;
using MiNET;

namespace WorldEdit.Commands
{
    public class Pos1
    {
        private WorldEdit Plugin { get; set; }

        public Pos1(WorldEdit plugin)
        {
            Plugin = plugin;
        }

        [Command(Name = "/pos1", Description = "Selects your first position.", Permission = "worldedit.command.pos1")]
        public void Launch(Player sender)
        {
            Plugin.SetFirstPosition(sender);

            sender.SendMessage(ChatColors.Gray + "First position selected to X: " + (int) sender.KnownPosition.X + " Y: " + (int) sender.KnownPosition.Y + " Z: " + (int) sender.KnownPosition.Z);
        }
    }
}
