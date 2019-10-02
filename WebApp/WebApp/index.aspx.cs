﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApp
{
    public partial class index : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        string source =ContantsUtils.DATABASE_PATH;

        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
        private void FillPage()
        {
            SqlConnection cn = new SqlConnection(ContantsUtils.DATABASE_PATH);
            cn.Open();
            string sq = "select * from [Product1]";
            cmd = new SqlCommand(sq, cn);

            SqlDataReader rdr = cmd.ExecuteReader();
            //lblResult.Text = Convert.ToString(rdr[4]);
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    Panel productPanel = new Panel();
                    ImageButton imgbutton = new ImageButton();
                    Label lblName = new Label();
                    Label lblPrice = new Label();


                    imgbutton.ImageUrl = "~/Images/cake Images/" + rdr["Image"];
                    imgbutton.CssClass = "productImage";
                    imgbutton.PostBackUrl = "~/Pages/FloraSelect.aspx?id=" + rdr["Id"];

                    lblName.Text = Convert.ToString(rdr["Name"]);
                    lblName.CssClass = "productName";
                    lblPrice.Text = Convert.ToString(rdr["Price"]) + " Kyats";
                    lblPrice.CssClass = "productPrice";


                    productPanel.Controls.Add(imgbutton);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });

                    productPanel.Controls.Add(lblPrice);

                    pnlProducts.Controls.Add(productPanel);

                }
            }
            else
            {
                pnlProducts.Controls.Add(new Literal { Text = "No Product found!" });
            }
        }
    }
}