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
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void BRegister_Click(object sender, EventArgs e)
        {
            if(db.getPassangerByNamePass(tbLogin.Text, tbPassport.Text) != null)
            {
                db.newPassanger(tbLogin.Text, tbPassport.Text);
                MessageBox.Show("Пользователь зарегистрирован");
            }
            else
            {
                MessageBox.Show("Пользователь уже существует");
            }
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            PASSANGER p = db.getPassangerByNamePass(tbLogin.Text, tbPassport.Text).LastOrDefault();
            if (p != null)
            {
                if (p.is_admin == 1)
                {
                    
                   Form1 fr = new Form1();
                    fr.Show();
                    //this.Close();
                    this.Visible = false;
                }
                else
                {
                    
                    Guest frm = new Guest(p);
                    frm.Show();
                    //this.Close();
                    this.Visible = false;
                }
            }
        }

        private void Sign_Deactivate(object sender, EventArgs e)
        {
    

        }
    }
}
