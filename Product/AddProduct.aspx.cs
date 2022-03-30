using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Product
{
    public partial class Contact : Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ProductConnectionString1"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addButton_Click(Object sender, EventArgs e)
        {
            try
            {
              
                if (check())
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into Products values('" + nameTextBox.Text + "','" + expiryTextBox.Text + "','" + amountTextBox.Text + "','" + currencyTextBox.Text + "','" + isActive.Checked.ToString() + "')", con);
                    int i = sqlCommand.ExecuteNonQuery();
                    if (i > 0)
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Added')", true);
                    else
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error')", true);

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please fill all the necessary fields.')", true);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool check()
        {
            if (nameTextBox.Text != "" || expiryTextBox.Text != "" || amountTextBox.Text != "" || currencyTextBox.Text != "")
                return true;
            else
                return false;
        }
    }
}