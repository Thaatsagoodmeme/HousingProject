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
            this.compBt = new System.Windows.Forms.Button();
            this.callendarBt = new System.Windows.Forms.Button();
            this.exitBt = new System.Windows.Forms.Button();
            this.logoBx = new System.Windows.Forms.GroupBox();
            this.contactBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shoppingBt
            // 
            this.shoppingBt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.shoppingBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.shoppingBt.Location = new System.Drawing.Point(67, 42);
            this.shoppingBt.Name = "shoppingBt";
            this.shoppingBt.Size = new System.Drawing.Size(160, 46);
            this.shoppingBt.TabIndex = 7;
            this.shoppingBt.Text = "Shopping";
            this.shoppingBt.UseVisualStyleBackColor = false;
            this.shoppingBt.Click += new System.EventHandler(this.shoppingBt_Click);
            // 
            // compBt
            // 
            this.compBt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.compBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.compBt.Location = new System.Drawing.Point(67, 149);
            this.compBt.Name = "compBt";
            this.compBt.Size = new System.Drawing.Size(160, 128);
            this.compBt.TabIndex = 9;
            this.compBt.Text = "Complaiments/\r\nRules/\r\nAgreements/\r\nSuggestions/";
            this.compBt.UseVisualStyleBackColor = false;
            this.compBt.Click += new System.EventHandler(this.compBt_Click);
            // 
            // callendarBt
            // 
            this.callendarBt.BackColor = System.Drawing.Color.LightSeaGreen;
            this.callendarBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.callendarBt.Location = new System.Drawing.Point(67, 336);
            this.callendarBt.Name = "callendarBt";
            this.callendarBt.Size = new System.Drawing.Size(160, 46);
            this.callendarBt.TabIndex = 10;
            this.callendarBt.Text = "Calander";
            this.callendarBt.UseVisualStyleBackColor = false;
            this.callendarBt.Click += new System.EventHandler(this.callendarBt_Click);
            // 
            // exitBt
            // 
            this.exitBt.BackColor = System.Drawing.Color.Transparent;
            this.exitBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.exitBt.Location = new System.Drawing.Point(562, 336);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(135, 46);
            this.exitBt.TabIndex = 12;
            this.exitBt.Text = "Exit";
            this.exitBt.UseVisualStyleBackColor = false;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
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
            // contactBt
            // 
            this.contactBt.BackColor = System.Drawing.Color.Transparent;
            this.contactBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.contactBt.Location = new System.Drawing.Point(562, 272);
            this.contactBt.Name = "contactBt";
            this.contactBt.Size = new System.Drawing.Size(135, 46);
            this.contactBt.TabIndex = 13;
            this.contactBt.Text = "Contact page";
            this.contactBt.UseVisualStyleBackColor = false;
            this.contactBt.Click += new System.EventHandler(this.contactBt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contactBt);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.logoBx);
            this.Controls.Add(this.callendarBt);
            this.Controls.Add(this.compBt);
            this.Controls.Add(this.shoppingBt);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shoppingBt;
        private System.Windows.Forms.Button compBt;
        private System.Windows.Forms.Button callendarBt;
        private System.Windows.Forms.GroupBox logoBx;
        private System.Windows.Forms.Button exitBt;
        private System.Windows.Forms.Button contactBt;
    }
}