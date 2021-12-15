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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ahira\OneDrive\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void show_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                hide.BringToFront();
                password.PasswordChar = '\0';
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0')
            {
                show.BringToFront();
                password.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTable where UserName='"+user.Text+"' and Password='"+password.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                main.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("wrong usename and password:");
            }
            con.Close();
        }

       
    }
}
