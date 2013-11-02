using Microsoft.Reporting.WinForms;
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
    public partial class frmMonthlyStats : Form
    {
        DataSet ds;
        int groupNum = 0;
        public frmMonthlyStats()
        {
            InitializeComponent();
        }

        private void frmMonthlyStats_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        /*
         * The general process for creating a report is as follows (Assuming the report is like a table):
         * Identify each column
         * Create a data-member only class (no functions), one member for each column in the table
         * Create a Data Source from that object (Data Sources -> Add New -> From Object -> Your Class)
         * I'm using classStatsReport.cs for this
         * Create a DataSet object
         * Fill the DataSet object with the necessary data
         * Create your rdlc report
         * Associate the Data Source you previously created with it (In the reportviewer_Load function/Event Handler)
         * Create a ReportDataSource object from your DataSet object (It can only use one of the DataSet's tables)
         * Add the ReportDataSource to your report
         * Use the GUI designer to lay out your report. It's fairly intuitive.
         * Subreports complicate things slightly.
         */
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //Clear the defaults from the report
            reportViewer1.Reset();
            reportViewer1.LocalReport.DataSources.Clear();

            //Tell the viewer which report we're using
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_Design_Mockup.MonthlyStatsReport.rdlc";
            //Generate a DataSet
            ds = generateDataSet();
            DataConnectionClass dc = DBCommands.DContext;
            var GroupList = from s in dc.Groups
                            orderby s.GroupNum
                            select s;
            GroupList = GroupList.OrderBy(s => s.GroupID);
            //foreach (var q in GroupList)
            //{
            //    this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler); 
            //}
            //Process the subreport. I'm pretty sure the loop above is necessary rather than the line below
            //But I just can't make it work
            this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
            //This line is irrelevant and just so the larger report has a dataset (Which may or may not be necessary)
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StatsReportDataSet", ds.Tables[0]));
            reportViewer1.RefreshReport();   
        }

        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            //Generate the RDS from the dataset we generate elsewhere
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "StatsReportDataSet"; //Must exactly match the Dataset name in the actual report
            //Set the datasource to the appropriate table.
            //Using the groupNum int to choose which group table to grab
            rds.Value = ds.Tables[groupNum];
            groupNum++;
            //MessageBox.Show(groupNum.ToString()); //Verified to run 15 times (Meaning this function runs 15 times, once for each group)
            e.DataSources.Add(rds);
            //foreach (var q in ds.Tables)
            //{
            //    rds.Value = ds;
            //    e.DataSources.Add(rds);
            //}
        }

        DataSet generateDataSet()
        {
            DataSet ds = new DataSet("StatsReportDataSet");
            DateTime StartDate = DateTime.Parse("2/1/2013"); //Should adjust these to parameters based on
            DateTime EndDate = DateTime.Parse("2/28/2013"); //The date pickers on the main menu
            Object[] data = new Object[7]; //Stores a row of data
            DataConnectionClass dc = DBCommands.DContext;
            //Get the group and department list
            var GroupList = from s in dc.Groups
                            orderby s.GroupNum
                            select s;
            var DeptList = from s in dc.Departments
                           select s;
            GroupList = GroupList.OrderBy(s => s.GroupID);
            foreach (var q in GroupList)
            {
                //Add a table to the dataset for this group
                ds.Tables.Add(q.GroupNum);
                ds.Tables[q.GroupNum].Columns.Add("groupNum");
                ds.Tables[q.GroupNum].Columns.Add("Department");
                ds.Tables[q.GroupNum].Columns.Add("numEmployees");
                ds.Tables[q.GroupNum].Columns.Add("numAwardsReceived");
                ds.Tables[q.GroupNum].Columns.Add("numEmployeesReceived");
                ds.Tables[q.GroupNum].Columns.Add("numAwardsGiven");
                ds.Tables[q.GroupNum].Columns.Add("numEmployeesGiven");
                var EmpsInGroup = from s in dc.Employees
                                  where s.GroupID == q.GroupID
                                  select s;
                var DeptIDs = from s in dc.Employees
                              where s.GroupID == q.GroupID
                              select s.DeptID;
                //Get the departments in the group by comparing department IDs
                var DeptsInGroup = from s in dc.Departments
                                   where DeptIDs.Contains(s.DeptID)
                                   select s;
                foreach (var p in DeptsInGroup)
                {
                    data[0] = q.GroupNum;
                    data[1] = p.DeptName;
                    var EmpsInDept = from s in dc.Employees //Select all employees in department that are in the group
                                     where s.DeptID == p.DeptID && s.Active == true && s.GroupID == q.GroupID
                                     select s; //There are some departments that are split iirc, this accounts for that
                    data[2] = EmpsInDept.Count(); //Count = # of Employees
                    if ((int)data[2] < 1) continue;
                    var EmpIDs = from s in EmpsInDept //Get the list of Employee IDs within the department
                                 select s.EmployeeID;
                    var AwardsReceived = from s in dc.Awards //Find all awards received by an employee in this department
                                         where EmpIDs.Contains(s.RecipientID) && (s.AwardDate >= (DateTime?)StartDate) && (s.AwardDate <= (DateTime?)EndDate)
                                         select s.RecipientID; //Select just this so we can Distinct them easily
                    data[3] = AwardsReceived.Count(); //Number of awards received by this department
                    data[4] = AwardsReceived.Distinct().Count(); //Number of distinct employees receiving awards
                    var AwardsGiven = from s in dc.Awards //Find all awards given by an employee in this department
                                      where EmpIDs.Contains(s.NominatorID) && (s.AwardDate >= (DateTime?)StartDate) && (s.AwardDate <= (DateTime?)EndDate)
                                      select s.NominatorID;
                    data[5] = AwardsGiven.Count(); //Same as awards received
                    data[6] = AwardsGiven.Distinct().Count();
                    ds.Tables[q.GroupNum].Rows.Add(data); //Add the object vector to the table.
                }
            }
            return ds;
        }
    }
}
