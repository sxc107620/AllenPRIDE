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
    public partial class frmDayOfPRIDE : Form
    {
        List<Group> GroupList;
        DataClasses1DataContext DContext;

        public frmDayOfPRIDE()
        {
            InitializeComponent();
            DContext = DBCommands.DContext;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDayOfPRIDE_Load(object sender, EventArgs e)
        {
            /*int C1;
            for (C1 = 0; 2004 + C1 <= DateTime.Now.Year; C1++)
                YearBox.Items.Add((2004 + C1).ToString());
            YearBox.Text = DateTime.Now.Year.ToString();
            HalfBox.SelectedIndex = ((DateTime.Now.Month - 1) / 6);*/
            InitializeGroupBox();
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
            GroupNoBox.SelectedIndex = 0;
        }

        private void GroupNoBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Group grp = (Group)GroupNoBox.SelectedItem;
            string GroupNum = "";
            if (grp != null)
                GroupNum = grp.GroupNum;
            /*string Year = "", Half = "";
            if (YearBox.SelectedItem != null)
                Year = YearBox.SelectedItem.ToString();
            if (HalfBox.SelectedItem != null)
                Half = HalfBox.SelectedItem.ToString();*/

            label7.Text = "Select winner(s) for Group " + GroupNum + " from " + StartDateBox.Value.ToShortDateString() + " to " + EndDateBox.Value.ToShortDateString() + ",\n\r then click the Winner button.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmNewAward("Day of PRIDE Nomination"));
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

        private void button4_Click(object sender, EventArgs e)
        {
            //int HalfValue = HalfBox.SelectedIndex;
            //int YearValue = int.Parse(YearBox.SelectedItem.ToString());

            DateTime FirstDay = StartDateBox.Value;// new DateTime(YearValue, 6 * HalfValue + 1, 1);
            DateTime LastDay = EndDateBox.Value;// new DateTime(YearValue, 6 + 6 * HalfValue, DateTime.DaysInMonth(YearValue, 6 + 6 * HalfValue));

            Group Grp = (Group)GroupNoBox.SelectedItem;
            if (Grp != null)
            {
                string AwdID = DBCommands.GetAwardID("Day of PRIDE");
                string AwdNomID = DBCommands.GetTypeOfAward(AwdID).AwardNominationID;
                List<Award> AwdList = new List<Award>();

                var AwdListRaw = from Awd in DContext.Awards
                                 join Emp in DContext.Employees on Awd.RecipientID equals Emp.EmployeeID
                                 where Awd.AwardDate >= FirstDay && Awd.AwardDate <= LastDay && Emp.GroupID == Grp.GroupID && Awd.AwardTypeID == AwdNomID
                                 select Awd;

                var AwdListRawB = from Awd in DContext.Awards
                                  join Emp in DContext.Employees on Awd.RecipientID equals Emp.EmployeeID
                                  where Awd.AwardDate >= FirstDay && Awd.AwardDate <= LastDay && Emp.GroupID == Grp.GroupID && Awd.AwardTypeID == AwdID
                                  select Awd;

                var AwdListRawC = from Awd in AwdListRaw
                                  where !AwdListRawB.Select(s => s.RecipientID).Contains(Awd.RecipientID)
                                  select Awd;

                var AwdListRawD = (from A in AwdListRawC
                                    join Emp in DContext.Employees on A.RecipientID equals Emp.EmployeeID
                                    join D in DContext.Departments on Emp.DeptID equals D.DeptID
                                    join G in DContext.Groups on Emp.GroupID equals G.GroupID
                                    where A.AwardDate >= FirstDay && A.AwardDate <= LastDay && Emp.GroupID == Grp.GroupID
                                    select new { Emp.PreferredName, Emp.LastName, D.DeptName, G.GroupNum }).Distinct();

                dataGridView1.DataSource = AwdListRawD;
                dataGridView1.Columns[0].HeaderText = "Preferred Name";
                dataGridView1.Columns[1].HeaderText = "Last Name";
                dataGridView1.Columns[2].HeaderText = "Department Name";
                dataGridView1.Columns[3].HeaderText = "Group Number";

            }
        }

        private void StartDateBox_ValueChanged(object sender, EventArgs e)
        {
            if (StartDateBox.Value > EndDateBox.Value)
                EndDateBox.Value = StartDateBox.Value;
        }

        private void EndDateBox_ValueChanged(object sender, EventArgs e)
        {
            if (EndDateBox.Value < StartDateBox.Value)
                StartDateBox.Value = EndDateBox.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime FirstDay = StartDateBox.Value;
            DateTime LastDay = EndDateBox.Value;

            Group Grp = (Group)GroupNoBox.SelectedItem;
            if (Grp != null)
            {
                string AwdID = DBCommands.GetAwardID("Day of PRIDE");
                var AwdListRaw = from Awd in DContext.Awards
                                 join Emp in DContext.Employees on Awd.RecipientID equals Emp.EmployeeID
                                 where Awd.AwardDate >= FirstDay && Awd.AwardDate <= LastDay && Emp.GroupID == Grp.GroupID && Awd.AwardTypeID == AwdID
                                 select Awd;
                List<Award> AwdList = new List<Award>();

                foreach (Award Awd in AwdListRaw)
                    AwdList.Add(Awd);

                frmReviewOnTheSpot OTSpot = new frmReviewOnTheSpot("Day of PRIDE");
                OTSpot.StartThing(AwdList);
                LaunchForm(OTSpot);
            }
        }
    }
}
