using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApp.mvp.models
{
    public class UserModel 
    {
        SqlConnection con = new SqlConnection(ContantsUtils.DATABASE_PATH);
        public UserModel() { }
        public virtual string login(string name, string password)
        {
            string res = "";
            try
            {
                
                con.Open();
                string qry = "select * from users where name='" + name + "' and Password='" + password + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
               
                if (sdr.Read())
                {
                    //lblError.Text = "Login Sucess......!!";
                    // lblError.Visible = true;
                    //  Session["UserId"] = sdr["Id"];
                    // Session["UserName"] = txtLogin.Text;
                    //   Session["PW"] = txtPassword.Text;
                    //  string a = sdr["user_type"].ToString();
                    //   Session["User_Type"] = a.Trim();
                    res = ContantsUtils.LOGIN_SUCCESS;
                }
                else
                {
                    res = ContantsUtils.LOGIN_FAIL;
                    //lblError.Text = "UserId & Password Is not correct Try again..!!";
                    //lblError.Visible = true;
                    //Response.Redirect("RegPage.aspx");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                res = ContantsUtils.LOGIN_FAIL;
            }
            return res;
        }
 
    }
}