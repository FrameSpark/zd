﻿using System;
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
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void BRegister_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text.Trim();
            login = Regex.Replace(login, @"\s+", " ");
            string password = tbPassport.Text.Trim();
            password = Regex.Replace(password, @"\s+", " ");
            if (db.getPassangerByNamePass(login, password) != null)
            {

                if (db.newPassanger(login, password) == null)
                    MessageBox.Show("Ошибка ввода");
                else
                MessageBox.Show("Пользователь зарегистрирован");
            }
            else
            {
                MessageBox.Show("Пользователь уже существует");
            }
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text.Trim();
            login = Regex.Replace(login, @"\s+", " ");
            string password = tbPassport.Text.Trim();
            password = Regex.Replace(password, @"\s+", " ");
            PASSANGER p = db.getPassangerByNamePass(login,password).LastOrDefault();
            if (p != null)
            {
                if (p.is_admin == 1)
                {
                    this.Hide();
                    Form1 fr = new Form1();
                    fr.ShowDialog();
                    this.Close();
                }
                if(p.is_admin == 0)
                {
                    
                    Guest frm = new Guest(p);
                    frm.Show();
                    //this.Close();
                    this.Visible = false;
                }
                if(p.is_admin == 3)
                {
                    TrainBOSS frm = new TrainBOSS(p);
                    frm.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }

        private void Sign_Deactivate(object sender, EventArgs e)
        {
    

        }
    }
}
