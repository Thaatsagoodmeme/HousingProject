namespace HousingStudentProject
{
    partial class Login
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
            this.loginBt = new System.Windows.Forms.Button();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.passTxtBx = new System.Windows.Forms.TextBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.passLb = new System.Windows.Forms.Label();
            this.housingLb = new System.Windows.Forms.Label();
            this.contentBx = new System.Windows.Forms.GroupBox();
            this.exitBt = new System.Windows.Forms.Button();
            this.logoBx = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.admTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.houseCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passRegTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameRegTxtBx = new System.Windows.Forms.TextBox();
            this.contentBx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBt
            // 
            this.loginBt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loginBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.loginBt.Location = new System.Drawing.Point(108, 261);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(135, 46);
            this.loginBt.TabIndex = 0;
            this.loginBt.Text = "LogIn";
            this.loginBt.UseVisualStyleBackColor = false;
            this.loginBt.Click += new System.EventHandler(this.LoginBt_Click);
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(180, 116);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(177, 20);
            this.nameTxtBx.TabIndex = 1;
            // 
            // passTxtBx
            // 
            this.passTxtBx.Location = new System.Drawing.Point(180, 184);
            this.passTxtBx.Name = "passTxtBx";
            this.passTxtBx.Size = new System.Drawing.Size(177, 20);
            this.passTxtBx.TabIndex = 2;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.BackColor = System.Drawing.Color.LightSeaGreen;
            this.nameLb.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.Location = new System.Drawing.Point(38, 116);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(64, 28);
            this.nameLb.TabIndex = 3;
            this.nameLb.Text = "Name";
            // 
            // passLb
            // 
            this.passLb.AutoSize = true;
            this.passLb.BackColor = System.Drawing.Color.LightSeaGreen;
            this.passLb.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.passLb.Location = new System.Drawing.Point(38, 176);
            this.passLb.Name = "passLb";
            this.passLb.Size = new System.Drawing.Size(98, 28);
            this.passLb.TabIndex = 4;
            this.passLb.Text = "Password";
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
            // contentBx
            // 
            this.contentBx.BackColor = System.Drawing.Color.White;
            this.contentBx.Controls.Add(this.loginBt);
            this.contentBx.Controls.Add(this.housingLb);
            this.contentBx.Controls.Add(this.passTxtBx);
            this.contentBx.Controls.Add(this.nameLb);
            this.contentBx.Controls.Add(this.passLb);
            this.contentBx.Controls.Add(this.nameTxtBx);
            this.contentBx.Location = new System.Drawing.Point(46, 23);
            this.contentBx.Name = "contentBx";
            this.contentBx.Size = new System.Drawing.Size(388, 326);
            this.contentBx.TabIndex = 7;
            this.contentBx.TabStop = false;
            // 
            // exitBt
            // 
            this.exitBt.BackColor = System.Drawing.Color.Transparent;
            this.exitBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.exitBt.Location = new System.Drawing.Point(46, 465);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(135, 46);
            this.exitBt.TabIndex = 7;
            this.exitBt.Text = "Exit";
            this.exitBt.UseVisualStyleBackColor = false;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // logoBx
            // 
            this.logoBx.BackgroundImage = global::HousingProject.Properties.Resources.Logo_small;
            this.logoBx.Location = new System.Drawing.Point(267, 400);
            this.logoBx.Name = "logoBx";
            this.logoBx.Size = new System.Drawing.Size(167, 111);
            this.logoBx.TabIndex = 6;
            this.logoBx.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.admTxtBx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.houseCbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.registerBt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passRegTxtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nameRegTxtBx);
            this.groupBox1.Location = new System.Drawing.Point(490, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 488);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign Up";
            // 
            // passRegTxtBx
            // 
            this.passRegTxtBx.Location = new System.Drawing.Point(180, 184);
            this.passRegTxtBx.Name = "passRegTxtBx";
            this.passRegTxtBx.Size = new System.Drawing.Size(177, 20);
            this.passRegTxtBx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.label5.Location = new System.Drawing.Point(35, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // nameRegTxtBx
            // 
            this.nameRegTxtBx.Location = new System.Drawing.Point(180, 116);
            this.nameRegTxtBx.Name = "nameRegTxtBx";
            this.nameRegTxtBx.Size = new System.Drawing.Size(177, 20);
            this.nameRegTxtBx.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(924, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoBx);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.contentBx);
            this.Name = "Login";
            this.Text = "Login";
            this.contentBx.ResumeLayout(false);
            this.contentBx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBt;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox passTxtBx;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label passLb;
        private System.Windows.Forms.Label housingLb;
        private System.Windows.Forms.GroupBox logoBx;
        private System.Windows.Forms.GroupBox contentBx;
        private System.Windows.Forms.Button exitBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox admTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox houseCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passRegTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameRegTxtBx;
    }
}

