namespace GUI_Design_Mockup
{
    partial class frmUpdateFromExcel
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.XofYLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeptBoxOld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleBoxOld = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FTEBoxOld = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StatusBoxOld = new System.Windows.Forms.TextBox();
            this.StatusBoxNew = new System.Windows.Forms.TextBox();
            this.TitleBoxNew = new System.Windows.Forms.TextBox();
            this.DeptBoxNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FTEBoxNew = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FTEBoxNew)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "HR Employees Changed (Department, Title, FTE, or Status)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hScrollBar1);
            this.panel2.Controls.Add(this.XofYLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 29);
            this.panel2.TabIndex = 4;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(685, 29);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // XofYLabel
            // 
            this.XofYLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.XofYLabel.Location = new System.Drawing.Point(685, 0);
            this.XofYLabel.Name = "XofYLabel";
            this.XofYLabel.Size = new System.Drawing.Size(71, 29);
            this.XofYLabel.TabIndex = 0;
            this.XofYLabel.Text = "X of Y";
            this.XofYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save All Updated Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Enabled = false;
            this.IDBox.Location = new System.Drawing.Point(12, 52);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(76, 20);
            this.IDBox.TabIndex = 7;
            this.IDBox.Text = "EMP0000000";
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(94, 52);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(105, 20);
            this.NameBox.TabIndex = 8;
            this.NameBox.Text = "EMP0000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Department";
            // 
            // DeptBoxOld
            // 
            this.DeptBoxOld.Enabled = false;
            this.DeptBoxOld.Location = new System.Drawing.Point(205, 52);
            this.DeptBoxOld.Multiline = true;
            this.DeptBoxOld.Name = "DeptBoxOld";
            this.DeptBoxOld.Size = new System.Drawing.Size(166, 35);
            this.DeptBoxOld.TabIndex = 10;
            this.DeptBoxOld.Text = "EMP0000000\r\nEMP0000001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Title";
            // 
            // TitleBoxOld
            // 
            this.TitleBoxOld.Enabled = false;
            this.TitleBoxOld.Location = new System.Drawing.Point(377, 52);
            this.TitleBoxOld.Name = "TitleBoxOld";
            this.TitleBoxOld.Size = new System.Drawing.Size(187, 20);
            this.TitleBoxOld.TabIndex = 12;
            this.TitleBoxOld.Text = "EMP0000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "FTE";
            // 
            // FTEBoxOld
            // 
            this.FTEBoxOld.Enabled = false;
            this.FTEBoxOld.Location = new System.Drawing.Point(570, 52);
            this.FTEBoxOld.Name = "FTEBoxOld";
            this.FTEBoxOld.Size = new System.Drawing.Size(49, 20);
            this.FTEBoxOld.TabIndex = 14;
            this.FTEBoxOld.Text = "0.10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status";
            // 
            // StatusBoxOld
            // 
            this.StatusBoxOld.Enabled = false;
            this.StatusBoxOld.Location = new System.Drawing.Point(625, 52);
            this.StatusBoxOld.Name = "StatusBoxOld";
            this.StatusBoxOld.Size = new System.Drawing.Size(119, 20);
            this.StatusBoxOld.TabIndex = 16;
            this.StatusBoxOld.Text = "Temporary";
            // 
            // StatusBoxNew
            // 
            this.StatusBoxNew.BackColor = System.Drawing.Color.White;
            this.StatusBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBoxNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StatusBoxNew.Location = new System.Drawing.Point(625, 93);
            this.StatusBoxNew.Name = "StatusBoxNew";
            this.StatusBoxNew.Size = new System.Drawing.Size(119, 20);
            this.StatusBoxNew.TabIndex = 21;
            this.StatusBoxNew.Text = "Temporary";
            // 
            // TitleBoxNew
            // 
            this.TitleBoxNew.BackColor = System.Drawing.Color.White;
            this.TitleBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBoxNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleBoxNew.Location = new System.Drawing.Point(377, 93);
            this.TitleBoxNew.Name = "TitleBoxNew";
            this.TitleBoxNew.Size = new System.Drawing.Size(187, 20);
            this.TitleBoxNew.TabIndex = 19;
            this.TitleBoxNew.Text = "EMP0000000";
            // 
            // DeptBoxNew
            // 
            this.DeptBoxNew.BackColor = System.Drawing.Color.White;
            this.DeptBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptBoxNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeptBoxNew.Location = new System.Drawing.Point(205, 93);
            this.DeptBoxNew.Multiline = true;
            this.DeptBoxNew.Name = "DeptBoxNew";
            this.DeptBoxNew.Size = new System.Drawing.Size(166, 35);
            this.DeptBoxNew.TabIndex = 18;
            this.DeptBoxNew.Text = "EMP0000000\r\nEMP0000001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(110, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "New HR Data:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FTEBoxNew
            // 
            this.FTEBoxNew.DecimalPlaces = 2;
            this.FTEBoxNew.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FTEBoxNew.Location = new System.Drawing.Point(570, 94);
            this.FTEBoxNew.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.FTEBoxNew.Name = "FTEBoxNew";
            this.FTEBoxNew.Size = new System.Drawing.Size(49, 20);
            this.FTEBoxNew.TabIndex = 23;
            // 
            // frmUpdateFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 183);
            this.Controls.Add(this.FTEBoxNew);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StatusBoxNew);
            this.Controls.Add(this.TitleBoxNew);
            this.Controls.Add(this.DeptBoxNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StatusBoxOld);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FTEBoxOld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TitleBoxOld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeptBoxOld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateFromExcel";
            this.Text = "frmUpdateFromExcel";
            this.Load += new System.EventHandler(this.frmUpdateFromExcel_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FTEBoxNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label XofYLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DeptBoxOld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TitleBoxOld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FTEBoxOld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StatusBoxOld;
        private System.Windows.Forms.TextBox StatusBoxNew;
        private System.Windows.Forms.TextBox TitleBoxNew;
        private System.Windows.Forms.TextBox DeptBoxNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown FTEBoxNew;

    }
}