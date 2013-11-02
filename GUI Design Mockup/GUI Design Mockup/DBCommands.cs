using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI_Design_Mockup
{
    class DBCommands
    {
        public static DataConnectionClass DContext;

        public static Employee GetEmployee(string EmpID)
        {
            Employee  result = null;
            var TempEmp = DContext.GetTable<Employee>().SingleOrDefault(p => p.EmployeeID == EmpID);
            if (TempEmp != null)
                result = TempEmp;
            return result;
        }

        public static Department GetDepartment(string DeptID)
        {
            Department result = null;
            var TempEmp = DContext.GetTable<Department>().SingleOrDefault(p => p.DeptID == DeptID);
            if (TempEmp != null)
                result = TempEmp;
            return result;
        }

        /*public static string GetAwardNominationID(string AwardName)
        {
            string result = "";
            var AwdNomination = DContext.GetTable<Type_Of_Award>().SingleOrDefault(p => p.AwardTypeName == AwardName);
            if (AwdNomination != null)
                result = AwdNomination.AwardTypeID;
            return result;
        }*/

        public static string GetDeptID(string DeptName)
        {
            string result = "";
            var DptVar = DContext.GetTable<Department>().SingleOrDefault(p => p.DeptName == DeptName);
            if (DptVar != null)
                result = DptVar.DeptID;
            return result;
        }

        public static string GetOrCreateDeptID(string DeptName)
        {
            string result = GetDeptID(DeptName);
            if (result == "")
            {
                Department NewDept = new Department();
                NewDept.DeptName = DeptName;
                NewDept.DeptID = NextID("Department");
                result = NewDept.DeptID;
                DContext.Departments.InsertOnSubmit(NewDept);
                DContext.SubmitChanges();
            }
            return result;
        }

        public static string GetGroupID(string GroupName)
        {
            string result = "";
            var DptVar = DContext.GetTable<Group>().SingleOrDefault(p => p.GroupNum == GroupName);
            if (DptVar != null)
                result = DptVar.GroupID;
            return result;
        }

        public static string GetAwardID(string AwardName)
        {
            string result = "";
            var AwdVar = DContext.GetTable<Type_Of_Award>().SingleOrDefault(p => p.AwardTypeName == AwardName);
            if (AwdVar != null)
                result = AwdVar.AwardTypeID;
            return result;
        }

        public static Type_Of_Award GetTypeOfAward(string AwardID)
        {
            var AwdVar = DContext.GetTable<Type_Of_Award>().SingleOrDefault(p => p.AwardTypeID == AwardID);
            if (AwdVar != null)
                return AwdVar;
            else 
                return null;
        }

        public static Type_Of_Award GetAwardFromNomination(string NominationID)
        {
            var AwdVar = DContext.GetTable<Type_Of_Award>().SingleOrDefault(p => p.AwardNominationID == NominationID);
            if (AwdVar != null)
                return AwdVar;
            else
                return null;
        }

        public static bool GetAwardExists(string AwardID)
        {
            var AwdVar = DContext.GetTable<Award>().SingleOrDefault(p => p.AwardID == AwardID);
            return AwdVar != null;
        }

        public static bool GetEmployeeExists(string FirstName, char? MiddleInitial, string LastName)
        {
            if (MiddleInitial != null)
            {
                var TempEmp = DContext.GetTable<Employee>().FirstOrDefault(p => p.FirstName == FirstName && p.MiddleInitial == MiddleInitial && p.LastName == LastName);
                return TempEmp != null;
            }
            else
            {
                var TempEmp = DContext.GetTable<Employee>().FirstOrDefault(p => p.FirstName == FirstName && p.LastName == LastName);
                return TempEmp != null;
            }
        }

        public static string GetEmployeeID(string PreferredName, string LastName)
        {
            string result = "";
            var EmpVar = DContext.GetTable<Employee>().SingleOrDefault(p => p.PreferredName == PreferredName && p.LastName == LastName);
            if (EmpVar != null)
                result = EmpVar.EmployeeID;
            return result;
        }

        public static string NextID(string TableName)
        {
            var NextId = DBCommands.DContext.GetTable<NextID>().SingleOrDefault(p => p.TableName == TableName);
            int result = (int)NextId.NextNum;
            NextId.NextNum++;
            DBCommands.DContext.SubmitChanges();
            string ResultStr = NextId.Prefix + result.ToString("0000000");
           return ResultStr;
        }

        public static List<Employee> GetNewEmployeesList()
        {
            List<Employee> EmpList = new List<Employee>();
            var EmpListRaw = from E in DContext.Employees
                             where E.GroupID==""
                             select E;
            foreach(Employee E in EmpListRaw)
                EmpList.Add(E);
            return EmpList;
        }

        public static void SaveEmployee(Employee Emp)
        {
            var EmpVal = DContext.GetTable<Employee>().SingleOrDefault(p => p.EmployeeID == Emp.EmployeeID );
            if (EmpVal != null)
            {
                EmpVal.PreferredName = Emp.PreferredName;
                EmpVal.GroupID = Emp.GroupID;
                EmpVal.PrideEligible = Emp.PrideEligible;
                EmpVal.Active = Emp.Active;
                EmpVal.OldAwardCount = Emp.OldAwardCount;
                DContext.SubmitChanges();
            }
        }

        public static void DeactivateEmployee(Employee Emp)
        {
            var EmpVal = DContext.GetTable<Employee>().SingleOrDefault(p => p.EmployeeID == Emp.EmployeeID);
            if (EmpVal != null)
            {
                EmpVal.Active = false;
                DContext.SubmitChanges();
            }
        }

        public static List<Employee> BuildEmployeeListFromExcel()
        {
            List<Employee> ExcelEmpList = new List<Employee>();
            List<Employee> NewEmpList = new List<Employee>();
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.DefaultExt = "*.xls";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                Excel.Application oXL = new Excel.Application();
                oXL.Visible = false;
                Excel.Workbook oWB = oXL.Workbooks.Open(OFD.FileName);
                Excel.Worksheet oSheet = oWB.ActiveSheet;
                Excel.Range rng;
                int C1 = 2;
                Employee tempEmp;
                Excel.Range last = oSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                Excel.Range range = oSheet.get_Range("A1", last);
                int lastUsedRow = last.Row;
                int lastUsedColumn = last.Column;
                for (C1 = 2; C1 <= lastUsedRow; C1++)
                {
                    tempEmp = new Employee();
                    rng = oSheet.Cells[C1, 1] as Excel.Range;
                    tempEmp.DeptID = DBCommands.GetOrCreateDeptID(rng.Value2.ToString());
                    rng = oSheet.Cells[C1, 2] as Excel.Range;
                    tempEmp.Title = rng.Value2.ToString();
                    rng = oSheet.Cells[C1, 3] as Excel.Range;
                    tempEmp.HR_Status = rng.Value2.ToString();
                    rng = oSheet.Cells[C1, 4] as Excel.Range;
                    tempEmp.LastName = rng.Value2;
                    rng = oSheet.Cells[C1, 5] as Excel.Range;
                    tempEmp.FirstName = rng.Value2;
                    rng = oSheet.Cells[C1, 6] as Excel.Range;
                    if (rng.Value2.ToString().Length > 0)
                        tempEmp.MiddleInitial = rng.Value2.ToString()[0];
                    rng = oSheet.Cells[C1, 7] as Excel.Range;
                    tempEmp.HireDate = (DateTime)rng.get_Value();
                    rng = oSheet.Cells[C1, 8] as Excel.Range;
                    tempEmp.HR_FTE = (double)rng.get_Value();
                    rng = oSheet.Cells[C1, 9] as Excel.Range;
                    tempEmp.EmployeeStatusCode = rng.Value2.ToString();

                    ExcelEmpList.Add(tempEmp);
                }
            }
            return ExcelEmpList;
        }

        public static void LoadNewEmployees()
        {
            List<Employee> ExcelEmpList = new List<Employee>();
            List<Employee> NewEmpList = new List<Employee>();
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.DefaultExt = "*.xls";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                Excel.Application oXL = new Excel.Application();
                oXL.Visible = false;
                Excel.Workbook oWB = oXL.Workbooks.Open(OFD.FileName);
                Excel.Worksheet oSheet = oWB.ActiveSheet;
                Excel.Range rng;
                int C1 = 2;
                Employee tempEmp;
                Excel.Range last = oSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                Excel.Range range = oSheet.get_Range("A1", last);
                int lastUsedRow = last.Row;
                int lastUsedColumn = last.Column;
                for (C1 = 2; C1 <= lastUsedRow; C1++)
                {
                    tempEmp = new Employee();
                    rng = oSheet.Cells[C1, 1] as Excel.Range;
                    tempEmp.DeptID = DBCommands.GetOrCreateDeptID(rng.Value2.ToString());
                    rng = oSheet.Cells[C1, 2] as Excel.Range;
                    tempEmp.Title = rng.Value2.ToString();
                    rng = oSheet.Cells[C1, 3] as Excel.Range;
                    tempEmp.HR_Status = rng.Value2.ToString();
                    rng = oSheet.Cells[C1, 4] as Excel.Range;
                    tempEmp.LastName = rng.Value2;
                    rng = oSheet.Cells[C1, 5] as Excel.Range;
                    tempEmp.FirstName = rng.Value2;
                    rng = oSheet.Cells[C1, 6] as Excel.Range;
                    if (rng.Value2.ToString().Length > 0)
                        tempEmp.MiddleInitial = rng.Value2.ToString()[0];
                    rng = oSheet.Cells[C1, 7] as Excel.Range;
                    tempEmp.HireDate = (DateTime)rng.get_Value();
                    rng = oSheet.Cells[C1, 8] as Excel.Range;
                    tempEmp.HR_FTE = (double)rng.get_Value();
                    rng = oSheet.Cells[C1, 9] as Excel.Range;
                    tempEmp.EmployeeStatusCode = rng.Value2.ToString();

                    ExcelEmpList.Add(tempEmp);
                }

                foreach (Employee E in ExcelEmpList)
                    if (!DBCommands.GetEmployeeExists(E.FirstName, E.MiddleInitial, E.LastName))
                    {
                         E.EmployeeID = NextID("Employee");
                         NewEmpList.Add(E);
                    }

                foreach (Employee E in NewEmpList)
                {
                    DContext.Employees.InsertOnSubmit(E);
                }

                DBCommands.DContext.SubmitChanges();
            }
        }
    }
}
