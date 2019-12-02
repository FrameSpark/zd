namespace Railway.Forms
{
    partial class Buy
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
            this.cbCarriage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceBuy = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вагон";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cbCarriage
            // 
            this.cbCarriage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarriage.FormattingEnabled = true;
            this.cbCarriage.Location = new System.Drawing.Point(55, 6);
            this.cbCarriage.Name = "cbCarriage";
            this.cbCarriage.Size = new System.Drawing.Size(121, 21);
            this.cbCarriage.TabIndex = 1;
            this.cbCarriage.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.cbCarriage.SelectionChangeCommitted += new System.EventHandler(this.CbCarriage_SelectionChangeCommitted);
            this.cbCarriage.TextUpdate += new System.EventHandler(this.CbCarriage_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Свободные места";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // priceBuy
            // 
            this.priceBuy.AutoSize = true;
            this.priceBuy.Location = new System.Drawing.Point(12, 61);
            this.priceBuy.Name = "priceBuy";
            this.priceBuy.Size = new System.Drawing.Size(33, 13);
            this.priceBuy.TabIndex = 4;
            this.priceBuy.Text = "Цена";
            this.priceBuy.Click += new System.EventHandler(this.Label3_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(15, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Купить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(101, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 140);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCarriage);
            this.Controls.Add(this.label1);
            this.Name = "Buy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.Buy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label priceBuy;
        public System.Windows.Forms.ComboBox cbCarriage;
    }
}