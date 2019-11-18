namespace Railway
{
    partial class New_ticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPassanger = new System.Windows.Forms.ComboBox();
            this.cbNumber = new System.Windows.Forms.ComboBox();
            this.cbCarriage = new System.Windows.Forms.ComboBox();
            this.cbTrip = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пассажир";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер поезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вагон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Рейс";
            // 
            // cbPassanger
            // 
            this.cbPassanger.FormattingEnabled = true;
            this.cbPassanger.Location = new System.Drawing.Point(192, 9);
            this.cbPassanger.Name = "cbPassanger";
            this.cbPassanger.Size = new System.Drawing.Size(121, 21);
            this.cbPassanger.TabIndex = 5;
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.Location = new System.Drawing.Point(192, 36);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(121, 21);
            this.cbNumber.TabIndex = 6;
            this.cbNumber.SelectedIndexChanged += new System.EventHandler(this.CbNumber_SelectedIndexChanged);
            this.cbNumber.SelectionChangeCommitted += new System.EventHandler(this.CbNumber_SelectionChangeCommitted);
            // 
            // cbCarriage
            // 
            this.cbCarriage.FormattingEnabled = true;
            this.cbCarriage.Location = new System.Drawing.Point(192, 62);
            this.cbCarriage.Name = "cbCarriage";
            this.cbCarriage.Size = new System.Drawing.Size(121, 21);
            this.cbCarriage.TabIndex = 7;
            this.cbCarriage.SelectedIndexChanged += new System.EventHandler(this.CbCarriage_SelectedIndexChanged);
            // 
            // cbTrip
            // 
            this.cbTrip.FormattingEnabled = true;
            this.cbTrip.Location = new System.Drawing.Point(192, 118);
            this.cbTrip.Name = "cbTrip";
            this.cbTrip.Size = new System.Drawing.Size(121, 21);
            this.cbTrip.TabIndex = 8;
            this.cbTrip.SelectionChangeCommitted += new System.EventHandler(this.CbTrip_SelectionChangeCommitted);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(192, 92);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(121, 20);
            this.tbPrice.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(59, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(149, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Свободные места";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Станция";
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(192, 145);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(121, 21);
            this.cbStation.TabIndex = 14;
            // 
            // New_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 235);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.cbTrip);
            this.Controls.Add(this.cbCarriage);
            this.Controls.Add(this.cbNumber);
            this.Controls.Add(this.cbPassanger);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_ticket";
            this.Text = "New_ticket";
            this.Load += new System.EventHandler(this.New_ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbPassanger;
        public System.Windows.Forms.ComboBox cbNumber;
        public System.Windows.Forms.ComboBox cbCarriage;
        public System.Windows.Forms.ComboBox cbTrip;
        public System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbStation;
    }
}