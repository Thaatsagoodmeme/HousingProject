namespace HousingProject
{
    partial class Calendar_Form
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTestGarbage = new System.Windows.Forms.Button();
            this.btnTestCleaning = new System.Windows.Forms.Button();
            this.btnTestParty = new System.Windows.Forms.Button();
            this.Garbage = new System.Windows.Forms.Label();
            this.lbGarbage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCleaning = new System.Windows.Forms.ListBox();
            this.lbPartys = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.Location = new System.Drawing.Point(67, 110);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2020, 6, 15, 0, 0, 0, 0), new System.DateTime(2020, 6, 21, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tbDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cbEvent);
            this.groupBox1.Controls.Add(this.btnSetDate);
            this.groupBox1.Location = new System.Drawing.Point(381, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 323);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.White;
            this.tbDate.Location = new System.Drawing.Point(20, 97);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(234, 20);
            this.tbDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.btnAdd.Location = new System.Drawing.Point(20, 246);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(234, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(20, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cbEvent
            // 
            this.cbEvent.BackColor = System.Drawing.Color.White;
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(20, 204);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(234, 21);
            this.cbEvent.TabIndex = 4;
            // 
            // btnSetDate
            // 
            this.btnSetDate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSetDate.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.btnSetDate.Location = new System.Drawing.Point(20, 42);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(234, 49);
            this.btnSetDate.TabIndex = 14;
            this.btnSetDate.Text = "Set date";
            this.btnSetDate.UseVisualStyleBackColor = false;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnDesc);
            this.groupBox2.Location = new System.Drawing.Point(732, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 134);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More ";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemove.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.btnRemove.Location = new System.Drawing.Point(22, 78);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(271, 43);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Done/Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDesc.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.btnDesc.Location = new System.Drawing.Point(22, 29);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(271, 43);
            this.btnDesc.TabIndex = 16;
            this.btnDesc.Text = "Description";
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnTestGarbage);
            this.groupBox3.Controls.Add(this.btnTestCleaning);
            this.groupBox3.Controls.Add(this.btnTestParty);
            this.groupBox3.Location = new System.Drawing.Point(732, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 183);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test";
            // 
            // btnTestGarbage
            // 
            this.btnTestGarbage.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTestGarbage.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.btnTestGarbage.Location = new System.Drawing.Point(6, 29);
            this.btnTestGarbage.Name = "btnTestGarbage";
            this.btnTestGarbage.Size = new System.Drawing.Size(315, 41);
            this.btnTestGarbage.TabIndex = 11;
            this.btnTestGarbage.Text = "Garbage";
            this.btnTestGarbage.UseVisualStyleBackColor = false;
            this.btnTestGarbage.Click += new System.EventHandler(this.btnTestGarbage_Click);
            // 
            // btnTestCleaning
            // 
            this.btnTestCleaning.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTestCleaning.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.btnTestCleaning.Location = new System.Drawing.Point(6, 76);
            this.btnTestCleaning.Name = "btnTestCleaning";
            this.btnTestCleaning.Size = new System.Drawing.Size(315, 42);
            this.btnTestCleaning.TabIndex = 13;
            this.btnTestCleaning.Text = "Cleaning";
            this.btnTestCleaning.UseVisualStyleBackColor = false;
            this.btnTestCleaning.Click += new System.EventHandler(this.btnTestCleaning_Click);
            // 
            // btnTestParty
            // 
            this.btnTestParty.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTestParty.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.btnTestParty.Location = new System.Drawing.Point(6, 124);
            this.btnTestParty.Name = "btnTestParty";
            this.btnTestParty.Size = new System.Drawing.Size(315, 42);
            this.btnTestParty.TabIndex = 12;
            this.btnTestParty.Text = "Partys";
            this.btnTestParty.UseVisualStyleBackColor = false;
            this.btnTestParty.Click += new System.EventHandler(this.btnTestParty_Click);
            // 
            // Garbage
            // 
            this.Garbage.AutoSize = true;
            this.Garbage.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Garbage.Location = new System.Drawing.Point(29, 393);
            this.Garbage.Name = "Garbage";
            this.Garbage.Size = new System.Drawing.Size(70, 20);
            this.Garbage.TabIndex = 14;
            this.Garbage.Text = "Garbage";
            // 
            // lbGarbage
            // 
            this.lbGarbage.BackColor = System.Drawing.Color.White;
            this.lbGarbage.FormattingEnabled = true;
            this.lbGarbage.Location = new System.Drawing.Point(27, 422);
            this.lbGarbage.Name = "lbGarbage";
            this.lbGarbage.Size = new System.Drawing.Size(327, 251);
            this.lbGarbage.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cleaning";
            // 
            // lbCleaning
            // 
            this.lbCleaning.BackColor = System.Drawing.Color.White;
            this.lbCleaning.FormattingEnabled = true;
            this.lbCleaning.Location = new System.Drawing.Point(381, 422);
            this.lbCleaning.Name = "lbCleaning";
            this.lbCleaning.Size = new System.Drawing.Size(327, 251);
            this.lbCleaning.TabIndex = 24;
            // 
            // lbPartys
            // 
            this.lbPartys.BackColor = System.Drawing.Color.White;
            this.lbPartys.FormattingEnabled = true;
            this.lbPartys.Location = new System.Drawing.Point(733, 422);
            this.lbPartys.Name = "lbPartys";
            this.lbPartys.Size = new System.Drawing.Size(327, 251);
            this.lbPartys.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Partys";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Sitka Text", 14.25F);
            this.btnBack.Location = new System.Drawing.Point(1, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 74);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Calendar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1083, 688);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPartys);
            this.Controls.Add(this.lbCleaning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGarbage);
            this.Controls.Add(this.Garbage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Calendar_Form";
            this.Text = "Calendar_Form";
            this.Load += new System.EventHandler(this.Calendar_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTestGarbage;
        private System.Windows.Forms.Button btnTestCleaning;
        private System.Windows.Forms.Button btnTestParty;
        private System.Windows.Forms.Label Garbage;
        private System.Windows.Forms.ListBox lbGarbage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbCleaning;
        private System.Windows.Forms.ListBox lbPartys;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}