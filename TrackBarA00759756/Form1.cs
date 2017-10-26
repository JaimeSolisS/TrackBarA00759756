using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBarA00759756
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //label1.Text = "warning";
            TrackBar trackBar1 = new TrackBar();
            TrackBar trackBar2 = new TrackBar();

            trackBar1.Maximum = 10;
            trackBar2.Maximum = 10;
        }



        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            if ((trackBar1.Value > 5) & (trackBar2.Value > 5))
            {
                label1.Text = "warning";
            }
        }
    }
}
