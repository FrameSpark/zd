using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway.Forms
{
    public partial class Buy : Form
    {
        public Buy(int train)
        {
            InitializeComponent();
            this.train = train;
        }
        int train;
        DataBase db = new DataBase();
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buy_Load(object sender, EventArgs e)
        {
            cbCarriage.DisplayMember = "id_carriage";
            cbCarriage.ValueMember = "id_carriage";
            cbCarriage.DataSource = db.getCompositionByTrain(train);
        }

        private void CbCarriage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label2.Text = "Свободных мест: " + Convert.ToInt32(db.getFreeTicket(train));
            string type = db.getCarriageTypeById(Convert.ToInt32(cbCarriage.SelectedValue)).type_carriage;
            switch (type)
            {
                case "Обычный":
                    priceBuy.Text = "Обычный вагон. Стоимость 1000 рублей";
                    break;
                case "Плацкарт":
                    priceBuy.Text = "Плацкарт. Стоимость 1000 рублей";
                    break;
                case "Товарный":
                    priceBuy.Text = "Товарный. Стоимость 500 рублей";
                    break;
                case "Купе":
                     priceBuy.Text = "Купе. Стоимость 3000 рублей";
                    break;
                case "Ресторан":
                    priceBuy.Text = "Ресторан. Стоимость 1500 рублей";
                    break;
                default:
                    priceBuy.Text = "Стоимость 1500 рублей";
                    break;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
