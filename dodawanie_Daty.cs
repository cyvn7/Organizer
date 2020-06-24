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
    public partial class dodawanie_Daty : Form
    {

        Form1 mainForm;



        private SqlCeConnection connect;

        public SqlCeCommand command;
        public string query = "";
        public dodawanie_Daty(Form1 parent)
        {
            InitializeComponent();
            k_dialog_wybor_daty.Format = DateTimePickerFormat.Custom;
            k_dialog_wybor_daty.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            mainForm = parent;
            connect = parent._conn;

        }

        private void dodawanie_Daty_Load(object sender, EventArgs e)
        {

        }

        private void k_dialog_dodaj_Click(object sender, EventArgs e)
        {
            //
            string wydarzenie = this.k_dialog_tb.Text;
            string data = this.k_dialog_wybor_daty.Value.ToString();

            bool dodawanie = mainForm.get_k();
            try
            {
                if (dodawanie == true)
                {
                    try
                    {

                        query = ("INSERT INTO [kalendarz](daty, tresc) VALUES('" + data + "', '" + wydarzenie + "');");
                        command = new SqlCeCommand(query, connect);
                        command.ExecuteNonQuery();
                        mainForm.kalendarz_refresh();
                    }
                    catch (SqlCeException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                 }
                else
                {
                    query = ("update kalendarz set daty = '" + data + "' where ID_wydarzenia = " + mainForm.kalendarz_IDkal + ";");
                    command = new SqlCeCommand(query, connect);
                    command.ExecuteNonQuery();

                    query = ("update kalendarz set tresc = '" + wydarzenie + "' where ID_wydarzenia = " + mainForm.kalendarz_IDkal + ";");
                    command = new SqlCeCommand(query, connect);
                    command.ExecuteNonQuery();
                }
                mainForm.kalendarz_refresh();
                this.Close();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
