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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahira\OneDrive\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Department_Load(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {
            con.Open();
            string query = "select * from DepartementTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            departmentdgv.DataSource = ds.Tables[0];
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
           try
           {
                if (depnametxb.Text == "" || ddescriptiontxb.Text == "" || dderationtxb.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DepartementTable values ('" + depnametxb.Text + "','" + ddescriptiontxb.Text + "','" + dderationtxb.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Add successful");
                    con.Close();
                    show();
                }
            }
            catch
            {
                MessageBox.Show(" somthing went wrong");
            }
        }



        private void edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (depnametxb.Text == "" || ddescriptiontxb.Text == "" || dderationtxb.Text == "")
                {
                    MessageBox.Show("missing data:");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update DepartementTable set DepDescription ='" + ddescriptiontxb.Text + "', DepDuration='" + dderationtxb.Text + "' where DepName='" + depnametxb.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" edit successfully:");
                    con.Close();
                    show();
                }
            }
            catch
            {
                MessageBox.Show("Somting went wrong  not edit:");
            }
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (depnametxb.Text == "")
                {
                    MessageBox.Show("Enter DepName :");
                }
                else
                {
                    con.Open();
                    string query = "delete from DepartmentTable where DepName ='" + depnametxb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" delete successfully");
                    con.Close();
                    show();
                }

            }
            catch
            {
                MessageBox.Show("Somting went wrong  not delete: ");
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm m = new MainForm();
            m.ShowDialog();
        }

        private void departmentdgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            depnametxb.Text = departmentdgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            ddescriptiontxb.Text = departmentdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            dderationtxb.Text = departmentdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
