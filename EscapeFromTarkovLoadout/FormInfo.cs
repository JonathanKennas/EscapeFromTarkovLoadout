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

            // Creating an event for entering and leaving the pictureboxes with the mouse
            this.pBoxExit.MouseEnter += new System.EventHandler(this.pBoxExit_MouseEnter);
            this.pBoxExit.MouseLeave += new System.EventHandler(this.pBoxExit_MouseLeave);
        }
        private void pBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Changes the color of the picturebox Exit when entering it to red
        private void pBoxExit_MouseEnter(object sender, EventArgs e)
        {
            // #CA0A0A is the color from "Get Ready!" Logo
            this.pBoxExit.BackColor = ColorTranslator.FromHtml("#CA0A0A");
        }

        // Changes the color of the picturebox Exit when leaving it back to transparent
        private void pBoxExit_MouseLeave(object sender, EventArgs e)
        {
            this.pBoxExit.BackColor = Color.Transparent;
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


        // Allows the form to be moved when FormBorderStyle = none
        // Link: https://stackoverflow.com/questions/1241812/how-to-move-a-windows-form-when-its-formborderstyle-property-is-set-to-none
        protected override void WndProc(ref Message m)
        {
            /*
            Constants in Windows API
            0x84 = WM_NCHITTEST - Mouse Capture Test
            0x1 = HTCLIENT - Application Client Area
            0x2 = HTCAPTION - Application Title Bar

            This function intercepts all the commands sent to the application. 
            It checks to see of the message is a mouse click in the application. 
            It passes the action to the base action by default. It reassigns 
            the action to the title bar if it occured in the client area
            to allow the drag and move behavior.
            */
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
    }
}
