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

        // Needs to be public for usage from From1, control if the rig is compatible with armor or not
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
                rigImage = Resources.Rig_Armored_6B5_16_Zh_86;
            }
            else if (rig == 2) // 6B3TM-01M armored rig
            {
                rigImage = Resources.Rig_Armored_6B3TM_01M;
            }
            else if (rig == 3) // 6B5-15 Zh -86 "Uley" armored rig
            {
                rigImage = Resources.Rig_Armored_6B5_15_Zh;
            }
            else if (rig == 4) // ANA Tactical M2 armored rig
            {
                rigImage = Resources.Rig_Armored_ANA_Tactical_M2;
            }
            else if (rig == 5) // ANA Tactical M1 armored rig
            {
                rigImage = Resources.Rig_Armored_ANA_Tactical_M1;
            }
            else if (rig == 6) // Crye Precision AVS platecarrier
            {
                rigImage = Resources.Rig_Armored_Crye_Precission_AVS;
            }
            else if (rig == 7) // Ars Arma A18 Skanda plate carrier
            {
                rigImage = Resources.Rig_Armored_Ars_Arma_A18;
            }
            else if (rig == 8) // Wartech TV-110 plate carrier
            {
                rigImage = Resources.Rig_Armored_Wartech_TV_110;
            }
            else if (rig == 9) // 5.11 Tactec plate carrier
            {
                rigImage = Resources.Rig_Armored_511_TacTec;
            }
            else if (rig == 10) // Ars Arma CPC MOD.2 plate carrier
            {
                rigImage = Resources.Rig_Armored_Ars_Arma_CPC_MOD_2;
            }
            // Armored rigs END

            // Unarmored rigs START
            else if (rig == 11) // Scav Vest
            {
                rigImage = Resources.Rig_Scav_vest;
            }
            else if (rig == 12) // Spiritus Systems Bank Robber Chest Rig
            {
                rigImage = Resources.Rig_Spiritus_System_Bank_Robber;
            }
            else if (rig == 13) // SOE Micro Rig
            {
                rigImage = Resources.Rig_SOE_Micro_rig;
            }
            else if (rig == 14) // Wartech gear rig (TV-109, TV-106)
            {
                rigImage = Resources.Rig_Wartech_TV_109_TV_106;
            }
            else if (rig == 15) // UMTBS 6sh112 Scout-Sniper
            {
                rigImage = Resources.Rig_UMTBS_6sh112_Scout_sniper;
            }
            else if (rig == 16) // Splav Tarzan M22 Rig
            {
                rigImage = Resources.Rig_Splav_Tarzan_M22;
            }
            else if (rig == 17) // Haley Strategic D3CRX Chest Harness
            {
                rigImage = Resources.Rig_Haley_Strategic_D3CRX;
            }
            else if (rig == 18) // Triton M43-A Chest Harness
            {
                rigImage = Resources.Rig_Triton_M43_A;
            }
            else if (rig == 19) // Blackhawk! Commando Chest Harness
            {
                rigImage = Resources.Rig_Blackhawk_Commando;
            }
            else if (rig == 20) // Direct Action Thunderbolt compact chest rig
            {
                rigImage = Resources.Rig_Direct_Action_Thunderbolt;
            }
            else if (rig == 21) // LBT-1961A Load Bearing Chest Vest
            {
                rigImage = Resources.Rig_LBT_1961A_Load_Bearing;
            }
            else if (rig == 22) // BlackRock chest rig
            {
                rigImage = Resources.Rig_BlackRock;
            }
            else if (rig == 23) // Wartech MK3 chest rig (TV-104)
            {
                rigImage = Resources.Rig_Wartech_MK3_TV_104;
            }
            else if (rig == 24) // ANA Tactical Alpha chest rig
            {
                rigImage = Resources.Rig_ANA_Tactical_Alpha;
            }
            else if (rig == 25) // Velocity Systems Multi-Purpose Patrol Vest
            {
                rigImage = Resources.Rig_Velocity_MPPV;
            }
            else if (rig == 26) // Belt-A + Belt-B gear rig
            {
                rigImage = Resources.Rig_Belt_A_Belt_B;
            }
            // Unarmored rigs END
            else rigImage = null;
            return rigImage;
        }
    }
}
