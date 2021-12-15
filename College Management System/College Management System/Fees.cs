using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace College_Management_System
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahira\OneDrive\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void showsfees()
        {
            con.Open();
            string query = "select * from FeesTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            paymentsdgv.DataSource = ds.Tables[0];
            con.Close();
        }

        private void clearf()
        {
            fnumtxb.Text = "";
            fnametxb.Text = "";
            famounttxb.Text = "";
        }

        private void feesdeparementautofull()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Studentid from StudentTable ", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Studentid", typeof(string));
            dt.Load(sdr);
            fstdidcob.ValueMember = "Studentid";
            fstdidcob.DataSource = dt;
            con.Close();
        }

        private void updatestudent()
        {
            con.Open();
            string query = "Update StudentTable set  StudentFees='" + famounttxb.Text + "' where Studentid ='" + fstdidcob.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            showsfees();
            feesdeparementautofull();
        }

        private void fstdidcob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from StudentTable where Studentid=" + fstdidcob.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query,con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                fnametxb.Text = dr["StudentName"].ToString();
            }
            con.Close();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            try
            {
                if (fnumtxb.Text == "" || fstdidcob.Text == "" || fnametxb.Text == "" || fperiod.Text == "" || famounttxb.Text == "" )
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    string Date = fperiod.Value.Year.ToString();
                    //con.Open();
                    //SqlDataAdapter sda = new SqlDataAdapter("select count(*) from FeesTable where Studentid='"+ fstdidcob.SelectedValue.ToString() +"' and  Period = '"+ Date +"'", con);
                    //DataTable dt = new DataTable();
                    //sda.Fill(dt);
                    //if (dt.Rows[0][0].ToString() == "1")
                   // {
                       // MessageBox.Show("allread added");
                      //  con.Close();
                    //}
                    //else
                    //{
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into FeesTable values ('" + fnumtxb.Text + "','" + fstdidcob.SelectedValue.ToString() + "','" + fnametxb.Text + "', '" + Date + "', '" + famounttxb.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fees Add successful");
                        con.Close();
                        updatestudent();
                        clearf();
                        showsfees();
                    //}
                   
                }
           }
            catch
            {
                MessageBox.Show(" somthing went wrong");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm m = new MainForm();
            m.ShowDialog();
        }

        private void home_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void paymentsdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fnumtxb.Text = paymentsdgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            fstdidcob.Text = paymentsdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            fnametxb.Text = paymentsdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            fperiod.Text = paymentsdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            famounttxb.Text = paymentsdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (fnumtxb.Text == "")
                {
                    MessageBox.Show("Enter num id :");
                }
                else
                {
                    con.Open();
                    string query = "delete from FeesTable where FeesNum ='" + fnumtxb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" delete successfully");
                    con.Close();
                    clearf();
                    showsfees();
                }

            }
            catch
            {
                MessageBox.Show("Somting went wrong user not delete: ");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if ( fnumtxb.Text == "" || fnametxb.Text == "" || fstdidcob.Text == "" || fperiod.Text == "" || famounttxb.Text == "" )
                {
                    MessageBox.Show("missing data:");
                }
                else
                {
                    con.Open();
                    string Date = fperiod.Value.Year.ToString();
                    SqlCommand cmd = new SqlCommand("Update FeesTable set Studentid='" + fstdidcob.SelectedValue.ToString() + "', StudentName= '" + fnametxb.Text + "', Period ='" + Date + "', Amount='" + famounttxb.Text + "' where FeesNum='" + fnumtxb.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" edit successfully:");
                    con.Close();
                    updatestudent();
                    clearf();
                    showsfees();
                }
            }
            catch
            {
                MessageBox.Show("Somting went wrong  not edit:");
            }
        }

      

     
    }
}
