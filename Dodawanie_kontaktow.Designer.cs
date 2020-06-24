namespace organizer
{
    partial class Dodawanie_kontaktow
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
            this.imie_tb_okno = new System.Windows.Forms.TextBox();
            this.nazwisko_tb_okno = new System.Windows.Forms.TextBox();
            this.firma_tb_okno = new System.Windows.Forms.TextBox();
            this.dodaj_okno_bt = new System.Windows.Forms.Button();
            this.anuluj_okno_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imie_tb_okno
            // 
            this.imie_tb_okno.ForeColor = System.Drawing.Color.Gray;
            this.imie_tb_okno.Location = new System.Drawing.Point(8, 9);
            this.imie_tb_okno.MaxLength = 50;
            this.imie_tb_okno.Name = "imie_tb_okno";
            this.imie_tb_okno.Size = new System.Drawing.Size(236, 20);
            this.imie_tb_okno.TabIndex = 3;
            this.imie_tb_okno.Text = "Imię";
            this.imie_tb_okno.Enter += new System.EventHandler(this.imie);
            this.imie_tb_okno.Leave += new System.EventHandler(this.imie_tb_okno_Leave);
            // 
            // nazwisko_tb_okno
            // 
            this.nazwisko_tb_okno.ForeColor = System.Drawing.Color.Gray;
            this.nazwisko_tb_okno.Location = new System.Drawing.Point(8, 35);
            this.nazwisko_tb_okno.MaxLength = 50;
            this.nazwisko_tb_okno.Name = "nazwisko_tb_okno";
            this.nazwisko_tb_okno.Size = new System.Drawing.Size(236, 20);
            this.nazwisko_tb_okno.TabIndex = 4;
            this.nazwisko_tb_okno.Text = "Nazwisko";
            this.nazwisko_tb_okno.CursorChanged += new System.EventHandler(this.nazwisko);
            this.nazwisko_tb_okno.Enter += new System.EventHandler(this.nazwisko);
            this.nazwisko_tb_okno.Leave += new System.EventHandler(this.nazwisko_tb_okno_Leave);
            // 
            // firma_tb_okno
            // 
            this.firma_tb_okno.ForeColor = System.Drawing.Color.Gray;
            this.firma_tb_okno.Location = new System.Drawing.Point(8, 61);
            this.firma_tb_okno.MaxLength = 150;
            this.firma_tb_okno.Name = "firma_tb_okno";
            this.firma_tb_okno.Size = new System.Drawing.Size(236, 20);
            this.firma_tb_okno.TabIndex = 5;
            this.firma_tb_okno.Text = "Nazwa firmy";
            this.firma_tb_okno.CursorChanged += new System.EventHandler(this.firma);
            this.firma_tb_okno.Enter += new System.EventHandler(this.firma);
            this.firma_tb_okno.Leave += new System.EventHandler(this.firma_tb_okno_Leave);
            // 
            // dodaj_okno_bt
            // 
            this.dodaj_okno_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dodaj_okno_bt.Location = new System.Drawing.Point(8, 87);
            this.dodaj_okno_bt.Name = "dodaj_okno_bt";
            this.dodaj_okno_bt.Size = new System.Drawing.Size(118, 23);
            this.dodaj_okno_bt.TabIndex = 0;
            this.dodaj_okno_bt.Text = "Dodaj";
            this.dodaj_okno_bt.UseVisualStyleBackColor = true;
            this.dodaj_okno_bt.Click += new System.EventHandler(this.dodaj_okno_bt_Click);
            // 
            // anuluj_okno_bt
            // 
            this.anuluj_okno_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anuluj_okno_bt.Location = new System.Drawing.Point(132, 87);
            this.anuluj_okno_bt.Name = "anuluj_okno_bt";
            this.anuluj_okno_bt.Size = new System.Drawing.Size(112, 23);
            this.anuluj_okno_bt.TabIndex = 1;
            this.anuluj_okno_bt.Text = "Anuluj";
            this.anuluj_okno_bt.UseVisualStyleBackColor = true;
            this.anuluj_okno_bt.Click += new System.EventHandler(this.anuluj_okno_bt_Click);
            // 
            // Dodawanie_kontaktow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anuluj_okno_bt;
            this.ClientSize = new System.Drawing.Size(256, 115);
            this.Controls.Add(this.anuluj_okno_bt);
            this.Controls.Add(this.dodaj_okno_bt);
            this.Controls.Add(this.firma_tb_okno);
            this.Controls.Add(this.nazwisko_tb_okno);
            this.Controls.Add(this.imie_tb_okno);
            this.MaximizeBox = false;
            this.Name = "Dodawanie_kontaktow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj kontakt";
            this.Load += new System.EventHandler(this.Dodawanie_kontaktow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imie_tb_okno;
        private System.Windows.Forms.TextBox nazwisko_tb_okno;
        private System.Windows.Forms.TextBox firma_tb_okno;
        private System.Windows.Forms.Button dodaj_okno_bt;
        private System.Windows.Forms.Button anuluj_okno_bt;
    }
}