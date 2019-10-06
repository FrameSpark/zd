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
            this.dgTrain = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.cbTypeTrain = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
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
            this.idDataGridViewTextBoxColumn,
            this.numberTrainDataGridViewTextBoxColumn,
            this.typeTrainDataGridViewTextBoxColumn});
            this.dgTrain.DataSource = this.trainBindingSource;
            this.dgTrain.Location = new System.Drawing.Point(12, 12);
            this.dgTrain.Name = "dgTrain";
            this.dgTrain.Size = new System.Drawing.Size(393, 315);
            this.dgTrain.TabIndex = 0;
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.update.Location = new System.Drawing.Point(411, 12);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(211, 23);
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
            this.cbTypeTrain.Location = new System.Drawing.Point(411, 50);
            this.cbTypeTrain.Name = "cbTypeTrain";
            this.cbTypeTrain.Size = new System.Drawing.Size(211, 21);
            this.cbTypeTrain.TabIndex = 2;
            this.cbTypeTrain.SelectedIndexChanged += new System.EventHandler(this.CbTypeTrain_SelectedIndexChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numberTrainDataGridViewTextBoxColumn
            // 
            this.numberTrainDataGridViewTextBoxColumn.DataPropertyName = "numberTrain";
            this.numberTrainDataGridViewTextBoxColumn.HeaderText = "Номер поезда";
            this.numberTrainDataGridViewTextBoxColumn.Name = "numberTrainDataGridViewTextBoxColumn";
            // 
            // typeTrainDataGridViewTextBoxColumn
            // 
            this.typeTrainDataGridViewTextBoxColumn.DataPropertyName = "typeTrain";
            this.typeTrainDataGridViewTextBoxColumn.HeaderText = "Тип поезда";
            this.typeTrainDataGridViewTextBoxColumn.Name = "typeTrainDataGridViewTextBoxColumn";
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataSource = typeof(Railway.Models.Train);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 339);
            this.Controls.Add(this.cbTypeTrain);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dgTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTrain;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox cbTypeTrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trainBindingSource;
    }
}

