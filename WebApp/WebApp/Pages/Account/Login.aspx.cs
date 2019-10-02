using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
 
using WebApp.mvp.presenter;

namespace WebApp.Pages.Account
{
    public partial class Login : System.Web.UI.Page 
    {
        Presenter login;

        public   void loginResult(string res) {
            Label4.Visible = true;
            Label4.BackColor = System.Drawing.Color.Red;
            Label4.Text = res;
        }

        public   void nevigateToIndexPage()
        {
            Response.Redirect("~/index.aspx");
        }

      

        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
            login = new Presenter();
            login.initLoginView(this);
            
            //lblError.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
             
                string uname = txtLogin.Text;
                string pass = txtPassword.Text;
                login.onTapLogin(uname, pass);
             
        }
    }
}