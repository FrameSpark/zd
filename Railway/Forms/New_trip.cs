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
            cbNumber.DisplayMember = "numberTrain";
            cbNumber.ValueMember = "numberTrain";
            cbNumber.DataSource = db.GetTrains();

            cbRoute.DisplayMember = "id_route";
            cbRoute.ValueMember = "id_route";
            cbRoute.DataSource = db.getRoute();
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
            MessageBox.Show("Минимальное количество дней на рейс " + Convert.ToString(db.getDayRoute(Convert.ToInt32(cbRoute.SelectedValue))));

        }
    }
}
