using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                litStatus.Text = Session["UserName"].ToString();
                InkLogin.Visible = false;
                InkRegister.Visible = false;

                InkLogout.Visible = true;
                litStatus.Visible = true;
            }
            else
            {
                InkLogin.Visible = true;
                InkRegister.Visible = true;

                InkLogout.Visible = false;
                litStatus.Visible = false;
            }
        }

        protected void LinkButtonM_Click(object sender, EventArgs e)
        {
            if (Session["User_Type"] != null)
            {
                string utype = Session["User_Type"].ToString();
                if (utype.Equals("Admin"))
                {
                    Response.Redirect("~/Pages/Management/ManagementWebForm.aspx");
                }
            }
        }

        protected void InkLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/index.aspx");
        }
    }
}