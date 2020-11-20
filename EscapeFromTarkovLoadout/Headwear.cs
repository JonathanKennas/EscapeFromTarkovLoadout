using EscapeFromTarkovLoadout.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    public class Headwear
    {
        // 55 headwear in patch 0.12.8.97.67
        // https://escapefromtarkov.gamepedia.com/Headwear
        // 1 added with value null

        int headwearNumber; // Local varibale for storing the random generaten headwear number

        // Generates random number between 1-56, there are 55 bifrent headwear and 1 for null
        public int RandomHeadwear()
        {
            Random rnd = new Random();
            int headwear = rnd.Next(1, 57); // Uses last number, therefore it's 57
            return headwear;
        }

        // Calling RandomHeadwear and saved the number in local varibale in usage for image
        public void GetRandomHeadwear()
        {
            headwearNumber = RandomHeadwear();
        }

        // Getting the random number from local variable headwearNumber and setting a image for it
        public Image GetHeadwearImage()
        {
            Image headwearImage;
            int headwear;
            headwear = headwearNumber;

            // Mount START
            if (headwear == 1) // Armasight NVG mask
            {
                headwearImage = Resources.Headwear_Armasight_NVG_mask;
            }
            else if (headwear == 2) // Wilcox Skull Lock head mount
            {
                headwearImage = Resources.Headwear_Wilcox_Skull_Lock_head_mount;
            }
            // Mount END

            // Armored helmets START
            else if (headwear == 3) // Tac-Kek Fast MT Helmet
            {
                headwearImage = Resources.Headwear_Tac_Kek_Fast_MT_Helmet;
            }
            else if (headwear == 4) // Soft tank crew helmet TSH-4M-L
            {
                headwearImage = Resources.Headwear_Soft_tank_crew_helmet_TSH_4M_L;
            }
            else if (headwear == 5) // Kolpak-1S riot helmet
            {
                headwearImage = Resources.Headwear_Kolpak_1S;
            }
            else if (headwear == 6) // SHPM Firefighter's helmet
            {
                headwearImage = Resources.Headwear_SHPM_Firefighter;
            }
            else if (headwear == 7) // PSH-97 Djeta helmet
            {
                headwearImage = Resources.Headwear_PSH_97_Djeta;
            }
            else if (headwear == 8) // Jack-o'-lantern tactical pumpkin helmet
            {
                headwearImage = Resources.Headwear_Jack_o_lantern_pumpkin;
            }
            else if (headwear == 9) // UNTAR helmet
            {
                headwearImage = Resources.Headwear_UNTAR;
            }
            else if (headwear == 10) // 6B47 Ratnik-BSh Helmet
            {
                headwearImage = Resources.Headwear_6B47_Ratnik_BSh;
            }
            else if (headwear == 11) // LZSh light helmet
            {
                headwearImage = Resources.Headwear_LZSh_light;
            }
            else if (headwear == 12) // SSh-68 helmet (1968 steel helmet)
            {
                headwearImage = Resources.Headwear_SSh_68;
            }
            else if (headwear == 13) // Kiver-M Helmet
            {
                headwearImage = Resources.Headwear_Kiver_M;
            }
            else if (headwear == 14) // DEVTAC Ronin ballistic helmet
            {
                headwearImage = Resources.Headwear_DEVTAC_Ronin;
            }
            else if (headwear == 15) // SSSh-95 Sfera-S (Sphere-S)
            {
                headwearImage = Resources.Headwear_SSSh_95_Sfera_S;
            }
            else if (headwear == 16) // MSA ACH TC-2001 MICH Series Helmet
            {
                headwearImage = Resources.Headwear_MSA_ACH_TC_2001;
            }
            else if (headwear == 17) // MSA ACH TC-2002 MICH Series Helmet
            {
                headwearImage = Resources.Headwear_MSA_ACH_TC_2002;
            }
            else if (headwear == 18) // MSA Gallet TC 800 High Cut combat helmet
            {
                headwearImage = Resources.Headwear_MSA_Gallet_TC_800;
            }
            else if (headwear == 19) // Highcom Striker ACHHC IIIA helmet
            {
                headwearImage = Resources.Headwear_Highcom_Striker_ACHHC_IIIA;
            }
            else if (headwear == 20) // ZSh-1-2M helmet
            {
                headwearImage = Resources.Headwear_ZSh1_2M;
            }
            else if (headwear == 21) // Highcom Striker ULACH IIIA helmet
            {
                headwearImage = Resources.Headwear_Highcom_Striker_ULACH_IIIA;
            }
            else if (headwear == 22) // Diamond Age Bastion Helmet
            {
                headwearImage = Resources.Headwear_Diamond_Age_Bastion;
            }
            else if (headwear == 23) // Ops-Core Fast MT SUPER HIGH CUT Helmet
            {
                headwearImage = Resources.Headwear_Ops_Core_Fast_MT;
            }
            else if (headwear == 24) // Crye Precision Airframe Tan
            {
                headwearImage = Resources.Headwear_Airframe;
            }
            else if (headwear == 25) // Team Wendy EXFIL Ballistic Helmet
            {
                headwearImage = Resources.Headwear_Team_Wendy_EXFIL;
            }
            else if (headwear == 26) // Galvion Caiman Ballistic Helmet
            {
                headwearImage = Resources.Headwear_Galvion_Caiman;
            }
            else if (headwear == 27) // BNTI LSHZ-2DTM Helmet
            {
                headwearImage = Resources.Headwear_BNTI_LSHZ_2DTM;
            }
            else if (headwear == 28) // Maska 1Sch helmet Killa
            {
                headwearImage = Resources.Headwear_Maska_1Sch_Killa;
            }
            else if (headwear == 29) // Altyn helmet
            {
                headwearImage = Resources.Headwear_Altyn;
            }
            else if (headwear == 30) // Rys-T helmet
            {
                headwearImage = Resources.Headwear_Rys_T;
            }
            else if (headwear == 31) // Vulkan-5 (LShZ-5) heavy helmet
            {
                headwearImage = Resources.Headwear_Vulkan_5_LShZ_5;
            }
            // Armored helmets END

            // Vanity START
            else if (headwear == 32) // Kinda cowboy hat
            {
                headwearImage = Resources.Headwear_Cowboy_Hat;
            }
            else if (headwear == 33) // Ushanka ear-flap cap
            {
                headwearImage = Resources.Headwear_Ushanka_ear_flap;
            }
            else if (headwear == 34) // Miltec panama hat
            {
                headwearImage = Resources.Headwear_Miltec_Panama;
            }
            else if (headwear == 35) // Door Kicker Boonie hat
            {
                headwearImage = Resources.Headwear_Door_Kicker;
            }
            else if (headwear == 36) // Beanie
            {
                headwearImage = Resources.Headwear_Beanie;
            }
            else if (headwear == 37) // Kotton beanie
            {
                headwearImage = Resources.Headwear_Kotton_Beanie;
            }
            else if (headwear == 38) // Army cap
            {
                headwearImage = Resources.Headwear_Army_cap;
            }
            else if (headwear == 39) // Baseball cap
            {
                headwearImage = Resources.Headwear_Baseball_cap;
            }
            else if (headwear == 40) // Ded Moroz hat
            {
                headwearImage = null; // Add image
            }
            else if (headwear == 41) // Santa's hat
            {
                headwearImage = null; // Add image
            }
            else if (headwear == 42) // Police cap
            {
                headwearImage = Resources.Headwear_Police_cap;
            }
            else if (headwear == 43) // Tactical fleece hat
            {
                headwearImage = Resources.Headwear_Tactical_Fleece_hat;
            }
            else if (headwear == 44) // UX PRO Beanie
            {
                headwearImage = Resources.Headwear_UX_PRO;
            }
            else if (headwear == 45) // USEC baseball cap
            {
                headwearImage = Resources.Headwear_USEC_Baseball;
            }
            else if (headwear == 46) // BEAR baseball cap
            {
                headwearImage = Resources.Headwear_BEAR_Baseball;
            }
            else if (headwear == 47) // USEC baseball cap black
            {
                headwearImage = Resources.Headwear_USEC_Baseball_Black;
            }
            else if (headwear == 48) // BEAR baseball cap black
            {
                headwearImage = Resources.Headwear_BEAR_Baseball_Black;
            }
            else if (headwear == 49) // EmerCom cap
            {
                headwearImage = Resources.Headwear_EmerCom_cap;
            }
            else if (headwear == 50) // Pompon hat
            {
                headwearImage = Resources.Headwear_Pompon;
            }
            else if (headwear == 51) // Bandana
            {
                headwearImage = Resources.Headwear_Bandana;
            }
            else if (headwear == 52) // Ski hat with holes for eyes
            {
                headwearImage = Resources.Headwear_Shmaska_Ski_hat_with_holes;
            }
            else if (headwear == 53) // Olive beret
            {
                headwearImage = Resources.Headwear_Beret_olive;
            }
            else if (headwear == 54) // Black beret
            {
                headwearImage = Resources.Headwear_Beret_black;
            }
            else if (headwear == 55) // Blue beret
            {
                headwearImage = Resources.Headwear_Beret_blue;
            }
            // Vanity END

            // If the generated number doesn't exist withing i "if" statment, the image sets to null
            else headwearImage = null;
            return headwearImage;
        }
    }
}
