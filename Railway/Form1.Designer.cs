namespace Railway
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTrain = new System.Windows.Forms.DataGridView();
            this.bChange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update = new System.Windows.Forms.Button();
            this.cbTypeTrain = new System.Windows.Forms.ComboBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bUpdateComposition = new System.Windows.Forms.Button();
            this.bCreateComposition = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.dgCarriage = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgComposition = new System.Windows.Forms.DataGridView();
            this.deleteComposition = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dCreate = new System.Windows.Forms.Button();
            this.bUpdateRoute = new System.Windows.Forms.Button();
            this.dgRoutes = new System.Windows.Forms.DataGridView();
            this.editRoute = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteRoute = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgStations = new System.Windows.Forms.DataGridView();
            this.editStation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteStation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgTrip = new System.Windows.Forms.DataGridView();
            this.EditTrip = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteTrip = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgPassanger = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.editPassanger = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletePassanger = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgTickets = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.deleteTicket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCarriage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecarriage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carriageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idcomposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcarriageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idroute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstartstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfinishstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOUTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timefinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRIPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpassangerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcarriageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tICKETBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idpassanger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepassanger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportpassanger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSANGERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pASSANGERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tICKETBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarriage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComposition)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStations)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrip)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carriageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSANGERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSANGERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTrain
            // 
            this.dgTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTrain.AutoGenerateColumns = false;
            this.dgTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.numberTrain,
            this.typeTrain,
            this.bChange,
            this.bDelete});
            this.dgTrain.DataSource = this.trainBindingSource;
            this.dgTrain.Location = new System.Drawing.Point(8, 58);
            this.dgTrain.Name = "dgTrain";
            this.dgTrain.Size = new System.Drawing.Size(749, 295);
            this.dgTrain.TabIndex = 0;
            this.dgTrain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTrain_CellContentClick);
            // 
            // bChange
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChange.DefaultCellStyle = dataGridViewCellStyle1;
            this.bChange.HeaderText = "Изменить";
            this.bChange.Name = "bChange";
            this.bChange.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bChange.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bChange.Text = "Edit";
            this.bChange.ToolTipText = "Изменить";
            this.bChange.UseColumnTextForButtonValue = true;
            // 
            // bDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.bDelete.HeaderText = "Удалить";
            this.bDelete.Name = "bDelete";
            this.bDelete.Text = "Delete";
            this.bDelete.ToolTipText = "Delete";
            this.bDelete.UseColumnTextForButtonValue = true;
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.update.Location = new System.Drawing.Point(8, 31);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(70, 21);
            this.update.TabIndex = 1;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // cbTypeTrain
            // 
            this.cbTypeTrain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTypeTrain.FormattingEnabled = true;
            this.cbTypeTrain.Location = new System.Drawing.Point(159, 6);
            this.cbTypeTrain.Name = "cbTypeTrain";
            this.cbTypeTrain.Size = new System.Drawing.Size(114, 21);
            this.cbTypeTrain.TabIndex = 2;
            this.cbTypeTrain.SelectedIndexChanged += new System.EventHandler(this.CbTypeTrain_SelectedIndexChanged);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(6, 6);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(72, 21);
            this.bSelect.TabIndex = 3;
            this.bSelect.Text = "Create";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 385);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bSelect);
            this.tabPage1.Controls.Add(this.cbTypeTrain);
            this.tabPage1.Controls.Add(this.update);
            this.tabPage1.Controls.Add(this.dgTrain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поезда";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип поезда";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bUpdateComposition);
            this.tabPage2.Controls.Add(this.bCreateComposition);
            this.tabPage2.Controls.Add(this.bCreate);
            this.tabPage2.Controls.Add(this.bUpdate);
            this.tabPage2.Controls.Add(this.dgCarriage);
            this.tabPage2.Controls.Add(this.dgComposition);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Состав поезда и вагоны";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // bUpdateComposition
            // 
            this.bUpdateComposition.Location = new System.Drawing.Point(21, 50);
            this.bUpdateComposition.Name = "bUpdateComposition";
            this.bUpdateComposition.Size = new System.Drawing.Size(75, 23);
            this.bUpdateComposition.TabIndex = 5;
            this.bUpdateComposition.Text = "Update";
            this.bUpdateComposition.UseVisualStyleBackColor = true;
            this.bUpdateComposition.Click += new System.EventHandler(this.BUpdateComposition_Click);
            // 
            // bCreateComposition
            // 
            this.bCreateComposition.Location = new System.Drawing.Point(21, 21);
            this.bCreateComposition.Name = "bCreateComposition";
            this.bCreateComposition.Size = new System.Drawing.Size(75, 23);
            this.bCreateComposition.TabIndex = 4;
            this.bCreateComposition.Text = "Create";
            this.bCreateComposition.UseVisualStyleBackColor = true;
            this.bCreateComposition.Click += new System.EventHandler(this.BCreateComposition_Click);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(370, 21);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 3;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(370, 50);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 2;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // dgCarriage
            // 
            this.dgCarriage.AutoGenerateColumns = false;
            this.dgCarriage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarriage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarriage,
            this.numberofseat,
            this.typecarriage,
            this.edit,
            this.Delete});
            this.dgCarriage.DataSource = this.carriageBindingSource;
            this.dgCarriage.Location = new System.Drawing.Point(359, 80);
            this.dgCarriage.Name = "dgCarriage";
            this.dgCarriage.Size = new System.Drawing.Size(398, 226);
            this.dgCarriage.TabIndex = 1;
            this.dgCarriage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCarriage_CellContentClick);
            // 
            // edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.edit.HeaderText = "Изменить";
            this.edit.Name = "edit";
            this.edit.Text = "edit";
            this.edit.ToolTipText = "Изменить";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.HeaderText = "Удалить";
            this.Delete.Name = "Delete";
            this.Delete.Text = "delete";
            this.Delete.ToolTipText = "Удалить";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // dgComposition
            // 
            this.dgComposition.AutoGenerateColumns = false;
            this.dgComposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComposition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomposition,
            this.idtrainDataGridViewTextBoxColumn,
            this.idcarriageDataGridViewTextBoxColumn,
            this.deleteComposition});
            this.dgComposition.DataSource = this.compositionBindingSource;
            this.dgComposition.Location = new System.Drawing.Point(8, 79);
            this.dgComposition.Name = "dgComposition";
            this.dgComposition.Size = new System.Drawing.Size(345, 226);
            this.dgComposition.TabIndex = 0;
            this.dgComposition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // deleteComposition
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteComposition.DefaultCellStyle = dataGridViewCellStyle5;
            this.deleteComposition.HeaderText = "delete";
            this.deleteComposition.Name = "deleteComposition";
            this.deleteComposition.Text = "delete";
            this.deleteComposition.ToolTipText = "delete";
            this.deleteComposition.UseColumnTextForButtonValue = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dCreate);
            this.tabPage3.Controls.Add(this.bUpdateRoute);
            this.tabPage3.Controls.Add(this.dgRoutes);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dgStations);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(763, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Маршруты и станции";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dCreate
            // 
            this.dCreate.Location = new System.Drawing.Point(9, 49);
            this.dCreate.Name = "dCreate";
            this.dCreate.Size = new System.Drawing.Size(75, 23);
            this.dCreate.TabIndex = 5;
            this.dCreate.Text = "Create";
            this.dCreate.UseVisualStyleBackColor = true;
            this.dCreate.Click += new System.EventHandler(this.DCreate_Click);
            // 
            // bUpdateRoute
            // 
            this.bUpdateRoute.Location = new System.Drawing.Point(9, 78);
            this.bUpdateRoute.Name = "bUpdateRoute";
            this.bUpdateRoute.Size = new System.Drawing.Size(75, 23);
            this.bUpdateRoute.TabIndex = 4;
            this.bUpdateRoute.Text = "Update";
            this.bUpdateRoute.UseVisualStyleBackColor = true;
            this.bUpdateRoute.Click += new System.EventHandler(this.BUpdateRoute_Click);
            // 
            // dgRoutes
            // 
            this.dgRoutes.AutoGenerateColumns = false;
            this.dgRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idroute,
            this.idstartstation,
            this.idfinishstation,
            this.routetime,
            this.editRoute,
            this.deleteRoute});
            this.dgRoutes.DataSource = this.rOUTEBindingSource;
            this.dgRoutes.Location = new System.Drawing.Point(10, 107);
            this.dgRoutes.Name = "dgRoutes";
            this.dgRoutes.Size = new System.Drawing.Size(443, 198);
            this.dgRoutes.TabIndex = 3;
            this.dgRoutes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRoutes_CellContentClick);
            // 
            // editRoute
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRoute.DefaultCellStyle = dataGridViewCellStyle6;
            this.editRoute.HeaderText = "Edit";
            this.editRoute.Name = "editRoute";
            this.editRoute.Text = "Edit";
            this.editRoute.UseColumnTextForButtonValue = true;
            // 
            // deleteRoute
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRoute.DefaultCellStyle = dataGridViewCellStyle7;
            this.deleteRoute.HeaderText = "Delete";
            this.deleteRoute.Name = "deleteRoute";
            this.deleteRoute.Text = "Delete";
            this.deleteRoute.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dgStations
            // 
            this.dgStations.AutoGenerateColumns = false;
            this.dgStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationId,
            this.stationName,
            this.editStation,
            this.DeleteStation});
            this.dgStations.DataSource = this.sTATIONBindingSource;
            this.dgStations.Location = new System.Drawing.Point(507, 107);
            this.dgStations.Name = "dgStations";
            this.dgStations.Size = new System.Drawing.Size(241, 198);
            this.dgStations.TabIndex = 0;
            this.dgStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // editStation
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editStation.DefaultCellStyle = dataGridViewCellStyle9;
            this.editStation.HeaderText = "Edit";
            this.editStation.Name = "editStation";
            this.editStation.Text = "Edit";
            this.editStation.ToolTipText = "Edit";
            this.editStation.UseColumnTextForButtonValue = true;
            // 
            // DeleteStation
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStation.DefaultCellStyle = dataGridViewCellStyle10;
            this.DeleteStation.HeaderText = "Delete";
            this.DeleteStation.Name = "DeleteStation";
            this.DeleteStation.Text = "Delete";
            this.DeleteStation.ToolTipText = "Delete";
            this.DeleteStation.UseColumnTextForButtonValue = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.dgTrip);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(763, 359);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Рейсы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Create";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dgTrip
            // 
            this.dgTrip.AutoGenerateColumns = false;
            this.dgTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrip,
            this.idrouteDataGridViewTextBoxColumn,
            this.idtrainDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.timestartDataGridViewTextBoxColumn,
            this.timefinishDataGridViewTextBoxColumn,
            this.EditTrip,
            this.DeleteTrip});
            this.dgTrip.DataSource = this.tRIPBindingSource1;
            this.dgTrip.Location = new System.Drawing.Point(8, 94);
            this.dgTrip.Name = "dgTrip";
            this.dgTrip.Size = new System.Drawing.Size(726, 211);
            this.dgTrip.TabIndex = 0;
            this.dgTrip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTrip_CellContentClick);
            // 
            // EditTrip
            // 
            this.EditTrip.HeaderText = "Edit";
            this.EditTrip.Name = "EditTrip";
            this.EditTrip.Text = "Edit";
            this.EditTrip.ToolTipText = "Edit";
            this.EditTrip.UseColumnTextForButtonValue = true;
            // 
            // DeleteTrip
            // 
            this.DeleteTrip.HeaderText = "Delete";
            this.DeleteTrip.Name = "DeleteTrip";
            this.DeleteTrip.Text = "Delete";
            this.DeleteTrip.UseColumnTextForButtonValue = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.dgTickets);
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.dgPassanger);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(763, 359);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Пассажиры и билеты";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.TabPage5_Click);
            // 
            // dgPassanger
            // 
            this.dgPassanger.AutoGenerateColumns = false;
            this.dgPassanger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPassanger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpassanger,
            this.namepassanger,
            this.passportpassanger,
            this.editPassanger,
            this.deletePassanger});
            this.dgPassanger.DataSource = this.pASSANGERBindingSource;
            this.dgPassanger.Location = new System.Drawing.Point(6, 39);
            this.dgPassanger.Name = "dgPassanger";
            this.dgPassanger.Size = new System.Drawing.Size(562, 150);
            this.dgPassanger.TabIndex = 0;
            this.dgPassanger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPassanger_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(89, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Create";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // editPassanger
            // 
            this.editPassanger.HeaderText = "edit";
            this.editPassanger.Name = "editPassanger";
            this.editPassanger.Text = "edit";
            this.editPassanger.UseColumnTextForButtonValue = true;
            // 
            // deletePassanger
            // 
            this.deletePassanger.HeaderText = "delete";
            this.deletePassanger.Name = "deletePassanger";
            this.deletePassanger.Text = "delete";
            this.deletePassanger.UseColumnTextForButtonValue = true;
            // 
            // dgTickets
            // 
            this.dgTickets.AutoGenerateColumns = false;
            this.dgTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idticket,
            this.idpassangerDataGridViewTextBoxColumn,
            this.idtrainDataGridViewTextBoxColumn2,
            this.idcarriageDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.idtripDataGridViewTextBoxColumn,
            this.deleteTicket});
            this.dgTickets.DataSource = this.tICKETBindingSource2;
            this.dgTickets.Location = new System.Drawing.Point(8, 226);
            this.dgTickets.Name = "dgTickets";
            this.dgTickets.Size = new System.Drawing.Size(749, 127);
            this.dgTickets.TabIndex = 4;
            this.dgTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTickets_CellContentClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(90, 195);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Create";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // deleteTicket
            // 
            this.deleteTicket.HeaderText = "delete";
            this.deleteTicket.Name = "deleteTicket";
            this.deleteTicket.Text = "Delete";
            this.deleteTicket.UseColumnTextForButtonValue = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // numberTrain
            // 
            this.numberTrain.DataPropertyName = "numberTrain";
            this.numberTrain.HeaderText = "Номер поезда";
            this.numberTrain.Name = "numberTrain";
            // 
            // typeTrain
            // 
            this.typeTrain.DataPropertyName = "typeTrain";
            this.typeTrain.HeaderText = "Тип поезда";
            this.typeTrain.Name = "typeTrain";
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataSource = typeof(Railway.Models.Train);
            // 
            // idCarriage
            // 
            this.idCarriage.DataPropertyName = "id_carriage";
            this.idCarriage.HeaderText = "ID вагона";
            this.idCarriage.Name = "idCarriage";
            // 
            // numberofseat
            // 
            this.numberofseat.DataPropertyName = "number_of_seats";
            this.numberofseat.HeaderText = "Количество мест";
            this.numberofseat.Name = "numberofseat";
            // 
            // typecarriage
            // 
            this.typecarriage.DataPropertyName = "type_carriage";
            this.typecarriage.HeaderText = "Тип вагона";
            this.typecarriage.Name = "typecarriage";
            // 
            // carriageBindingSource
            // 
            this.carriageBindingSource.DataSource = typeof(Railway.Models.Carriage);
            // 
            // idcomposition
            // 
            this.idcomposition.DataPropertyName = "id_composition";
            this.idcomposition.HeaderText = "ID состава";
            this.idcomposition.Name = "idcomposition";
            // 
            // idtrainDataGridViewTextBoxColumn
            // 
            this.idtrainDataGridViewTextBoxColumn.DataPropertyName = "id_train";
            this.idtrainDataGridViewTextBoxColumn.HeaderText = "ID поезда";
            this.idtrainDataGridViewTextBoxColumn.Name = "idtrainDataGridViewTextBoxColumn";
            // 
            // idcarriageDataGridViewTextBoxColumn
            // 
            this.idcarriageDataGridViewTextBoxColumn.DataPropertyName = "id_carriage";
            this.idcarriageDataGridViewTextBoxColumn.HeaderText = "ID вагона";
            this.idcarriageDataGridViewTextBoxColumn.Name = "idcarriageDataGridViewTextBoxColumn";
            // 
            // compositionBindingSource
            // 
            this.compositionBindingSource.DataSource = typeof(Railway.Models.Composition);
            // 
            // idroute
            // 
            this.idroute.DataPropertyName = "id_route";
            this.idroute.HeaderText = "Id маршрута";
            this.idroute.Name = "idroute";
            // 
            // idstartstation
            // 
            this.idstartstation.DataPropertyName = "id_start_station";
            this.idstartstation.HeaderText = "Id начала маршрута";
            this.idstartstation.Name = "idstartstation";
            // 
            // idfinishstation
            // 
            this.idfinishstation.DataPropertyName = "id_finish_station";
            this.idfinishstation.HeaderText = "Id конца маршрута";
            this.idfinishstation.Name = "idfinishstation";
            // 
            // routetime
            // 
            this.routetime.DataPropertyName = "route_time";
            this.routetime.HeaderText = "Время маршрута";
            this.routetime.Name = "routetime";
            // 
            // rOUTEBindingSource
            // 
            this.rOUTEBindingSource.DataSource = typeof(Railway.ROUTE);
            // 
            // stationId
            // 
            this.stationId.DataPropertyName = "id_station";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationId.DefaultCellStyle = dataGridViewCellStyle8;
            this.stationId.HeaderText = "ID станции";
            this.stationId.Name = "stationId";
            // 
            // stationName
            // 
            this.stationName.DataPropertyName = "name_station";
            this.stationName.HeaderText = "Название станции";
            this.stationName.Name = "stationName";
            // 
            // sTATIONBindingSource
            // 
            this.sTATIONBindingSource.DataSource = typeof(Railway.STATION);
            // 
            // idtrip
            // 
            this.idtrip.DataPropertyName = "id_trip";
            this.idtrip.HeaderText = "Id рейса";
            this.idtrip.Name = "idtrip";
            // 
            // idrouteDataGridViewTextBoxColumn
            // 
            this.idrouteDataGridViewTextBoxColumn.DataPropertyName = "id_route";
            this.idrouteDataGridViewTextBoxColumn.HeaderText = "Id маршрута";
            this.idrouteDataGridViewTextBoxColumn.Name = "idrouteDataGridViewTextBoxColumn";
            // 
            // idtrainDataGridViewTextBoxColumn1
            // 
            this.idtrainDataGridViewTextBoxColumn1.DataPropertyName = "id_train";
            this.idtrainDataGridViewTextBoxColumn1.HeaderText = "Id поезда";
            this.idtrainDataGridViewTextBoxColumn1.Name = "idtrainDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус рейса";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // timestartDataGridViewTextBoxColumn
            // 
            this.timestartDataGridViewTextBoxColumn.DataPropertyName = "time_start";
            this.timestartDataGridViewTextBoxColumn.HeaderText = "Время начала поездки";
            this.timestartDataGridViewTextBoxColumn.Name = "timestartDataGridViewTextBoxColumn";
            // 
            // timefinishDataGridViewTextBoxColumn
            // 
            this.timefinishDataGridViewTextBoxColumn.DataPropertyName = "time_finish";
            this.timefinishDataGridViewTextBoxColumn.HeaderText = "Время окончания поездки";
            this.timefinishDataGridViewTextBoxColumn.Name = "timefinishDataGridViewTextBoxColumn";
            // 
            // tRIPBindingSource1
            // 
            this.tRIPBindingSource1.DataSource = typeof(Railway.TRIP);
            // 
            // idticket
            // 
            this.idticket.DataPropertyName = "id_ticket";
            this.idticket.HeaderText = "Id билета";
            this.idticket.Name = "idticket";
            // 
            // idpassangerDataGridViewTextBoxColumn
            // 
            this.idpassangerDataGridViewTextBoxColumn.DataPropertyName = "id_passanger";
            this.idpassangerDataGridViewTextBoxColumn.HeaderText = "Id пассажира";
            this.idpassangerDataGridViewTextBoxColumn.Name = "idpassangerDataGridViewTextBoxColumn";
            // 
            // idtrainDataGridViewTextBoxColumn2
            // 
            this.idtrainDataGridViewTextBoxColumn2.DataPropertyName = "id_train";
            this.idtrainDataGridViewTextBoxColumn2.HeaderText = "Id поезда";
            this.idtrainDataGridViewTextBoxColumn2.Name = "idtrainDataGridViewTextBoxColumn2";
            // 
            // idcarriageDataGridViewTextBoxColumn1
            // 
            this.idcarriageDataGridViewTextBoxColumn1.DataPropertyName = "id_carriage";
            this.idcarriageDataGridViewTextBoxColumn1.HeaderText = "Id вагона";
            this.idcarriageDataGridViewTextBoxColumn1.Name = "idcarriageDataGridViewTextBoxColumn1";
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
            this.idtripDataGridViewTextBoxColumn.HeaderText = "Id рейса";
            this.idtripDataGridViewTextBoxColumn.Name = "idtripDataGridViewTextBoxColumn";
            // 
            // tICKETBindingSource2
            // 
            this.tICKETBindingSource2.DataSource = typeof(Railway.TICKET);
            // 
            // idpassanger
            // 
            this.idpassanger.DataPropertyName = "id_passanger";
            this.idpassanger.HeaderText = "Id пассажира";
            this.idpassanger.Name = "idpassanger";
            // 
            // namepassanger
            // 
            this.namepassanger.DataPropertyName = "name";
            this.namepassanger.HeaderText = "ФИО";
            this.namepassanger.Name = "namepassanger";
            // 
            // passportpassanger
            // 
            this.passportpassanger.DataPropertyName = "passport";
            this.passportpassanger.HeaderText = "Номер пасспорта";
            this.passportpassanger.Name = "passportpassanger";
            // 
            // pASSANGERBindingSource
            // 
            this.pASSANGERBindingSource.DataSource = typeof(Railway.PASSANGER);
            // 
            // tRIPBindingSource
            // 
            this.tRIPBindingSource.DataSource = typeof(Railway.TRIP);
            // 
            // pASSANGERBindingSource1
            // 
            this.pASSANGERBindingSource1.DataSource = typeof(Railway.PASSANGER);
            // 
            // tICKETBindingSource
            // 
            this.tICKETBindingSource.DataSource = typeof(Railway.TICKET);
            // 
            // tICKETBindingSource1
            // 
            this.tICKETBindingSource1.DataSource = typeof(Railway.TICKET);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 386);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarriage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComposition)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStations)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrip)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPassanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carriageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSANGERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSANGERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTrain;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox cbTypeTrain;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTrain;
        private System.Windows.Forms.DataGridViewButtonColumn bChange;
        private System.Windows.Forms.DataGridViewButtonColumn bDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgComposition;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private System.Windows.Forms.DataGridView dgCarriage;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.BindingSource carriageBindingSource;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarriage;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofseat;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecarriage;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button bUpdateComposition;
        private System.Windows.Forms.Button bCreateComposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarriageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteComposition;
        private System.Windows.Forms.DataGridView dgStations;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource sTATIONBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationName;
        private System.Windows.Forms.DataGridViewButtonColumn editStation;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteStation;
        private System.Windows.Forms.DataGridView dgRoutes;
        private System.Windows.Forms.BindingSource rOUTEBindingSource;
        private System.Windows.Forms.Button bUpdateRoute;
        private System.Windows.Forms.Button dCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroute;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstartstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfinishstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn routetime;
        private System.Windows.Forms.DataGridViewButtonColumn editRoute;
        private System.Windows.Forms.DataGridViewButtonColumn deleteRoute;
        private System.Windows.Forms.DataGridView dgTrip;
        private System.Windows.Forms.BindingSource tRIPBindingSource;
        private System.Windows.Forms.BindingSource tRIPBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timefinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditTrip;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteTrip;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgPassanger;
        private System.Windows.Forms.BindingSource pASSANGERBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpassanger;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepassanger;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportpassanger;
        private System.Windows.Forms.DataGridViewButtonColumn editPassanger;
        private System.Windows.Forms.DataGridViewButtonColumn deletePassanger;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgTickets;
        private System.Windows.Forms.BindingSource tICKETBindingSource;
        private System.Windows.Forms.BindingSource pASSANGERBindingSource1;
        private System.Windows.Forms.BindingSource tICKETBindingSource2;
        private System.Windows.Forms.BindingSource tICKETBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpassangerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarriageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteTicket;
    }
}

