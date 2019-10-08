namespace Railway
{
    partial class New_route
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
            this.cbStation1 = new System.Windows.Forms.ComboBox();
            this.cbStation2 = new System.Windows.Forms.ComboBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная станция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечная станция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время маршрута (в минутах)";
            // 
            // cbStation1
            // 
            this.cbStation1.FormattingEnabled = true;
            this.cbStation1.Location = new System.Drawing.Point(172, 12);
            this.cbStation1.Name = "cbStation1";
            this.cbStation1.Size = new System.Drawing.Size(121, 21);
            this.cbStation1.TabIndex = 3;
            // 
            // cbStation2
            // 
            this.cbStation2.FormattingEnabled = true;
            this.cbStation2.Location = new System.Drawing.Point(172, 48);
            this.cbStation2.Name = "cbStation2";
            this.cbStation2.Size = new System.Drawing.Size(121, 21);
            this.cbStation2.TabIndex = 4;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(172, 84);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(121, 20);
            this.tbTime.TabIndex = 5;
            // 
            // bCreate
            // 
            this.bCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bCreate.Location = new System.Drawing.Point(44, 136);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 6;
            this.bCreate.Text = "Создать";
            this.bCreate.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(172, 136);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // New_route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 176);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.cbStation2);
            this.Controls.Add(this.cbStation1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_route";
            this.Text = "New_route";
            this.Load += new System.EventHandler(this.New_route_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbStation1;
        public System.Windows.Forms.ComboBox cbStation2;
        public System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bCancel;
    }
}