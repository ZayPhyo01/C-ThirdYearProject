using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Pages.Account
{
    public partial class RegPage : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection con;
        
        protected void Page_Load(object sender, EventArgs e)
        {
             con = new SqlConnection(ContantsUtils.DATABASE_PATH);


        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            //Register
            con.Open();
            string name = txtName.Text;
            string pass = txtPassword.Text;
            string email = "sutaung.com";
            string userType = "super man";
            //  string sq = "Insert into [Product1](TypeId,Name,Price,Description,Image) values(@typeid,@name,@price,@des,@img)";
            
            string insert = "insert into [users] (name,password,email,user_type) values(@name ,@pass ,@email ,@type)";
            cmd = new SqlCommand(insert,con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@type", userType);
            cmd.ExecuteNonQuery();
            con.Close(); 
           

              

        }
    }
}