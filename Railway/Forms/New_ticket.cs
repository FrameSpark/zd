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
    public partial class New_ticket : Form
    {
        public New_ticket()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void New_ticket_Load(object sender, EventArgs e)
        {
            cbPassanger.DisplayMember = "name";
            cbPassanger.ValueMember = "id_passanger";
            cbPassanger.DataSource = db.GetPASSANGERsOnly();

            cbNumber.DisplayMember = "number_train";
            cbNumber.ValueMember = "id_train";
            cbNumber.DataSource = db.GetTrainsWithTrip();

            
            
            
        }

        private void CbNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbCarriage.DisplayMember = "id_carriage";
            cbCarriage.ValueMember = "id_carriage";
            cbCarriage.DataSource = db.getCompositionByTrain(Convert.ToInt32(cbNumber.SelectedValue));

            cbTrip.DisplayMember = "id_trip";
            cbTrip.ValueMember = "id_trip";
            cbTrip.DataSource = db.getTripByTrain(Convert.ToInt32(cbNumber.SelectedValue));

            cbStation.ValueMember = "name_station";
            cbStation.DisplayMember = "name_station";
            List<String> station = db.getStationsByTrain(Convert.ToInt32(cbNumber.SelectedValue));
            station.Remove(station.First<string>());
            cbStation.DataSource = station;
            
            label6.Text = "Свободных мест" + Convert.ToInt32(db.getFreeTicket(Convert.ToInt32(cbNumber.SelectedValue)));
        }

        private void CbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCarriage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbTrip_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
