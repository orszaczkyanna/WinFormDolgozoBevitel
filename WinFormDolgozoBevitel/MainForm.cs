using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormDolgozoBevitel
{
    public partial class MainForm : Form
    {
        public MySqlConnection connection = null;
        public MySqlCommand cmd = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            KapcsolatFelepitese();
            DolgozokMegjelenitese();
        }

        private void KapcsolatFelepitese()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "dolgozo";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message + "\nA program leáll!");
                Environment.Exit(0);

            }
        }

        public void DolgozokMegjelenitese()
        {
            lbDolgozok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`szuletesiIdo` FROM `dolgozo`;";
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    lbDolgozok.Items.Add(new Dolgozo(
                        dr.GetInt32("id"),
                        dr.GetString("nev"),
                        dr.GetString("szuletesiIdo"))
                    );
                }
            }
        }

        private void btnBevitelForm_Click(object sender, EventArgs e)
        {
            Program.formBevitel.ShowDialog();
        }
    }
}
