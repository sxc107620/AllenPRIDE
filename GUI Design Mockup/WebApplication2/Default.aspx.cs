using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDropDownListData();
        }

        protected void BindDropDownListData()
        {
            using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
            {
                mySqlConnection.Open();
                SqlCommand mySqlCommand = new SqlCommand("SELECT AwardTypeID, AwardTypeName FROM dbo.Type_Of_Award", mySqlConnection);  
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);

                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet);
                
                inputType.DataSource = myDataSet;
                inputType.DataTextField = "AwardTypeName";
                inputType.DataValueField = "AwardTypeID"; 
                inputType.DataBind();
 
                mySqlConnection.Close();  
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection1 = new SqlConnection(connectionString))
            {
                sqlConnection1.Open();
                string stmt = "INSERT INTO dbo.Award(AwardID, AwardTypeID, RecipientID, NominatorID, AwardDate, Notes, AwardDeptID) "
                        + "VALUES(@id, @type, @recipiant, @nominator, @date, @reason, @department);";
                SqlCommand cmd = new SqlCommand(stmt, sqlConnection1);

                cmd.Parameters.Add("@id", System.Data.SqlDbType.Char, 10);
                cmd.Parameters.Add("@type", System.Data.SqlDbType.Char, 10);
                cmd.Parameters.Add("@recipiant", System.Data.SqlDbType.Char, 10);
                cmd.Parameters.Add("@nominator", System.Data.SqlDbType.Char, 10);
                cmd.Parameters.Add("@date", System.Data.SqlDbType.Date);
                cmd.Parameters.Add("@reason", System.Data.SqlDbType.NChar);
                cmd.Parameters.Add("@department", System.Data.SqlDbType.Char, 10);

                cmd.Parameters["@id"].Value = "temp" + DateTime.UtcNow;
                cmd.Parameters["@type"].Value = inputType.DataValueField;
                cmd.Parameters["@recipiant"].Value = inputRecipiant.Text;
                cmd.Parameters["@nominator"].Value = inputNominator.Text;
                cmd.Parameters["@date"].Value = DateTime.Now;
                cmd.Parameters["@reason"].Value = inputReason.Text;
                cmd.Parameters["@department"].Value = inputDepartment.Text;

                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                inputType.SelectedIndex = 0;
                inputRecipiant.Text = "";
                inputNominator.Text = ""; 
                inputReason.Text = "";
                inputDepartment.Text = "";
            }
        }
    }
}