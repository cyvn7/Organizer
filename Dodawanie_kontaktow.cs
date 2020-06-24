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

namespace organizer
{
    public partial class Dodawanie_kontaktow : Form
    {
        Form1 mainForm;



        private SqlCeConnection _con;

        public SqlCeCommand command;
        public string query = "";
        public Dodawanie_kontaktow(Form1 parent)
        {
            InitializeComponent();
            mainForm = parent;
            _con = parent._conn;

        }
        private void imie(object sender, EventArgs e)
        {
            if (imie_tb_okno.Text.Equals("Imię"))
            {
                imie_tb_okno.Text = "";
                imie_tb_okno.ForeColor = Color.Black;
            }
        }

        private void nazwisko(object sender, EventArgs e)
        {
            if (nazwisko_tb_okno.Text.Equals("Nazwisko"))
            {
                nazwisko_tb_okno.Text = "";
                nazwisko_tb_okno.ForeColor = Color.Black;
            }
        }
        private void firma(object sender, EventArgs e)
        {
            if (firma_tb_okno.Text.Equals("Nazwa firmy"))
            {
                firma_tb_okno.Text = "";
                firma_tb_okno.ForeColor = Color.Black;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void anuluj_okno_bt_Click(object sender, EventArgs e)
        {
        }

        private void firma_tb_okno_Leave(object sender, EventArgs e)
        {
            if (firma_tb_okno.Text.Equals(""))
            {
                firma_tb_okno.Text = "Nazwa firmy";
                firma_tb_okno.ForeColor = Color.Gray;
            }
        }

        private void nazwisko_tb_okno_Leave(object sender, EventArgs e)
        {
            if (nazwisko_tb_okno.Text.Equals(""))
            {
                nazwisko_tb_okno.Text = "Nazwisko";
                nazwisko_tb_okno.ForeColor = Color.Gray;
            }
        }

        private void imie_tb_okno_Leave(object sender, EventArgs e)
        {
            if (imie_tb_okno.Text.Equals(""))
            {
                imie_tb_okno.Text = "Imię";
                imie_tb_okno.ForeColor = Color.Gray;
            }
        }

        private void dodaj_okno_bt_Click(object sender, EventArgs e)
        {

            bool if_add = mainForm.WEZ_ADD();
            string imie = imie_tb_okno.Text;
            string nazwisko = nazwisko_tb_okno.Text;
            string firma = firma_tb_okno.Text;
            try
            {
                if(if_add == true)
                {
                    query = ("INSERT INTO [kontakty](imie, nazwisko, firma) VALUES('" + imie + "', '" + nazwisko + "', '" + firma + "');");
                    command = new SqlCeCommand(query, _con);
                    command.ExecuteNonQuery();
                }
                else
                {
                    query = ("update kontakty set imie = '" + imie + "' where ID_kontaktu = "+ mainForm.kontakty_IDKon + ";");
                    command = new SqlCeCommand(query, _con);
                    command.ExecuteNonQuery();

                    query = ("update kontakty set nazwisko = '" + nazwisko + "' where ID_kontaktu = " + mainForm.kontakty_IDKon + ";");
                    command = new SqlCeCommand(query, _con);
                    command.ExecuteNonQuery();

                    query = ("update kontakty set firma = '" + firma + "' where ID_kontaktu = " + mainForm.kontakty_IDKon + ";");
                    command = new SqlCeCommand(query, _con);
                    command.ExecuteNonQuery();
                }
                mainForm.kontakty_refresh();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dodawanie_kontaktow_Load(object sender, EventArgs e)
        {
        }
    }
}
