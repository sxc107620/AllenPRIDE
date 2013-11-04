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
    public partial class frmUpdateEmployees : Form
    {
        List<Employee> EmpList;
        List<Group> GroupList;
        Employee SelectedEmployee;
        DataClasses1DataContext DContext;
        public frmUpdateEmployees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSelectedEmployee();
            SaveChangesToDB();
            this.Close();
        }

        public void StartThing(List<Employee> EList)
        {
            EmpList = new List<Employee>();
            foreach (Employee E in EList)
                EmpList.Add(E);
            DContext = DBCommands.DContext;
            InitializeGroupBox();
            hScrollBar1.Minimum = 1;
            hScrollBar1.Maximum = EmpList.Count + (hScrollBar1.LargeChange - 1);
            label1.Text = "1 of " + EmpList.Count.ToString();
            if (EmpList.Count > 0)
                LoadEmployee(EmpList[0]);
        }

        private void frmUpdateEmployees_Load(object sender, EventArgs e)
        {
           
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SaveSelectedEmployee();
            label1.Text = hScrollBar1.Value.ToString() + " of " + EmpList.Count.ToString();
            LoadEmployee(EmpList[hScrollBar1.Value - 1]);
        }

        private void SaveSelectedEmployee()
        {
            if (SelectedEmployee != null)
            {
                SelectedEmployee.PreferredName = PrefNameBox.Text;

                if (GroupNoBox.SelectedItem != null && GroupNoBox.SelectedItem is Group)
                {
                    SelectedEmployee.GroupID = ((Group)GroupNoBox.SelectedItem).GroupID;
                }

                SelectedEmployee.PrideEligible = PrideEligibleBox.Checked;
                SelectedEmployee.Active = ActiveBox.Checked;
                SelectedEmployee.OldAwardCount = Decimal.ToInt32(OldAwdCountBox.Value);
            }
        }

        private void InitializeGroupBox()
        {
            var GroupListRaw = from G in DBCommands.DContext.Groups
                               orderby G.GroupID ascending
                               select G;
            GroupList = new List<Group>();


            foreach (Group G in GroupListRaw)
            {
                GroupList.Add(G);
            }

            GroupNoBox.DataSource = GroupList;
        }

        private void LoadEmployee(Employee Emp)
        {
            SelectedEmployee = Emp;
            EmpNameBox.Text = SelectedEmployee.LastName + ", " + SelectedEmployee.FirstName;
            if (SelectedEmployee.MiddleInitial != null)
                EmpNameBox.Text += " " + SelectedEmployee.MiddleInitial.ToString();
            EmpIDBox.Text = SelectedEmployee.EmployeeID;
            EmpDeptBox.Text = DBCommands.GetDepartment(SelectedEmployee.DeptID).DeptName;
            EmpTitleBox.Text = SelectedEmployee.Title;
            if (SelectedEmployee.HR_FTE != null)
                EmpFTEBox.Text = ((double)SelectedEmployee.HR_FTE).ToString("0.00");
            else
                EmpFTEBox.Text = "";
            if (SelectedEmployee.HireDate != null)
                EmpHireDateBox.Text = ((DateTime)SelectedEmployee.HireDate).ToShortDateString();
            else
                EmpHireDateBox.Text = "";
            EmpStatusBox.Text = SelectedEmployee.HR_Status;

            PrefNameBox.Text = SelectedEmployee.PreferredName;

            int GrpInd = GetGroupIndex(SelectedEmployee.GroupID);
            if (GrpInd >= 0)
                GroupNoBox.SelectedIndex = GrpInd;
            else
                GroupNoBox.SelectedIndex = -1;

            if (SelectedEmployee.PrideEligible != null)
                PrideEligibleBox.Checked = (bool)SelectedEmployee.PrideEligible;
            else
                PrideEligibleBox.Checked = false;

            if (SelectedEmployee.Active != null)
                ActiveBox.Checked = (bool)SelectedEmployee.Active;
            else
                ActiveBox.Checked = false;

            if (SelectedEmployee.OldAwardCount != null)
                OldAwdCountBox.Value = (decimal)SelectedEmployee.OldAwardCount;
            else
                OldAwdCountBox.Value = 0;
        }

        private int GetGroupIndex(string GroupID)
        {
            int C1, Result;
            Result = -1;
            for (C1 = 0; C1 < GroupList.Count; C1++)
                if (GroupList[C1].GroupID.Equals(GroupID, StringComparison.CurrentCultureIgnoreCase))
                    Result = C1;
            return Result;
        }

        private void SaveChangesToDB()
        {
            foreach (Employee E in EmpList)
            {
                DBCommands.SaveEmployee(E);
            }
        }
    }
}
