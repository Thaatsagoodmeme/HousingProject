namespace HousingProject
{
    partial class Schedule
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
            this.exitBt = new System.Windows.Forms.Button();
            this.logoBx = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // exitBt
            // 
            this.exitBt.BackColor = System.Drawing.Color.Transparent;
            this.exitBt.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.exitBt.Location = new System.Drawing.Point(653, 392);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(135, 46);
            this.exitBt.TabIndex = 13;
            this.exitBt.Text = "Exit";
            this.exitBt.UseVisualStyleBackColor = false;
            // 
            // logoBx
            // 
            this.logoBx.BackgroundImage = global::HousingProject.Properties.Resources.Logo_small;
            this.logoBx.Location = new System.Drawing.Point(545, 60);
            this.logoBx.Name = "logoBx";
            this.logoBx.Size = new System.Drawing.Size(167, 111);
            this.logoBx.TabIndex = 14;
            this.logoBx.TabStop = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoBx);
            this.Controls.Add(this.exitBt);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBt;
        private System.Windows.Forms.GroupBox logoBx;
    }
}