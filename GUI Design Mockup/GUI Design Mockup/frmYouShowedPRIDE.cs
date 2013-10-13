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
    public partial class frmYouShowedPRIDE : Form
    {
        List<Group> GroupList;
        public frmYouShowedPRIDE()
        {
            InitializeComponent();
        }

        private void frmYouShowedPRIDE_Load(object sender, EventArgs e)
        {
            int C1;
            for (C1 = 0; 2004 + C1 <= DateTime.Now.Year; C1++)
                YearBox.Items.Add((2004 + C1).ToString());
            YearBox.Text = DateTime.Now.Year.ToString();
            MonthBox.SelectedIndex = DateTime.Now.Month - 1;
            InitializeGroupBox();
        }

        private void GroupBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Group grp = (Group)GroupNoBox.SelectedItem;
            string GroupNum = "";
            if (grp != null)
                GroupNum = grp.GroupNum;
            string Month="";
            if (MonthBox.SelectedItem != null) 
            Month = MonthBox.SelectedItem.ToString();

            label7.Text = "Select " + Month + " winner(s) for Group " + GroupNum + ", then click the Winner button.";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }
    }
}
