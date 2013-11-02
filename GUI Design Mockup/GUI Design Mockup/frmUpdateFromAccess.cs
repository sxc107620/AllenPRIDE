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
        DataConnectionClass DContext;
        DataTable AwardDataTable, EmployeeDataTable, EmployeeAwardDataTable, GroupDataTable;

        public frmUpdateFromAccess()
        {
            InitializeComponent();
            DContext = DBCommands.DContext;
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
            ImportIDs();
            ImportGroups();
            ImportAwardTypes();
            //LoadAllEmployees();
            //LoadAllAwards();
            MessageBox.Show("Done doing whatever this button does today!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadAllDeptNames();
            LoadAllEmployees();
            LoadAllAwards();
            //LoadAllDeptNames();
            MessageBox.Show("Done doing whatever this button does today!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //LoadAllEmployees();
            MessageBox.Show("Done doing whatever this button does today!");
        }

        private void ImportIDs()
        {
            string Temp;
            NextID ID;
            List<NextID> NIds = new List<NextID>();
            string[] Pieces;
            System.IO.StreamReader SRead = new System.IO.StreamReader("IDTypes.txt");
            while (!SRead.EndOfStream)
            {
                Temp = SRead.ReadLine();
                ID = new NextID();
                Pieces = Temp.Split(',');
                if (Pieces.Length == 3)
                {
                    ID.TableName = Pieces[0];
                    ID.NextNum = int.Parse(Pieces[1]);
                    ID.Prefix = Pieces[2];
                    NIds.Add(ID);
                }
            }
            foreach (NextID NID in NIds)
            {
                DContext.NextIDs.InsertOnSubmit(NID);
            }
            DContext.SubmitChanges();
        }

        private void ImportGroups()
        {
            string Temp;
            Group G;
            List<Group> Groups = new List<Group>();
            string[] Pieces;
            System.IO.StreamReader SRead = new System.IO.StreamReader("Groups.txt");
            while (!SRead.EndOfStream)
            {
                Temp = SRead.ReadLine();
                G = new Group();
                Pieces = Temp.Split(',');
                if (Pieces.Length == 3)
                {
                   G.GroupID= Pieces[0];
                    G.GroupNum  = Pieces[1];
                    G.DayOfPride = Pieces[2][0];
                    Groups.Add(G);
                }
            }
            foreach (Group Gr in Groups)
            {
                DContext.Groups.InsertOnSubmit(Gr);
            }
            DContext.SubmitChanges();
        }

        private void ImportAwardTypes()
        {
            string Temp;
            Type_Of_Award TOA;
            List<Type_Of_Award > TOAs= new List<Type_Of_Award>();
            string[] Pieces;
            System.IO.StreamReader SRead = new System.IO.StreamReader("AwardTypes.txt");
            while (!SRead.EndOfStream)
            {
                Temp = SRead.ReadLine();
                TOA = new Type_Of_Award();
                Pieces = Temp.Split(',');
                if (Pieces.Length == 5)
                {
                    TOA.AwardTypeID = Pieces[0];
                    TOA.AwardTypeName= Pieces[1];
                    TOA.IsNomination = bool.Parse(Pieces[2]);
                    TOA.Frequency = Pieces[3];
                    TOA.AwardNominationID = Pieces[4];
                    TOAs.Add(TOA);
                }
            }
            foreach (Type_Of_Award A in TOAs)
            {
                DContext.Type_Of_Awards.InsertOnSubmit(A);
            }
            DContext.SubmitChanges();
        }

        private void ExtractAllNextIDs()
        {
            var IDs = from ID in DContext.NextIDs
                      select ID;
            System.IO.StreamWriter SWrite = new System.IO.StreamWriter("IDTypes.txt");
            foreach (NextID ID in IDs)
            {
                SWrite.WriteLine(ID.TableName+","+ID.NextNum.ToString()+","+ID.Prefix );
            }
            SWrite.Close();
        }

        private void ExtractAllAwardTypes()
        {
            //NOTE: Do not use, built for pulling data to give to Scott
            var Stuff = from TOA in DContext.Type_Of_Awards
                        select TOA;

            System.IO.StreamWriter SWrite = new System.IO.StreamWriter("AwardTypes.txt");
            foreach (Type_Of_Award TOA in Stuff)
            {
                SWrite.WriteLine(TOA.AwardTypeID + "," + TOA.AwardTypeName + "," + TOA.IsNomination.ToString() + "," + TOA.Frequency.ToArray() + "," + TOA.AwardNominationID);
            }
            SWrite.Close();
        }
        private void ExtractAllGroups()
        {
            //NOTE: Do not use, built for pulling data to give to Scott
            var Stuff = from TOA in DContext.Groups
                        select TOA;

            System.IO.StreamWriter SWrite = new System.IO.StreamWriter("Groups.txt");
            foreach (Group G in Stuff)
            {
                SWrite.WriteLine(G.GroupID+","+G.GroupNum+","+G.DayOfPride.ToString());
            }
            SWrite.Close();
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

        private void LoadAllNominationTypes()
        {
            List<DataRow> NominationRows = GetAwards("Nomination");
            int C1;//, NextNum;
            Type_Of_Award ToA;
            List<Type_Of_Award> ToAList = new List<Type_Of_Award>();
            for (C1 = 0; C1 < NominationRows.Count; C1++)
            {
                ToA = new Type_Of_Award();
                ToA.AwardTypeID = DBCommands.NextID("Type_Of_Award");
                ToA.AwardTypeName = NominationRows[C1][0].ToString();
                if (DBCommands.GetAwardID(ToA.AwardTypeName).Equals(""))
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

        private void LoadAllAwardTypes()
        {
            List<DataRow> NominationRows = GetAwards("Award");
            int C1;
            Type_Of_Award ToA;
            List<Type_Of_Award> ToAList = new List<Type_Of_Award>();
            for (C1 = 0; C1 < NominationRows.Count; C1++)
            {
                ToA = new Type_Of_Award();
                ToA.AwardTypeID = DBCommands.NextID("Type_Of_Award");
                ToA.AwardTypeName = NominationRows[C1][0].ToString();
                if (DBCommands.GetAwardID(ToA.AwardTypeName).Equals(""))
                {
                    ToA.IsNomination = false;
                    ToA.Frequency = NominationRows[C1][3].ToString();
                    ToA.AwardNominationID = DBCommands.GetAwardID(NominationRows[C1][4].ToString());
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
            foreach (string S in StringListRaw)
            {
                StringList.Add(S);
                dept = new Department();
                if (DBCommands.GetDeptID(S) == "")
                {
                    dept.DeptName = S;
                    dept.DeptID = DBCommands.NextID("Department");
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
            foreach (string S in StringListRaw)
            {
                StringList.Add(S);
                dept = new Department();
                if (DBCommands.GetDeptID(S) == "")
                {
                    dept.DeptName = S;
                    dept.DeptID= DBCommands.NextID("Department");

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
                TempEmp.GroupID = DBCommands.GetGroupID(DR[5].ToString());
                if (DR[6].ToString().Length > 0)
                    TempEmp.HR_FTE = double.Parse(DR[6].ToString());
                TempEmp.IsDirector = DR[7].ToString().Equals("x", StringComparison.CurrentCultureIgnoreCase);
                TempEmp.DeptID = DBCommands.GetDeptID(DR[8].ToString());
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
                if (DBCommands.GetEmployeeID(TempEmp.PreferredName, TempEmp.LastName).Equals(""))
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
                if (!DBCommands.GetAwardExists(TempAwd.AwardID))
                {
                    TempAwd.AwardDate = (DateTime)DR[1];
                    TempAwd.AwardTypeID = DBCommands.GetAwardID(DR[2].ToString());
                    NextNum = (int)DR[3];
                    TempAwd.RecipientID = "EMP" + NextNum.ToString("0000000");
                    NextNum = (int)DR[8];
                    TempAwd.NominatorID = "EMP" + NextNum.ToString("0000000");
                    TempAwd.Notes = DR[13].ToString();
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
