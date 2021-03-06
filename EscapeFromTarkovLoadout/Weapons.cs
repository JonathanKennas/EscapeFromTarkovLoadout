﻿using EscapeFromTarkovLoadout.Properties;
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
        // 1 added with value null

        // Needs to be public for usage from From1, control if the weapon is a pistol or not
        public int weaponNumber; // Local varibale for storing the random generaten weapon number

        // Generates random number between 1-84, there are 83 bifrent weapons and 1 for null
        public int RandomWeapon()
        {
            Random rnd = new Random();
            int weapon = rnd.Next(1, 85); // Uses last number, therefore it's 85
            return weapon;
        }

        // Calling RandomWeapon and saved the number in local varibale in usage for image
        public void GetRandomWeapon()
        {
            weaponNumber = 0;
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
                weaponImage = Resources.Weapon_AssaultRifle_ADAR_2_15;
            }
            else if (weapon == 2) // AK-101
            {
                weaponImage = Resources.Weapon_AssaultRifle_AK_101;
            }
            else if (weapon == 3) // AK-102
            {
                weaponImage = Resources.Weapon_AssaultRifle_AK_102;
            }
            else if (weapon == 4) // AK-103
            {
                weaponImage = Resources.Weapon_AssaultRifle_AK_103;
            }
            else if (weapon == 5) // AK-104
            {
                weaponImage = Resources.Weapon_AssaultRifle_AK_104;
            }
            else if (weapon == 6) // AK-105
            {
                weaponImage = Resources.Weapon_AssaultRifle_AK_105;
            }
            else if (weapon == 7) // AK-74
            {
                weaponImage = Resources.Weapon_AssaultRifle_AK_74;
            }
            else if (weapon == 8) // AK-74M
            {
                weaponImage = Resources.Weapon_AssaultRifle_AK_74M;
            }
            else if (weapon == 9) // AK-74N
            {
                weaponImage = Resources.Weapon_AssaultRifle_AK_74N;
            }
            else if (weapon == 10) // AKM
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKM;
            }
            else if (weapon == 11) // AKMN
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKMN;
            }
            else if (weapon == 12) // AKMS
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKMS;
            }
            else if (weapon == 13) // AKMSN
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKMSN;
            }
            else if (weapon == 14) // AKS-74
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKS_74;
            }
            else if (weapon == 15) // AKS-74N
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKS_74N;
            }
            else if (weapon == 16) // AKS-74U
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKS_74U;
            }
            else if (weapon == 17) // AKS-74UB
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKS_74UB;
            }
            else if (weapon == 18) // AKS-74UN
            {
                weaponImage = Resources.Weapon_AssaultRifle_AKS_74UN;
            }
            else if (weapon == 19) // ASh-12
            {
                weaponImage = Resources.Weapon_AssaultRifle_ASh_12;
            }
            else if (weapon == 20) // AS VAL
            {
                weaponImage = Resources.Weapon_AssaultRifle_AS_VAL;
            }
            else if (weapon == 21) // DT MDR 5.56x45
            {
                weaponImage = Resources.Weapon_AssaultRifle_DT_MDR_556;
            }
            else if (weapon == 22) // DT MDR .308 (7.62)
            {
                weaponImage = Resources.Weapon_AssaultRifle_DT_MDR_762;
            }
            else if (weapon == 23) // HK 416A5
            {
                weaponImage = Resources.Weapon_AssaultRifle_HK_416A5;
            }
            else if (weapon == 24) // Kel-Tec RFB
            {
                weaponImage = Resources.Weapon_AssaultRifle_Kel_Tec_RFB;
            }
            else if (weapon == 25) // M4A1
            {
                weaponImage = Resources.Weapon_AssaultRifle_M4A1;
            }
            else if (weapon == 26) // SA-58
            {
                weaponImage = Resources.Weapon_AssaultRifle_SA_58;
            }
            else if (weapon == 27) // TX-15 DML
            {
                weaponImage = Resources.Weapon_AssaultRifle_TX_15_DML;
            }
            else if (weapon == 28) // Vepr AKM/VPO-209
            {
                weaponImage = Resources.Weapon_AssaultRifle_Vepr_AKM_VPO_209;
            }
            else if (weapon == 29) // Vepr KM/VPO-136
            {
                weaponImage = Resources.Weapon_AssaultRifle_Vepr_KM_VPO_136;
            }
            // Assault rifles END

            // Assault carbines START
            else if (weapon == 30) // OP-SKS
            {
                weaponImage = Resources.Weapon_AssaultCarbine_OP_SKS;
            }
            else if (weapon == 31) // SKS
            {
                weaponImage = Resources.Weapon_AssaultCarbine_SKS;
            }
            else if (weapon == 32) // Vepr Hunter/VPO-101
            {
                weaponImage = Resources.Weapon_AssaultCarbine_Vepr_Hunter;
            }
            // Assault carbines END

            // Light machine guns START
            else if (weapon == 33) // RPK-16
            {
                weaponImage = Resources.Weapon_LightMachineGun_RPK_16;
            }
            // Light machine guns END

            // Submachine guns START
            else if (weapon == 34) // MP5
            {
                weaponImage = Resources.Weapon_SubMachineGun_MP5;
            }
            else if (weapon == 35) // MP5K-N
            {
                weaponImage = Resources.Weapon_SubMachineGun_MP5K_N;
            }
            else if (weapon == 36) // MP7A1
            {
                weaponImage = Resources.Weapon_SubMachineGun_MP7A1;
            }
            else if (weapon == 37) // MP7A2
            {
                weaponImage = Resources.Weapon_SubMachineGun_MP7A2;
            }
            else if (weapon == 38) // MP9
            {
                weaponImage = Resources.Weapon_SubMachineGun_MP9;
            }
            else if (weapon == 39) // MP9-N
            {
                weaponImage = Resources.Weapon_SubMachineGun_MP9_N;
            }
            else if (weapon == 40) // MPX
            {
                weaponImage = Resources.Weapon_SubMachineGun_MPX;
            }
            else if (weapon == 41) // P90
            {
                weaponImage = Resources.Weapon_SubMachineGun_P90;
            }
            else if (weapon == 42) // PP-19-01 Vityaz-SN
            {
                weaponImage = Resources.Weapon_SubMachineGun_PP_19_01;
            }
            else if (weapon == 43) // PP-9 Klin
            {
                weaponImage = Resources.Weapon_SubMachineGun_PP_9_Klin;
            }
            else if (weapon == 44) // PP-91 Kedr
            {
                weaponImage = Resources.Weapon_SubMachineGun_PP_91_Kedr;
            }
            else if (weapon == 45) // PP-91-01 Kedr-B
            {
                weaponImage = Resources.Weapon_SubMachineGun_PP_91_01_Kedr_B;
            }
            else if (weapon == 46) // PPSH-41
            {
                weaponImage = Resources.Weapon_SubMachineGun_PPSH_41;
            }
            else if (weapon == 47) // Saiga-9
            {
                weaponImage = Resources.Weapon_SubMachineGun_Saiga_9;
            }
            // Submachine guns END

            // Shotguns START
            else if (weapon == 48) // 590A1
            {
                weaponImage = Resources.Weapon_Shotgun_590A1;
            }
            else if (weapon == 49) // M870
            {
                weaponImage = Resources.Weapon_Shotgun_M870;
            }
            else if (weapon == 50) // MP-133
            {
                weaponImage = Resources.Weapon_Shotgun_MP_133;
            }
            else if (weapon == 51) // MP-153
            {
                weaponImage = Resources.Weapon_Shotgun_MP_153;
            }
            else if (weapon == 52) // Saiga-12
            {
                weaponImage = Resources.Weapon_Shotgun_Saiga_12;
            }
            else if (weapon == 53) // TOZ-106
            {
                weaponImage = Resources.Weapon_Shotgun_TOZ_106;
            }
            else if (weapon == 54) // KS-23M
            {
                weaponImage = Resources.Weapon_Shotgun_KS_23M;
            }
            // Shotguns END

            // DMR START
            else if (weapon == 55) // M1A
            {
                weaponImage = Resources.Weapon_DMR_M1A;
            }
            else if (weapon == 56) // RSASS
            {
                weaponImage = Resources.Weapon_DMR_RSASS;
            }
            else if (weapon == 57) // SR-25
            {
                weaponImage = Resources.Weapon_DMR_SR_25;
            }
            else if (weapon == 58) // SVDS
            {
                weaponImage = Resources.Weapon_DMR_SVDS;
            }
            else if (weapon == 59) // VSS Vintorez
            {
                weaponImage = Resources.Weapon_DMR_VSS;
            }
            // DMR END

            // Sniper rifles START
            else if (weapon == 60) // DVL-10
            {
                weaponImage = Resources.Weapon_SniperRifle_DVL_10;
            }
            else if (weapon == 61) // M700
            {
                weaponImage = Resources.Weapon_SniperRifle_M700;
            }
            else if (weapon == 62) // Mosin
            {
                weaponImage = Resources.Weapon_SniperRifle_Mosin;
            }
            else if (weapon == 63) // Mosin Inf.
            {
                weaponImage = Resources.Weapon_SniperRifle_Mosin_inf;
            }
            else if (weapon == 64) // SV-98
            {
                weaponImage = Resources.Weapon_SniperRifle_SV_98;
            }
            else if (weapon == 65) // T-5000
            {
                weaponImage = Resources.Weapon_SniperRifle_T_5000;
            }
            else if (weapon == 66) // VPO-215
            {
                weaponImage = Resources.Weapon_SniperRifle_VOP_215;
            }
            // Sniper rifles END

            // Grenade launchers START
            else if (weapon == 67) // FN GL40
            {
                weaponImage = Resources.Weapon_GranadeLauncher_GL_40;
            }
            // Grenade launchers END

            // Pistols START
            else if (weapon == 68) // APB
            {
                weaponImage = Resources.Weapon_Pistol_APB;
            }
            else if (weapon == 69) // APS
            {
                weaponImage = Resources.Weapon_Pistol_APS;
            }
            else if (weapon == 70) // FN 5-7
            {
                weaponImage = Resources.Weapon_Pistol_FN_5_7;
            }
            else if (weapon == 71) // GLOCK17
            {
                weaponImage = Resources.Weapon_Pistol_Glock_17;
            }
            else if (weapon == 72) // GLOCK18C
            {
                weaponImage = Resources.Weapon_Pistol_Glock_18C;
            }
            else if (weapon == 73) // M1911A1
            {
                weaponImage = Resources.Weapon_Pistol_M1911A1;
            }
            else if (weapon == 74) // M45A1
            {
                weaponImage = Resources.Weapon_Pistol_M45A1;
            }
            else if (weapon == 75) // M9A3
            {
                weaponImage = Resources.Weapon_Pistol_M9A3;
            }
            else if (weapon == 76) // MP-443 Grach
            {
                weaponImage = Resources.Weapon_Pistol_MP_443_Grach;
            }
            else if (weapon == 77) // P226R
            {
                weaponImage = Resources.Weapon_Pistol_P226R;
            }
            else if (weapon == 78) // PB
            {
                weaponImage = Resources.Weapon_Pistol_PB;
            }
            else if (weapon == 79) // PM (t)
            {
                weaponImage = Resources.Weapon_Pistol_PM_t;
            }
            else if (weapon == 80) // PM
            {
                weaponImage = Resources.Weapon_Pistol_PM;
            }
            else if (weapon == 81) // SR-1MP Gyurza
            {
                weaponImage = Resources.Weapon_Pistol_SR_1MP;
            }
            else if (weapon == 82) // TT
            {
                weaponImage = Resources.Weapon_Pistol_TT;
            }
            else if (weapon == 83) // TT (gold)
            {
                weaponImage = Resources.Weapon_Pistol_TT_Glod;
            }
            // Pistols END

            // If the generated number doesn't exist withing i "if" statment, the image sets to null
            else weaponImage = null;
            return weaponImage;
        }
    }
}
