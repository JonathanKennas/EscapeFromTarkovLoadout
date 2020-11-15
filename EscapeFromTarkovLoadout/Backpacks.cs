using EscapeFromTarkovLoadout.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    public class Backpacks
    {
        // 21 backpacks in patch 0.12.8.97.67
        // https://escapefromtarkov.gamepedia.com/Backpacks

        int backpackNumber; // Local varibale for storing the random generaten backpack number

        // Generates random number between 1-21, there are 21 bifrent backpacks
        public int RandomBackpack()
        {
            Random rnd = new Random();
            int backpack = rnd.Next(1, 22); // Uses last number, therefore it's 22
            return backpack;
        }

        // Calling RandomBackpack and saved the number in local varibale in usage for image
        public void GetRandomBackpack()
        {
            backpackNumber = RandomBackpack();
        }

        // Getting the random number from local variable backpackNumber and setting a image for it
        public Image GetBackpackImage()
        {
            Image backpackImage;
            int backpack;
            backpack = backpackNumber;

            if (backpack == 1) // 6SH118 raid backpack
            {
                //backpackImage = Resources
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\6SH118.png");
            }
            else if (backpack == 2) // Mystery Ranch Blackjack 50 backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Mystery_Ranch_Blackjack_50_backpack.png");
            }
            else if (backpack == 3) // Eberlestock F4 Terminator load bearing backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\F4_terminator.png");
            }
            else if (backpack == 4) // SSO Attack 2 raid backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Attack.png");
            }
            else if (backpack == 5) // Pilgrim tourist backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Pilgrim.png");
            }
            else if (backpack == 6) // 3V G Paratus 3-Day Operator's Tactical Backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\3V_G_Paratus.png");
            }
            else if (backpack == 7) // LBT-2670 Slim Field Med Pack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\LBT-2670.png");
            }
            else if (backpack == 8) // Oakley Mechanism heavy duty backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Oakley_Mechanism.png");
            }
            else if (backpack == 9) // Camelbak Tri-Zip Backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Tri-Zip.png");
            }
            else if (backpack == 10) // Ana tactical Beta 2 battle backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Beta2.png");
            }
            else if (backpack == 11) // Eberlestock F5 Switchblade backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Eberlestock_F5.png");
            }
            else if (backpack == 12) // Wartech Berkut VV-102 backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Wartech_Berkut_VV-102.png");
            }
            else if (backpack == 13) // LBT-8005A Day Pack backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Day_pack.png");
            }
            else if (backpack == 14) // Scav Backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\ScavBP.png");
            }
            else if (backpack == 15) // Flyye MBSS Backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Flyye_MBSS.png");
            }
            else if (backpack == 16) // Sanitar bag
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Sanitar_Bag.png");
            }
            else if (backpack == 17) // Duffle bag
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Duffel.png");
            }
            else if (backpack == 18) // LK 3F Transfer tourist backpack
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\LK_3F.png");
            }
            else if (backpack == 19) // Transformer Bag
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\T-Bag.png");
            }
            else if (backpack == 20) // VKBO army bag
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\Armybag.png");
            }
            else if (backpack == 21) // Tactical sling bag
            {
                backpackImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Backpacks\SlingBackPack.png");
            }
            else
            {
                backpackImage = null;
            }
            return backpackImage;
        }
    }
}
