using EscapeFromTarkovLoadout.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    public class Armor
    {
        // 22 bodyarmor in patch 0.12.8.97.67
        // https://escapefromtarkov.gamepedia.com/Armor_vests
        // 1 added with value null

        int armorNumber; // Local varibale for storing the random generaten armor number
        int rigNumber; // Local variable for storing the random generated number from rigs

        // Getting the random generated rig-number, is called from Form1
        public void GetRigNumber(int n)
        {
            int rigNr = n;
            rigNumber = rigNr;
        }

        // Generates random number between 1-23, there are 22 bifrent armors and 1 for null
        public int RandomArmor()
        {
            Random rnd = new Random();
            int armor = rnd.Next(1, 24);  // Uses last number, therefore it's 24
            return armor;
        }

        // Calling RandomArmor and saved the number in local varibale in usage for image
        public void GetRandomArmor()
        {
            armorNumber = 0;
            armorNumber = RandomArmor();
        }

        // Getting the random number from local variable armorNumber and setting a image for it
        public Image GetArmorImage()
        {
            Image armorImage;
            int armor;
            armor = armorNumber;

            if (rigNumber > 10) // Controll if rignumber is bigger then 10 (unarmored rigs starts at 10)
            {
                if (armor == 1) // Module-3M bodyarmor
                {
                    armorImage = Resources.Armor_Module_3M;
                }
                else if (armor == 2) // PACA Soft Armor
                {
                    armorImage = Resources.Armor_PACA_Soft_Armor;
                }
                else if (armor == 3) // 6B2 armor
                {
                    armorImage = Resources.Armor_6B2_armor;
                }
                else if (armor == 4) // MF-UNTAR armor vest
                {
                    armorImage = Resources.Armor_MF_UNTAR;
                }
                else if (armor == 5) // Zhuk - 3 Press armor
                {
                    armorImage = Resources.Armor_Zhuk_3_Press_Armor;
                }
                else if (armor == 6) // 6B23-1 armor
                {
                    armorImage = Resources.Armor_6B23_1_digital_flora;
                }
                else if (armor == 7) // BNTI Kirasa-N armor
                {
                    armorImage = Resources.Armor_BNTI_Kirasa_N;
                }
                else if (armor == 8) // Highcom Trooper TFO armor
                {
                    armorImage = Resources.Armor_Highcom_Trooper_TFO;
                }
                else if (armor == 9) // 6B13 assault armor
                {
                    armorImage = Resources.Armor_6B13_assault;
                }
                else if (armor == 10) // 6B23-2 armor
                {
                    armorImage = Resources.Armor_6B23_2;
                }
                else if (armor == 11) // BNTI Korund-VM armor
                {
                    armorImage = Resources.Armor_BNTI_Korund_VM;
                }
                else if (armor == 12) // FORT Redut-M body armor
                {
                    armorImage = Resources.Armor_FORT_Redut_M;
                }
                else if (armor == 13) // 6B13 M Killa assault armor
                {
                    armorImage = Resources.Armor_6B13_M_Killa;
                }
                else if (armor == 14) // IOTV Gen4 armor (high mobility kit)
                {
                    armorImage = Resources.Armor_IOTV_Gen4_high_mobility;
                }
                else if (armor == 15) // BNTI Gzhel-K armor
                {
                    armorImage = Resources.Armor_BNTI_Gzhel_K;
                }
                else if (armor == 16) // FORT Defender-2 body armor
                {
                    armorImage = Resources.Armor_FORT_Defender_2;
                }
                else if (armor == 17) // IOTV Gen4 armor (assault kit)
                {
                    armorImage = Resources.Armor_IOTV_Gen4_assault;
                }
                else if (armor == 18) // IOTV Gen4 armor (full protection)
                {
                    armorImage = Resources.Armor_IOTV_Gen4_full;
                }
                else if (armor == 19) // FORT Redut-T5 body armor
                {
                    armorImage = Resources.Armor_Redut_T5;
                }
                else if (armor == 20) // LBT 6094A Slick Plate Carrier
                {
                    armorImage = Resources.Armor_LBT_6094A_Slick;
                }
                else if (armor == 21) // Zhuk-6a heavy armor
                {
                    armorImage = Resources.Armor_Zhuk_6a;
                }
                else if (armor == 22) // 6B43 Zabralo-Sh 6A Armor
                {
                    armorImage = Resources.Armor_6B43_Zabralo_Sh_6A_Fort;
                }
                // If the generated number doesn't exist withing i "if" statment, the image sets to null
                else armorImage = null;
                return armorImage;
            }
            // If the generated number cannot be combined with a armored rig the image is set to null
            armorImage = null;
            return armorImage;
        }
    }
}
