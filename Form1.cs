using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Collections;

namespace organizer
{
    public partial class Form1 : Form
    {
        public int kontakty_IDKon;
        public int kalendarz_IDkal;
        bool k_edycja = false;
        bool kontakty_add = true;
        List <string> notatki_tytuly = new List<string>();
        List <string> notatki_tresci = new List <string>();
        List<int> notatki_ID = new List<int>();
        //int[] notatki_ID;
        public SqlCeConnection _conn;
            public SqlCeCommand _comm;
            public SqlCeDataReader _read;
            public string query = "";
        public string imie, nazwisko, firma;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql_create();
        }

        private void kalendarz_Click(object sender, EventArgs e)
        {
            //panel1.Add(MonthCalendar);
           // this.Controls.Add(newButton);
        }
        
        private void notatki_tresc_click(object sender, EventArgs e)
        {
            if (notatki_tresc.Text.Equals("Wpisz notatkę"))
            {
                notatki_tresc.Text = "";
                notatki_tresc.ForeColor = Color.Black;
            }
        }

        private void notatki_tytul_click(object sender, EventArgs e)
        {
            if (notatki_tytul.Text.Equals("Tytuł"))
            {
                notatki_tytul.Text = "";
                notatki_tytul.ForeColor = Color.Black;
            }
        }
        

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            // MessageBox.Show(kalendarz_kal.SelectionStart.Date.ToString("yyyy-MM-dd"));

           // MessageBox.Show(kalendarz_kal.SelectionStart.Date.ToString("dd.MM.yyyy"));
            try
            {
                //query = ("INSERT INTO [kontakty](imie, nazwisko, firma) VALUES('" + imie + "', '" + nazwisko + "', '" + firma + "');");
                //_comm = new SqlCeCommand(query, _conn);
                // _comm.ExecuteNonQuery();
                query = "SELECT * FROM kalendarz WHERE daty like '" + kalendarz_kal.SelectionStart.Date.ToString("dd.MM.yyyy") + "%';";
                _comm = new SqlCeCommand(query, _conn);
                _read = _comm.ExecuteReader();
                kalendarz_daty.Columns.Clear();
                kalendarz_daty.Rows.Clear();
                kalendarz_daty.Columns.Add("ID_wydarzenia", "ID_wydarzenia");
                kalendarz_daty.Columns["ID_wydarzenia"].Visible = false;
                kalendarz_daty.Columns.Add("daty", "Data");
                kalendarz_daty.Columns.Add("tresc", "Wydarzenie");
                //int licznik = 1;
                while (_read.Read())
                {
                    kalendarz_daty.Rows.Add(new string[] { _read[0].ToString(), _read[1].ToString(), _read[2].ToString(), });

                    //licznik++;
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void sql_create()
        {
            string Source = "C://Temp//organizer.sdf";
            string Password = "maciek123";

            if(!File.Exists(Source))
            {
                SqlCeEngine ceEngine = new SqlCeEngine();
                ceEngine.LocalConnectionString = "DataSource=" + Source + "; Password=" + Password;
                ceEngine.CreateDatabase();


                sql_connect();


                query = "create table kontakty (ID_kontaktu bigint identity(1,1), imie nvarchar(50),nazwisko nvarchar(50), firma nvarchar(150)); ";
                _comm = new SqlCeCommand(query, _conn);
                _read = _comm.ExecuteReader();

                query = "create table notatki (ID_notatki bigint identity(1,1), tytul nvarchar(50), tresc nvarchar(1000)); ";
                _comm = new SqlCeCommand(query, _conn);
                _read = _comm.ExecuteReader();

                query = "create table kalendarz (ID_wydarzenia bigint identity(1,1), daty nvarchar(50), tresc nvarchar(100)); ";
                _comm = new SqlCeCommand(query, _conn);
                _read = _comm.ExecuteReader();

                //sql_connect();
            }
            else { sql_connect(); }
        }
        public void sql_connect()
        {
            try
            {
                
                string connect = "Data Source = C:\\Temp\\organizer.sdf; Password = maciek123";

                _conn = new SqlCeConnection(connect);

                //if (_conn.State != ConnectionState.Open)
                //{
                //    _conn.Open();
                //}
                _conn.Open();
                kontakty_refresh();
                notatki_refresh();
                kalendarz_refresh();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void notatki_refresh()
        {

            try
            {
                //query = ("INSERT INTO [kontakty](imie, nazwisko, firma) VALUES('" + imie + "', '" + nazwisko + "', '" + firma + "');");
                //_comm = new SqlCeCommand(query, _conn);
                // _comm.ExecuteNonQuery();
                query = "SELECT * FROM notatki";
                _comm = new SqlCeCommand(query, _conn);
                _read = _comm.ExecuteReader();
                notatki_lista.Columns.Clear();
                notatki_lista.Rows.Clear();
                notatki_lista.Columns.Add("ID_notatki", "ID_notatki");
                notatki_lista.Columns["ID_notatki"].Visible = false;
                notatki_lista.Columns.Add("tytul", "Tytuł");
                notatki_lista.Columns.Add("tresc", "tresc");
                notatki_lista.Columns["tresc"].Visible = false;
                //int licznik = 1;
                while (_read.Read())
                {
                    notatki_lista.Rows.Add(new string[] { _read[0].ToString(), _read[1].ToString(), _read[2].ToString(), });

                    //licznik++;
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void kontakty_refresh()
        {
            //try
            //{
            //    query = "SELECT id_pracownika, imie, nazwisko, wiek FROM pracownicy";
            //    _comm = new SqlCeCommand(query, _conn);

            //    _read = _comm.ExecuteReader();
            //}
            //catch (SqlCeException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            try
            {
                //query = ("INSERT INTO [kontakty](imie, nazwisko, firma) VALUES('" + imie + "', '" + nazwisko + "', '" + firma + "');");
                //_comm = new SqlCeCommand(query, _conn);
               // _comm.ExecuteNonQuery();
                query = "SELECT * FROM kontakty";
                _comm = new SqlCeCommand(query, _conn);
                _read = _comm.ExecuteReader();
                kontakty_tabela.Columns.Clear();
                kontakty_tabela.Rows.Clear();
                kontakty_tabela.Columns.Add("ID_kontaktu", "ID_kontaktu");
                kontakty_tabela.Columns["ID_kontaktu"].Visible = false;
                kontakty_tabela.Columns.Add("imie", "Imię");
                kontakty_tabela.Columns.Add("nazwisko", "Nazwisko");
                kontakty_tabela.Columns.Add("firma", "Firma");
                //int licznik = 1;
                while (_read.Read())
                {
                    kontakty_tabela.Rows.Add(new string[] { _read[0].ToString(), _read[1].ToString(), _read[2].ToString(), _read[3].ToString(), });
                    
                    //licznik++;
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void dodaj_bt_Click(object sender, EventArgs e)
        {
            kontakty_add = true;
            Dodawanie_kontaktow dk = new Dodawanie_kontaktow(this);
            dk.ShowDialog();
        }
        public void kalendarz_refresh()
        {
            try
            {
                //query = ("INSERT INTO [kontakty](imie, nazwisko, firma) VALUES('" + imie + "', '" + nazwisko + "', '" + firma + "');");
                //_comm = new SqlCeCommand(query, _conn);
                // _comm.ExecuteNonQuery();
                query = "SELECT * FROM kalendarz";
                _comm = new SqlCeCommand(query, _conn);
                _read = _comm.ExecuteReader();
                kalendarz_daty.Columns.Clear();
                kalendarz_daty.Rows.Clear();
                kalendarz_daty.Columns.Add("ID_wydarzenia", "ID_wydarzenia");
                kalendarz_daty.Columns["ID_wydarzenia"].Visible = false;
                kalendarz_daty.Columns.Add("daty", "Data");
                kalendarz_daty.Columns.Add("tresc", "Wydarzenie");
                //int licznik = 1;
                while (_read.Read())
                {
                    kalendarz_daty.Rows.Add(new string[] { _read[0].ToString(), _read[1].ToString(), _read[2].ToString(), });

                    //licznik++;
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void kontakty_dodawanie()
        {
            try
            {
                query = ("INSERT INTO [kontakty](imie, nazwisko, firma) VALUES('" + imie + "', '" + nazwisko + "', '" + firma + "');");
                _comm = new SqlCeCommand(query, _conn);
                _comm.ExecuteNonQuery();

                kontakty_refresh();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    TabPage t = sender as TabPage;
        //    if ()
        //    {
        //        kontakty_refresh();
        //        MessageBox.Show("");
        //    }
        }

        private void notatnik_add_Click(object sender, EventArgs e)
        {
            try
            {
                    string tytul = notatki_tytul.Text;
                    string tresc = notatki_tresc.Text;
                    query = ("INSERT INTO [notatki](tytul, tresc) VALUES('" + tytul + "', '" + tresc + "');");
                    _comm = new SqlCeCommand(query, _conn);
                    _comm.ExecuteNonQuery();
                    notatki_refresh();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void notatki_stworz_Click(object sender, EventArgs e)
        {
            int notatki_IDnot = 0;
            foreach (DataGridViewRow r in notatki_lista.SelectedRows)
            {
                notatki_IDnot = Convert.ToInt32(r.Cells[0].Value.ToString());
            }
            query = ("update notatki set tytul = '" + notatki_tytul.Text + "' where ID_notatki = " + notatki_IDnot + ";");
            _comm = new SqlCeCommand(query, _conn);
            _comm.ExecuteNonQuery();

            query = ("update notatki set tresc = '" + notatki_tresc.Text + "' where ID_notatki = " + notatki_IDnot + ";");
            _comm = new SqlCeCommand(query, _conn);
            _comm.ExecuteNonQuery();

            notatki_refresh();
        }

        

        private void kalendarz_dodaj_Click(object sender, EventArgs e)
        {
            dodawanie_Daty dw = new dodawanie_Daty(this);
            dw.ShowDialog();
        }

        private void usun_bt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in kontakty_tabela.SelectedRows)
            {


                query = ("delete from kontakty where ID_kontaktu = " + r.Cells[0].Value + ";");
                _comm = new SqlCeCommand(query, _conn);
                _comm.ExecuteNonQuery();
               // MessageBox.Show(r.Index.ToString(), "");
            }
            
            kontakty_refresh();
        }

        public void edytuj_bt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in kontakty_tabela.SelectedRows)
            {
                kontakty_IDKon = Convert.ToInt32(r.Cells[0].Value.ToString());
            }
            kontakty_add = false;
            Dodawanie_kontaktow dk = new Dodawanie_kontaktow(this);
            dk.ShowDialog();
        }

        private void notatki_tytul_Leave(object sender, EventArgs e)
        {
            if (notatki_tytul.Text.Equals(""))
            {
                notatki_tytul.Text = "Tytuł";
                notatki_tytul.ForeColor = Color.Gray;
            }
        }

        private void kalendarz_usun_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in kalendarz_daty.SelectedRows)
            {


                query = ("delete from kalendarz where ID_wydarzenia = " + r.Cells[0].Value + ";");
                _comm = new SqlCeCommand(query, _conn);
                _comm.ExecuteNonQuery();
                // MessageBox.Show(r.Index.ToString(), "");
            }

            kalendarz_refresh();
        }

        private void kalendarz_showall_Click(object sender, EventArgs e)
        {
            kalendarz_refresh();
        }

       

        private void notatki_tresc_Leave(object sender, EventArgs e)
        {
            if (notatki_tresc.Text.Equals(""))
            {
                notatki_tresc.Text = "Wpisz notatkę";
                notatki_tresc.ForeColor = Color.Gray;
            }
        }

        

        private void notatki_lista_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in notatki_lista.SelectedRows)
            {


                query = ("select * from notatki where ID_notatki = " + r.Cells[0].Value + ";");
                _comm = new SqlCeCommand(query, _conn);
                _read = _comm.ExecuteReader();
                // MessageBox.Show(r.Index.ToString(), "");
            }
            while (_read.Read())
            {
                kalendarz_daty.Rows.Add(new string[] { _read[0].ToString(), _read[1].ToString(), _read[2].ToString(), });
                this.notatki_tytul.Text = _read[1].ToString();
                this.notatki_tresc.Text = _read[2].ToString();
                //licznik++;
            }
            this.notatki_tytul.ForeColor = System.Drawing.Color.Black;
            this.notatki_tresc.ForeColor = System.Drawing.Color.Black;
        }

        private void notatki_bt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in notatki_lista.SelectedRows)
            {


                query = ("delete from notatki where ID_notatki = " + r.Cells[0].Value + ";");
                _comm = new SqlCeCommand(query, _conn);
                _comm.ExecuteNonQuery();
                // MessageBox.Show(r.Index.ToString(), "");
            }

            notatki_refresh();
        }

        public bool WEZ_ADD()
        {
            return kontakty_add;
        }

        public bool get_k()
        {
            return k_edycja;
        }
    }
}
