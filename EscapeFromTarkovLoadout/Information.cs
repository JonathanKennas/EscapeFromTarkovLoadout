using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    public class Information
    {
        public string GetTitleForInfo()
        {
            string text;
            text = "Information";
            return text;
        }

        public string GetTextForInfo()
        {
            string text;
            text = "This is a free loadout generator for Escape From Tarkov.\n \n" +
                "All the gear that is added are currently in patch 12.8.97.67\n \n" +
                "It generates weapons, armor, headwear, rigs, backpacks and maps \nwithin the combinations that works in the game. \n\n" +
                "This loadout generator contains:\n " +
                "83 weapons\n " +
                "22 armors\n " +
                "55 headwear\n " +
                "26 rigs (10 armored & 16 unarmored)\n " +
                "21 backpacks\n " +
                "7 maps\n\n " +
                "Enjoy!";
            return text;
        }
    }
}
