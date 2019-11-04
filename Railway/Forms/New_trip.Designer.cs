namespace Railway
{
    partial class New_trip
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
            this.cbNumber = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtFinish = new System.Windows.Forms.DateTimePicker();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер поезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время начала поездки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время окончания поездки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id маршрута";
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.Location = new System.Drawing.Point(159, 9);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(200, 21);
            this.cbNumber.TabIndex = 4;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(159, 36);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 5;
            // 
            // dtFinish
            // 
            this.dtFinish.Location = new System.Drawing.Point(159, 62);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.Size = new System.Drawing.Size(200, 20);
            this.dtFinish.TabIndex = 6;
            // 
            // cbRoute
            // 
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Location = new System.Drawing.Point(159, 88);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(198, 21);
            this.cbRoute.TabIndex = 7;
            this.cbRoute.SelectedIndexChanged += new System.EventHandler(this.CbRoute_SelectedIndexChanged);
            this.cbRoute.SelectionChangeCommitted += new System.EventHandler(this.CbRoute_SelectionChangeCommitted);
            this.cbRoute.SelectedValueChanged += new System.EventHandler(this.CbRoute_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(78, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(212, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // New_trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 185);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbRoute);
            this.Controls.Add(this.dtFinish);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cbNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_trip";
            this.Text = "New_trip";
            this.Load += new System.EventHandler(this.New_trip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox cbNumber;
        public System.Windows.Forms.DateTimePicker dtStart;
        public System.Windows.Forms.DateTimePicker dtFinish;
        public System.Windows.Forms.ComboBox cbRoute;
    }
}