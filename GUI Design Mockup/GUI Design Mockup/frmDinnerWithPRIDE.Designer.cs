namespace GUI_Design_Mockup
{
    partial class frmDinnerWithPRIDE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupNoBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QuarterBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dinner with PRIDE Nominations and Awards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selection Criteria:";
            // 
            // GroupNoBox
            // 
            this.GroupNoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupNoBox.FormattingEnabled = true;
            this.GroupNoBox.Location = new System.Drawing.Point(228, 50);
            this.GroupNoBox.Name = "GroupNoBox";
            this.GroupNoBox.Size = new System.Drawing.Size(121, 21);
            this.GroupNoBox.TabIndex = 10;
            this.GroupNoBox.SelectedValueChanged += new System.EventHandler(this.YearBox_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(15, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 61);
            this.panel1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dinner with PRIDE Award Winners";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Email Dinner with PRIDE Eligibility Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dinner with PRIDE Eligibility Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QuarterBox
            // 
            this.QuarterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuarterBox.FormattingEnabled = true;
            this.QuarterBox.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th"});
            this.QuarterBox.Location = new System.Drawing.Point(228, 77);
            this.QuarterBox.Name = "QuarterBox";
            this.QuarterBox.Size = new System.Drawing.Size(121, 21);
            this.QuarterBox.TabIndex = 13;
            this.QuarterBox.SelectedValueChanged += new System.EventHandler(this.YearBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Quarter:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YearBox
            // 
            this.YearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Location = new System.Drawing.Point(228, 104);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(121, 21);
            this.YearBox.TabIndex = 15;
            this.YearBox.SelectedValueChanged += new System.EventHandler(this.YearBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select Year:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Reports:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(386, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Select 3rd Quarter winner(s) for Group 1, then click Winner button.";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 48);
            this.button4.TabIndex = 18;
            this.button4.Text = "Show Nominees";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(516, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 21);
            this.button5.TabIndex = 19;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(516, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 21);
            this.button6.TabIndex = 20;
            this.button6.Text = "WINNER";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 213);
            this.dataGridView1.TabIndex = 21;
            // 
            // frmDinnerWithPRIDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuarterBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupNoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDinnerWithPRIDE";
            this.Text = "Dinner With PRIDE";
            this.Load += new System.EventHandler(this.frmDinnerWithPRIDE_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GroupNoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox QuarterBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}