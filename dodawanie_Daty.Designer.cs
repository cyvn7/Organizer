namespace organizer
{
    partial class dodawanie_Daty
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
            this.k_dialog_wybor_daty = new System.Windows.Forms.DateTimePicker();
            this.k_dialog_data_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.k_dialog_dodaj = new System.Windows.Forms.Button();
            this.k_dialog_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // k_dialog_wybor_daty
            // 
            this.k_dialog_wybor_daty.CustomFormat = "mm/dd/yyyy hh:mm:ss";
            this.k_dialog_wybor_daty.Location = new System.Drawing.Point(84, 10);
            this.k_dialog_wybor_daty.Name = "k_dialog_wybor_daty";
            this.k_dialog_wybor_daty.Size = new System.Drawing.Size(200, 20);
            this.k_dialog_wybor_daty.TabIndex = 0;
            // 
            // k_dialog_data_lb
            // 
            this.k_dialog_data_lb.AutoSize = true;
            this.k_dialog_data_lb.Location = new System.Drawing.Point(12, 12);
            this.k_dialog_data_lb.Name = "k_dialog_data_lb";
            this.k_dialog_data_lb.Size = new System.Drawing.Size(33, 13);
            this.k_dialog_data_lb.TabIndex = 1;
            this.k_dialog_data_lb.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wydarzenie:";
            // 
            // k_dialog_dodaj
            // 
            this.k_dialog_dodaj.Location = new System.Drawing.Point(13, 63);
            this.k_dialog_dodaj.Name = "k_dialog_dodaj";
            this.k_dialog_dodaj.Size = new System.Drawing.Size(271, 23);
            this.k_dialog_dodaj.TabIndex = 4;
            this.k_dialog_dodaj.Text = "Dodaj";
            this.k_dialog_dodaj.UseVisualStyleBackColor = true;
            this.k_dialog_dodaj.Click += new System.EventHandler(this.k_dialog_dodaj_Click);
            // 
            // k_dialog_tb
            // 
            this.k_dialog_tb.Location = new System.Drawing.Point(84, 37);
            this.k_dialog_tb.Name = "k_dialog_tb";
            this.k_dialog_tb.Size = new System.Drawing.Size(196, 20);
            this.k_dialog_tb.TabIndex = 5;
            // 
            // dodawanie_Daty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 92);
            this.Controls.Add(this.k_dialog_tb);
            this.Controls.Add(this.k_dialog_dodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.k_dialog_data_lb);
            this.Controls.Add(this.k_dialog_wybor_daty);
            this.Name = "dodawanie_Daty";
            this.Text = "Dodaj wydarzenie";
            this.Load += new System.EventHandler(this.dodawanie_Daty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker k_dialog_wybor_daty;
        private System.Windows.Forms.Label k_dialog_data_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button k_dialog_dodaj;
        private System.Windows.Forms.TextBox k_dialog_tb;
    }
}