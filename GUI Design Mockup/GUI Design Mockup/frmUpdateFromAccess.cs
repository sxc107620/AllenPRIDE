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
    public partial class frmUpdateFromAccess : Form
    {
        DataClasses1DataContext DContext;
        DataTable AwardDataTable, EmployeeDataTable, EmployeeAwardDataTable, GroupDataTable;
        public frmUpdateFromAccess()
        {
            InitializeComponent();
            DContext = new DataClasses1DataContext();
            AwardDataTable = pRIDE_beDataSet.TypeOfAward;
            EmployeeDataTable = pRIDE_beDataSet.Employee;
            EmployeeAwardDataTable = pRIDE_beDataSet.EmployeeAward;
            GroupDataTable = pRIDE_beDataSet.Groups;
        }

        private void frmUpdateFromAccess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRIDE_beDataSet.TypeOfAward' table. You can move, or remove it, as needed.
            this.typeOfAwardTableAdapter.Fill(this.pRIDE_beDataSet.TypeOfAward);
            // TODO: This line of code loads data into the 'pRIDE_beDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.pRIDE_beDataSet.Groups);
            // TODO: This line of code loads data into the 'pRIDE_beDataSet.EmployeeAward' table. You can move, or remove it, as needed.
            this.employeeAwardTableAdapter.Fill(this.pRIDE_beDataSet.EmployeeAward);
            // TODO: This line of code loads data into the 'pRIDE_beDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.pRIDE_beDataSet.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadAllDeptNames();
            LoadAllDeptNamesB();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadAllAwards();
        }

        private int NextID(string TableName)
        {
            //var matchedproduct = db.GetTable<product>().SingleOrDefault(p =>p.ProductID==productID);
            var NextId = DContext.GetTable<NextID>().SingleOrDefault(p => p.TableName == TableName);
            int result = (int)NextId.NextNum;
            NextId.NextNum++;
            DContext.SubmitChanges();
            return result;
        }

        private string GetAwardNominationID(string AwardName)
        {
            string result = "";
            var AwdNomination = DContext.GetTable<Type_Of_Award>().SingleOrDefault(p => p.AwardTypeName == AwardName);
            if (AwdNomination != null)
                result = AwdNomination.AwardTypeID;
            return result;
        }

        private string GetDeptID(string DeptName)
        {
            string result = "";
            var DptVar = DContext.GetTable<Department>().SingleOrDefault(p => p.DeptName == DeptName);
            if (DptVar != null)
                result = DptVar.DeptID;
            return result;
        }

        private string GetGroupID(string GroupName)
        {
            string result = "";
            var DptVar = DContext.GetTable<Group>().SingleOrDefault(p => p.GroupNum == GroupName);
            if (DptVar != null)
                result = DptVar.GroupID;
            return result;
        }

        private string GetAwardID(string AwardName)
        {
            string result = "";
            var AwdVar = DContext.GetTable<Type_Of_Award>().SingleOrDefault(p => p.AwardTypeName == AwardName);
            if (AwdVar != null)
                result = AwdVar.AwardTypeID;
            return result;
        }

        private bool GetAwardExists(string AwardID)
        {
            var AwdVar = DContext.GetTable<Award>().SingleOrDefault(p => p.AwardID == AwardID);
            return AwdVar!=null;
        }

        private string GetEmployeeID(string PreferredName, string LastName)
        {
            string result = "";
            var EmpVar = DContext.GetTable<Employee>().SingleOrDefault(p => p.PreferredName==PreferredName && p.LastName==LastName);
            if (EmpVar != null)
                result = EmpVar.EmployeeID;
            return result;
        }

        private List<DataRow> GetAwards(string AwType)
        {
            var NominationRowsRaw = from N in AwardDataTable.AsEnumerable()
                                    where N.Field<string>(2).Equals(AwType, StringComparison.CurrentCultureIgnoreCase)
                                    select N;
            List<DataRow> NominationRows = new List<DataRow>();
            foreach (DataRow DR in NominationRowsRaw)
                NominationRows.Add(DR);

            return NominationRows;
        }

        private void LoadNominationsIntoTable()
        {
            List<DataRow> NominationRows = GetAwards("Nomination");
            int C1, NextNum;
            Type_Of_Award ToA;
            List<Type_Of_Award> ToAList = new List<Type_Of_Award>();
            for (C1 = 0; C1 < NominationRows.Count; C1++)
            {
                ToA = new Type_Of_Award();
                NextNum = NextID("Type_Of_Award");
                ToA.AwardTypeID = "TOA" + NextNum.ToString("0000000");
                ToA.AwardTypeName = NominationRows[C1][0].ToString();
                if (GetAwardID(ToA.AwardTypeName).Equals(""))
                {
                    ToA.IsNomination = true;
                    ToA.Frequency = NominationRows[C1][3].ToString();
                    ToAList.Add(ToA);
                }
            }

            foreach (Type_Of_Award TA in ToAList)
            {
                DContext.Type_Of_Awards.InsertOnSubmit(TA);
            }
            try
            {
                MessageBox.Show(DContext.GetChangeSet().Updates.Count.ToString());
                DContext.SubmitChanges();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void LoadAwardsIntoTable()
        {
            List<DataRow> NominationRows = GetAwards("Award");
            int C1, NextNum;
            Type_Of_Award ToA;
            List<Type_Of_Award> ToAList = new List<Type_Of_Award>();
            for (C1 = 0; C1 < NominationRows.Count; C1++)
            {
                ToA = new Type_Of_Award();
                NextNum = NextID("Type_Of_Award");
                ToA.AwardTypeID = "TOA" + NextNum.ToString("0000000");
                ToA.AwardTypeName = NominationRows[C1][0].ToString();
                if (GetAwardID(ToA.AwardTypeName).Equals(""))
                {
                    ToA.IsNomination = false;
                    ToA.Frequency = NominationRows[C1][3].ToString();
                    ToA.AwardNominationID = GetAwardNominationID(NominationRows[C1][4].ToString());
                    ToAList.Add(ToA);
                }
            }

            foreach (Type_Of_Award TA in ToAList)
            {
                DContext.Type_Of_Awards.InsertOnSubmit(TA);
            }
            try
            {
                DContext.SubmitChanges();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void LoadAllDeptNames()
        {
            var StringListRaw = (from S in EmployeeDataTable.AsEnumerable()
                                 where S.Field<string>(8)!=null
                                 select S.Field<string>(8).ToUpper()).Distinct<string>();

            List<String> StringList = new List<String>();
            List<Department> DeptList = new List<Department>();

            Department dept = new Department();
            int NextNum;
            foreach (string S in StringListRaw)
            {
                StringList.Add(S);
                dept = new Department();
                if (GetDeptID(S) == "")
                {
                    dept.DeptName = S;
                    NextNum = NextID("Department");
                    dept.DeptID = "DPT" + NextNum.ToString("0000000");
                    DeptList.Add(dept);
                }
            }
            foreach (Department D in DeptList)
                DContext.Departments.InsertOnSubmit(D);
            try
            {
                DContext.SubmitChanges();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void LoadAllDeptNamesB()
        {
            var StringListRaw = (from S in EmployeeAwardDataTable.AsEnumerable()
                                 where S.Field<string>(15) != null
                                 select S.Field<string>(15).ToUpper()).Distinct<string>();

            List<String> StringList = new List<String>();
            List<Department> DeptList = new List<Department>();

            Department dept = new Department();
            int NextNum;
            foreach (string S in StringListRaw)
            {
                StringList.Add(S);
                dept = new Department();
                if (GetDeptID(S) == "")
                {
                    dept.DeptName = S;
                    NextNum = NextID("Department");
                    dept.DeptID = "DPT" + NextNum.ToString("0000000");

                    DeptList.Add(dept);
                }
            }
            foreach (Department D in DeptList)
                DContext.Departments.InsertOnSubmit(D);
            try
            {
                DContext.SubmitChanges();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void LoadAllEmployees()
        {
            int C1;
            List<Employee> EmployeeList = new List<Employee>();
            Employee TempEmp;
            int NextNum;
            DataRow DR;
            for (C1 = 0; C1 < EmployeeDataTable.Rows.Count; C1++)
            {
                DR = EmployeeDataTable.Rows[C1];
                TempEmp = new Employee();
                NextNum = (int)DR[0];
                TempEmp.EmployeeID = "EMP" + NextNum.ToString("0000000");
                TempEmp.FirstName = DR[1].ToString();
                TempEmp.LastName = DR[2].ToString();
                if (DR[3].ToString().Length > 0)
                    TempEmp.MiddleInitial = DR[3].ToString()[0];
                TempEmp.Title = DR[4].ToString();
                TempEmp.GroupID = GetGroupID(DR[5].ToString());
                if (DR[6].ToString().Length > 0)
                    TempEmp.HR_FTE = double.Parse(DR[6].ToString());
                TempEmp.IsDirector = DR[7].ToString().Equals("x", StringComparison.CurrentCultureIgnoreCase);
                TempEmp.DeptID = GetDeptID(DR[8].ToString());
                if (DR[9].ToString().Length > 0)
                    TempEmp.HireDate = DateTime.Parse(DR[9].ToString());
                TempEmp.HR_Status = DR[10].ToString();
                TempEmp.EmployeeStatusCode = DR[11].ToString();
                TempEmp.PreferredName = DR[12].ToString();
                TempEmp.Active = (bool)DR[13];
                TempEmp.PrideEligible = (bool)DR[14];
                if (DR[15].ToString().Length > 0)
                    TempEmp.OldAwardCount = (int)(double)DR[15];
                TempEmp.DeptRecord = (bool)DR[16];
                TempEmp.DateLastUpdated = DateTime.Today;
                if(GetEmployeeID(TempEmp.PreferredName,TempEmp.LastName).Equals(""))
                EmployeeList.Add(TempEmp);
            }

            foreach (Employee Emp in EmployeeList)
                DContext.Employees.InsertOnSubmit(Emp);

            try
            {
                DContext.SubmitChanges();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void LoadAllAwards()
        {
            int C1;
            List<Award> AwardList = new List<Award>();
            Award TempAwd;
            int NextNum;
            DataRow DR;
            for (C1 = 0; C1 < EmployeeAwardDataTable.Rows.Count; C1++)
            {
                DR = EmployeeAwardDataTable.Rows[C1];
                TempAwd = new Award();
                NextNum = (int)DR[0];
                TempAwd.AwardID = "AWD" + NextNum.ToString("0000000");
                if (!GetAwardExists(TempAwd.AwardID))
                {
                    TempAwd.AwardDate = (DateTime)DR[1];
                    TempAwd.AwardTypeID = GetAwardID(DR[2].ToString());
                    NextNum = (int)DR[3];
                    TempAwd.RecipientID = "EMP" + NextNum.ToString("0000000");
                    NextNum = (int)DR[8];
                    TempAwd.NominatorID = "EMP" + NextNum.ToString("0000000");
                    TempAwd.Notes = DR[13].ToString();
                    TempAwd.AwardDeptID = GetDeptID(DR[15].ToString());
                    AwardList.Add(TempAwd);
                }
            }

            foreach (Award Awd in AwardList)
                DContext.Awards.InsertOnSubmit(Awd);

            try
            {
                MessageBox.Show(DContext.GetChangeSet().Inserts.Count.ToString());
                DContext.SubmitChanges();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
