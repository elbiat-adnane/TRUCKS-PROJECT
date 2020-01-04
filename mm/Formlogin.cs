using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mm
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }
            signup s = new signup();
        private void Formlogin_Load(object sender, EventArgs e)
        {
            
                s.Show();
           
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s.Left += 25;
            if(s.Left >= 920)
            {
                timer1.Stop();
                this.TopMost = false;
                s.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s.Left -= 25;
            if (s.Left <= 560)
            {
                timer2.Stop();
                
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
