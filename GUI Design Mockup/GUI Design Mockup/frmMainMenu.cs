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
    public partial class frmMainMenu : Form
    {
        List<Group> GroupList;

        DataClasses1DataContext DContext;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmEmployees());
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

        private void button6_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmNewOnTheSpot());
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRIDE_beDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.pRIDE_beDataSet.Employee);

            DContext = new DataClasses1DataContext();
            var GroupListRaw = from G in DContext.Groups
                               select G;
            GroupList = new List<Group>();
            foreach (Group G in GroupListRaw)
                GroupList.Add(G);

           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LaunchForm(new frmUpdateFromAccess());
        }
    }
}
