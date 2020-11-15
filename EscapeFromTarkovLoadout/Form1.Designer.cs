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
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInfo)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 707);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Created by lenny952";
            // 
            // pBoxInfo
            // 
            this.pBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pBoxInfo.BackgroundImage = global::EscapeFromTarkovLoadout.Properties.Resources.Info_logo;
            this.pBoxInfo.Location = new System.Drawing.Point(1143, 3);
            this.pBoxInfo.Name = "pBoxInfo";
            this.pBoxInfo.Size = new System.Drawing.Size(25, 25);
            this.pBoxInfo.TabIndex = 4;
            this.pBoxInfo.TabStop = false;
            this.pBoxInfo.Click += new System.EventHandler(this.pBoxInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::EscapeFromTarkovLoadout.Properties.Resources.EscapeFromTarkovBackgroundCharacter;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 729);
            this.Controls.Add(this.pBoxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBoxMap);
            this.Controls.Add(this.btnCreateLoadout);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Escape From Tarkov Loadout";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateLoadout;
        private System.Windows.Forms.PictureBox pBoxMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBoxInfo;
    }
}

