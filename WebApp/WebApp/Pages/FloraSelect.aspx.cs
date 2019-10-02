using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApp.Pages
{
    public partial class FloraSelect : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        string source =ContantsUtils.DATABASE_PATH;
        SqlConnection cn = new SqlConnection();
        static int prodprice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (!IsPostBack)
            {
              //  GetImage();
                //Check if the url contains an id parameter
                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    FillPage(id);
                }
            }
        }
            private void FillPage(int sid)
        {
            //Get selectProduct from DB
            cn = new SqlConnection(source);
            cn.Open();
            string sq = "select * from [Product1] where Id=@sid";
            cmd = new SqlCommand(sq, cn);
            cmd.Parameters.AddWithValue("@sid", sid);
            SqlDataReader rdr = cmd.ExecuteReader();
            //lblResult.Text = Convert.ToString(rdr[4]);
              
            if (rdr.HasRows)
            {
                rdr.Read();
                prodprice = Convert.ToInt32(rdr["Price"]);
                // lblPrice.Text ="Price per unit: <br />"+ Convert.ToString(rdr["Price"])+" Kyats";
                lblPrice.Text = "Price per unit: <br />" + Convert.ToString(prodprice) + " Kyats";
                lblTitle.Text = Convert.ToString(rdr["Name"]);
                lblDescription.Text = Convert.ToString(rdr["Description"]);
                lblItemNr.Text = sid.ToString();
                //select dropdownlist values
                imgProduct.ImageUrl = "~/Images/cake Images/" + rdr["Image"];
                int[] qty = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = qty;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();

            }
            cn.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(source);
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {

                if (Session["UserID"] != null)
                {
                    string clientId = Session["UserID"].ToString();
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    int amount = Convert.ToInt32(ddlAmount.SelectedValue);
                    DateTime dt = DateTime.Now;
                    bool isIncart = true;
                    Cart c = new Cart();
                    c.ClientId = clientId;
                    c.pid = id;
                    c.pname = lblTitle.Text;
                    c.price = prodprice;
                    c.qty = amount;
                    c.amount = c.price * amount;
                    c.dtime = dt;
                    c.IsIncart = isIncart;

                    cn.Open();
                    string sq = "Insert into [Cart1](ClientID,ProductId,Name,price,qty,Amount,DatePurchased,IsInCart) values(@cid,@pid,@name,@price,@qty,@amt,@dt,@inCart)";
                    cmd = new SqlCommand(sq, cn);
                    cmd.Parameters.Clear();
                    // cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                    cmd.Parameters.AddWithValue("@cid", Convert.ToInt32(c.ClientId));
                    cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(c.pid));
                    cmd.Parameters.AddWithValue("@name", c.pname.ToString());
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(c.price));
                    cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(c.qty));
                    cmd.Parameters.AddWithValue("@amt", Convert.ToInt32(c.amount));
                    cmd.Parameters.AddWithValue("@dt", c.dtime);
                    cmd.Parameters.AddWithValue("@inCart", c.IsIncart);
                    cmd.ExecuteNonQuery();
                    lblResult.Text = "Product " + id.ToString() + " is inserted successful!";
                    cn.Close();
                    Session["UserID"] = id.ToString();
                    Response.Redirect("~/Pages/ShoppingCart.aspx");
                }
                else
                {
                    lblResult.Text = "You need to login firstly!";
                    Response.Redirect("~/Pages/Account/Login.aspx");
                }
            }
        }
    }
}