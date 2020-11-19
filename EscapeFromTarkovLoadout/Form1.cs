using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeFromTarkovLoadout
{
    public partial class Form1 : Form
    {
        Weapons weapons = new Weapons();
        Armor armor = new Armor();
        Headwear headwear = new Headwear();
        Rigs rigs = new Rigs();
        Backpacks backpacks = new Backpacks();
        Maps maps = new Maps();
        FormInfo forminfo = new FormInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void pBoxGetReady_Click(object sender, EventArgs e)
        {
            try
            {
                // Getting weapon
                weapons.GetRandomWeapon();
                GetWeaponType();

                // Getting headwear
                headwear.GetRandomHeadwear();
                pBoxHeadwear.BackgroundImage = headwear.GetHeadwearImage();

                // Getting rig
                rigs.GetRandomRig();
                pBoxRig.BackgroundImage = rigs.GetRigImage();

                // Getting the generated rig-number and passes it to armor for control
                armor.GetRigNumber(rigs.rigNumber);

                // Getting armor
                armor.GetRandomArmor();
                pBoxArmor.BackgroundImage = armor.GetArmorImage();

                // Getting backpack
                backpacks.GetRandomBackpack();
                pBoxBackpack.BackgroundImage = backpacks.GetBackpackImage();

                // Getting map
                maps.GetRandomMap();
                pBoxMap.BackgroundImage = maps.GetMapImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      

        private void pBoxInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Information about this application shown in a new form (FormInfo) when clicking at the "info" picture
                forminfo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetWeaponType()
        {
            int type;
            type = weapons.weaponNumber;
            if (type > 67) // Control if the weapon is a pistol (weaponNumber over 67)
            {
                pBoxWeapon_Pistol.BackgroundImage = weapons.GetWeaponImage();
                pBoxWeapon.BackgroundImage = null;
            }
            else
            {
                pBoxWeapon.BackgroundImage = weapons.GetWeaponImage();
                pBoxWeapon_Pistol.BackgroundImage = null;
            }
        }

    }
}
