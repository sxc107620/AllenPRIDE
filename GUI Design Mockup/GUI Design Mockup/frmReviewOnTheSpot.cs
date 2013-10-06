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
    public partial class frmReviewOnTheSpot : Form
    {
        List<Award> AwdList;
        List<Department> DeptList;
        List<Employee> EmpList;
        List<Employee> EmpListA;
        DataConnectionClass DContext;

        Award SelectedAward;

        public frmReviewOnTheSpot(string AwardName = "On The Spot")
        {
            InitializeComponent();
            DContext = DBCommands.DContext;
            AwdList = new List<Award>();
            panel2.Enabled = true;
            textBox3.Text = AwardName;
            label1.Text = AwardName + " Award";
            Text = "Review "+AwardName + " Awards";
        }

        private void frmReviewOnTheSpot_Load(object sender, EventArgs e)
        {

        }

        public void StartThing(List<Award> AwdListB)
        {
            foreach (Award A in AwdListB)
                AwdList.Add(A);

            hScrollBar1.Maximum = AwdList.Count + (hScrollBar1.LargeChange - 1);
            hScrollBar1.Minimum = 1;
            XofYLabel.Text = hScrollBar1.Value.ToString() + " of " + AwdList.Count;
            if(AwdList.Count>0)
            LoadDataForAward(0);
        }

        public void LoadDataForAward(int Index)
        {
         SelectedAward = AwdList[Index];
            NoteBox.Text = SelectedAward.Notes;
            Employee NomEmp = DBCommands.GetEmployee(SelectedAward.NominatorID);
            Employee RecEmp = DBCommands.GetEmployee(SelectedAward.RecipientID);
            Department NomDept;
            if (NomEmp != null)
            {
                NominatorBox.Text = NomEmp.ToString();
                NomDept = DBCommands.GetDepartment(NomEmp.DeptID);
                if (NomDept != null)
                    DepartmentBox.Text = NomDept.ToString();
            }
            if (RecEmp != null)
                RecipientBox.Text = RecEmp.ToString();
            dateTimePicker1.Value = (DateTime)SelectedAward.AwardDate;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int SelectedIndex = hScrollBar1.Value;
            XofYLabel.Text = SelectedIndex.ToString() + " of " + AwdList.Count.ToString();
            LoadDataForAward(SelectedIndex-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoteBox.Text = SelectedAward.Notes;
            dateTimePicker1.Value = (DateTime)SelectedAward.AwardDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Awd = DContext.Awards.Single(x => x.AwardID == SelectedAward.AwardID);
            Awd.Notes = NoteBox.Text;
            Awd.AwardDate = dateTimePicker1.Value;
            DContext.SubmitChanges();
            MessageBox.Show("Changes saved");
            /*using (var ctx = new FooContext())
            {
                var obj = ctx.Bars.Single(x => x.Id == id);
                obj.SomeProp = 123;
                ctx.SubmitChanges();
            }*/
        }
    }
}
