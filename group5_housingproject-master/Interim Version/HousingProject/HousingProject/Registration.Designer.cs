namespace HousingProject
{
    partial class Registration
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
            this.contentBx = new System.Windows.Forms.GroupBox();
            this.admTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.houseCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerBt = new System.Windows.Forms.Button();
            this.housingLb = new System.Windows.Forms.Label();
            this.passTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.contentBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentBx
            // 
            this.contentBx.BackColor = System.Drawing.Color.White;
            this.contentBx.Controls.Add(this.admTxtBx);
            this.contentBx.Controls.Add(this.label4);
            this.contentBx.Controls.Add(this.houseCbx);
            this.contentBx.Controls.Add(this.label3);
            this.contentBx.Controls.Add(this.registerBt);
            this.contentBx.Controls.Add(this.housingLb);
            this.contentBx.Controls.Add(this.passTxtBx);
            this.contentBx.Controls.Add(this.label1);
            this.contentBx.Controls.Add(this.label2);
            this.contentBx.Controls.Add(this.nameTxtBx);
            this.contentBx.Location = new System.Drawing.Point(12, 12);
            this.contentBx.Name = "contentBx";
            this.contentBx.Size = new System.Drawing.Size(388, 457);
            this.contentBx.TabIndex = 8;
            this.contentBx.TabStop = false;
            // 
            // admTxtBx
            // 
            this.admTxtBx.Location = new System.Drawing.Point(180, 290);
            this.admTxtBx.Name = "admTxtBx";
            this.admTxtBx.Size = new System.Drawing.Size(177, 20);
            this.admTxtBx.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.label4.Location = new System.Drawing.Point(35, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Admin key";
            // 
            // houseCbx
            // 
            this.houseCbx.FormattingEnabled = true;
            this.houseCbx.Items.AddRange(new object[] {
            "house first",
            "house second",
            "house third"});
            this.houseCbx.Location = new System.Drawing.Point(180, 238);
            this.houseCbx.Name = "houseCbx";
            this.houseCbx.Size = new System.Drawing.Size(177, 21);
            this.houseCbx.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.label3.Location = new System.Drawing.Point(35, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "House";
            // 
            // registerBt
            // 
            this.registerBt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.registerBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.registerBt.Location = new System.Drawing.Point(109, 394);
            this.registerBt.Name = "registerBt";
            this.registerBt.Size = new System.Drawing.Size(135, 46);
            this.registerBt.TabIndex = 6;
            this.registerBt.Text = "Register";
            this.registerBt.UseVisualStyleBackColor = false;
            this.registerBt.Click += new System.EventHandler(this.registerBt_Click);
            // 
            // housingLb
            // 
            this.housingLb.AutoSize = true;
            this.housingLb.BackColor = System.Drawing.Color.LightSeaGreen;
            this.housingLb.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housingLb.Location = new System.Drawing.Point(34, 16);
            this.housingLb.Name = "housingLb";
            this.housingLb.Size = new System.Drawing.Size(237, 35);
            this.housingLb.TabIndex = 5;
            this.housingLb.Text = "Student Housing Bv";
            // 
            // passTxtBx
            // 
            this.passTxtBx.Location = new System.Drawing.Point(180, 184);
            this.passTxtBx.Name = "passTxtBx";
            this.passTxtBx.Size = new System.Drawing.Size(177, 20);
            this.passTxtBx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.label2.Location = new System.Drawing.Point(35, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(180, 116);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(177, 20);
            this.nameTxtBx.TabIndex = 1;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 481);
            this.Controls.Add(this.contentBx);
            this.Name = "Registration";
            this.Text = "Registration";
            this.contentBx.ResumeLayout(false);
            this.contentBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contentBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerBt;
        private System.Windows.Forms.Label housingLb;
        private System.Windows.Forms.TextBox passTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox houseCbx;
        private System.Windows.Forms.TextBox admTxtBx;
    }
}