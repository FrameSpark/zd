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
    public partial class New_composition : Form
    {
        DataBase db = new DataBase();
        public New_composition()
        {
            InitializeComponent();
        }

        private void New_composition_Load(object sender, EventArgs e)
        {
            cbTrain.DisplayMember = "numberTrain";
            cbTrain.ValueMember = "numberTrain";
            cbTrain.DataSource = db.GetTrains();

            cbCarriage.DisplayMember = "id_carriage";
            cbCarriage.ValueMember = "id_carriage";
            cbCarriage.DataSource = db.getFreeCarriage();

        }

        private void CbTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CbCarriage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BCreateConposition_Click(object sender, EventArgs e)
        {

        }
    }
}
