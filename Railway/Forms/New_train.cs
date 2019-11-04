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
    public partial class New_train : Form
    {
        public New_train()
        {
            InitializeComponent();
            ControlBox = false;
        }

        public New_train(string numberTrain, string type_train)
        {
            InitializeComponent();
            tNumberTrain.Text = numberTrain;
            tTypeTrain.Text = type_train;
            ControlBox = false;
        }

        private void New_train_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
