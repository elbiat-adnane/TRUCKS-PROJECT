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
    public partial class FormDRIVERS : Form
    {
        public FormDRIVERS()
        {
            InitializeComponent();
        }

        private void FormDRIVERS_Load(object sender, EventArgs e)
        {
            //bunifuElipse1.ApplyElipse(panel1, 15);
            //bunifuElipse1.ApplyElipse(panel2, 15);
            //bunifuElipse1.ApplyElipse(panel3, 15);
            //bunifuElipse1.ApplyElipse(panel5, 15);
            bunifuElipse1.ApplyElipse(panel4, 15);
            bunifuElipse1.ApplyElipse(panel6, 15);
            bunifuElipse1.ApplyElipse(panel7, 15);
            bunifuElipse1.ApplyElipse(panel9, 15);


            bunifuCustomDataGrid1.Rows.Add("adnan");
            bunifuCustomDataGrid1.Rows.Add("adnan");
            bunifuCustomDataGrid1.Rows.Add("adnan");
            bunifuCustomDataGrid1.Rows.Add("adnan");
            bunifuCustomDataGrid1.Rows.Add("adnan");
            bunifuCustomDataGrid1.Rows.Add("adnan");
            bunifuCustomDataGrid1.Rows.Add("adnan");


        }

        private void xuiBanner1_Click(object sender, EventArgs e)
        {

        }

        private void xuiBanner4_Click(object sender, EventArgs e)
        {

        }

        private void xuiBanner6_Click(object sender, EventArgs e)
        {

        }

        private void xuiBanner8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormADDDriver f = new FormADDDriver();
            f.ShowDialog();
           



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
