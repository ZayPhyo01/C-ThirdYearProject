﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Data;

namespace WebApp.Pages.Management
{
    public partial class InsertFlora : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        //="Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Zay_Phyo\Desktop\SectionCProject\coffeeshop.mdf;Integrated Security=True;Connect Timeout=30"
        string source =  @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Zay_Phyo\Desktop\original\GroupA\coffeeshop.mdf;Integrated Security=True;Connect Timeout=30";
        
            private void GetImage()
        {
            try
            {
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/cake Images/"));
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }
                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();
            }
            catch (Exception e)
            {
                lblResult.Text = e.ToString();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            lblResult.Text = "";
            if (!IsPostBack)
            {
                GetImage();
                //Check if the url contains an id parameter
                
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(source);


            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                cn.Open();
                //Id exists->Update
                int id = Convert.ToInt32(Request.QueryString["id"]);
                string upd = "Update Product1 set TypeId=@typeid,Name=@name,Price=@price,Description=@des,Image=@img where id=@id";
                cmd = new SqlCommand(upd, cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                cmd.Parameters.AddWithValue("@typeid", Convert.ToInt32(ddlType.SelectedValue));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                cmd.Parameters.AddWithValue("@des", Convert.ToString(txtDes.Text));
                cmd.Parameters.AddWithValue("@img", ddlImage.SelectedValue);
                cmd.ExecuteNonQuery();
                lblResult.Text = txtName.Text + " is updated successful!";
                cn.Close();
                clearTextBox();
            }
            else
            {
                //id doesn't exist-> create a new row
                cn.Open();
                string sq = "Insert into [Product1](TypeId,Name,Price,Description,Image) values(@typeid,@name,@price,@des,@img)";
                cmd = new SqlCommand(sq, cn);
                cmd.Parameters.Clear();
                // cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@typeid", Convert.ToInt32(ddlType.SelectedValue));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                cmd.Parameters.AddWithValue("@des", Convert.ToString(txtDes.Text));
                cmd.Parameters.AddWithValue("@img", ddlImage.SelectedValue);
                cmd.ExecuteNonQuery();
                lblResult.Text = txtName.Text + " is inserted successful!";
                cn.Close();
                clearTextBox();
            }
        }
        private void clearTextBox()
        {
            txtDes.Text = "";
            txtName.Text = "";
            txtPrice.Text = "0";
            ddlImage.SelectedIndex = 0;
            ddlType.SelectedIndex = 0;
        }
    }
}