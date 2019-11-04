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
    public partial class New_carriage : Form
    {
        public New_carriage()
        {
            InitializeComponent();
        }

        private void New_carriage_Load(object sender, EventArgs e)
        {

        }

        public New_carriage(int numberSeat, string type)
        {
            InitializeComponent();
            tbNumberSeats.Text = Convert.ToString(numberSeat);
            tbTypeCarriage.Text = type;
            ControlBox = false;
        }

        private void BCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
