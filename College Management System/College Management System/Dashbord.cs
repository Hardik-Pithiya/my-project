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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahira\OneDrive\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Dashbord_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from StudentTable ", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            stulab.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from FeesTable ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            feeslab.Text ="Rs" +Convert.ToInt32(dt2.Rows[0][0].ToString())*20000;

            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from TeacherTable ", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            teaclab.Text = dt3.Rows[0][0].ToString();

            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from DepartementTable ", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            deplab.Text = dt4.Rows[0][0].ToString();

            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm m = new MainForm();
            m.ShowDialog();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

     
    }
}
