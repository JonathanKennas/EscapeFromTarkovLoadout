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
        // 1 added with value null

        int backpackNumber; // Local varibale for storing the random generaten backpack number

        // Generates random number between 1-22, there are 21 bifrent backpacks and 1 for null
        public int RandomBackpack()
        {
            Random rnd = new Random();
            int backpack = rnd.Next(1, 23); // Uses last number, therefore it's 23
            return backpack;
        }

        // Calling RandomBackpack and saved the number in local varibale in usage for image
        public void GetRandomBackpack()
        {
            backpackNumber = 0;
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
                backpackImage = Resources.Backpack_6SH118_Raid;
            }
            else if (backpack == 2) // Mystery Ranch Blackjack 50 backpack
            {
                backpackImage = Resources.Backpack_Mystery_Ranch_Blackjack_50;
            }
            else if (backpack == 3) // Eberlestock F4 Terminator load bearing backpack
            {
                backpackImage = Resources.Backpack_Eberlestock_F4_Terminator;
            }
            else if (backpack == 4) // SSO Attack 2 raid backpack
            {
                backpackImage = Resources.Backpack_SS0_Attack_2_Raid;
            }
            else if (backpack == 5) // Pilgrim tourist backpack
            {
                backpackImage = Resources.Backpack_Pilgrim_tourist;
            }
            else if (backpack == 6) // 3V G Paratus 3-Day Operator's Tactical Backpack
            {
                backpackImage = Resources.Backpack_3V_G_Paratus;
            }
            else if (backpack == 7) // LBT-2670 Slim Field Med Pack
            {
                backpackImage = Resources.Backpack_LBT_2670_Slim_Field_Med;
            }
            else if (backpack == 8) // Oakley Mechanism heavy duty backpack
            {
                backpackImage = Resources.Backpack_Oakley_Mechanism;
            }
            else if (backpack == 9) // Camelbak Tri-Zip Backpack
            {
                backpackImage = Resources.Backpack_Camelback_Tri_Zip;
            }
            else if (backpack == 10) // Ana tactical Beta 2 battle backpack
            {
                backpackImage = Resources.Backpack_Ana_Beta_2;
            }
            else if (backpack == 11) // Eberlestock F5 Switchblade backpack
            {
                backpackImage = Resources.Backpack_Eberlestock_F5_Switchable;
            }
            else if (backpack == 12) // Wartech Berkut VV-102 backpack
            {
                backpackImage = Resources.Backpack_Wartech_Berkut_VV_102;
            }
            else if (backpack == 13) // LBT-8005A Day Pack backpack
            {
                backpackImage = Resources.Backpack_LBT_8005A_Day_pack;
            }
            else if (backpack == 14) // Scav Backpack
            {
                backpackImage = Resources.Backpack_Scav_Backpack;
            }
            else if (backpack == 15) // Flyye MBSS Backpack
            {
                backpackImage = Resources.Backpack_Flyye_MBSS;
            }
            else if (backpack == 16) // Sanitar bag
            {
                backpackImage = Resources.Backpack_Sanitar_bag;
            }
            else if (backpack == 17) // Duffle bag
            {
                backpackImage = Resources.Backpack_Duffle_bag;
            }
            else if (backpack == 18) // LK 3F Transfer tourist backpack
            {
                backpackImage = Resources.Backpack_LK_3F_Transfer_tourist;
            }
            else if (backpack == 19) // Transformer Bag
            {
                backpackImage = Resources.Backpack_Transformer_T_bag;
            }
            else if (backpack == 20) // VKBO army bag
            {
                backpackImage = Resources.Backpack_VKBO_Army_bag;
            }
            else if (backpack == 21) // Tactical sling bag
            {
                backpackImage = Resources.Backpack_Tactical_sling;
            }
            // If the generated number doesn't exist withing i "if" statment, the image sets to null
            else backpackImage = null;          
            return backpackImage;
        }
    }
}
