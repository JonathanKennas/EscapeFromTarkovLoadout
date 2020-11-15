using EscapeFromTarkovLoadout.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTarkovLoadout
{
    public class Weapons
    {
        // 83 weapons in patch 0.12.8.97.67 (16 guns)
        //https://escapefromtarkov.gamepedia.com/Weapons

        int weaponNumber; // Local varibale for storing the random generaten weapon number

        // Generates random number between 1-83, there are 83 bifrent weapons
        public int RandomWeapon()
        {
            Random rnd = new Random();
            int weapon = rnd.Next(1, 84); // Uses last number, therefore it's 84
            return weapon;
        }

        // Calling RandomWeapon and saved the number in local varibale in usage for image
        public void GetRandomWeapon()
        {
            weaponNumber = RandomWeapon();
        }

        // Getting the random number from local variable weaponNumber and setting a image for it
        public Image GetWeaponImage()
        {
            Image weaponImage;
            int weapon;
            weapon = weaponNumber;

            // Assault rifles START
            if (weapon == 1) // ADAR 2-15
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 2) // AK-101
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 3) // AK-102
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 4) // AK-103
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 5) // AK-104
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 6) // AK-105
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 7) // AK-74
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 8) // AK-74M
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 9) // AK-74N
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 10) // AKM
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 11) // AKMN
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 12) // AKMS
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 13) // AKMSN
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 14) // AKS-74
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 15) // AKS-74N
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 16) // AKS-74U
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 17) // AKS-74UB
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 18) // AKS-74UN
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 19) // ASh-12
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 20) // AS VAL
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 21) // DT MDR 5.56x45
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 22) // DT MDR .308
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 23) // HK 416A5
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 24) // Kel-Tec RFB
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 25) // M4A1
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 26) // SA-58
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 27) // TX-15 DML
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 28) // Vepr AKM/VPO-209
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 29) // Vepr KM/VPO-136
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // Assault rifles END

            // Assault carbines START
            else if (weapon == 30) // OP-SKS
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 31) // SKS
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 32) // Vepr Hunter/VPO-101
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // Assault carbines END

            // Light machine guns START
            else if (weapon == 33) // RPK-16
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // Light machine guns END

            // Submachine guns START
            else if (weapon == 34) // MP5
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 35) // MP5K-N
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 36) // MP7A1
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 37) // MP7A2
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 38) // MP9
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 39) // MP9-N
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 40) // MPX
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 41) // P90
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 42) // PP-19-01 Vityaz-SN
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 43) // PP-9 Klin
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 44) // PP-91 Kedr
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 45) // PP-91-01 Kedr-B
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 46) // PPSH-41
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 47) // Saiga-9
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // Submachine guns END

            // Shotguns START
            else if (weapon == 48) // 590A1
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 49) // M870
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 50) // MP-133
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 51) // MP-153
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 52) // Saiga-12
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 53) // TOZ-106
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 54) // KS-23M
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // Shotguns END

            // DMR START
            else if (weapon == 55) // M1A
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 56) // RSASS
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 57) // SR-25
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 58) // SVDS
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 59) // VSS Vintorez
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // DMR END

            // Sniper rifles START
            else if (weapon == 60) // DVL-10
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 61) // M700
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 62) // Mosin
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 63) // Mosin Inf.
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 64) // SV-98
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 65) // T-5000
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 66) // VPO-215
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // Sniper rifles END

            // Grenade launchers START
            else if (weapon == 67) // FN GL40
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // Grenade launchers END

            // Pistols START
            else if (weapon == 68) // APB
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 69) // APS
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 70) // FN 5-7
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 71) // GLOCK17
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 72) // GLOCK18C
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 73) // M1911A1
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 74) // M45A1
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 75) // M9A3
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 76) // MP-443 Grach
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 77) // P226R
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 78) // PB
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 79) // PM (t)
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 80) // PM
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 81) // SR-1MP Gyurza
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 82) // TT
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            else if (weapon == 83) // TT (gold)
            {
                weaponImage = Resources.EscapeFromTarkovBackgroundCharacter;
            }
            // Pistols END
            else weaponImage = null;
            return weaponImage;
        }
    }
}
