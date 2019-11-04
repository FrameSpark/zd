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
    public partial class Guest : Form
    {
        PASSANGER passanger;
        public Guest(PASSANGER passanger)
        {
            InitializeComponent();
            this.passanger = passanger;
            
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            label1.Text = "ФИО: " + passanger.name;
            label2.Text = "Пасспорт: " +passanger.passport;
        }

        private void Guest_Deactivate(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
