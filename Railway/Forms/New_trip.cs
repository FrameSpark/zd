using Railway.Models;
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
        string train;
        public New_trip(bool f)
        {
            InitializeComponent();
            cbNumber.Visible = f;
            dtFinish.Visible = f;
            cbNumber.DisplayMember = "numberTrain";
            cbNumber.ValueMember = "numberTrain";

            cbNumber.DataSource = db.GetTrainsWithoutTrip(train);
        }
        public New_trip(bool f , bool f1, string train)
        {
            InitializeComponent();
            cbNumber.Visible = true;
            dtFinish.Visible = f;
            this.train = train;
            cbNumber.DisplayMember = "numberTrain";
            cbNumber.ValueMember = "numberTrain";

            cbNumber.DataSource = db.GetTrainsWithoutTrip(train);
        }
        DataBase db = new DataBase();
       
        private void New_trip_Load(object sender, EventArgs e)
        {
            TRIP trip = db.getTripByTrain(db.getIdTrainByNumber(train)).FirstOrDefault<TRIP>();
            cbNumber.DisplayMember = "numberTrain";
            cbNumber.ValueMember = "numberTrain";

            cbNumber.DataSource = db.GetTrainsWithoutTrip(train);
            if(train!=null)
            cbNumber.Text =  db.getTrainById(trip.id_train).number_train;
            

            listBox1.DataSource = db.getRoute();
            listBox1.DisplayMember = "route";
            listBox1.ValueMember = "id_route";
            if (train != null)
            {
                foreach(Route temp in db.getRoutebyTrip(trip.id_trip))
                {
                    int index = listBox1.FindString(temp.route);
                    listBox1.SetSelected(index, true);
                }
               
                
            }
                
           
            dtStart.MinDate = DateTime.Now;
            if (train != null)
                dtStart.Value = trip.time_start;
            dtFinish.MinDate = DateTime.Now;
          

            
            

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

        private void CbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
