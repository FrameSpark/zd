namespace Railway
{
    partial class New_station
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
            this.bCreate = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameStation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCreate
            // 
            this.bCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bCreate.Location = new System.Drawing.Point(35, 76);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 0;
            this.bCreate.Text = "Создать";
            this.bCreate.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(128, 76);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название станции";
            // 
            // tbNameStation
            // 
            this.tbNameStation.Location = new System.Drawing.Point(128, 34);
            this.tbNameStation.Name = "tbNameStation";
            this.tbNameStation.Size = new System.Drawing.Size(100, 20);
            this.tbNameStation.TabIndex = 3;
            // 
            // New_station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 120);
            this.Controls.Add(this.tbNameStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCreate);
            this.Name = "New_station";
            this.Text = "New_station";
            this.Load += new System.EventHandler(this.New_station_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bCreate;
        public System.Windows.Forms.Button bCancel;
        public System.Windows.Forms.TextBox tbNameStation;
    }
}