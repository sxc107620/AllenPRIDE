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
        List<Employee> EmpListA;
        List<Type_Of_Award> ToAList;
        DataConnectionClass DContext;

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
            frm.Location = this.Location;
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmNewAward());
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRIDE_beDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.pRIDE_beDataSet.Employee);

            DBCommands.DContext = new DataConnectionClass();
            DContext = DBCommands.DContext;
            InitializeGroupBox();
            InitializeDeptBox();
            InitializeEmpBox();
            InitializeAwdBox();
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


        private void InitializeDeptBox()
        {
            var DeptListRaw = from D in DBCommands.DContext.Departments
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
            var EmpListRaw = from E in DBCommands.DContext.Employees
                             orderby E.LastName ascending
                             select E;
            EmpList = new List<Employee>();

            EmpListA = new List<Employee>();

            Employee AllEmployee;
            AllEmployee = new Employee();
            AllEmployee.EmployeeID = "EMP0000000";
            EmpList.Add(AllEmployee);
            EmpListA.Add(AllEmployee);

            foreach (Employee E in EmpListRaw)
            {
                EmpList .Add(E);
                EmpListA.Add(E);
            }


            NominatorBox.DataSource = EmpList ;
            RecipientBox.DataSource = EmpListA;
        }

        private void InitializeAwdBox()
        {
            var AwdListRaw = from A in DBCommands.DContext.Type_Of_Awards
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
            frmReviewOnTheSpot form = new frmReviewOnTheSpot();
            List<Award> AwdList = new List<Award>();
            string AwdID = DBCommands.GetAwardID("On The Spot");
            var AwdListRawA = from N in DContext.Awards
                              where N.AwardTypeID == AwdID
                              orderby N.RecipientID
                              select N;

            Group GrpVal =(Group) GroupNoBox.SelectedItem;
            if (GrpVal != null && !GrpVal.GroupID.Equals("GRP0000000", StringComparison.CurrentCultureIgnoreCase))
            {
                var AwdListRawB = from N in AwdListRawA
                                  join Emp in DContext.Employees on N.RecipientID equals Emp.EmployeeID
                                  where Emp.GroupID == GrpVal.GroupID
                                  orderby N.RecipientID 
                                  select N;
                AwdListRawA = (System.Linq.IOrderedQueryable<Award>)AwdListRawB;
            }

            Department DptVal = (Department)DepartmentBox.SelectedItem;
            if (DptVal != null && !DptVal.DeptID.Equals("DPT0000000", StringComparison.CurrentCultureIgnoreCase))
            {
                var AwdListRawB = from N in AwdListRawA
                                  join Emp in DContext.Employees on N.RecipientID equals Emp.EmployeeID
                                  where Emp.DeptID==DptVal.DeptID
                                  orderby N.RecipientID 
                                  select N;
                AwdListRawA = (System.Linq.IOrderedQueryable<Award>)AwdListRawB;
            }

            Employee RecEmp = (Employee)RecipientBox.SelectedItem;
            if (RecEmp != null && !RecEmp.EmployeeID.Equals("EMP0000000", StringComparison.CurrentCultureIgnoreCase))
            {
                var AwdListRawB = from N in AwdListRawA
                                  where N.RecipientID == RecEmp.EmployeeID
                                  orderby N.RecipientID 
                                  select N;
                AwdListRawA = (System.Linq.IOrderedQueryable<Award>)AwdListRawB;
            }

            Employee NomEmp = (Employee)NominatorBox.SelectedItem;
            if (NomEmp != null && !NomEmp.EmployeeID.Equals("EMP0000000", StringComparison.CurrentCultureIgnoreCase))
            {
                var AwdListRawB = from N in AwdListRawA
                                  where N.NominatorID == NomEmp.EmployeeID
                                  orderby N.RecipientID 
                                  select N;
                AwdListRawA = (System.Linq.IOrderedQueryable<Award>)AwdListRawB;
            }

            if (checkBox1.Checked)
            {
                var AwdListRawB = from N in AwdListRawA
                                  where N.AwardDate >= StartDateBox.Value
                                  orderby N.RecipientID 
                                  select N;
                AwdListRawA = (System.Linq.IOrderedQueryable<Award>)AwdListRawB;
            }

            if (checkBox2.Checked)
            {
                var AwdListRawB = from N in AwdListRawA
                                  where N.AwardDate <= EndDateBox.Value
                                  orderby N.RecipientID 
                                  select N;
                AwdListRawA = (System.Linq.IOrderedQueryable<Award>)AwdListRawB;
            }

            foreach (Award A in AwdListRawA)
                AwdList.Add(A);

            form.StartThing(AwdList);
            LaunchForm(form);
        }

        private void StartDateBox_ValueChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void EndDateBox_ValueChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void YSPButton_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmYouShowedPRIDE());
        }

        private void DWPButton_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmDinnerWithPRIDE());
        }

        private void DOPButton_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmDayOfPRIDE());
        }

        private void PAAButton_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmPRIDEAwards());
        }

        private void MonthStatRptButton_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmMonthlyStats());
        }
    }
}