using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fees_Click(object sender, EventArgs e)
        {
            Fees f = new Fees();
            f.Show();
            this.Hide();
        }

        private void student_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
            this.Hide();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void user_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
            this.Hide();
        }

        private void department_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            d.Show();
            this.Hide();
        }


        private void logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashbord d = new Dashbord();
            d.Show();
            this.Hide();
        }

   

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
