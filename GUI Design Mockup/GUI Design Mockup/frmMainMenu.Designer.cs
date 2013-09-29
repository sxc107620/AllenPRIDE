namespace GUI_Design_Mockup
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupNoBox = new System.Windows.Forms.ComboBox();
            this.DepartmentBox = new System.Windows.Forms.ComboBox();
            this.RecipientBox = new System.Windows.Forms.ComboBox();
            this.NominatorBox = new System.Windows.Forms.ComboBox();
            this.AwardTypeBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StartDateBox = new System.Windows.Forms.DateTimePicker();
            this.EndDateBox = new System.Windows.Forms.DateTimePicker();
            this.EmpAwdSumButton = new System.Windows.Forms.Button();
            this.MonthStatRptButton = new System.Windows.Forms.Button();
            this.DeptGrpRptButton = new System.Windows.Forms.Button();
            this.EmployeeEditButton = new System.Windows.Forms.Button();
            this.ReviewOTSButton = new System.Windows.Forms.Button();
            this.NewOTSButton = new System.Windows.Forms.Button();
            this.BlankOTSButton = new System.Windows.Forms.Button();
            this.YSPButton = new System.Windows.Forms.Button();
            this.DWPButton = new System.Windows.Forms.Button();
            this.DOPButton = new System.Windows.Forms.Button();
            this.PAAButton = new System.Windows.Forms.Button();
            this.pRIDE_beDataSet = new GUI_Design_Mockup.PRIDE_beDataSet();
            this.pRIDEbeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new GUI_Design_Mockup.PRIDE_beDataSetTableAdapters.EmployeeTableAdapter();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pRIDE_beDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRIDEbeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "City of Allen Pride Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selection Criteria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recipient:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nominator:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Award Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Select Start Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Select End Date:";
            // 
            // GroupNoBox
            // 
            this.GroupNoBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GroupNoBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GroupNoBox.FormattingEnabled = true;
            this.GroupNoBox.Location = new System.Drawing.Point(83, 75);
            this.GroupNoBox.Name = "GroupNoBox";
            this.GroupNoBox.Size = new System.Drawing.Size(95, 21);
            this.GroupNoBox.TabIndex = 9;
            this.GroupNoBox.Text = "All Groups";
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DepartmentBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.Location = new System.Drawing.Point(83, 102);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(413, 21);
            this.DepartmentBox.TabIndex = 10;
            this.DepartmentBox.Text = "All Departments";
            // 
            // RecipientBox
            // 
            this.RecipientBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RecipientBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RecipientBox.FormattingEnabled = true;
            this.RecipientBox.Location = new System.Drawing.Point(83, 129);
            this.RecipientBox.Name = "RecipientBox";
            this.RecipientBox.Size = new System.Drawing.Size(254, 21);
            this.RecipientBox.TabIndex = 11;
            this.RecipientBox.Text = "All Employees";
            // 
            // NominatorBox
            // 
            this.NominatorBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NominatorBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NominatorBox.FormattingEnabled = true;
            this.NominatorBox.Location = new System.Drawing.Point(83, 156);
            this.NominatorBox.Name = "NominatorBox";
            this.NominatorBox.Size = new System.Drawing.Size(254, 21);
            this.NominatorBox.TabIndex = 12;
            this.NominatorBox.Text = "All Employees";
            // 
            // AwardTypeBox
            // 
            this.AwardTypeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AwardTypeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AwardTypeBox.FormattingEnabled = true;
            this.AwardTypeBox.Location = new System.Drawing.Point(84, 183);
            this.AwardTypeBox.Name = "AwardTypeBox";
            this.AwardTypeBox.Size = new System.Drawing.Size(253, 21);
            this.AwardTypeBox.TabIndex = 13;
            this.AwardTypeBox.Text = "All Awards";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Reports:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "On The Spot Award:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Awards And Nominations:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(375, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Edit/Add Employees:";
            // 
            // StartDateBox
            // 
            this.StartDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateBox.Location = new System.Drawing.Point(440, 159);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(99, 20);
            this.StartDateBox.TabIndex = 18;
            // 
            // EndDateBox
            // 
            this.EndDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateBox.Location = new System.Drawing.Point(440, 186);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(99, 20);
            this.EndDateBox.TabIndex = 19;
            // 
            // EmpAwdSumButton
            // 
            this.EmpAwdSumButton.Location = new System.Drawing.Point(15, 240);
            this.EmpAwdSumButton.Name = "EmpAwdSumButton";
            this.EmpAwdSumButton.Size = new System.Drawing.Size(100, 50);
            this.EmpAwdSumButton.TabIndex = 20;
            this.EmpAwdSumButton.Text = "Employee Awards Summary";
            this.EmpAwdSumButton.UseVisualStyleBackColor = true;
            // 
            // MonthStatRptButton
            // 
            this.MonthStatRptButton.Location = new System.Drawing.Point(121, 240);
            this.MonthStatRptButton.Name = "MonthStatRptButton";
            this.MonthStatRptButton.Size = new System.Drawing.Size(100, 50);
            this.MonthStatRptButton.TabIndex = 21;
            this.MonthStatRptButton.Text = "Monthly Statistics Report";
            this.MonthStatRptButton.UseVisualStyleBackColor = true;
            // 
            // DeptGrpRptButton
            // 
            this.DeptGrpRptButton.Location = new System.Drawing.Point(227, 240);
            this.DeptGrpRptButton.Name = "DeptGrpRptButton";
            this.DeptGrpRptButton.Size = new System.Drawing.Size(100, 50);
            this.DeptGrpRptButton.TabIndex = 22;
            this.DeptGrpRptButton.Text = "Department Group Report";
            this.DeptGrpRptButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeEditButton
            // 
            this.EmployeeEditButton.Location = new System.Drawing.Point(390, 240);
            this.EmployeeEditButton.Name = "EmployeeEditButton";
            this.EmployeeEditButton.Size = new System.Drawing.Size(100, 50);
            this.EmployeeEditButton.TabIndex = 23;
            this.EmployeeEditButton.Text = "Employees";
            this.EmployeeEditButton.UseVisualStyleBackColor = true;
            this.EmployeeEditButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReviewOTSButton
            // 
            this.ReviewOTSButton.Location = new System.Drawing.Point(15, 344);
            this.ReviewOTSButton.Name = "ReviewOTSButton";
            this.ReviewOTSButton.Size = new System.Drawing.Size(100, 50);
            this.ReviewOTSButton.TabIndex = 24;
            this.ReviewOTSButton.Text = "Review On The Spot";
            this.ReviewOTSButton.UseVisualStyleBackColor = true;
            this.ReviewOTSButton.Click += new System.EventHandler(this.ReviewOTSButton_Click);
            // 
            // NewOTSButton
            // 
            this.NewOTSButton.Location = new System.Drawing.Point(121, 344);
            this.NewOTSButton.Name = "NewOTSButton";
            this.NewOTSButton.Size = new System.Drawing.Size(100, 50);
            this.NewOTSButton.TabIndex = 25;
            this.NewOTSButton.Text = "New On The Spot";
            this.NewOTSButton.UseVisualStyleBackColor = true;
            this.NewOTSButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // BlankOTSButton
            // 
            this.BlankOTSButton.Location = new System.Drawing.Point(227, 344);
            this.BlankOTSButton.Name = "BlankOTSButton";
            this.BlankOTSButton.Size = new System.Drawing.Size(100, 50);
            this.BlankOTSButton.TabIndex = 26;
            this.BlankOTSButton.Text = "Blank On The Spot Form";
            this.BlankOTSButton.UseVisualStyleBackColor = true;
            // 
            // YSPButton
            // 
            this.YSPButton.Location = new System.Drawing.Point(15, 448);
            this.YSPButton.Name = "YSPButton";
            this.YSPButton.Size = new System.Drawing.Size(100, 50);
            this.YSPButton.TabIndex = 27;
            this.YSPButton.Text = "You Showed Pride";
            this.YSPButton.UseVisualStyleBackColor = true;
            // 
            // DWPButton
            // 
            this.DWPButton.Location = new System.Drawing.Point(121, 448);
            this.DWPButton.Name = "DWPButton";
            this.DWPButton.Size = new System.Drawing.Size(100, 50);
            this.DWPButton.TabIndex = 28;
            this.DWPButton.Text = "Dinner With Pride";
            this.DWPButton.UseVisualStyleBackColor = true;
            // 
            // DOPButton
            // 
            this.DOPButton.Location = new System.Drawing.Point(227, 448);
            this.DOPButton.Name = "DOPButton";
            this.DOPButton.Size = new System.Drawing.Size(100, 50);
            this.DOPButton.TabIndex = 29;
            this.DOPButton.Text = "Day Of Pride";
            this.DOPButton.UseVisualStyleBackColor = true;
            // 
            // PAAButton
            // 
            this.PAAButton.Location = new System.Drawing.Point(333, 448);
            this.PAAButton.Name = "PAAButton";
            this.PAAButton.Size = new System.Drawing.Size(100, 50);
            this.PAAButton.TabIndex = 30;
            this.PAAButton.Text = "PRIDE Annual Awards";
            this.PAAButton.UseVisualStyleBackColor = true;
            // 
            // pRIDE_beDataSet
            // 
            this.pRIDE_beDataSet.DataSetName = "PRIDE_beDataSet";
            this.pRIDE_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRIDEbeDataSetBindingSource
            // 
            this.pRIDEbeDataSetBindingSource.DataSource = this.pRIDE_beDataSet;
            this.pRIDEbeDataSetBindingSource.Position = 0;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.pRIDEbeDataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(439, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 50);
            this.button12.TabIndex = 31;
            this.button12.Text = "Update From Access Database";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 508);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.PAAButton);
            this.Controls.Add(this.DOPButton);
            this.Controls.Add(this.DWPButton);
            this.Controls.Add(this.YSPButton);
            this.Controls.Add(this.BlankOTSButton);
            this.Controls.Add(this.NewOTSButton);
            this.Controls.Add(this.ReviewOTSButton);
            this.Controls.Add(this.EmployeeEditButton);
            this.Controls.Add(this.DeptGrpRptButton);
            this.Controls.Add(this.MonthStatRptButton);
            this.Controls.Add(this.EmpAwdSumButton);
            this.Controls.Add(this.EndDateBox);
            this.Controls.Add(this.StartDateBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AwardTypeBox);
            this.Controls.Add(this.NominatorBox);
            this.Controls.Add(this.RecipientBox);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.GroupNoBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMainMenu";
            this.Text = "City of Allen PRIDE Database Ver. 3";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRIDE_beDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRIDEbeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox GroupNoBox;
        private System.Windows.Forms.ComboBox DepartmentBox;
        private System.Windows.Forms.ComboBox RecipientBox;
        private System.Windows.Forms.ComboBox NominatorBox;
        private System.Windows.Forms.ComboBox AwardTypeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker StartDateBox;
        private System.Windows.Forms.DateTimePicker EndDateBox;
        private System.Windows.Forms.Button EmpAwdSumButton;
        private System.Windows.Forms.Button MonthStatRptButton;
        private System.Windows.Forms.Button DeptGrpRptButton;
        private System.Windows.Forms.Button EmployeeEditButton;
        private System.Windows.Forms.Button ReviewOTSButton;
        private System.Windows.Forms.Button NewOTSButton;
        private System.Windows.Forms.Button BlankOTSButton;
        private System.Windows.Forms.Button YSPButton;
        private System.Windows.Forms.Button DWPButton;
        private System.Windows.Forms.Button DOPButton;
        private System.Windows.Forms.Button PAAButton;
        private System.Windows.Forms.BindingSource pRIDEbeDataSetBindingSource;
        private PRIDE_beDataSet pRIDE_beDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PRIDE_beDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button button12;
    }
}

