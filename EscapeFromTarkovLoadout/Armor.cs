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

        int armorNumber; // Local varibale for storing the random generaten armor number
        int rigNumber; // Local variable for storing the random generated number from rigs

        // Getting the random generated rig-number, is called from Form1
        public void GetRigNumber(int n)
        {
            int rigNr = n;
            rigNumber = rigNr;
        }

        // Generates random number between 1-22, there are 22 bifrent armors
        public int RandomArmor()
        {
            Random rnd = new Random();
            int armor = rnd.Next(1, 23);  // Uses last number, therefore it's 23
            return armor;
        }

        // Calling RandomArmor and saved the number in local varibale in usage for image
        public void GetRandomArmor()
        {
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
                    //armorImage = Resources
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\3M.png");
                }
                else if (armor == 2) // PACA Soft Armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\PACA.png");
                }
                else if (armor == 3) // 6B2 armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\6B2.png");
                }
                else if (armor == 4) // MF-UNTAR armor vest
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\UNTARArmor.png");
                }
                else if (armor == 5) // Zhuk - 3 Press armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Zhuk-3_Press_armor.png");
                }
                else if (armor == 6) // 6B23-1 armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\6B23-1.png");
                }
                else if (armor == 7) // BNTI Kirasa-N armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Kirasa.png");
                }
                else if (armor == 8) // Highcom Trooper TFO armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Highcom_Trooper.png");
                }
                else if (armor == 9) // 6B13 assault armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\6B13.gif");
                }
                else if (armor == 10) // 6B23-2 armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\6B23-2.png");
                }
                else if (armor == 11) // BNTI Korund-VM armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\KORUND.png");
                }
                else if (armor == 12) // FORT Redut-M body armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\FORT_Redut-M.png");
                }
                else if (armor == 13) // 6B13 M assault armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\6B13_M_killa.png");
                }
                else if (armor == 14) // IOTV Gen4 armor (high mobility kit)
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Gen4hmk.png");
                }
                else if (armor == 15) // BNTI Gzhel-K armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\GZHEL-K.png");
                }
                else if (armor == 16) // FORT Defender-2 body armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Defender-2.png");
                }
                else if (armor == 17) // IOTV Gen4 armor (assault kit)
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Gen4assault.png");
                }
                else if (armor == 18) // IOTV Gen4 armor (full protection)
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Gen4full.png");
                }
                else if (armor == 19) // FORT Redut-T5 body armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\FORT_Redut-T5.png");
                }
                else if (armor == 20) // LBT 6094A Slick Plate Carrier
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Slick.png");
                }
                else if (armor == 21) // Zhuk-6a heavy armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\Zhuk-6a.png");
                }
                else if (armor == 22) // 6B43 Zabralo-Sh 6A Armor
                {
                    armorImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Armor\FORT-6b43-6a.png");
                }
                else armorImage = null;
                return armorImage;
            }
            armorImage = null;
            return armorImage;
        }
    }
}
