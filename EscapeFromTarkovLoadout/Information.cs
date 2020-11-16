using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    public class Information
    {
        //public string GetTitleForInfo()
        //{
        //    string text;
        //    text = "Information";
        //    return text;
        //}

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
                "7 maps\n\n" +
                "Feel free to mod the weapons as you like, the images are the standard appearance for it.\n" +
                "Some helmets and armor exists in diffrent colors, the images represent the model only.";
            return text;
        }

        // Link to Escape From Tarkov Weapons
        public void VisitLinkWeapons()
        {
            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://escapefromtarkov.gamepedia.com/Weapons");
        }

        // Link to Escape From Tarkov Armor
        public void VisitLinkArmor()
        {
            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://escapefromtarkov.gamepedia.com/Armor_vests");
        }

        // Link to Escape From Tarkov Headwear
        public void VisitLinkHeadwear()
        {
            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://escapefromtarkov.gamepedia.com/Headwear");
        }

        // Link to Escape From Tarkov Rigs
        public void VisitLinkRigs()
        {
            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://escapefromtarkov.gamepedia.com/Chest_rigs#Armored");
        }

        // Link to Escape From Tarkov Backpacks
        public void VisitLinkBackpacks()
        {
            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://escapefromtarkov.gamepedia.com/Backpacks");
        }

        // Link to Escape From Tarkov Maps
        public void VisitLinkMaps()
        {
            //Call the Process.Start method to open the default browser with a URL:
            System.Diagnostics.Process.Start("https://escapefromtarkov.gamepedia.com/Map_of_Tarkov");
        }

        // Link to PayPal for donations
        public void VisitPayPalDonate()
        {
            // Add URL
            System.Diagnostics.Process.Start("");
        }
    }
}
