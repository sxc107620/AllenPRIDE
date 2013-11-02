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
            //int C1;
            //for (C1 = 0; 2004 + C1 <= DateTime.Now.Year; C1++)
            //    YearBox.Items.Add((2004 + C1).ToString());
            //YearBox.Text = DateTime.Now.Year.ToString();

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
            //int YearValue = int.Parse(YearBox.SelectedItem.ToString());

            DateTime FirstDay = StartDateBox.Value;// new DateTime(YearValue, 1, 1);
            DateTime LastDay = EndDateBox.Value;// new DateTime(YearValue, 12, DateTime.DaysInMonth(YearValue, 12));

            if (SelectedAwd!= null)
            {
                string AwdID = DBCommands.GetAwardFromNomination(SelectedAwd.AwardTypeID).AwardTypeID;
                string AwdNomID = SelectedAwd.AwardTypeID;
                List<Award> AwdList = new List<Award>();

                var AwdListRaw = from Awd in DContext.Awards
                                 join Emp in DContext.Employees on Awd.RecipientID equals Emp.EmployeeID
                                 where Awd.AwardDate >= FirstDay && Awd.AwardDate <= LastDay && Awd.AwardTypeID == AwdNomID
                                 select Awd;

                var AwdListRawB = from Awd in DContext.Awards
                                  join Emp in DContext.Employees on Awd.RecipientID equals Emp.EmployeeID
                                  where Awd.AwardDate >= FirstDay && Awd.AwardDate <= LastDay && Awd.AwardTypeID == AwdID
                                  select Awd;

                var AwdListRawC = from Awd in AwdListRaw
                                  where !AwdListRawB.Select(s => s.RecipientID).Contains(Awd.RecipientID)
                                  select Awd;

                var AwardListRawD = (from A in AwdListRawC
                                    join Emp in DContext.Employees on A.RecipientID equals Emp.EmployeeID
                                    join D in DContext.Departments on Emp.DeptID equals D.DeptID
                                    join G in DContext.Groups on Emp.GroupID equals G.GroupID
                                    where A.AwardDate >= FirstDay && A.AwardDate <= LastDay
                                    orderby G.DayOfPride 
                                    select new { Emp.PreferredName, Emp.LastName, D.DeptName, G.DayOfPride  }).Distinct();

                dataGridView1.DataSource = AwardListRawD;
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

            Type_Of_Award ToA = (Type_Of_Award)AwardBox.SelectedItem;
            if (ToA != null)
            {
                Type_Of_Award  ParentAward = DBCommands.GetAwardFromNomination(ToA.AwardTypeID);
                var AwdListRaw = from Awd in DContext.Awards
                                 where Awd.AwardDate >= FirstDay && Awd.AwardDate <= LastDay && Awd.AwardTypeID == ParentAward.AwardTypeID 
                                 select Awd;

                List<Award> AwdList = new List<Award>();
                foreach (Award Awd in AwdListRaw)
                    AwdList.Add(Awd);

                frmReviewOnTheSpot form = new frmReviewOnTheSpot(ParentAward.AwardTypeName);
                form.StartThing(AwdList);
                LaunchForm(form);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Type_Of_Award ToA = (Type_Of_Award)AwardBox.SelectedItem;
            if(ToA!=null)
            LaunchForm(new frmNewAward(ToA.AwardTypeName ));
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

        private void button10_Click(object sender, EventArgs e)
        {
             Type_Of_Award SelectedAwd = (Type_Of_Award)AwardBox.SelectedItem;
            //int YearValue = int.Parse(YearBox.SelectedItem.ToString());

            DateTime FirstDay = StartDateBox.Value;// new DateTime(YearValue, 1, 1);
            DateTime LastDay = EndDateBox.Value;// new DateTime(YearValue, 12, DateTime.DaysInMonth(YearValue, 12));

            if (SelectedAwd != null)
            {
                string AwdID = DBCommands.GetAwardFromNomination(SelectedAwd.AwardTypeID).AwardTypeID;
                string AwdNomID = SelectedAwd.AwardTypeID;
                List<Award> AwdList = new List<Award>();

                var AwdListRaw = from Awd in DContext.Awards
                                 join Emp in DContext.Employees on Awd.RecipientID equals Emp.EmployeeID
                                 where Awd.AwardDate >= FirstDay && Awd.AwardDate <= LastDay && Awd.AwardTypeID == AwdNomID
                                 select Awd;

                var AwdListRawB = from Awd in DContext.Awards
                                  join Emp in DContext.Employees on Awd.RecipientID equals Emp.EmployeeID
                                  where Awd.AwardDate >= FirstDay && Awd.AwardDate <= LastDay && Awd.AwardTypeID == AwdID
                                  select Awd;

                var AwdListRawC = from Awd in AwdListRaw
                                  where !AwdListRawB.Select(s => s.RecipientID).Contains(Awd.RecipientID)
                                  select Awd;

                foreach (Award A in AwdListRawC)
                    AwdList.Add(A);

                frmReviewOnTheSpot frm = new frmReviewOnTheSpot(SelectedAwd.AwardTypeName);
                frm.StartThing(AwdList);
                LaunchForm(frm);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
