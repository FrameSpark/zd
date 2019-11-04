using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway
{
    public partial class New_station : Form
    {
        public New_station()
        {
            InitializeComponent();
        }

        public New_station(string name)
        {
            InitializeComponent();
            tbNameStation.Text = name;
        }

        private void New_station_Load(object sender, EventArgs e)
        {

        }
    }
}
