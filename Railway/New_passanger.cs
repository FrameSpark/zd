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
    public partial class New_passanger : Form
    {
        public New_passanger()
        {
            InitializeComponent();
        }

        public New_passanger(string fio, string passport)
        {
            InitializeComponent();
            tbFIO.Text = fio;
            textBox2.Text = passport;
        }

        private void New_passanger_Load(object sender, EventArgs e)
        {

        }
    }
}
