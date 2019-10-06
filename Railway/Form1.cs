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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        
        private void Update_Click(object sender, EventArgs e)
        {
            dgTrain.DataSource = db.GetTrains();
        }

        private void CbTypeTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            String need_type = (String)cbTypeTrain.SelectedItem;
           dgTrain.DataSource = db.GetTrainsByType(need_type);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cbTypeTrain.DisplayMember = "type_train";
            cbTypeTrain.ValueMember = "type_train";
            cbTypeTrain.DataSource = db.getTypesTrain();

        }
    }
}
