using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GeoMap()
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Random random = new Random();
            Dictionary<string, double> values = new Dictionary<string, double>();
            values["3472"] = random.Next(0, 100);


            values[label1.Text] = random.Next(0, 100);
            //values["CN"] = random.Next(0, 100);
            //values["JP"] = random.Next(0, 100);
            values["1314"] = 4587;
            values["1316"] = 5487;
            //values["DE"] = random.Next(0, 100);
            //values["FR"] = random.Next(0, 100);
            //values["GB"] = random.Next(0, 100);
            geoMap.HeatMap = values;

            geoMap.BackColor = Color.White;

            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            panelMAP.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            bunifuElipse1.ApplyElipse(panel3, 15);
            bunifuElipse1.ApplyElipse(panel4, 15);
            bunifuElipse1.ApplyElipse(panel5, 15);
            bunifuElipse1.ApplyElipse(panel7, 15);
            bunifuElipse1.ApplyElipse(panel6, 15);
            bunifuElipse1.ApplyElipse(panel8, 15);
            bunifuElipse1.ApplyElipse(panelMAP, 15);
            GeoMap();
            graph();




        }

        //Graph
        public void graph()
        {

           
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title="ad",

                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),      //First Point of First Line
                        new ObservablePoint(4,7),       //2nd POint
                        new ObservablePoint(5,3),     //------
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 10
                },
                new LineSeries
                {
                    Title="lilo",
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),      //First Point of 2nd Line
                        new ObservablePoint(2,5),       //2nd POint
                        new ObservablePoint(3,6),     //------
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 10

                    
                }
            };
        }
        private Form activ = null;
        private void child(Form ibn)
        {
            if (activ != null)
                activ.Close();


            activ = ibn;
            ibn.TopLevel = false;
            ibn.FormBorderStyle = FormBorderStyle.None;
            ibn.Dock = DockStyle.Fill;
            bunifuCards3.Controls.Add(ibn);
            bunifuCards3.Tag = ibn;
            ibn.BringToFront();
            ibn.Show();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            child(new FormDRIVERS());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (activ != null)
                activ.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            child(new FormOrders());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            child(new FormTRUCKS());
        }
    }
}
