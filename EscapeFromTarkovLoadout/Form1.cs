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
                weapons.GetRandomWeapon();
                // Add image

                // Getting headwear
                headwear.GetRandomHeadwear();
                // Add image

                // Getting rig
                rigs.GetRandomRig();
                // Add image

                // Getting the generated rig-number and passes it to armor for control
                armor.GetRigNumber(rigs.rigNumber);

                // Getting armor
                armor.GetRandomArmor();
                // Add image

                // Getting backpack
                backpacks.GetRandomBackpack();
                // Add image

                // Getting map
                maps.GetRandomMap();
                // Add image
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
