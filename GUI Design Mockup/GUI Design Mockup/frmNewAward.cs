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
        List<Department> DeptList;
        List<Employee> EmpList;
        List<Employee> EmpListA;
        List<Type_Of_Award> AwardTypeList;
        DataConnectionClass DContext;

        public frmNewAward(string AwardName="On The Spot")
        {
            InitializeComponent();
            DContext = DBCommands.DContext;
            InitializeDeptBox();
            InitializeEmpBox();
            InitializeTypeOfAwardBox(AwardName);
            Text = "New "+AwardName + " Award";
            label1.Text = AwardName + " Award";
            if (!AwardName.Equals("On The Spot", StringComparison.CurrentCultureIgnoreCase))
            {
                button3.Visible = false;
                button1.Visible = false;
                label7.Visible = false;
                button2.Text = "Submit " + AwardName;
                comboBox1.Location = new Point(251,137);
                comboBox1.Size = new Size(187, 21);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeDeptBox()
        {
            var DeptListRaw = from D in DContext.Departments
                              orderby D.DeptName ascending
                              select D;
            DeptList = new List<Department>();


            Department AllDepartment;
            AllDepartment = new Department();
            AllDepartment.DeptID = "DPT0000000";
            AllDepartment.DeptName = "All Departments";
            DeptList.Add(AllDepartment);

            foreach (Department D in DeptListRaw)
            {
                DeptList.Add(D);
            }
        }

        private void InitializeEmpBox()
        {
            var EmpListRaw = from E in DContext.Employees
                             orderby E.LastName ascending
                             select E;
            EmpList = new List<Employee>();

            EmpListA = new List<Employee>();

            Employee AllEmployee;
            AllEmployee = new Employee();
            AllEmployee.EmployeeID = "EMP-000001";
            EmpList.Add(AllEmployee);
            EmpListA.Add(AllEmployee);

            foreach (Employee E in EmpListRaw)
            {
                EmpList.Add(E);
                EmpListA.Add(E);
            }


            NominatorBox.DataSource = EmpList;
            RecipientBox.DataSource = EmpListA;
        }

        private void InitializeTypeOfAwardBox(string DefaultAwardType)
        {
            var ToAListRaw = from A in DContext.Type_Of_Awards
                             where A.IsNomination == true || A.AwardTypeName == "On The Spot"
                             orderby A.AwardTypeName ascending 
                             select A;
            AwardTypeList = new List<Type_Of_Award>();

            Type_Of_Award temp = null;
            foreach (Type_Of_Award T in ToAListRaw)
            {
                AwardTypeList.Add(T);
                if (T.AwardTypeName.Equals(DefaultAwardType , StringComparison.CurrentCultureIgnoreCase))
                    temp = T;
            }

            comboBox1.DataSource = AwardTypeList;
            if(temp!=null)
            comboBox1.SelectedIndex = AwardTypeList.IndexOf(temp);
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
            EmpA = (Employee)NominatorBox.SelectedItem;
            EmpB = (Employee)RecipientBox.SelectedItem;
            if (EmpA.EmployeeID != "DPT-000001" && EmpB.EmployeeID!= "DPT-000001")
            {
                NewAward.NominatorID = EmpA.EmployeeID;
                NewAward.RecipientID = EmpB.EmployeeID;
                NewAward.Notes = NoteBox.Text;
                NewAward.AwardDate = dateTimePicker1.Value;
                NewAward.AwardTypeID = ((Type_Of_Award)comboBox1.SelectedItem).AwardTypeID ;
                DContext.Awards.InsertOnSubmit(NewAward);
                DContext.SubmitChanges();
                this.Close();
            }
                else
            {
                MessageBox.Show("You must select both a nominator and a recipient for the award");
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
    }
}
