using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Product
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid("default");
        }

        private void BindGrid(string searchby)
        {
            string constr = ConfigurationManager.ConnectionStrings["ProductConnectionString1"].ConnectionString;
            try
            {
                if (searchby == "name")
                {
                   
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "SELECT productName, expiryDate, amount, currency, isActive FROM Products WHERE productName LIKE '%' + @productName + '%'";
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@productName", nameTextBox.Text.Trim());
                            DataTable dt = new DataTable();
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                sda.Fill(dt);
                                dataGrid.DataSource = dt;
                                dataGrid.DataBind();
                            }
                        }
                    }
                }
                if (searchby == "date")
                {
               
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "SELECT productName, expiryDate, amount, currency, isActive FROM Products WHERE expiryDate LIKE '%' + @expiryDate + '%'";
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@expiryDate", dateTextBox.Text.Trim());
                            DataTable dt = new DataTable();
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                sda.Fill(dt);
                                dataGrid.DataSource = dt;
                                dataGrid.DataBind();
                            }
                        }
                    }
                }
                if (searchby == "default")
                {
                 
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "SELECT productName, expiryDate, amount, currency, isActive FROM Products";
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                sda.Fill(dt);
                                dataGrid.DataSource = dt;
                                dataGrid.DataBind();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void nameButton_Click(object sender, EventArgs e)
        {
            this.BindGrid("name");
        }

        protected void dateButton_Click(object sender, EventArgs e)
        {
            this.BindGrid("date");
        }
    }
}