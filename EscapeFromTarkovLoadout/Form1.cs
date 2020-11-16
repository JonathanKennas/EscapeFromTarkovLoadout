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
        Information info = new Information();
        Maps maps = new Maps();
        Weapons weapons = new Weapons();
        Armor armor = new Armor();
        Rigs rigs = new Rigs();
        Headwear headwear = new Headwear();
        Backpacks backpacks = new Backpacks();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateLoadout_Click(object sender, EventArgs e)
        {
            try
            {
                // Getting weapon
                //weapons.GetRandomWeapon();
                //GetWeaponType();

                // Getting headwear
                //headwear.GetRandomHeadwear();
                // Add image

                // Getting rig
                rigs.GetRandomRig();
                pBoxRig.BackgroundImage = rigs.GetRigImage();

                // Getting the generated rig-number and passes it to armor for control
                //armor.GetRigNumber(rigs.rigNumber);

                // Getting armor
                //armor.GetRandomArmor();
                // Add image

                // Getting backpack
                //backpacks.GetRandomBackpack();
                // Add image

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
                // Information about this application shown in a messagebox when clicking at the "info" picture
                MessageBox.Show(info.GetTextForInfo(), info.GetTitleForInfo());
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
            if (type > 67) // Control if the weapon is a pistol (over 67)
            {
                pBoxWeapon_Pistol.BackgroundImage = weapons.GetWeaponImage();
            }
            else pBoxWeapon.BackgroundImage = weapons.GetWeaponImage();
        }
    }
}
