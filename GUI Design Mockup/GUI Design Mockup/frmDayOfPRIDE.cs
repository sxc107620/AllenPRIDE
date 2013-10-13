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

        public frmDayOfPRIDE()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDayOfPRIDE_Load(object sender, EventArgs e)
        {
            int C1;
            for (C1 = 0; 2004 + C1 <= DateTime.Now.Year; C1++)
                YearBox.Items.Add((2004 + C1).ToString());
            YearBox.Text = DateTime.Now.Year.ToString();
            HalfBox.SelectedIndex = ((DateTime.Now.Month-1) / 6);
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
            string Year = "", Half = "";
            if (YearBox.SelectedItem != null)
                Year = YearBox.SelectedItem.ToString();
            if (HalfBox.SelectedItem != null)
                Half = HalfBox.SelectedItem.ToString();

            label7.Text = "Select " + Half + " " + Year + " Group " + GroupNum + " winner(s), \r\nthen click the Winner or Short List button.";
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
    }
}
