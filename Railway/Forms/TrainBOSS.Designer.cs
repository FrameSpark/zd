namespace Railway.Forms
{
    partial class TrainBOSS
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Отцепить = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idcomposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbertrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcarriageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecarriageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpassanger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbertrainDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcarriageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш поезд";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Состав";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пассажиры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomposition,
            this.numbertrainDataGridViewTextBoxColumn,
            this.idcarriageDataGridViewTextBoxColumn,
            this.typecarriageDataGridViewTextBoxColumn,
            this.Отцепить});
            this.dataGridView1.DataSource = this.compositionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Отцепить
            // 
            this.Отцепить.HeaderText = "Отцепить вагон";
            this.Отцепить.Name = "Отцепить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = ".";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Прицепить вагон";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idticket,
            this.idpassanger,
            this.nameDataGridViewTextBoxColumn,
            this.numbertrainDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.finishDataGridViewTextBoxColumn,
            this.stationDataGridViewTextBoxColumn,
            this.idtrainDataGridViewTextBoxColumn,
            this.idcarriageDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.idtripDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView2.DataSource = this.ticketBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(850, 378);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "снять с рейса";
            this.Column1.Name = "Column1";
            // 
            // idcomposition
            // 
            this.idcomposition.DataPropertyName = "id_composition";
            this.idcomposition.HeaderText = "id_composition";
            this.idcomposition.Name = "idcomposition";
            this.idcomposition.Visible = false;
            // 
            // numbertrainDataGridViewTextBoxColumn
            // 
            this.numbertrainDataGridViewTextBoxColumn.DataPropertyName = "number_train";
            this.numbertrainDataGridViewTextBoxColumn.HeaderText = "number_train";
            this.numbertrainDataGridViewTextBoxColumn.Name = "numbertrainDataGridViewTextBoxColumn";
            this.numbertrainDataGridViewTextBoxColumn.Visible = false;
            // 
            // idcarriageDataGridViewTextBoxColumn
            // 
            this.idcarriageDataGridViewTextBoxColumn.DataPropertyName = "id_carriage";
            this.idcarriageDataGridViewTextBoxColumn.HeaderText = "Номер вагона";
            this.idcarriageDataGridViewTextBoxColumn.Name = "idcarriageDataGridViewTextBoxColumn";
            // 
            // typecarriageDataGridViewTextBoxColumn
            // 
            this.typecarriageDataGridViewTextBoxColumn.DataPropertyName = "type_carriage";
            this.typecarriageDataGridViewTextBoxColumn.HeaderText = "Тип вагона";
            this.typecarriageDataGridViewTextBoxColumn.Name = "typecarriageDataGridViewTextBoxColumn";
            // 
            // compositionBindingSource
            // 
            this.compositionBindingSource.DataSource = typeof(Railway.Models.Composition);
            // 
            // idticket
            // 
            this.idticket.DataPropertyName = "id_ticket";
            this.idticket.HeaderText = "id_ticket";
            this.idticket.Name = "idticket";
            this.idticket.Visible = false;
            // 
            // idpassanger
            // 
            this.idpassanger.DataPropertyName = "id_passanger";
            this.idpassanger.HeaderText = "id_passanger";
            this.idpassanger.Name = "idpassanger";
            this.idpassanger.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numbertrainDataGridViewTextBoxColumn1
            // 
            this.numbertrainDataGridViewTextBoxColumn1.DataPropertyName = "number_train";
            this.numbertrainDataGridViewTextBoxColumn1.HeaderText = "number_train";
            this.numbertrainDataGridViewTextBoxColumn1.Name = "numbertrainDataGridViewTextBoxColumn1";
            this.numbertrainDataGridViewTextBoxColumn1.Visible = false;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Время посадки";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.Visible = false;
            // 
            // finishDataGridViewTextBoxColumn
            // 
            this.finishDataGridViewTextBoxColumn.DataPropertyName = "finish";
            this.finishDataGridViewTextBoxColumn.HeaderText = "finish";
            this.finishDataGridViewTextBoxColumn.Name = "finishDataGridViewTextBoxColumn";
            this.finishDataGridViewTextBoxColumn.Visible = false;
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
            // idcarriageDataGridViewTextBoxColumn1
            // 
            this.idcarriageDataGridViewTextBoxColumn1.DataPropertyName = "id_carriage";
            this.idcarriageDataGridViewTextBoxColumn1.HeaderText = "Номер вагона";
            this.idcarriageDataGridViewTextBoxColumn1.Name = "idcarriageDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена билета";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // idtripDataGridViewTextBoxColumn
            // 
            this.idtripDataGridViewTextBoxColumn.DataPropertyName = "id_trip";
            this.idtripDataGridViewTextBoxColumn.HeaderText = "id_trip";
            this.idtripDataGridViewTextBoxColumn.Name = "idtripDataGridViewTextBoxColumn";
            this.idtripDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(Railway.Models.Ticket);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = ".";
            // 
            // TrainBOSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TrainBOSS";
            this.Text = "TrainBOSS";
            this.Load += new System.EventHandler(this.TrainBOSS_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbertrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarriageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecarriageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Отцепить;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpassanger;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbertrainDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarriageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label label4;
    }
}