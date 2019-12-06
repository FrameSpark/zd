using Railway.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway.Forms
{
    public partial class Guest : Form
    {
        PASSANGER passanger;
        public Guest(PASSANGER passanger)
        {
            InitializeComponent();
            this.passanger = passanger;
            dgTicket.DataSource = db.getTicketsByPassangerId(passanger.id_passanger);

        }
        DataBase db = new DataBase();
        private void Guest_Load(object sender, EventArgs e)
        {
            label1.Text = "ФИО: " + passanger.name;
            label2.Text = "Пасспорт: " +passanger.passport;

            cbType.DisplayMember = "type_train";
            cbType.ValueMember = "type_train";
            cbType.DataSource = db.getTypesTrain();

            cbStation.DisplayMember = "name_station";
            cbStation.ValueMember = "name_station";
            cbStation.DataSource = db.getStations();

        }
        private void Guest_Deactivate(object sender, EventArgs e)
        {
           // Environment.Exit(0);
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String need_type = (String)cbType.SelectedItem;
            String station = (String)cbStation.SelectedItem;

            dgTrain.DataSource = db.searchTrain(need_type, station);
        }

        private void DgTrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string numberTrain = Convert.ToString(dgTrain.CurrentRow.Cells["number"].Value);
            int id = db.getIdTrainByNumber(numberTrain);
            if (e.ColumnIndex == 8)
            {
                using (Buy frm = new Buy(id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        string s = frm.priceBuy.Text;
                        int price ;
                        int.TryParse(string.Join("", s.Where(c => char.IsDigit(c))), out price);
                        if (db.newTicket(passanger.id_passanger,id, Convert.ToInt32(frm.cbCarriage.Text), price , db.getTripByTrain(id).First<TRIP>().id_trip, (String)cbStation.SelectedItem) == null)
                        {
                            MessageBox.Show("Ошибка");
                        }
                       dgTicket.DataSource = db.getTicketsByPassangerId(passanger.id_passanger);
                       
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            dgTicket.DataSource = db.getTicketsByPassangerId(passanger.id_passanger);
        }

        private void DgTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgTicket.CurrentRow.Cells["idticket"].Value);
            if (e.ColumnIndex == 12)
            {
                string message = "Вы действительно хотите сдать билет ";
                string caption = "Подтверждение выбора";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DateTime time = DateTime.Now;
                    foreach(Ticket temp in db.getTicketsByPassangerId(passanger.id_passanger))
                    {
                        if(temp.id_ticket == id)
                        {
                            time = temp.time;
                        }
                    }
                    String status = db.getTripById(db.getTicketById(id).id_trip).status;
                    if (time > DateTime.Now || status == "Не начат")
                    {
                        if (db.deleteTicket(id))
                        {
                            MessageBox.Show("Билет удален");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поезд уже в пути");
                    }
                }
               dgTicket.DataSource = db.getTicketsByPassangerId(passanger.id_passanger);
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
