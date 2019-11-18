namespace Railway
{
    partial class New_composition
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
            this.cbTrain = new System.Windows.Forms.ComboBox();
            this.cbCarriage = new System.Windows.Forms.ComboBox();
            this.bCreateConposition = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поезд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вагон";
            // 
            // cbTrain
            // 
            this.cbTrain.FormattingEnabled = true;
            this.cbTrain.Location = new System.Drawing.Point(57, 9);
            this.cbTrain.Name = "cbTrain";
            this.cbTrain.Size = new System.Drawing.Size(121, 21);
            this.cbTrain.TabIndex = 2;
            this.cbTrain.SelectedIndexChanged += new System.EventHandler(this.CbTrain_SelectedIndexChanged);
            // 
            // cbCarriage
            // 
            this.cbCarriage.FormattingEnabled = true;
            this.cbCarriage.Location = new System.Drawing.Point(57, 37);
            this.cbCarriage.Name = "cbCarriage";
            this.cbCarriage.Size = new System.Drawing.Size(121, 21);
            this.cbCarriage.TabIndex = 3;
            this.cbCarriage.SelectedIndexChanged += new System.EventHandler(this.CbCarriage_SelectedIndexChanged);
            // 
            // bCreateConposition
            // 
            this.bCreateConposition.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bCreateConposition.Location = new System.Drawing.Point(47, 93);
            this.bCreateConposition.Name = "bCreateConposition";
            this.bCreateConposition.Size = new System.Drawing.Size(75, 23);
            this.bCreateConposition.TabIndex = 4;
            this.bCreateConposition.Text = "Создать";
            this.bCreateConposition.UseVisualStyleBackColor = true;
            this.bCreateConposition.Click += new System.EventHandler(this.BCreateConposition_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(140, 93);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // New_composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 168);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCreateConposition);
            this.Controls.Add(this.cbCarriage);
            this.Controls.Add(this.cbTrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_composition";
            this.Text = "New_composition";
            this.Load += new System.EventHandler(this.New_composition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbTrain;
        private System.Windows.Forms.Button bCreateConposition;
        private System.Windows.Forms.Button bCancel;
        public System.Windows.Forms.ComboBox cbCarriage;
    }
}