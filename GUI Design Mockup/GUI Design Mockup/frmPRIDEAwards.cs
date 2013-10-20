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
    public partial class frmPRIDEAwards : Form
    {
        List<Type_Of_Award> AwardList;
        DataConnectionClass DContext;
        public frmPRIDEAwards()
        {
            InitializeComponent();
            DContext = DBCommands.DContext;
        }

        private void frmPRIDEAwards_Load(object sender, EventArgs e)
        {
            int C1;
            for (C1 = 0; 2004 + C1 <= DateTime.Now.Year; C1++)
                YearBox.Items.Add((2004 + C1).ToString());
            YearBox.Text = DateTime.Now.Year.ToString();

            InitializeAwardBox();
        }

        private void InitializeAwardBox()
        {
            var TypeOfAwardListRaw = from TOA in DBCommands.DContext.Type_Of_Awards
                                     where TOA.IsNomination == true
                               orderby TOA.AwardTypeID  ascending
                               select TOA;
            AwardList = new List<Type_Of_Award>();

            foreach (Type_Of_Award TOA in TypeOfAwardListRaw)
            {
                AwardList.Add(TOA);
            }

            AwardBox.DataSource = AwardList;
            AwardBox.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Type_Of_Award SelectedAwd = (Type_Of_Award)AwardBox.SelectedItem;
            int YearValue = int.Parse(YearBox.SelectedItem.ToString());

            DateTime FirstDay = new DateTime(YearValue, 1, 1);
            DateTime LastDay = new DateTime(YearValue, 12, DateTime.DaysInMonth(YearValue, 12));

            if (SelectedAwd!= null)
            {
                var AwardListRaw = (from A in DContext.Awards
                                    join Emp in DContext.Employees on A.RecipientID equals Emp.EmployeeID
                                    join D in DContext.Departments on Emp.DeptID equals D.DeptID
                                    join G in DContext.Groups on Emp.GroupID equals G.GroupID
                                    where A.AwardDate >= FirstDay && A.AwardDate <= LastDay && A.AwardTypeID == SelectedAwd.AwardTypeID 
                                    orderby G.DayOfPride 
                                    select new { Emp.PreferredName, Emp.LastName, D.DeptName, G.DayOfPride  }).Distinct();

                dataGridView1.DataSource = AwardListRaw;
                dataGridView1.Columns[0].HeaderText = "Preferred Name";
                dataGridView1.Columns[1].HeaderText = "Last Name";
                dataGridView1.Columns[2].HeaderText = "Department Name";
                dataGridView1.Columns[3].HeaderText = "Group Number";
            }
        }
    }
}
