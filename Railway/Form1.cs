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
            dgComposition.DataSource = db.GetComposition();
            dgCarriage.DataSource = db.GetCarriages();
            dgTrain.DataSource = db.GetTrains();
            dgStations.DataSource = db.GetStations();
            dgRoutes.DataSource = db.getRoute();

        }

        private void BSelect_Click(object sender, EventArgs e)
        {
          //  dgTrain.DataSource = db.
        }

        private void DgTrain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgTrain.CurrentRow.Cells["id"].Value);
            string numberTrain = dgTrain.CurrentRow.Cells["numberTrain"].Value.ToString();
            string typeTrain = dgTrain.CurrentRow.Cells["typeTrain"].Value.ToString();

            if(e.ColumnIndex == 4)
            {
                string message = "Вы действительно хотите удалить поезд " +
                    numberTrain;
                string caption = "Подтверждение выбора";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    if(db.deleteTrain(id))
                    {
                        MessageBox.Show(numberTrain + " удален");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить");
                    }
                }
                dgTrain.DataSource = db.GetTrains();
            }

            if(e.ColumnIndex == 3)
            {
                using(New_train frm = new New_train(numberTrain, typeTrain))
                {
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        if(!db.UpdateTrain(id,frm.tNumberTrain.Text, frm.tTypeTrain.Text))
                        {
                            MessageBox.Show("Ошибка изменения");
                        };
                        dgTrain.DataSource = db.GetTrains();
                    }
                }
            }
                
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            using (New_train frm = new New_train())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (db.newTrain(frm.tNumberTrain.Text, frm.tTypeTrain.Text) == null)
                    {
                        MessageBox.Show("Ошибка вставки");
                    };
                    dgTrain.DataSource = db.GetTrains();
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgCarriage.CurrentRow.Cells["idcomposition"].Value);
            if (e.ColumnIndex == 3)
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

        private void BUpdate_Click(object sender, EventArgs e)
        {
            dgCarriage.DataSource = db.GetCarriages();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (New_carriage frm = new New_carriage())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (db.newCarriage(Convert.ToInt32(frm.tbNumberSeats.Text), frm.tbTypeCarriage.Text) == null)
                    {
                        MessageBox.Show("Ошибка вставки");
                    };
                    dgCarriage.DataSource = db.GetCarriages();
                }
            }
        }

        private void DgCarriage_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
               

                using (New_carriage frm = new New_carriage(numberSeats,typeCarriage))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (!db.UpdateCarriage(id, Convert.ToInt32(frm.tbNumberSeats.Text), frm.tbTypeCarriage.Text))
                        {
                            MessageBox.Show("Ошибка изменения");
                        };
                        dgCarriage.DataSource = db.GetCarriages();
                    }
                }
            }

        }

        private void BCreateComposition_Click(object sender, EventArgs e)
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
            int id = Convert.ToInt32(dgStations.CurrentRow.Cells["stationId"].Value);
            string name = dgStations.CurrentRow.Cells["stationName"].Value.ToString();

            if (e.ColumnIndex == 3)
            {
                string message = "Вы действительно хотите удалить станцию " + name ;
                string caption = "Подтверждение выбора";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (db.deleteStation(id))
                    {
                        MessageBox.Show("Станция удалена");
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
                    }
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            dgStations.DataSource = db.GetStations();
        }

        private void BUpdateRoute_Click(object sender, EventArgs e)
        {
            dgRoutes.DataSource = db.getRoute();
        }

        private void DCreate_Click(object sender, EventArgs e)
        {
            using (New_route frm = new New_route())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (db.newRoute(Convert.ToString(frm.cbStation1.SelectedValue), Convert.ToString(frm.cbStation2.SelectedValue), Convert.ToInt32(frm.tbTime.Text)) == null)
                    {
                        MessageBox.Show("Ошибка вставки");
                    };
                    dgRoutes.DataSource = db.getRoute();

                }
            }
        }

        private void DgRoutes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string station1 = Convert.ToString(dgRoutes.CurrentRow.Cells["idstartstation"].Value);
            string station2 = Convert.ToString(dgRoutes.CurrentRow.Cells["idfinishstation"].Value);
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
                        MessageBox.Show("Станция удалена");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить");
                    }
                }
                dgRoutes.DataSource = db.getRoute();
            }

            if (e.ColumnIndex == 4)
            {

                using (New_route frm = new New_route())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (!db.UpdateRoute(id,Convert.ToString(frm.cbStation1.SelectedValue), Convert.ToString(frm.cbStation2.SelectedValue), Convert.ToInt32(frm.tbTime.Text)))
                        {
                            MessageBox.Show("Ошибка вставки");
                        };
                        dgRoutes.DataSource = db.getRoute();

                    }
                }
            }
        }
    }
    }

