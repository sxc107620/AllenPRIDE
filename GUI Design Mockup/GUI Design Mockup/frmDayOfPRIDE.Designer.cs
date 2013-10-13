namespace GUI_Design_Mockup
{
    partial class frmDayOfPRIDE
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HalfBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupNoBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 213);
            this.dataGridView1.TabIndex = 36;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(419, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 21);
            this.button6.TabIndex = 35;
            this.button6.Text = "WINNER";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(516, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 21);
            this.button5.TabIndex = 34;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 48);
            this.button4.TabIndex = 33;
            this.button4.Text = "Show Nominees";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "Select 2nd Half 2009 All Groups winner(s),\r\n then click the Winner or Short List " +
    "button.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Reports:";
            // 
            // HalfBox
            // 
            this.HalfBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HalfBox.FormattingEnabled = true;
            this.HalfBox.Items.AddRange(new object[] {
            "1st",
            "2nd"});
            this.HalfBox.Location = new System.Drawing.Point(228, 102);
            this.HalfBox.Name = "HalfBox";
            this.HalfBox.Size = new System.Drawing.Size(121, 21);
            this.HalfBox.TabIndex = 30;
            this.HalfBox.SelectedValueChanged += new System.EventHandler(this.GroupNoBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Select Half:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YearBox
            // 
            this.YearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Location = new System.Drawing.Point(228, 75);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(121, 21);
            this.YearBox.TabIndex = 28;
            this.YearBox.SelectedValueChanged += new System.EventHandler(this.GroupNoBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Select Year:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(15, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 61);
            this.panel1.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Day Of PRIDE Award Winners";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Day Of PRIDE Eligibility Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GroupNoBox
            // 
            this.GroupNoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupNoBox.FormattingEnabled = true;
            this.GroupNoBox.Location = new System.Drawing.Point(228, 48);
            this.GroupNoBox.Name = "GroupNoBox";
            this.GroupNoBox.Size = new System.Drawing.Size(121, 21);
            this.GroupNoBox.TabIndex = 25;
            this.GroupNoBox.SelectedValueChanged += new System.EventHandler(this.GroupNoBox_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Group No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Selection Criteria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Day of PRIDE Nominations and Awards";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(516, 253);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 21);
            this.button7.TabIndex = 37;
            this.button7.Text = "Short List";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nomination Form:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Location = new System.Drawing.Point(247, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 61);
            this.panel2.TabIndex = 38;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(217, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 50);
            this.button8.TabIndex = 2;
            this.button8.Text = "Blank Day Of PRIDE Form";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(110, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 50);
            this.button9.TabIndex = 1;
            this.button9.Text = "New Day Of PRIDE Nomination";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(101, 50);
            this.button10.TabIndex = 0;
            this.button10.Text = "Review Day of PRIDE Nominations";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // frmDayOfPRIDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 505);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HalfBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupNoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDayOfPRIDE";
            this.Text = "Day of PRIDE";
            this.Load += new System.EventHandler(this.frmDayOfPRIDE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox HalfBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GroupNoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}