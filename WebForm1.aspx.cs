using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Control = System.Web.UI.Control;


namespace Student_Registration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string constr = @"Data Source=.; Initial Catalog=School;User ID=sa;Password=Securepass123_#;";
        SqlConnection conn;
        DataTable table = new DataTable();

        PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();
        int rowindex2;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Upload(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                int fileLen;
                // Get the length of the file.
                fileLen = FileUpload1.PostedFile.ContentLength;
                byte[] input = new byte[fileLen - 1];
                input = FileUpload1.FileBytes;

                //byte[] fileBytes = new byte[FileUpload1.PostedFile.ContentLength];

                Image2.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(input.ToArray(), 0, input.ToArray().Length);

            }
            else
            {
                MessageBox.Show("Please uplaod file","Error",MessageBoxButtons.OK);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                // to open the connection
                conn.Open();

                // use to perform read and write
                // operations in the database
                //SqlCommand cmd;

                // data adapter object is use to 
                // insert, update or delete commands
                SqlDataAdapter adap = new SqlDataAdapter();

                string sql = "";

                // use the defined sql statement
                // against our database


                sql = "INSERT INTO Student (Eroll_no,Name,Father_name,Mother_name,Aadhar,DOB,DOA,Birth_City,Disability,Caste,Category,School_Last_Attended,Class,Residential_Address,City,Blood_Group,Mark) VALUES (" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "'," + TextBox5.Text + ",'" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + (DropDownList1.SelectedItem).Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + (DropDownList2.SelectedItem).Text + "','" + TextBox17.Text + "')";

                // use to execute the sql command so we 
                // are passing query and connection object


                // associate the insert SQL 
                // command to adapter object
                adap.InsertCommand = new SqlCommand(sql, conn);

                // use to execute the DML statement against
                // our database
                adap.InsertCommand.ExecuteNonQuery();

                // closing all the objects

                conn.Close();
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }
        public void getData()
        {


            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            // use to perform read and write
            // operations in the database
            SqlCommand cmd;

            // use to read a row in
            // table one by one
            SqlDataReader dreader;

            // to store SQL command and
            // the output of SQL command
            string sql;

            // use to fetch rows from demo table
            sql = "Select * from Student";

            // to execute the sql statement
            cmd = new SqlCommand(sql, conn);

            // fetch all the rows 
            // from the demo table
            dreader = cmd.ExecuteReader();
            table.Load(dreader);
            GridView1.DataSource = table;
            GridView1.DataBind();

            // to close all the objects
            dreader.Close();
            cmd.Dispose();
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            getData();
        }
        protected void btn_click(object sender, EventArgs e)
        {
            int rowindex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int studentid = Convert.ToInt32(GridView1.Rows[rowindex].Cells[3].Text);
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE Eroll_no='" + studentid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            getData();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void btn_click2(object sender, EventArgs e)
        {
            int rowindex1 = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            TextBox1.Text = GridView1.Rows[rowindex1].Cells[3].Text;
            TextBox2.Text = GridView1.Rows[rowindex1].Cells[4].Text;
            TextBox3.Text = GridView1.Rows[rowindex1].Cells[5].Text;
            TextBox4.Text = GridView1.Rows[rowindex1].Cells[6].Text;
            TextBox5.Text = GridView1.Rows[rowindex1].Cells[7].Text;
            TextBox6.Text = GridView1.Rows[rowindex1].Cells[8].Text;
            TextBox7.Text = GridView1.Rows[rowindex1].Cells[9].Text;
            TextBox8.Text = GridView1.Rows[rowindex1].Cells[9].Text;
            TextBox9.Text = GridView1.Rows[rowindex1].Cells[11].Text;
            (DropDownList1.SelectedItem).Text = GridView1.Rows[rowindex1].Cells[12].Text;
            TextBox11.Text = GridView1.Rows[rowindex1].Cells[13].Text;
            TextBox12.Text = GridView1.Rows[rowindex1].Cells[14].Text;
            TextBox13.Text = GridView1.Rows[rowindex1].Cells[15].Text;
            TextBox14.Text = GridView1.Rows[rowindex1].Cells[16].Text;
            TextBox15.Text = GridView1.Rows[rowindex1].Cells[17].Text;
            (DropDownList2.SelectedItem).Text = GridView1.Rows[rowindex1].Cells[18].Text;
            TextBox17.Text = GridView1.Rows[rowindex1].Cells[19].Text;

        }
        protected void btn_click3(object sender, EventArgs e)
        {
            rowindex2 = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Universal Public School", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(185, 10));
            e.Graphics.DrawString("Student Registration", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(240, 40));
            e.Graphics.DrawString("Eroll no: " + GridView1.Rows[rowindex2].Cells[3].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("Name: " + GridView1.Rows[rowindex2].Cells[4].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("Father's Name: " + GridView1.Rows[rowindex2].Cells[5].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("Mother's Name: " + GridView1.Rows[rowindex2].Cells[6].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            e.Graphics.DrawString("Aadhar Card No: " + GridView1.Rows[rowindex2].Cells[7].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,220));
            e.Graphics.DrawString("Date of Birth: " + GridView1.Rows[rowindex2].Cells[8].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Date of Addmission: " + GridView1.Rows[rowindex2].Cells[9].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,280));
            e.Graphics.DrawString("Place of Birth: " + GridView1.Rows[rowindex2].Cells[10].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,310));
            e.Graphics.DrawString("Physical problem/Disability(If any): " + GridView1.Rows[rowindex2].Cells[11].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,340));
            e.Graphics.DrawString("Caste: " + GridView1.Rows[rowindex2].Cells[12].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,370));
            e.Graphics.DrawString("Category: " + GridView1.Rows[rowindex2].Cells[13].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,400));
            e.Graphics.DrawString("Name of the School Last Attended: " + GridView1.Rows[rowindex2].Cells[14].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,430));
            e.Graphics.DrawString("Class: " + GridView1.Rows[rowindex2].Cells[15].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,460));
            e.Graphics.DrawString("Residential Address: " + GridView1.Rows[rowindex2].Cells[16].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,490));
            e.Graphics.DrawString("City: " + GridView1.Rows[rowindex2].Cells[17].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,520));
            e.Graphics.DrawString("Blood Group: " + GridView1.Rows[rowindex2].Cells[18].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,550));
            e.Graphics.DrawString("Identification Mark: " + GridView1.Rows[rowindex2].Cells[19].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25,580));

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();
            string sql = "UPDATE Student SET Eroll_no=" + TextBox1.Text +",Name='"+TextBox2.Text+"',Father_name='"+TextBox3.Text+"',Mother_name='"+TextBox4.Text+"',Aadhar="+TextBox5.Text+",DOB='"+TextBox6.Text+"',DOA='"+TextBox7.Text+"',Birth_City='"+TextBox8.Text+"',Disability='"+TextBox9.Text+"',Caste='"+(DropDownList1.SelectedItem).Text+"',Category='"+TextBox11.Text+"',School_Last_Attended='"+TextBox12.Text+"',Class='"+TextBox13.Text+"',Residential_Address='"+TextBox14.Text+"',City='"+TextBox15.Text+"',Blood_Group='"+(DropDownList2.SelectedItem).Text+"',Mark='"+TextBox17.Text+"' WHERE Eroll_no=" + TextBox1.Text + "";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            getData();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
            TextBox8.Text = string.Empty;
            TextBox9.Text = string.Empty;
            TextBox11.Text = string.Empty;
            TextBox12.Text = string.Empty;
            TextBox13.Text = string.Empty;
            TextBox14.Text = string.Empty;
            TextBox15.Text = string.Empty;
            TextBox17.Text = string.Empty;
        }
    }
}