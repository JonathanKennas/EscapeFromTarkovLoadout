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
    public partial class FormInfo : Form
    {
        Information info = new Information();
        public FormInfo()
        {
            InitializeComponent();
            lblInfo.Text = info.GetTextForInfo();

            // Text and link for donation to paypal
            linkLblLinkPayPal.Hide();
            lblPayPal.Hide();
        }

        private void linkLblWeapons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Getting hyperlink with URL from Information.cs
                info.VisitLinkWeapons();
            }
            catch
            {
                MessageBox.Show("The link could not be opend...");
            }
        }

        private void linkLblArmor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Getting hyperlink with URL from Information.cs
                info.VisitLinkArmor();
            }
            catch
            {
                MessageBox.Show("The link could not be opend...");
            }        
        }

        private void linkLblHeadwear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Getting hyperlink with URL from Information.cs
                info.VisitLinkHeadwear();
            }
            catch
            {
                MessageBox.Show("The link could not be opend...");
            }          
        }

        private void linkLblRigs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Getting hyperlink with URL from Information.cs
                info.VisitLinkRigs();
            }
            catch
            {
                MessageBox.Show("The link could not be opend...");
            }            
        }

        private void linkLblBackpacks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Getting hyperlink with URL from Information.cs
                info.VisitLinkBackpacks();
            }
            catch
            {
                MessageBox.Show("The link could not be opend...");
            }          
        }

        private void linkLblMaps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Getting hyperlink with URL from Information.cs
                info.VisitLinkMaps();
            }
            catch
            {
                MessageBox.Show("The link could not be opend...");
            }           
        }

        private void linkLblLinkPayPal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Getting hyperlink with URL from Information.cs
                info.VisitPayPalDonate();
            }
            catch
            {
                MessageBox.Show("The link could not be opend...");
            }
        }
    }
}
