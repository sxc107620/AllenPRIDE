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
    public partial class frmMainMenu : Form
    {
        List<Group> GroupList;
        List<Department> DeptList;
        List<Employee> EmpList;
        List<Type_Of_Award> ToAList;

        DataClasses1DataContext DContext;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmEmployees());
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

        private void button6_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmNewOnTheSpot());
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRIDE_beDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.pRIDE_beDataSet.Employee);

            DContext = new DataClasses1DataContext();

            InitializeGroupBox();
            InitializeDeptBox();
            InitializeEmpBox();
            InitializeAwdBox();
        }

        private void InitializeGroupBox()
        {
            var GroupListRaw = from G in DContext.Groups
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

            DepartmentBox.DataSource = DeptList;
        }

        private void InitializeEmpBox()
        {
            var EmpListRaw = from E in DContext.Employees
                             orderby E.LastName ascending
                             select E;
            EmpList = new List<Employee>();

            Employee AllEmployee;
            AllEmployee = new Employee();
            AllEmployee.EmployeeID = "EMP0000000";
            EmpList.Add(AllEmployee);

            foreach (Employee E in EmpListRaw)
            {
                EmpList.Add(E);
            }

            NominatorBox.DataSource = EmpList;
            RecipientBox.DataSource = EmpList;
        }

        private void InitializeAwdBox()
        {
            var AwdListRaw = from A in DContext.Type_Of_Awards
                             orderby A.AwardTypeName ascending
                             select A;
            ToAList = new List<Type_Of_Award >();

            Type_Of_Award  AllAward;
            AllAward = new Type_Of_Award();
            AllAward.AwardTypeName = "All Awards";
            ToAList.Add(AllAward);

            foreach (Type_Of_Award ToA in AwdListRaw)
            {
                ToAList.Add(ToA);
            }

            AwardTypeBox.DataSource = ToAList;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmUpdateFromAccess());
        }

        private void ReviewOTSButton_Click(object sender, EventArgs e)
        {

        }
    }
}
