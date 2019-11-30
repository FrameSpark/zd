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
    public partial class New_route : Form
    {
        DataBase db = new DataBase();
        public New_route(String station1 , String station2, int time)
        {
            InitializeComponent();
            cbStation1.DisplayMember = "name_station";
            cbStation1.ValueMember = "name_station";
            cbStation1.DataSource = db.GetStations();

            cbStation2.DisplayMember = "name_station";
            cbStation2.ValueMember = "name_station";
            cbStation2.DataSource = db.GetStations();

            cbStation1.SelectedValue = station1;
            cbStation2.SelectedValue = station2;
            tbTime.Text = Convert.ToString(time);
        }

        public New_route()
        {
            InitializeComponent();
            cbStation1.DisplayMember = "name_station";
            cbStation1.ValueMember = "name_station";
            cbStation1.DataSource = db.GetStations();

            cbStation2.DisplayMember = "name_station";
            cbStation2.ValueMember = "name_station";
            cbStation2.DataSource = db.GetStations();

           
        }

        private void New_route_Load(object sender, EventArgs e)
        {
            
        }
    }
}
