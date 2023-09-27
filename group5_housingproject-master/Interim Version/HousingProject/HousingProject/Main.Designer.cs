namespace HousingProject
{
    partial class Main
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
            this.shoppingBt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.logoBx = new System.Windows.Forms.GroupBox();
            this.exitBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shoppingBt
            // 
            this.shoppingBt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.shoppingBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.shoppingBt.Location = new System.Drawing.Point(67, 42);
            this.shoppingBt.Name = "shoppingBt";
            this.shoppingBt.Size = new System.Drawing.Size(135, 46);
            this.shoppingBt.TabIndex = 7;
            this.shoppingBt.Text = "Shopping";
            this.shoppingBt.UseVisualStyleBackColor = false;
            this.shoppingBt.Click += new System.EventHandler(this.shoppingBt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.button1.Location = new System.Drawing.Point(67, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Schedule";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.button2.Location = new System.Drawing.Point(67, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Function3";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.button3.Location = new System.Drawing.Point(67, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 46);
            this.button3.TabIndex = 10;
            this.button3.Text = "Function4";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // logoBx
            // 
            this.logoBx.BackgroundImage = global::HousingProject.Properties.Resources.Logo_small;
            this.logoBx.Location = new System.Drawing.Point(530, 42);
            this.logoBx.Name = "logoBx";
            this.logoBx.Size = new System.Drawing.Size(167, 111);
            this.logoBx.TabIndex = 11;
            this.logoBx.TabStop = false;
            // 
            // exitBt
            // 
            this.exitBt.BackColor = System.Drawing.Color.Transparent;
            this.exitBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.exitBt.Location = new System.Drawing.Point(634, 382);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(135, 46);
            this.exitBt.TabIndex = 12;
            this.exitBt.Text = "Exit";
            this.exitBt.UseVisualStyleBackColor = false;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.logoBx);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shoppingBt);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shoppingBt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox logoBx;
        private System.Windows.Forms.Button exitBt;
    }
}