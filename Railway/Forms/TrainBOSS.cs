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

namespace Railway.Forms
{
    public partial class TrainBOSS : Form
    {
        PASSANGER passanger;
        int numberTrain;
        TRAIN train;
        String type;
        DataBase db = new DataBase();
        public TrainBOSS(PASSANGER p)
        {
            InitializeComponent();
            passanger=p;
            int.TryParse(string.Join("", p.name.Where(c => char.IsDigit(c))), out numberTrain);
            train = db.getTrainById(db.getIdTrainByNumber(Convert.ToString(numberTrain)));
            type = db.getTrainTypeById(db.getIdTrainByNumber(Convert.ToString(numberTrain))).type_train;
            label1.Text = "Ваш поезд #" + numberTrain + " /" + type;


        }

        private void TrainBOSS_Load(object sender, EventArgs e)
        {
            List<Composition> list = db.GetComposition();
            List<Composition> t = new List<Composition>();
            foreach (Composition temp in list)
            {
                if (temp.number_train == Convert.ToString(numberTrain))
                    t.Add(temp);
            }
            dataGridView1.DataSource = t;
            label2.Text = "Свободных мест " + db.getFreeTicket(train.id_train);
            label3.Text = "Рейса нет";
            if (db.getTripByTrain(train.id_train).Last<TRIP>() != null)
            {
                label3.Text = "Рейс: " + db.getTripByTrain(train.id_train).Last<TRIP>().status;
                List<String> st = db.getStationsByTrip(db.getTripByTrain(train.id_train).First<TRIP>().id_trip);
                label4.Text = st.First<String>() + " - " + st.Last<String>();
            }

            List<Ticket> ticket = db.getTickets();
            List<Ticket> nt = new List<Ticket>();
            foreach(Ticket temp in ticket)
            {
                if (temp.id_train == train.id_train)
                    nt.Add(temp);
            }
            dataGridView2.DataSource = nt;
           
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (New_composition frm = new New_composition(false))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (db.newComposition(Convert.ToString(numberTrain), Convert.ToInt32(frm.cbCarriage.SelectedValue)) == null)
                        {
                            MessageBox.Show("Ошибка вставки");
                        };

                        List<Composition> list = db.GetComposition();
                        List<Composition> t = new List<Composition>();
                        foreach (Composition temp in list)
                        {
                            if (temp.number_train == Convert.ToString(numberTrain))
                                t.Add(temp);
                        }
                        dataGridView1.DataSource = t;
                        label2.Text = "Свободных мест " + db.getFreeTicket(train.id_train);

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idcomposition"].Value);
                if (e.ColumnIndex == 4)
                {
                    string message = "Вы действительно хотите удалить связку ";
                    string caption = "Подтверждение выбора";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.deleteComposition(id))
                        {
                            MessageBox.Show("Связка удалена");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить");
                        }
                    }
                    List<Composition> list = db.GetComposition();
                    List<Composition> t = new List<Composition>();
                    foreach (Composition temp in list)
                    {
                        if (temp.number_train == Convert.ToString(numberTrain))
                            t.Add(temp);
                    }
                    dataGridView1.DataSource = t;
                    label2.Text = "Свободных мест " + db.getFreeTicket(train.id_train);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["idticket"].Value);


                if (e.ColumnIndex == 12)
                {
                    string message = "Вы действительно хотите удалить пассажира ";
                    string caption = "Подтверждение выбора";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
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
                    List<Ticket> ticket = db.getTickets();
                    List<Ticket> nt = new List<Ticket>();
                    foreach (Ticket temp in ticket)
                    {
                        if (temp.id_train == train.id_train)
                            nt.Add(temp);
                    }
                    dataGridView2.DataSource = nt;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
    }
