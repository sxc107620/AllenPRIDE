using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Design_Mockup
{
    public partial class frmNewAward : Form
    {
        DataClasses1DataContext  DContext;

        List<ComboBox> CBoxes;
        ComboBox RecipientBox;

        public frmNewAward(string AwardName="On The Spot")
        {
            InitializeComponent();
            DContext = DBCommands.DContext;
            InitializeEmpBox();
            InitializeTypeOfAwardBox(AwardName);
            Text = "New "+AwardName + " Award";
            label1.Text = AwardName + " Award";
            CBoxes = new List<ComboBox>();
            RecipientBox = BuildNextNomineeBox();
            RecipientBox.SelectedIndexChanged += RecipientBox_SelectedIndexChanged;
            CBoxes.Add(RecipientBox );
            /*if (!AwardName.Equals("On The Spot", StringComparison.CurrentCultureIgnoreCase))
            {
                button3.Visible = false;
                button1.Visible = false;
                label7.Visible = false;
                button2.Text = "Submit " + AwardName;
                comboBox1.Location = new Point(251,137);
                comboBox1.Size = new Size(187, 21);
            }*/
        }

        private ComboBox BuildNextNomineeBox()
        {
            ComboBox CBox = new ComboBox();
            CBox.DataSource = DBCommands.GetAllEmployeeList();
            CBox.Size = new Size(278, 21);
            CBox.Location= new Point(160, 55 +(27*CBoxes.Count));
            CBox.FormattingEnabled = true;
            CBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.Controls.Add(CBox);
            return CBox;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeEmpBox()
        {
            NominatorBox.DataSource = DBCommands.GetAllEmployeeList();
        }

        private void InitializeTypeOfAwardBox(string DefaultAwardType)
        {
            Type_Of_Award temp;

            comboBox1.DataSource = DBCommands.GetAllTypeOfAwardList(DefaultAwardType,out temp);
            if(temp!=null)
            comboBox1.SelectedIndex = ((List<Type_Of_Award>)comboBox1.DataSource).IndexOf(temp);
        }

        private void RecipientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee SelectedEmployee = (Employee)RecipientBox.Items[RecipientBox.SelectedIndex];
            if (SelectedEmployee != null && !SelectedEmployee.EmployeeID.Equals("EMP-000001"))
            {
                Department tempDept = DBCommands.GetDepartment(SelectedEmployee.DeptID);
                if (tempDept != null)
                    DepartmentBox.Text = tempDept.DeptName;
                else
                    DepartmentBox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Award NewAward = new Award();
            NewAward.AwardID = DBCommands.NextID("Award");
            Employee EmpA, EmpB;
            if (CBoxes.Count == 1)
            {
                EmpA = (Employee)NominatorBox.SelectedItem;
                EmpB = (Employee)RecipientBox.SelectedItem;
                if (EmpA.EmployeeID != "EMP-000001" && EmpB.EmployeeID != "EMP-000001")
                {
                    NewAward.NominatorID = EmpA.EmployeeID;
                    NewAward.RecipientID = EmpB.EmployeeID;
                    NewAward.Notes = NoteBox.Text;
                    NewAward.AwardDate = dateTimePicker1.Value;
                    NewAward.AwardTypeID = ((Type_Of_Award)comboBox1.SelectedItem).AwardTypeID;
                    DContext.Awards.InsertOnSubmit(NewAward);
                    DContext.SubmitChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must select both a nominator and a recipient for the award");
                }
            }
            else
            {
                List<Employee> SelectedEmployees = new List<Employee>();
                int C1;
                for (C1 = 0; C1 < CBoxes.Count; C1++)
                {
                    EmpA = (Employee)CBoxes[C1].SelectedItem;
                    if (EmpA.EmployeeID != "EMP-000001" && !SelectedEmployees.Contains(EmpA))
                    {
                        SelectedEmployees.Add(EmpA);
                    }
                }
                EmpB = (Employee)RecipientBox.SelectedItem;
                if (SelectedEmployees.Count > 0 && EmpB.EmployeeID != "EMP-000001")
                {
                    string[] EmpIDlist = new string[SelectedEmployees.Count];
                    for (C1 = 0; C1 < SelectedEmployees.Count; C1++)
                    {
                        EmpIDlist[C1] = SelectedEmployees[C1].EmployeeID;
                    }
                    string TeamID = DBCommands.BuildTeam(EmpIDlist);
                    NewAward.RecipientID = TeamID;
                    NewAward.NominatorID = EmpB.EmployeeID;
                    NewAward.Notes = NoteBox.Text;
                    NewAward.AwardDate = dateTimePicker1.Value;
                    NewAward.AwardTypeID = ((Type_Of_Award)comboBox1.SelectedItem).AwardTypeID;
                    DContext.Awards.InsertOnSubmit(NewAward);
                    DContext.SubmitChanges();
                    this.Close();
                }
                else
                    MessageBox.Show("You must select a nominator and at least one recipient for the award");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Award NewAward = new Award();
            NewAward.AwardID = DBCommands.NextID("Award");
            Employee EmpA, EmpB;
            EmpA = (Employee)NominatorBox.SelectedItem;
            EmpB = (Employee)RecipientBox.SelectedItem;
            if (EmpA.EmployeeID != "DPT-000001" && EmpB.EmployeeID != "DPT-000001")
            {
                NewAward.NominatorID = EmpA.EmployeeID;
                NewAward.RecipientID = EmpB.EmployeeID;
                NewAward.Notes = NoteBox.Text;
                NewAward.AwardDate = dateTimePicker1.Value;
                NewAward.AwardTypeID = "TOA0000029";
                DContext.Awards.InsertOnSubmit(NewAward);
                DContext.SubmitChanges();

                RecipientBox.Text = "";
                MessageBox.Show("Award added.");
            }
            else
            {
                MessageBox.Show("You must select both a nominator and a recipient for the award");
            }
        }

        private void frmNewAward_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CBoxes.Count == 1)
            {
                DepartmentBox.Visible = false;
                label3.Visible = false;
                RemoveButton.Enabled = true;
            }
            else
            this.Size= new Size(this.Size.Width,this.Size.Height+27);
            CBoxes.Add(BuildNextNomineeBox());
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ComboBox LastBox = CBoxes.Last<ComboBox>();
            this.Controls.Remove(LastBox);
            CBoxes.Remove(LastBox);
            if (CBoxes.Count == 1)
            {
                RemoveButton.Enabled = false;
                DepartmentBox.Visible = true;
                label3.Visible = true;
            }
            else
                this.Size = new Size(this.Size.Width, this.Size.Height - 27);
        }
    }
}
