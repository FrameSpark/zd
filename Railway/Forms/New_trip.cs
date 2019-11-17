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
    public partial class New_trip : Form
    {
        public New_trip()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
       
        private void New_trip_Load(object sender, EventArgs e)
        {
            dtStart.MinDate = DateTime.Now;
            dtFinish.MinDate = DateTime.Now;
            listBox1.DataSource = db.getRoute();
            listBox1.DisplayMember = "route";
            listBox1.ValueMember = "id_route";

            cbNumber.DisplayMember = "numberTrain";
            cbNumber.ValueMember = "numberTrain";
            cbNumber.DataSource = db.GetTrainsWithoutTrip();

            //cbRoute.DisplayMember = "id_route";
            //cbRoute.ValueMember = "id_route";
            //cbRoute.DataSource = db.getRoute();
        }

        private void CbRoute_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void CbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Минимальное количество дней на рейс " + Convert.ToString(db.getDayRoute(Convert.ToInt32(cbRoute.SelectedValue))));

        }

        private void CbRoute_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // MessageBox.Show("Минимальное количество дней на рейс " + Convert.ToString(db.getDayRoute(Convert.ToInt32(cbRoute.SelectedValue))));

        }

        private void DtStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
