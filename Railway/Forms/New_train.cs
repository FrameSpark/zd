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
        DataBase db = new DataBase();
        public New_train()
        {
            InitializeComponent();
            List<String> type = db.getTypesTrain();
            type.Remove("Все");
            comboBox1.ValueMember = "string";
            comboBox1.DisplayMember = "string";
            comboBox1.DataSource = type;
        }

        public New_train(string numberTrain, string type_train)
        {
            InitializeComponent();
            List<String> type = db.getTypesTrain();
            type.Remove("Все");
            tNumberTrain.Text = numberTrain;
            
            
            comboBox1.ValueMember = "string";
            comboBox1.DisplayMember = "string";
            comboBox1.DataSource = type;
            
            
            
        }

        private void New_train_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
