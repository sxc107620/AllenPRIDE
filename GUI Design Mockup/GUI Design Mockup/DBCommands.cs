using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static string GetAwardNominationID(string AwardName)
        {
            string result = "";
            var AwdNomination = DContext.GetTable<Type_Of_Award>().SingleOrDefault(p => p.AwardTypeName == AwardName);
            if (AwdNomination != null)
                result = AwdNomination.AwardTypeID;
            return result;
        }

        public static string GetDeptID(string DeptName)
        {
            string result = "";
            var DptVar = DContext.GetTable<Department>().SingleOrDefault(p => p.DeptName == DeptName);
            if (DptVar != null)
                result = DptVar.DeptID;
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

        public static bool GetAwardExists(string AwardID)
        {
            var AwdVar = DContext.GetTable<Award>().SingleOrDefault(p => p.AwardID == AwardID);
            return AwdVar != null;
        }

        public static string GetEmployeeID(string PreferredName, string LastName)
        {
            string result = "";
            var EmpVar = DContext.GetTable<Employee>().SingleOrDefault(p => p.PreferredName == PreferredName && p.LastName == LastName);
            if (EmpVar != null)
                result = EmpVar.EmployeeID;
            return result;
        }
    }
}
