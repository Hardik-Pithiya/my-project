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
    public partial class Form1 : Form
    {
       int p = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             p += 1;
            progressBar1.Value = p;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                 log.Show();
            }
        }
    }
}
