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
    public partial class FormBevitel : Form
    {
        public FormBevitel()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            string beNev = tbNev.Text;
            string beSzulIdo = dtSzulIdo.Value.ToString("yyyy-MM-dd");            
            Program.mainForm.cmd.CommandText = $"INSERT INTO `dolgozo`(`id`, `nev`, `szuletesiIdo`) VALUES ('null','{beNev}','{beSzulIdo}');";


            try
            {
                if (Program.mainForm.cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeres beolvasás");
                }
                else
                {
                    MessageBox.Show("Sikertelen beolvasás");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();


        }
    }
}
