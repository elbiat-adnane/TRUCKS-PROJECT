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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            bunifuMaterialTextbox1.Focus();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Add("1212", "lala", "2457", "2019/10/10");
            bunifuCustomDataGrid1.Rows.Add("1212", "lala", "2457", "2019/10/10");
            bunifuCustomDataGrid1.Rows.Add("1212", "lala", "2457", "2019/10/10");
            bunifuCustomDataGrid1.Rows.Add("1212", "lala", "2457", "2019/10/10");
            bunifuCustomDataGrid1.Rows.Add("1212", "lala", "2457", "2019/10/10");
            bunifuCustomDataGrid1.Rows.Add("1212", "lala", "2457", "2019/10/10");
            bunifuCustomDataGrid1.Rows.Add("1212", "lala", "2457", "2019/10/10");



        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Height = 45;
            pictureBox2.Width = 53;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Width = 43;
            pictureBox2.Height = 35;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Height = 45;
            pictureBox3.Width = 53;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Width = 43;
            pictureBox3.Height = 35;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Height = 45;
            pictureBox4.Width = 53;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Width = 43;
            pictureBox4.Height = 35;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Height = 45;
            pictureBox5.Width = 53;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Height = 43;
            pictureBox5.Width = 35;
        }
    }
}
