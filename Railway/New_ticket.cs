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
            cbPassanger.DataSource = db.GetPASSANGERs();

            cbNumber.DisplayMember = "number_train";
            cbNumber.ValueMember = "id_train";
            cbNumber.DataSource = db.db.TRAINs.ToList();

            
            
            
        }

        private void CbNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbCarriage.DisplayMember = "id_carriage";
            cbCarriage.ValueMember = "id_carriage";
            cbCarriage.DataSource = db.getCompositionByTrain(Convert.ToInt32(cbNumber.SelectedValue));

            cbTrip.DisplayMember = "id_trip";
            cbTrip.ValueMember = "id_trip";
            cbTrip.DataSource = db.getTripByTrain(Convert.ToInt32(cbNumber.SelectedValue));

            label6.Text = "Свободных мест" + Convert.ToInt32(db.getFreeTicket(Convert.ToInt32(cbNumber.SelectedValue)));
        }
    }
}
