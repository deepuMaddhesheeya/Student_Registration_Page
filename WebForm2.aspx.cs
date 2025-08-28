using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Student_Registration
{
    public partial class WebForm2 : System.Web.UI.Page
    { 
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=School;User ID=sa;Password=Securepass123_#;");
        DataTable table1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string x = TextBox2.Text;
            if (TextBox2.TextMode.ToString()=="Password")
            {
                TextBox2.TextMode = TextBoxMode.SingleLine;
                ImageButton1.ImageUrl=("~/Properties/icon-blind.png");
                TextBox2.Text = x;
            }
            else
            {
                TextBox2.TextMode = TextBoxMode.Password;
                ImageButton1.ImageUrl=("~/Properties/icon-eye.png");
                TextBox2.Text = x;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                String query = "SELECT * FROM Login WHERE username = '" + TextBox1.Text + "' AND password = '" + TextBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(table1);

                if (table1.Rows.Count > 0)
                {
                    //page that needed to be load next
                    Response.Redirect("WebForm1.aspx");

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error "+ex);
            }
            finally
            {
                conn.Close(); 
            }
        }
    }
}