namespace EscapeFromTarkovLoadout
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateLoadout = new System.Windows.Forms.Button();
            this.pBoxMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateLoadout
            // 
            this.btnCreateLoadout.Location = new System.Drawing.Point(436, 553);
            this.btnCreateLoadout.Name = "btnCreateLoadout";
            this.btnCreateLoadout.Size = new System.Drawing.Size(140, 153);
            this.btnCreateLoadout.TabIndex = 1;
            this.btnCreateLoadout.Text = "Create Loadout";
            this.btnCreateLoadout.UseVisualStyleBackColor = true;
            this.btnCreateLoadout.Click += new System.EventHandler(this.btnCreateLoadout_Click);
            // 
            // pBoxMap
            // 
            this.pBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMap.Location = new System.Drawing.Point(653, 461);
            this.pBoxMap.Name = "pBoxMap";
            this.pBoxMap.Size = new System.Drawing.Size(380, 230);
            this.pBoxMap.TabIndex = 2;
            this.pBoxMap.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::EscapeFromTarkovLoadout.Properties.Resources.EscapeFromTarkovBackgroundCharacter;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 729);
            this.Controls.Add(this.pBoxMap);
            this.Controls.Add(this.btnCreateLoadout);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Escape From Tarkov Loadout";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateLoadout;
        private System.Windows.Forms.PictureBox pBoxMap;
    }
}

