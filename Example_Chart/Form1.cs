using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Book"].Points.AddXY("The Mediterranean region", 5);
            chart1.Series["Book"].Points.AddXY("Aegean region", 8);
            chart1.Series["Book"].Points.AddXY("Southeastern Anatolia region", 20);
            chart1.Series["Book"].Points.AddXY("Eastern Anatolia region", 17);
            chart1.Series["Book"].Points.AddXY("Black Sea region", 5);
            chart1.Series["Book"].Points.AddXY("Marmara region", 18);
            chart1.Series["Book"].Points.AddXY("Central anatolia region", 10);
        }
    }
}
