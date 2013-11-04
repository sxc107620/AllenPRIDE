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
    public partial class frmUpdateFromExcel : Form
    {
        List<Employee[]> EmpPairs;
        int SelectedIndex;

        public frmUpdateFromExcel()
        {
            InitializeComponent();
        }

        private void frmUpdateFromExcel_Load(object sender, EventArgs e)
        {
            List<Employee> EmpList = DBCommands.BuildEmployeeListFromExcel();
            EmpPairs = new List<Employee[]>();
            int C1;
            for (C1 = 0; C1 < EmpList.Count; C1++)
            {
                Employee OldEmp;
                if (DBCommands.EmployeeNeedsUpdating(EmpList[C1], out OldEmp))
                {
                    EmpPairs.Add(new Employee[2] { OldEmp,EmpList[C1]});
                }
            }

            hScrollBar1.Maximum = EmpPairs.Count + (hScrollBar1.LargeChange - 1);
            hScrollBar1.Minimum = 1;
            XofYLabel.Text = hScrollBar1.Value.ToString() + " of " + EmpPairs.Count.ToString();
            SelectedIndex = -1;
            if (EmpPairs.Count > 0)
                UpdateDataFromEmpPair(0);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void UpdateDataFromEmpPair(int Index)
        {
            UpdateDataFromEmpPair(EmpPairs[Index]);
            SelectedIndex = Index;
        }

        public void UpdateDataFromEmpPair(Employee[] EmpPair)
        {
            IDBox.Text = EmpPair[0].EmployeeID;
            NameBox.Text = EmpPair[0].ToString();
            string DeptName1 = DBCommands.GetDepartment(EmpPair[0].DeptID).DeptName;
            string DeptName2 = DBCommands.GetDepartment(EmpPair[1].DeptID).DeptName;
            DeptBoxOld.Text = DeptName1;
            DeptBoxNew.Text = DeptName2;
            TitleBoxOld.Text = EmpPair[0].Title;
            TitleBoxNew.Text = EmpPair[1].Title;
            FTEBoxOld.Text = EmpPair[0].HR_FTE.ToString();
            FTEBoxNew.Value = (decimal)EmpPair[1].HR_FTE;
            StatusBoxOld.Text = EmpPair[0].HR_Status;
            StatusBoxNew.Text = EmpPair[1].HR_Status;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (SelectedIndex >= 0)
            {
                EmpPairs[SelectedIndex][1].Title = TitleBoxNew.Text;
                EmpPairs[SelectedIndex][1].HR_FTE  = (double)FTEBoxNew.Value;
                EmpPairs[SelectedIndex][1].HR_Status = StatusBoxNew.Text;
            }
            XofYLabel.Text = hScrollBar1.Value.ToString() + " of " + EmpPairs.Count.ToString();
            UpdateDataFromEmpPair(hScrollBar1.Value-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int C1;
            for (C1 = 0; C1 < EmpPairs.Count; C1++)
            {
                if (EmpPairs[C1][0].DeptID != EmpPairs[C1][1].DeptID||EmpPairs[C1][0].Title!=EmpPairs[C1][1].Title)
                {
                    EmpPairs[C1][0].GroupID = "";
                }
                EmpPairs[C1][0].DeptID = EmpPairs[C1][1].DeptID;
                EmpPairs[C1][0].Title = EmpPairs[C1][1].Title;
                EmpPairs[C1][0].HR_FTE = EmpPairs[C1][1].HR_FTE;
                EmpPairs[C1][0].HR_Status = EmpPairs[C1][1].HR_Status;
                DBCommands.SaveEmployeeB(EmpPairs[C1][0]);
            }
            this.Close();
        }
    }
}
