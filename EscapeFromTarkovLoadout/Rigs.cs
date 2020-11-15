using EscapeFromTarkovLoadout.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    public class Rigs
    {
        // 10 armored and 16 unarmored, total 26, rigs in patch 0.12.8.97.67
        // https://escapefromtarkov.gamepedia.com/Chest_rigs#Armored

        // IMPORTANT! When adding a new rig, remember to add it to control in Armor-class

        // Needs to be public for usage from From1
        public int rigNumber; // Local varibale for storing the random generaten rig number

        // Generates random number between 1-26, there are 26 diffrent rigs
        public int RandomRig()
        {
            Random rnd = new Random();
            int rig = rnd.Next(1, 27); // Generates a random number between 1-26
            return rig;
        }

        // Calling RandomRig and saved the number in local varibale in usage for image
        public void GetRandomRig()
        {
            rigNumber = RandomRig();
        }

        // Getting the random number from local variable rigNumber and setting a image for it
        public Image GetRigImage()
        {
            Image rigImage;
            int rig;
            rig = rigNumber;

            // Armored rigs START
            if (rig == 1) // 6B5-16 Zh -86 "Uley" armored rig
            {
                //rigImage = Resources
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\6B5-16_armored_rig.png");
            }
            else if (rig == 2) // 6B3TM-01M armored rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\6B3TM-01M.png");
            }
            else if (rig == 3) // 6B5-15 Zh -86 "Uley" armored rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\6B5-15.png");
            }
            else if (rig == 4) // ANA Tactical M2 armored rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\ANA-M2.png");
            }
            else if (rig == 5) // ANA Tactical M1 armored rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\ANA-M1.png");
            }
            else if (rig == 6) // Crye Precision AVS platecarrier
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\AVS.png");
            }
            else if (rig == 7) // Ars Arma A18 Skanda plate carrier
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\ARS-A18.png");
            }
            else if (rig == 8) // Wartech TV-110 plate carrier
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\Wartech_TV-110.png");
            }
            else if (rig == 9) // 5.11 Tactec plate carrier
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\Tactec-5.11.png");
            }
            else if (rig == 10) // Ars Arma CPC MOD.2 plate carrier
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Armored\ARS-AACPC-MOD.2.png");
            }
            // Armored rigs END

            // Unarmored rigs START
            else if (rig == 11) // Scav Vest
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Scav_Vest.png");
            }
            else if (rig == 12) // Spiritus Systems Bank Robber Chest Rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Bank_Robber.png");
            }
            else if (rig == 13) // SOE Micro Rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\SOE-micro.png");
            }
            else if (rig == 14) // Wartech gear rig (TV-109, TV-106)
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Wartech.png");
            }
            else if (rig == 15) // UMTBS 6sh112 Scout-Sniper
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Scout_Sniper.png");
            }
            else if (rig == 16) // Splav Tarzan M22 Rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Tarzan.png");
            }
            else if (rig == 17) // Haley Strategic D3CRX Chest Harness
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\D3CRX.png");
            }
            else if (rig == 18) // Triton M43-A Chest Harness
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Triton_M43-A.png");
            }
            else if (rig == 19) // Blackhawk! Commando Chest Harness
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Blackhawk!_commando.gif");
            }
            else if (rig == 20) // Direct Action Thunderbolt compact chest rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Direct_Action_Thunderbolt.png");
            }
            else if (rig == 21) // LBT-1961A Load Bearing Chest Vest
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\LBT_1961.png");
            }
            else if (rig == 22) // BlackRock chest rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Blackrock.png");
            }
            else if (rig == 23) // Wartech MK3 chest rig (TV-104)
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Wartech-Mk3.png");
            }
            else if (rig == 24) // ANA Tactical Alpha chest rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\ANA-Alpha.png");
            }
            else if (rig == 25) // Velocity Systems Multi-Purpose Patrol Vest
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Velocity-MPPV.png");
            }
            else if (rig == 26) // Belt-A + Belt-B gear rig
            {
                rigImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Rigs\Unarmored\Belt-A_Belt-B.png");
            }
            // Unarmored rigs END
            else rigImage = null;
            return rigImage;
        }
    }
}
