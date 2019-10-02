using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApp.Pages.Management
{
    public partial class InsertFloraType : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        string source =ContantsUtils.DATABASE_PATH;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }
        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(source);
            cn.Open();

            string sq = "Insert into [ProductTypes1](Name) values('" + txtName.Text + "')";
            cmd = new SqlCommand(sq, cn);
            cmd.ExecuteNonQuery();
            lblResult.Text = txtName.Text + " is inserted successful!";
            cn.Close();
        }
    }
}