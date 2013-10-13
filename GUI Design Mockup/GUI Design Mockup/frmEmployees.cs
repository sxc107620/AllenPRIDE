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
    public partial class frmEmployees : Form
    {
        List<Group> GroupList;
        List<Employee> EmpList;
        DataConnectionClass DContext;

        public frmEmployees()
        {
            DContext = DBCommands.DContext;
            InitializeComponent();
            InitializeEmpBox();
            InitializeGroupBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUpdateEmployees frm = new frmUpdateEmployees();
            frm.StartThing(DBCommands.GetNewEmployeesList());
            LaunchForm(frm);
        }

        private void OnSubFormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        public void LaunchForm(Form frm)
        {
            frm.FormClosed += OnSubFormClose;
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor OldCurs = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            DBCommands.LoadNewEmployees();
            this.Cursor = OldCurs;
        }

        private void InitializeGroupBox()
        {
            var GroupListRaw = from G in DBCommands.DContext.Groups
                               orderby G.GroupID ascending
                               select G;
            GroupList = new List<Group>();

            Group AllGroup;
            AllGroup = new Group();
            AllGroup.GroupID = "GRP0000000";
            AllGroup.GroupNum = "All Groups";
            AllGroup.DayOfPride = 'X';
            GroupList.Add(AllGroup);

            foreach (Group G in GroupListRaw)
            {
                GroupList.Add(G);
            }

            GroupNoBox.DataSource = GroupList;
        }

        private void InitializeEmpBox()
        {
            var EmpListRaw = from E in DBCommands.DContext.Employees
                             orderby E.LastName ascending
                             select E;
            EmpList = new List<Employee>();

            Employee AllEmployee;
            AllEmployee = new Employee();
            AllEmployee.EmployeeID = "EMP-000001";
            EmpList.Add(AllEmployee);

            foreach (Employee E in EmpListRaw)
            {
                EmpList.Add(E);
            }


            EmpBox.DataSource = EmpList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var NewEmpListRaw = from E in DContext.Employees
                                select E;

            Group Grp = (Group)GroupNoBox.SelectedItem;
            if (Grp != null && Grp.GroupID != "GRP0000000")
            {
                var NewEmpListRawB = from E in NewEmpListRaw
                                     where E.GroupID == Grp.GroupID
                                     select E;
                NewEmpListRaw = NewEmpListRawB;
            }

            if (!checkBox1.Checked)
            {
                var NewEmpListRawB = from E in NewEmpListRaw
                                     where E.Active == true // Yes, that's necessary. Not quite sure why, but it is
                                     select E;
                NewEmpListRaw = NewEmpListRawB;
            }

            List<Employee> NewEmpList = new List<Employee>();
            foreach (Employee E in NewEmpListRaw)
                NewEmpList.Add(E);

            frmUpdateEmployees frm = new frmUpdateEmployees();
            frm.StartThing(NewEmpList);
            LaunchForm(frm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee SelectedEmp = (Employee)EmpBox.SelectedItem;
            if (SelectedEmp != null && SelectedEmp.EmployeeID != "EMP-000001")
            {
                List<Employee> ShortList = new List<Employee>();
                ShortList.Add(SelectedEmp);
                frmUpdateEmployees frm = new frmUpdateEmployees();
                frm.StartThing(ShortList);
                LaunchForm(frm);
            }
        }

        private void EmpBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (EmpBox.SelectedItem != null)
            {
                Employee SelectedEmp = (Employee)EmpBox.SelectedItem;
                button4.Enabled = SelectedEmp.EmployeeID != "EMP-000001";
            }
            else
                button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Employee> TempEmpList = DBCommands.BuildEmployeeListFromExcel();
            var FullEmpListRaw = from E in DContext.Employees
                                 select E;
            List<Employee> FullEmpList = new List<Employee>();
            foreach (Employee E in FullEmpListRaw)
                FullEmpList.Add(E);


            List<Employee> InactiveEmployeeList = new List<Employee>();
            foreach (Employee E in FullEmpList)
            {
                if (E.MiddleInitial != null)
                    if (TempEmpList.Count(p => p.FirstName == E.FirstName && p.LastName == E.LastName && p.MiddleInitial == E.MiddleInitial) == 0)
                        if ((bool)E.Active)
                            InactiveEmployeeList.Add(E);
                else
                    if (TempEmpList.Count(p => p.FirstName == E.FirstName && p.LastName == E.LastName) == 0)
                        if ((bool)E.Active)
                            InactiveEmployeeList.Add(E);
            }

            foreach (Employee E in InactiveEmployeeList)
                DBCommands.DeactivateEmployee(E);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
