namespace organizer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kalendarz = new System.Windows.Forms.TabPage();
            this.kalendarz_showall = new System.Windows.Forms.Button();
            this.kalendarz_edytuj = new System.Windows.Forms.Button();
            this.kalendarz_usun = new System.Windows.Forms.Button();
            this.kalendarz_dodaj = new System.Windows.Forms.Button();
            this.kalendarz_daty = new System.Windows.Forms.DataGridView();
            this.kalendarz_kal = new System.Windows.Forms.MonthCalendar();
            this.kontakty = new System.Windows.Forms.TabPage();
            this.notatki_lista = new System.Windows.Forms.DataGridView();
            this.notatnik_add = new System.Windows.Forms.Button();
            this.notatki_tytul = new System.Windows.Forms.TextBox();
            this.notatki_tresc = new System.Windows.Forms.TextBox();
            this.notatki_zaktualizuj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.TabPage();
            this.usun_bt = new System.Windows.Forms.Button();
            this.edytuj_bt = new System.Windows.Forms.Button();
            this.dodaj_bt = new System.Windows.Forms.Button();
            this.kontakty_tabela = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notatki_bt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.kalendarz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kalendarz_daty)).BeginInit();
            this.kontakty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notatki_lista)).BeginInit();
            this.usun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontakty_tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kalendarz);
            this.tabControl1.Controls.Add(this.kontakty);
            this.tabControl1.Controls.Add(this.usun);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 208);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // kalendarz
            // 
            this.kalendarz.Controls.Add(this.kalendarz_showall);
            this.kalendarz.Controls.Add(this.kalendarz_edytuj);
            this.kalendarz.Controls.Add(this.kalendarz_usun);
            this.kalendarz.Controls.Add(this.kalendarz_dodaj);
            this.kalendarz.Controls.Add(this.kalendarz_daty);
            this.kalendarz.Controls.Add(this.kalendarz_kal);
            this.kalendarz.Location = new System.Drawing.Point(4, 22);
            this.kalendarz.Name = "kalendarz";
            this.kalendarz.Padding = new System.Windows.Forms.Padding(3);
            this.kalendarz.Size = new System.Drawing.Size(589, 182);
            this.kalendarz.TabIndex = 0;
            this.kalendarz.Text = "Kalendarz";
            this.kalendarz.UseVisualStyleBackColor = true;
            // 
            // kalendarz_showall
            // 
            this.kalendarz_showall.Location = new System.Drawing.Point(359, 154);
            this.kalendarz_showall.Name = "kalendarz_showall";
            this.kalendarz_showall.Size = new System.Drawing.Size(55, 23);
            this.kalendarz_showall.TabIndex = 5;
            this.kalendarz_showall.Text = "Wszystko";
            this.kalendarz_showall.UseVisualStyleBackColor = true;
            this.kalendarz_showall.Click += new System.EventHandler(this.kalendarz_showall_Click);
            // 
            // kalendarz_edytuj
            // 
            this.kalendarz_edytuj.Location = new System.Drawing.Point(498, 154);
            this.kalendarz_edytuj.Name = "kalendarz_edytuj";
            this.kalendarz_edytuj.Size = new System.Drawing.Size(85, 23);
            this.kalendarz_edytuj.TabIndex = 4;
            this.kalendarz_edytuj.Text = "Edytuj";
            this.kalendarz_edytuj.UseVisualStyleBackColor = true;
            // 
            // kalendarz_usun
            // 
            this.kalendarz_usun.Location = new System.Drawing.Point(420, 154);
            this.kalendarz_usun.Name = "kalendarz_usun";
            this.kalendarz_usun.Size = new System.Drawing.Size(72, 23);
            this.kalendarz_usun.TabIndex = 3;
            this.kalendarz_usun.Text = "Usuń";
            this.kalendarz_usun.UseVisualStyleBackColor = true;
            this.kalendarz_usun.Click += new System.EventHandler(this.kalendarz_usun_Click);
            // 
            // kalendarz_dodaj
            // 
            this.kalendarz_dodaj.Location = new System.Drawing.Point(290, 155);
            this.kalendarz_dodaj.Name = "kalendarz_dodaj";
            this.kalendarz_dodaj.Size = new System.Drawing.Size(63, 21);
            this.kalendarz_dodaj.TabIndex = 2;
            this.kalendarz_dodaj.Text = "Dodaj";
            this.kalendarz_dodaj.UseVisualStyleBackColor = true;
            this.kalendarz_dodaj.Click += new System.EventHandler(this.kalendarz_dodaj_Click);
            // 
            // kalendarz_daty
            // 
            this.kalendarz_daty.AllowUserToAddRows = false;
            this.kalendarz_daty.AllowUserToDeleteRows = false;
            this.kalendarz_daty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kalendarz_daty.Location = new System.Drawing.Point(290, 10);
            this.kalendarz_daty.MultiSelect = false;
            this.kalendarz_daty.Name = "kalendarz_daty";
            this.kalendarz_daty.ReadOnly = true;
            this.kalendarz_daty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kalendarz_daty.Size = new System.Drawing.Size(293, 139);
            this.kalendarz_daty.TabIndex = 1;
            // 
            // kalendarz_kal
            // 
            this.kalendarz_kal.Location = new System.Drawing.Point(9, 10);
            this.kalendarz_kal.Name = "kalendarz_kal";
            this.kalendarz_kal.ShowToday = false;
            this.kalendarz_kal.TabIndex = 0;
            this.kalendarz_kal.TodayDate = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
            this.kalendarz_kal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // kontakty
            // 
            this.kontakty.Controls.Add(this.notatki_bt);
            this.kontakty.Controls.Add(this.notatki_lista);
            this.kontakty.Controls.Add(this.notatnik_add);
            this.kontakty.Controls.Add(this.notatki_tytul);
            this.kontakty.Controls.Add(this.notatki_tresc);
            this.kontakty.Controls.Add(this.notatki_zaktualizuj);
            this.kontakty.Location = new System.Drawing.Point(4, 22);
            this.kontakty.Name = "kontakty";
            this.kontakty.Size = new System.Drawing.Size(589, 182);
            this.kontakty.TabIndex = 2;
            this.kontakty.Text = "Notatnik";
            this.kontakty.UseVisualStyleBackColor = true;
            // 
            // notatki_lista
            // 
            this.notatki_lista.AllowUserToAddRows = false;
            this.notatki_lista.AllowUserToDeleteRows = false;
            this.notatki_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notatki_lista.Location = new System.Drawing.Point(3, 6);
            this.notatki_lista.MultiSelect = false;
            this.notatki_lista.Name = "notatki_lista";
            this.notatki_lista.ReadOnly = true;
            this.notatki_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notatki_lista.Size = new System.Drawing.Size(106, 143);
            this.notatki_lista.TabIndex = 5;
            this.notatki_lista.Click += new System.EventHandler(this.notatki_lista_Click);
            // 
            // notatnik_add
            // 
            this.notatnik_add.Location = new System.Drawing.Point(175, 155);
            this.notatnik_add.Name = "notatnik_add";
            this.notatnik_add.Size = new System.Drawing.Size(231, 23);
            this.notatnik_add.TabIndex = 4;
            this.notatnik_add.Text = "Dodaj";
            this.notatnik_add.UseVisualStyleBackColor = true;
            this.notatnik_add.Click += new System.EventHandler(this.notatnik_add_Click);
            // 
            // notatki_tytul
            // 
            this.notatki_tytul.ForeColor = System.Drawing.Color.Black;
            this.notatki_tytul.Location = new System.Drawing.Point(115, 6);
            this.notatki_tytul.MaxLength = 50;
            this.notatki_tytul.Name = "notatki_tytul";
            this.notatki_tytul.Size = new System.Drawing.Size(471, 20);
            this.notatki_tytul.TabIndex = 3;
            this.notatki_tytul.Text = "Tytuł";
            this.notatki_tytul.Enter += new System.EventHandler(this.notatki_tytul_click);
            this.notatki_tytul.Leave += new System.EventHandler(this.notatki_tytul_Leave);
            // 
            // notatki_tresc
            // 
            this.notatki_tresc.ForeColor = System.Drawing.Color.Black;
            this.notatki_tresc.Location = new System.Drawing.Point(115, 32);
            this.notatki_tresc.MaxLength = 1000;
            this.notatki_tresc.Multiline = true;
            this.notatki_tresc.Name = "notatki_tresc";
            this.notatki_tresc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notatki_tresc.Size = new System.Drawing.Size(471, 117);
            this.notatki_tresc.TabIndex = 2;
            this.notatki_tresc.Text = "Wpisz notatkę";
            this.notatki_tresc.Enter += new System.EventHandler(this.notatki_tresc_click);
            this.notatki_tresc.Leave += new System.EventHandler(this.notatki_tresc_Leave);
            // 
            // notatki_zaktualizuj
            // 
            this.notatki_zaktualizuj.Location = new System.Drawing.Point(3, 155);
            this.notatki_zaktualizuj.Name = "notatki_zaktualizuj";
            this.notatki_zaktualizuj.Size = new System.Drawing.Size(166, 23);
            this.notatki_zaktualizuj.TabIndex = 1;
            this.notatki_zaktualizuj.Text = "Zaktualizuj";
            this.notatki_zaktualizuj.UseVisualStyleBackColor = true;
            this.notatki_zaktualizuj.Click += new System.EventHandler(this.notatki_stworz_Click);
            // 
            // usun
            // 
            this.usun.Controls.Add(this.usun_bt);
            this.usun.Controls.Add(this.edytuj_bt);
            this.usun.Controls.Add(this.dodaj_bt);
            this.usun.Controls.Add(this.kontakty_tabela);
            this.usun.Location = new System.Drawing.Point(4, 22);
            this.usun.Name = "usun";
            this.usun.Padding = new System.Windows.Forms.Padding(3);
            this.usun.Size = new System.Drawing.Size(589, 182);
            this.usun.TabIndex = 1;
            this.usun.Text = "Kontakty";
            this.usun.UseVisualStyleBackColor = true;
            // 
            // usun_bt
            // 
            this.usun_bt.Location = new System.Drawing.Point(508, 63);
            this.usun_bt.Name = "usun_bt";
            this.usun_bt.Size = new System.Drawing.Size(75, 49);
            this.usun_bt.TabIndex = 3;
            this.usun_bt.Text = "Usuń";
            this.usun_bt.UseVisualStyleBackColor = true;
            this.usun_bt.Click += new System.EventHandler(this.usun_bt_Click);
            // 
            // edytuj_bt
            // 
            this.edytuj_bt.Location = new System.Drawing.Point(508, 118);
            this.edytuj_bt.Name = "edytuj_bt";
            this.edytuj_bt.Size = new System.Drawing.Size(75, 49);
            this.edytuj_bt.TabIndex = 2;
            this.edytuj_bt.Text = "Edytuj";
            this.edytuj_bt.UseVisualStyleBackColor = true;
            this.edytuj_bt.Click += new System.EventHandler(this.edytuj_bt_Click);
            // 
            // dodaj_bt
            // 
            this.dodaj_bt.Location = new System.Drawing.Point(508, 8);
            this.dodaj_bt.Name = "dodaj_bt";
            this.dodaj_bt.Size = new System.Drawing.Size(75, 49);
            this.dodaj_bt.TabIndex = 1;
            this.dodaj_bt.Text = "Dodaj";
            this.dodaj_bt.UseVisualStyleBackColor = true;
            this.dodaj_bt.Click += new System.EventHandler(this.dodaj_bt_Click);
            // 
            // kontakty_tabela
            // 
            this.kontakty_tabela.AllowUserToAddRows = false;
            this.kontakty_tabela.AllowUserToDeleteRows = false;
            this.kontakty_tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kontakty_tabela.Location = new System.Drawing.Point(3, 6);
            this.kontakty_tabela.MultiSelect = false;
            this.kontakty_tabela.Name = "kontakty_tabela";
            this.kontakty_tabela.ReadOnly = true;
            this.kontakty_tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kontakty_tabela.Size = new System.Drawing.Size(499, 169);
            this.kontakty_tabela.TabIndex = 0;
            // 
            // notatki_bt
            // 
            this.notatki_bt.Location = new System.Drawing.Point(412, 155);
            this.notatki_bt.Name = "notatki_bt";
            this.notatki_bt.Size = new System.Drawing.Size(174, 23);
            this.notatki_bt.TabIndex = 6;
            this.notatki_bt.Text = "Usuń";
            this.notatki_bt.UseVisualStyleBackColor = true;
            this.notatki_bt.Click += new System.EventHandler(this.notatki_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 225);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.kalendarz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kalendarz_daty)).EndInit();
            this.kontakty.ResumeLayout(false);
            this.kontakty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notatki_lista)).EndInit();
            this.usun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kontakty_tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage kalendarz;
        private System.Windows.Forms.TabPage usun;
        private System.Windows.Forms.MonthCalendar kalendarz_kal;
        private System.Windows.Forms.TabPage kontakty;
        private System.Windows.Forms.TextBox notatki_tytul;
        private System.Windows.Forms.Button notatki_zaktualizuj;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox notatki_tresc;
        private System.Windows.Forms.DataGridView kontakty_tabela;
        private System.Windows.Forms.Button usun_bt;
        private System.Windows.Forms.Button edytuj_bt;
        private System.Windows.Forms.Button dodaj_bt;
        private System.Windows.Forms.Button notatnik_add;
        private System.Windows.Forms.DataGridView kalendarz_daty;
        private System.Windows.Forms.Button kalendarz_dodaj;
        private System.Windows.Forms.Button kalendarz_edytuj;
        private System.Windows.Forms.Button kalendarz_usun;
        private System.Windows.Forms.Button kalendarz_showall;
        private System.Windows.Forms.DataGridView notatki_lista;
        private System.Windows.Forms.Button notatki_bt;
    }
}

