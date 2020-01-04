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
    public partial class FormTRUCKS : Form
    {
        public FormTRUCKS()
        {
            InitializeComponent();
        }

        private void FormTRUCKS_Load(object sender, EventArgs e)
        {
            bunifuElipse1.ApplyElipse(panel4, 15);
            bunifuElipse1.ApplyElipse(panel6, 15);
            bunifuElipse1.ApplyElipse(panel7, 15);
            bunifuElipse1.ApplyElipse(panel9, 15);

            bunifuCustomDataGrid1.Rows.Add("24124/A/44");
            bunifuCustomDataGrid1.Rows.Add("24124/A/44");
            bunifuCustomDataGrid1.Rows.Add("24124/A/44");
            bunifuCustomDataGrid1.Rows.Add("24124/A/44");
            bunifuCustomDataGrid1.Rows.Add("24124/A/44");
            bunifuCustomDataGrid1.Rows.Add("24124/A/44");
            bunifuCustomDataGrid1.Rows.Add("24124/A/44");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormADDTruck t = new FormADDTruck();
            t.ShowDialog();
        }
    }
}
