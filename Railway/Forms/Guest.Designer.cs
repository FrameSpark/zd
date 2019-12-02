namespace Railway.Forms
{
    partial class Guest
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.dgTrain = new System.Windows.Forms.DataGridView();
            this.idtrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timefiinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Купить = new System.Windows.Forms.DataGridViewButtonColumn();
            this.trainsGuestBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dgTicket = new System.Windows.Forms.DataGridView();
            this.idticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpassangerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbertrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcarriageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сдать = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainsGuestBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.trainsGuestBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsGuestBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trainsGuestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsGuestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource5)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgTrain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Покупка";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbStation);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Нужная станция";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(102, 55);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип поезда";
            // 
            // cbStation
            // 
            this.cbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(102, 19);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(121, 21);
            this.cbStation.TabIndex = 1;
            this.cbStation.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dgTrain
            // 
            this.dgTrain.AutoGenerateColumns = false;
            this.dgTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrain,
            this.number,
            this.startDataGridViewTextBoxColumn,
            this.finishDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.timestartDataGridViewTextBoxColumn,
            this.timefiinishDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.Купить});
            this.dgTrain.DataSource = this.trainsGuestBindingSource5;
            this.dgTrain.Location = new System.Drawing.Point(6, 132);
            this.dgTrain.Name = "dgTrain";
            this.dgTrain.Size = new System.Drawing.Size(682, 164);
            this.dgTrain.TabIndex = 0;
            this.dgTrain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTrain_CellContentClick);
            // 
            // idtrain
            // 
            this.idtrain.DataPropertyName = "id_train";
            this.idtrain.HeaderText = "id_train";
            this.idtrain.Name = "idtrain";
            this.idtrain.Visible = false;
            // 
            // number
            // 
            this.number.DataPropertyName = "number_train";
            this.number.HeaderText = "Номер поезда";
            this.number.Name = "number";
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Начальная станция";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            // 
            // finishDataGridViewTextBoxColumn
            // 
            this.finishDataGridViewTextBoxColumn.DataPropertyName = "finish";
            this.finishDataGridViewTextBoxColumn.HeaderText = "Конечная станция";
            this.finishDataGridViewTextBoxColumn.Name = "finishDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип поезда";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // timestartDataGridViewTextBoxColumn
            // 
            this.timestartDataGridViewTextBoxColumn.DataPropertyName = "time_start";
            this.timestartDataGridViewTextBoxColumn.HeaderText = "Время начала движения";
            this.timestartDataGridViewTextBoxColumn.Name = "timestartDataGridViewTextBoxColumn";
            // 
            // timefiinishDataGridViewTextBoxColumn
            // 
            this.timefiinishDataGridViewTextBoxColumn.DataPropertyName = "time_fiinish";
            this.timefiinishDataGridViewTextBoxColumn.HeaderText = "Время окончания движения";
            this.timefiinishDataGridViewTextBoxColumn.Name = "timefiinishDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Время в пути(ч)";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // Купить
            // 
            this.Купить.HeaderText = "Купить";
            this.Купить.Name = "Купить";
            this.Купить.Text = "Buy";
            this.Купить.ToolTipText = "Buy";
            // 
            // trainsGuestBindingSource5
            // 
            this.trainsGuestBindingSource5.DataSource = typeof(Railway.GuestModels.TrainsGuest);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dgTicket);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мои билеты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dgTicket
            // 
            this.dgTicket.AutoGenerateColumns = false;
            this.dgTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idticket,
            this.idpassangerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numbertrainDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn1,
            this.startDataGridViewTextBoxColumn1,
            this.finishDataGridViewTextBoxColumn1,
            this.stationDataGridViewTextBoxColumn,
            this.idtrainDataGridViewTextBoxColumn,
            this.idcarriageDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idtripDataGridViewTextBoxColumn,
            this.Сдать});
            this.dgTicket.DataSource = this.ticketBindingSource1;
            this.dgTicket.Location = new System.Drawing.Point(9, 63);
            this.dgTicket.Name = "dgTicket";
            this.dgTicket.Size = new System.Drawing.Size(682, 223);
            this.dgTicket.TabIndex = 0;
            this.dgTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTicket_CellContentClick);
            // 
            // idticket
            // 
            this.idticket.DataPropertyName = "id_ticket";
            this.idticket.HeaderText = "id_ticket";
            this.idticket.Name = "idticket";
            this.idticket.Visible = false;
            // 
            // idpassangerDataGridViewTextBoxColumn
            // 
            this.idpassangerDataGridViewTextBoxColumn.DataPropertyName = "id_passanger";
            this.idpassangerDataGridViewTextBoxColumn.HeaderText = "id_passanger";
            this.idpassangerDataGridViewTextBoxColumn.Name = "idpassangerDataGridViewTextBoxColumn";
            this.idpassangerDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numbertrainDataGridViewTextBoxColumn
            // 
            this.numbertrainDataGridViewTextBoxColumn.DataPropertyName = "number_train";
            this.numbertrainDataGridViewTextBoxColumn.HeaderText = "Номер поезда";
            this.numbertrainDataGridViewTextBoxColumn.Name = "numbertrainDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Время посадки";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            // 
            // startDataGridViewTextBoxColumn1
            // 
            this.startDataGridViewTextBoxColumn1.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn1.HeaderText = "start";
            this.startDataGridViewTextBoxColumn1.Name = "startDataGridViewTextBoxColumn1";
            this.startDataGridViewTextBoxColumn1.Visible = false;
            // 
            // finishDataGridViewTextBoxColumn1
            // 
            this.finishDataGridViewTextBoxColumn1.DataPropertyName = "finish";
            this.finishDataGridViewTextBoxColumn1.HeaderText = "finish";
            this.finishDataGridViewTextBoxColumn1.Name = "finishDataGridViewTextBoxColumn1";
            this.finishDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stationDataGridViewTextBoxColumn
            // 
            this.stationDataGridViewTextBoxColumn.DataPropertyName = "station";
            this.stationDataGridViewTextBoxColumn.HeaderText = "Станция назначения";
            this.stationDataGridViewTextBoxColumn.Name = "stationDataGridViewTextBoxColumn";
            // 
            // idtrainDataGridViewTextBoxColumn
            // 
            this.idtrainDataGridViewTextBoxColumn.DataPropertyName = "id_train";
            this.idtrainDataGridViewTextBoxColumn.HeaderText = "id_train";
            this.idtrainDataGridViewTextBoxColumn.Name = "idtrainDataGridViewTextBoxColumn";
            this.idtrainDataGridViewTextBoxColumn.Visible = false;
            // 
            // idcarriageDataGridViewTextBoxColumn
            // 
            this.idcarriageDataGridViewTextBoxColumn.DataPropertyName = "id_carriage";
            this.idcarriageDataGridViewTextBoxColumn.HeaderText = "Номер вагона";
            this.idcarriageDataGridViewTextBoxColumn.Name = "idcarriageDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // idtripDataGridViewTextBoxColumn
            // 
            this.idtripDataGridViewTextBoxColumn.DataPropertyName = "id_trip";
            this.idtripDataGridViewTextBoxColumn.HeaderText = "id_trip";
            this.idtripDataGridViewTextBoxColumn.Name = "idtripDataGridViewTextBoxColumn";
            this.idtripDataGridViewTextBoxColumn.Visible = false;
            // 
            // Сдать
            // 
            this.Сдать.HeaderText = "Сдать билет";
            this.Сдать.Name = "Сдать";
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataSource = typeof(Railway.Models.Ticket);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пасспорт:";
            // 
            // trainsGuestBindingSource4
            // 
            this.trainsGuestBindingSource4.DataSource = typeof(Railway.GuestModels.TrainsGuest);
            // 
            // trainsGuestBindingSource3
            // 
            this.trainsGuestBindingSource3.DataSource = typeof(Railway.GuestModels.TrainsGuest);
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(Railway.Models.Ticket);
            // 
            // trainsGuestBindingSource2
            // 
            this.trainsGuestBindingSource2.DataSource = typeof(Railway.GuestModels.TrainsGuest);
            // 
            // trainsGuestBindingSource
            // 
            this.trainsGuestBindingSource.DataSource = typeof(Railway.GuestModels.TrainsGuest);
            // 
            // trainsGuestBindingSource1
            // 
            this.trainsGuestBindingSource1.DataSource = typeof(Railway.GuestModels.TrainsGuest);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Guest";
            this.Text = "Guest";
            this.Deactivate += new System.EventHandler(this.Guest_Deactivate);
            this.Load += new System.EventHandler(this.Guest_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsGuestBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.DataGridView dgTrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource trainsGuestBindingSource;
        private System.Windows.Forms.BindingSource trainsGuestBindingSource2;
        private System.Windows.Forms.BindingSource trainsGuestBindingSource1;
        private System.Windows.Forms.BindingSource trainsGuestBindingSource3;
        private System.Windows.Forms.DataGridView dgTicket;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpassangerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbertrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarriageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Сдать;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private System.Windows.Forms.BindingSource trainsGuestBindingSource4;
        private System.Windows.Forms.BindingSource trainsGuestBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timefiinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Купить;
    }
}