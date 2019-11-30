using Railway.Logic;
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

namespace Railway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgComposition.DataSource = db.GetComposition();
            dgCarriage.DataSource = db.GetCarriages();
            dgTrain.DataSource = db.GetTrains();
            dgStations.DataSource = db.GetStations();
            dgRoutes.DataSource = vc.View_route.ToList();
            dgTrip.DataSource = db.getTrip();
            dgPassanger.DataSource = db.GetPASSANGERs();
            dgTickets.DataSource = db.getTickets();
            
        } 
        DataBase db = new DataBase();
        ViewContext vc = new ViewContext();

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
            cbNumberTrain.DataSource = db.GetTrainsNumber();
            cbNumberTrain.DisplayMember = "numberTrain";
            cbNumberTrain.ValueMember = "numberTrain";

            cbTypeTrain.DisplayMember = "type_train";
            cbTypeTrain.ValueMember = "type_train";
            cbTypeTrain.DataSource = db.getTypesTrain();

            cbTypeCarriage.DataSource = db.getTypesCarriage();
            cbTypeCarriage.ValueMember = "type_carriage";
            cbTypeCarriage.DisplayMember = "type_carriage";

            dgComposition.DataSource = db.GetComposition();
            dgCarriage.DataSource = db.GetCarriages();
            dgTrain.DataSource = db.GetTrains();
            dgStations.DataSource = db.GetStations();
            dgRoutes.DataSource = vc.View_route.ToList();
            dgTrip.DataSource = vc.View_trip.ToList();
            dgPassanger.DataSource = db.GetPASSANGERs();
            dgTickets.DataSource = db.getTickets();

        }

        private void BSelect_Click(object sender, EventArgs e)
        {
            //  dgTrain.DataSource = db.
        }
        
        private void DgTrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgTrain.CurrentRow.Cells["id"].Value);
                string numberTrain = dgTrain.CurrentRow.Cells["numberTrain"].Value.ToString();
                string typeTrain = dgTrain.CurrentRow.Cells["typeTrain"].Value.ToString();

                if (e.ColumnIndex == 4)
                {
                    string message = "Вы действительно хотите удалить поезд " +
                        numberTrain;
                    string caption = "Подтверждение выбора";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.deleteTrain(id))
                        {
                           // MessageBox.Show(numberTrain + " удален");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить");
                        }
                    }
                    dgTrain.DataSource = db.GetTrains();
                }

                if (e.ColumnIndex == 3)
                {
                    using (New_train frm = new New_train(numberTrain, typeTrain))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            string types;
                            if (Convert.ToString(frm.comboBox1.Text) != "")
                            {
                                types = Convert.ToString(frm.comboBox1.Text);
                            }
                            else
                            {
                                types = Convert.ToString(frm.comboBox1.SelectedItem);
                            }
                            if (!db.UpdateTrain(id, frm.tNumberTrain.Text, types))
                            {
                                MessageBox.Show("Ошибка изменения");
                            };
                            dgTrain.DataSource = db.GetTrains();
                        }
                    }
                }
            }
           catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }

        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (New_train frm = new New_train())
                {
                    
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        string types;
                        if (Convert.ToString(frm.comboBox1.Text) != "")
                        {
                            types = Convert.ToString(frm.comboBox1.Text);
                            if(!Regex.IsMatch(types, @"^[А-Яа-я]{1}[а-я]{2,15}$"))
                            {
                                throw new Exception();
                            }
                        }
                        else
                        {
                            types = Convert.ToString(frm.comboBox1.SelectedItem);
                        }
                       


                        if (db.newTrain(frm.tNumberTrain.Text, types) == null)
                        {
                            MessageBox.Show("Ошибка вставки");
                        };
                        dgTrain.DataSource = db.GetTrains();
                    }
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(dgComposition.CurrentRow.Cells["idc"].Value);
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
                    dgComposition.DataSource = db.GetComposition();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            dgCarriage.DataSource = db.GetCarriages();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (New_carriage frm = new New_carriage())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        string types;
                        if (Convert.ToString(frm.comboBox1.Text) != "")
                        {
                            types = Convert.ToString(frm.comboBox1.Text);
                           
                        }
                        else
                        {
                            types = Convert.ToString(frm.comboBox1.SelectedItem);
                        }
                        int number = Convert.ToInt32(frm.tbNumberSeats.Text);
                        if (!Regex.IsMatch(Convert.ToString(number), "^[0-9]{1,2}$"))
                            throw new Exception();
                        if (db.newCarriage(number, types) == null)
                        {
                            MessageBox.Show("Ошибка вставки");
                        };
                        dgCarriage.DataSource = db.GetCarriages();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void DgCarriage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgCarriage.CurrentRow.Cells["idCarriage"].Value);
                int numberSeats = Convert.ToInt32(dgCarriage.CurrentRow.Cells["numberofseat"].Value);
                string typeCarriage = dgCarriage.CurrentRow.Cells["typecarriage"].Value.ToString();

                if (e.ColumnIndex == 4)
                {
                    string message = "Вы действительно хотите удалить вагон ";
                    string caption = "Подтверждение выбора";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.deleteCarriage(id))
                        {
                            MessageBox.Show("Вагон удален");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить");
                        }
                    }
                    dgCarriage.DataSource = db.GetCarriages();
                }

                if (e.ColumnIndex == 3)
                {


                    using (New_carriage frm = new New_carriage(numberSeats, typeCarriage))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            string types;
                            if (Convert.ToString(frm.comboBox1.Text) != "")
                            {
                                types = Convert.ToString(frm.comboBox1.Text);
                            }
                            else
                            {
                                types = Convert.ToString(frm.comboBox1.SelectedItem);
                            }
                            int number = Convert.ToInt32(frm.tbNumberSeats.Text);
                            if (!Regex.IsMatch(Convert.ToString(number), "^[0-9]{1,2}$"))
                                throw new Exception();
                            if (!db.UpdateCarriage(id, number, types))
                            {
                                MessageBox.Show("Ошибка изменения");
                            };
                            dgCarriage.DataSource = db.GetCarriages();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void BCreateComposition_Click(object sender, EventArgs e)
        {
            try
            {
                using (New_composition frm = new New_composition())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (db.newComposition(Convert.ToString(frm.cbTrain.SelectedValue), Convert.ToInt32(frm.cbCarriage.SelectedValue)) == null)
                        {
                            MessageBox.Show("Ошибка вставки");
                        };
                        dgComposition.DataSource = db.GetComposition();

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
            dgComposition.DataSource = db.GetComposition();
            dgCarriage.DataSource = db.GetCarriages();
        }

        private void BUpdateComposition_Click(object sender, EventArgs e)
        {
            dgComposition.DataSource = db.GetComposition();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgStations.CurrentRow.Cells["stationId"].Value);
                string name = dgStations.CurrentRow.Cells["stationName"].Value.ToString();

                if (e.ColumnIndex == 3)
                {
                    string message = "Вы действительно хотите удалить станцию " + name;
                    string caption = "Подтверждение выбора";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.deleteStation(id))
                        {
                            MessageBox.Show("Станция удалена");
                            db.checkAllRoute();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить");
                        }
                    }
                    dgStations.DataSource = db.GetStations();
                }

                if (e.ColumnIndex == 2)
                {


                    using (New_station frm = new New_station(name))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            if (!db.UpdateStation(id, frm.tbNameStation.Text))
                            {
                                MessageBox.Show("Ошибка изменения");
                            };

                            dgStations.DataSource = db.GetStations();
                            db.checkAllRoute();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (New_station frm = new New_station())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (db.newStation(frm.tbNameStation.Text) == null)
                        {
                            MessageBox.Show("Ошибка вставки");
                        };
                        dgStations.DataSource = db.GetStations();

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dgStations.DataSource = db.GetStations();
        }

        private void BUpdateRoute_Click(object sender, EventArgs e)
        {
            dgRoutes.DataSource = vc.View_route.ToList();
                
        }

        private void DCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (New_route frm = new New_route())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (db.newRoute(Convert.ToString(frm.cbStation1.SelectedValue), Convert.ToString(frm.cbStation2.SelectedValue), Convert.ToInt32(frm.tbTime.Text)) == null)
                        {
                            MessageBox.Show("Ошибка вставки. Возможно данный маршрут уже существует");
                        };
                        dgRoutes.DataSource =vc.View_route.ToList();

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void DgRoutes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string station1 = Convert.ToString(dgRoutes.CurrentRow.Cells["startnamestation"].Value);
                string station2 = Convert.ToString(dgRoutes.CurrentRow.Cells["finishnamestation"].Value);
                int min = Convert.ToInt32(dgRoutes.CurrentRow.Cells["routetime"].Value);
                int id = Convert.ToInt32(dgRoutes.CurrentRow.Cells["idroute"].Value);
                if (e.ColumnIndex == 5)
                {
                    string message = "Вы действительно хотите удалить маршрут ";
                    string caption = "Подтверждение выбора";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.deleteRoute(id))
                        {
                            MessageBox.Show("Маршрут удален");
                            db.checkAllRoute();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить");
                        }
                    }
                    dgRoutes.DataSource = vc.View_route.ToList();
                }

                if (e.ColumnIndex == 4)
                {

                    using (New_route frm = new New_route(station1,station2,min))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            if (!db.UpdateRoute(id, Convert.ToString(frm.cbStation1.SelectedValue), Convert.ToString(frm.cbStation2.SelectedValue), Convert.ToInt32(frm.tbTime.Text)))
                            {
                                MessageBox.Show("Ошибка вставки");
                            };
                            db.checkAllRoute();
                            dgRoutes.DataSource = vc.View_route.ToList();

                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dgTrip.DataSource = db.getTrip();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (New_trip frm = new New_trip(false))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (db.newTrip(Convert.ToString(frm.cbNumber.SelectedValue), frm.dtStart.Value, frm.dtFinish.Value, frm.listBox1.SelectedItems) == null)
                        {
                            MessageBox.Show("Ошибка вставки");
                        };
                        dgTrip.DataSource = db.getTrip(); 

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void DgTrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idTrip = Convert.ToInt32(dgTrip.CurrentRow.Cells["idtrip"].Value);
                string number = Convert.ToString(dgTrip.CurrentRow.Cells["train"].Value);
               
                if (e.ColumnIndex == 8)
                {
                    string message = "Вы действительно хотите удалить рейс ";
                    string caption = "Подтверждение выбора";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.deleteTrip(idTrip))
                        {
                            MessageBox.Show("Рейс удален");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить");
                        }
                    }
                    dgTrip.DataSource = db.getTrip();
                }

                if (e.ColumnIndex == 7)
                {


                    using (New_trip frm = new New_trip(false,false,number))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            
                            if (!db.updateTrip(idTrip, (String)frm.cbNumber.SelectedValue, frm.dtStart.Value, frm.dtFinish.Value, frm.listBox1.SelectedItems))
                            {
                                MessageBox.Show("Ошибка изменения");
                            };

                            dgTrip.DataSource = db.getTrip();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dgPassanger.DataSource = db.GetPASSANGERs();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (New_passanger frm = new New_passanger())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (db.newPassanger(frm.tbFIO.Text, frm.textBox2.Text) == null)
                        {
                            MessageBox.Show("Ошибка вставки");
                        };
                        dgPassanger.DataSource = db.GetPASSANGERs();

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void DgPassanger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgPassanger.CurrentRow.Cells["idpassanger"].Value);
                string name1 = Convert.ToString(dgPassanger.CurrentRow.Cells["namepassanger"].Value);
                string passport = Convert.ToString(dgPassanger.CurrentRow.Cells["passportpassanger"].Value);

                if (e.ColumnIndex == 4)
                {
                    string message = "Вы действительно хотите удалить пассажира ";
                    string caption = "Подтверждение выбора";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.deletePassanger(id))
                        {
                            MessageBox.Show("Пассажир удален");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить");
                        }
                    }
                    dgPassanger.DataSource = db.GetPASSANGERs();
                }

                if (e.ColumnIndex == 3)
                {


                    using (New_passanger frm = new New_passanger(name1, passport))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            if (!db.updatePassanger(id, frm.tbFIO.Text, frm.textBox2.Text))
                            {
                                MessageBox.Show("Ошибка изменения");
                            };

                            dgPassanger.DataSource = db.GetPASSANGERs();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dgTickets.DataSource = db.getTickets();
                //db.getTickets();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (New_ticket frm = new New_ticket())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (db.newTicket(Convert.ToInt32(frm.cbPassanger.SelectedValue),
                                         Convert.ToInt32(frm.cbNumber.SelectedValue),
                                         Convert.ToInt32(frm.cbCarriage.SelectedValue),
                                         Convert.ToInt32(frm.tbPrice.Text),
                                         Convert.ToInt32(frm.cbTrip.SelectedValue),
                                        Convert.ToString(frm.cbStation.SelectedValue)
                                            ) == null) 
                        {
                            MessageBox.Show("Ошибка вставки");
                        };
                        dgTickets.DataSource = db.getTickets();

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void DgTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgTickets.CurrentRow.Cells["idticket"].Value);


                if (e.ColumnIndex == 12)
                {
                    string message = "Вы действительно хотите удалить билет ";
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
                    dgTickets.DataSource = db.getTickets();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            //Environment.Exit(0);

        }

        private void CbNumberTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Train train = (Train)cbNumberTrain.SelectedItem;
            dgComposition.DataSource = db.getCompositionByTrain(train.numberTrain);
            
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbTypeCarriage_SelectedIndexChanged(object sender, EventArgs e)
        {
            String type = (String)cbTypeCarriage.SelectedItem;
            dgCarriage.DataSource = db.getCarriageByType(type);
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }
    }
    }


