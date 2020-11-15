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

        int headwearNumber; // Local varibale for storing the random generaten headwear number

        // Generates random number between 1-55, there are 55 bifrent headwear
        public int RandomHeadwear()
        {
            Random rnd = new Random();
            int headwear = rnd.Next(1, 56); // Uses last number, therefore it's 56
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
                //headwearImage = Resources
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Armasight_NVG_Mask.png");
            }
            else if (headwear == 2) // Wilcox Skull Lock head mount
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\WilcoxShull.png");
            }
            // Mount END

            // Armored helmets START
            else if (headwear == 3) // Tac-Kek Fast MT Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\TK_FAST.png");
            }
            else if (headwear == 4) // Soft tank crew helmet TSH-4M-L
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\TankHelmet.png");
            }
            else if (headwear == 5) // Kolpak-1S riot helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Kolpak-1S.png");
            }
            else if (headwear == 6) // SHPM Firefighter's helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\SHPM_Firefighter.png");
            }
            else if (headwear == 7) // PSH-97 Djeta helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\PSH-97_-Jeta.png");
            }
            else if (headwear == 8) // Jack-o'-lantern tactical pumpkin helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Pumpkin.png");
            }
            else if (headwear == 9) // UNTAR helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\UNTARHelmet.png");
            }
            else if (headwear == 10) // 6B47 Ratnik-BSh Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\6B47.gif"); // GIF?
            }
            else if (headwear == 11) // LZSh light helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\LZSh_light_helmet.png");
            }
            else if (headwear == 12) // SSh-68 helmet (1968 steel helmet)
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\SSH-68.png");
            }
            else if (headwear == 13) // Kiver-M Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Kiver-M_Helmet.png");
            }
            else if (headwear == 14) // DEVTAC Ronin ballistic helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\DEVTAC_Ronin.png");
            }
            else if (headwear == 15) // SSSh-95 Sfera-S (Sphere-S)
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\SFERAHelmet.png");
            }
            else if (headwear == 16) // MSA ACH TC-2001 MICH Series Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\MICH-ach-TC-2001.png");
            }
            else if (headwear == 17) // MSA ACH TC-2002 MICH Series Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\MICH-ach-TC-2002.png");
            }
            else if (headwear == 18) // MSA Gallet TC 800 High Cut combat helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\MSA_TC_800.png");
            }
            else if (headwear == 19) // Highcom Striker ACHHC IIIA helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\ACHHC.gif"); // GIF?
            }
            else if (headwear == 20) // ZSh-1-2M helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\ZSH-1-2M.gif"); // GIF?
            }
            else if (headwear == 21) // Highcom Striker ULACH IIIA helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\ULACH.gif"); // GIF?
            }
            else if (headwear == 22) // Diamond Age Bastion Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Bastion.png");
            }
            else if (headwear == 23) // Ops-Core Fast MT SUPER HIGH CUT Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\FASTMT.gif"); // GIF?
            }
            else if (headwear == 24) // Crye Precision Airframe Tan
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Crye_Precision_Airframe.png");
            }
            else if (headwear == 25) // Team Wendy EXFIL Ballistic Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Team_Wendy_EXFIL.gif"); // GIF?
            }
            else if (headwear == 26) // Galvion Caiman Ballistic Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Caiman.png");
            }
            else if (headwear == 27) // BNTI LSHZ-2DTM Helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\LZHZ-2DTM.png");
            }
            else if (headwear == 28) // Maska 1Sch helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Maska_1Sch.gif"); // GIF?
            }
            else if (headwear == 29) // Altyn helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Altyn.png");
            }
            else if (headwear == 30) // Rys-T helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Ryst.png");
            }
            else if (headwear == 31) // Vulkan-5 (LShZ-5) heavy helmet
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Vulkan-5_(LShZ-5).png");
            }
            // Armored helmets END

            // Vanity START
            else if (headwear == 32) // Kinda cowboy hat
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Cow_boy_hat.png");
            }
            else if (headwear == 33) // Ushanka ear-flap cap
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Ushanka.png");
            }
            else if (headwear == 34) // Miltec panama hat
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Panama.png");
            }
            else if (headwear == 35) // Door Kicker Boonie hat
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Door_kicker.png");
            }
            else if (headwear == 36) // Beanie
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Knitcap-beanie.png");
            }
            else if (headwear == 37) // Kotton beanie
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Kotton_Beanie.png");
            }
            else if (headwear == 38) // Army cap
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Army_cap.png");
            }
            else if (headwear == 39) // Baseball cap
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Baseball_cap.png");
            }
            else if (headwear == 40) // Ded Moroz hat
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\DedMorozHat.png");
            }
            else if (headwear == 41) // Santa's hat
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\SantasHat.png");
            }
            else if (headwear == 42) // Police cap
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Police.png");
            }
            else if (headwear == 43) // Tactical fleece hat
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Fleec.png");
            }
            else if (headwear == 44) // UX PRO Beanie
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Uxpro.png");
            }
            else if (headwear == 45) // USEC baseball cap
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\USECCap.png");
            }
            else if (headwear == 46) // BEAR baseball cap
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\BEARCap.png");
            }
            else if (headwear == 47) // USEC baseball cap black
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Black_USEC_Cap.png");
            }
            else if (headwear == 48) // BEAR baseball cap black
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Black_BEAR_Cap.png");
            }
            else if (headwear == 49) // EmerCom cap
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Emercom.png");
            }
            else if (headwear == 50) // Pompon hat
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Pompon_hat.png");
            }
            else if (headwear == 51) // Bandana
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Bandana.png");
            }
            else if (headwear == 52) // Ski hat with holes for eyes
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Shmaska.png");
            }
            else if (headwear == 53) // Olive beret
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Oliveberet.png");
            }
            else if (headwear == 54) // Black beret
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Blackberet.png");
            }
            else if (headwear == 55) // Blue beret
            {
                headwearImage = Image.FromFile(@"C:\Users\jk95\source\repos\SlotEFT\SlotEFT\Images\Headwear\Blueberet.png");
            }
            // Vanity END
            else headwearImage = null;
            return headwearImage;
        }
    }
}
