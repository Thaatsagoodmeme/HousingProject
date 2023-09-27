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
            this.logoBx = new System.Windows.Forms.GroupBox();
            this.contentBx = new System.Windows.Forms.GroupBox();
            this.registerBt = new System.Windows.Forms.Button();
            this.exitBt = new System.Windows.Forms.Button();
            this.contentBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBt
            // 
            this.loginBt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loginBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.loginBt.Location = new System.Drawing.Point(222, 263);
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
            // logoBx
            // 
            this.logoBx.BackgroundImage = global::HousingProject.Properties.Resources.Logo_small;
            this.logoBx.Location = new System.Drawing.Point(557, 45);
            this.logoBx.Name = "logoBx";
            this.logoBx.Size = new System.Drawing.Size(167, 111);
            this.logoBx.TabIndex = 6;
            this.logoBx.TabStop = false;
            // 
            // contentBx
            // 
            this.contentBx.BackColor = System.Drawing.Color.White;
            this.contentBx.Controls.Add(this.registerBt);
            this.contentBx.Controls.Add(this.loginBt);
            this.contentBx.Controls.Add(this.housingLb);
            this.contentBx.Controls.Add(this.passTxtBx);
            this.contentBx.Controls.Add(this.nameLb);
            this.contentBx.Controls.Add(this.passLb);
            this.contentBx.Controls.Add(this.nameTxtBx);
            this.contentBx.Location = new System.Drawing.Point(55, 68);
            this.contentBx.Name = "contentBx";
            this.contentBx.Size = new System.Drawing.Size(388, 326);
            this.contentBx.TabIndex = 7;
            this.contentBx.TabStop = false;
            // 
            // registerBt
            // 
            this.registerBt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.registerBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.registerBt.Location = new System.Drawing.Point(43, 263);
            this.registerBt.Name = "registerBt";
            this.registerBt.Size = new System.Drawing.Size(135, 46);
            this.registerBt.TabIndex = 6;
            this.registerBt.Text = "Register";
            this.registerBt.UseVisualStyleBackColor = false;
            this.registerBt.Click += new System.EventHandler(this.registerBt_Click);
            // 
            // exitBt
            // 
            this.exitBt.BackColor = System.Drawing.Color.Transparent;
            this.exitBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.exitBt.Location = new System.Drawing.Point(632, 371);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(135, 46);
            this.exitBt.TabIndex = 7;
            this.exitBt.Text = "Exit";
            this.exitBt.UseVisualStyleBackColor = false;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.logoBx);
            this.Controls.Add(this.contentBx);
            this.Name = "Login";
            this.Text = "Login";
            this.contentBx.ResumeLayout(false);
            this.contentBx.PerformLayout();
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
        private System.Windows.Forms.Button registerBt;
        private System.Windows.Forms.Button exitBt;
    }
}

