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
        DataConnectionClass DContext;

        public frmNewAward(string AwardName="On The Spot")
        {
            InitializeComponent();
            DContext = DBCommands.DContext;
            InitializeDeptBox();
            InitializeEmpBox();
            Text = "New "+AwardName + " Award";
            label1.Text = AwardName + " Award";
            textBox3.Text = AwardName;
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

        private void RecipientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee SelectedEmployee = (Employee)RecipientBox.Items[RecipientBox.SelectedIndex];
            if (SelectedEmployee != null && !SelectedEmployee.EmployeeID.Equals("EMP-000001"))
            {
                var tempVar = from D in DeptList
                              where D.DeptID == SelectedEmployee.DeptID
                              select D;

                List<string> SList = new List<string>();


                foreach (Department D in tempVar)
                    SList.Add(D.DeptName);

                if (SList.Count > 0)
                    DepartmentBox.Text = SList[0];
                else
                    DepartmentBox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Award NewAward = new Award();
            int NextNum = frmMainMenu.NextID("Award");
            NewAward.AwardID = "AWD" + NextNum.ToString("0000000");
            Employee EmpA, EmpB;
            EmpA = (Employee)NominatorBox.SelectedItem;
            EmpB = (Employee)RecipientBox.SelectedItem;
            if (EmpA.EmployeeID != "DPT-000001" && EmpB.EmployeeID!= "DPT-000001")
            {
                NewAward.NominatorID = EmpA.EmployeeID;
                NewAward.RecipientID = EmpB.EmployeeID;
                NewAward.Notes = NoteBox.Text;
                NewAward.AwardDeptID = EmpA.DeptID;
                NewAward.AwardDate = dateTimePicker1.Value;
                NewAward.AwardTypeID = DBCommands.GetAwardID("On The Spot");
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
            int NextNum = frmMainMenu.NextID("Award");
            NewAward.AwardID = "AWD" + NextNum.ToString("0000000");
            Employee EmpA, EmpB;
            EmpA = (Employee)NominatorBox.SelectedItem;
            EmpB = (Employee)RecipientBox.SelectedItem;
            if (EmpA.EmployeeID != "DPT-000001" && EmpB.EmployeeID != "DPT-000001")
            {
                NewAward.NominatorID = EmpA.EmployeeID;
                NewAward.RecipientID = EmpB.EmployeeID;
                NewAward.Notes = NoteBox.Text;
                NewAward.AwardDeptID = EmpA.DeptID;
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
    }
}
