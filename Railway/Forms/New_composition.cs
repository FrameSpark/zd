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

        public New_composition(bool f)
        {
            InitializeComponent();
            cbTrain.Visible = false;
            label1.Visible = false;
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

        private void CbCarriage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbCarriage.SelectedValue);
            try
            {
                label3.Text = db.getCarriageTypeById(id).type_carriage;
                label4.Text = "Количество мест " + db.getCarriageById(id).number_of_seats;
            }
            catch
            {

            }
        }

        private void CbCarriage_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbCarriage.SelectedValue);
                label3.Text = db.getCarriageTypeById(id).type_carriage;
                label4.Text = "Количество мест " + db.getCarriageById(id).number_of_seats;
            }
            catch
            {

            }
        }
    }
}
