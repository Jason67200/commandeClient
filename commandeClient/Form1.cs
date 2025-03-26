using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commandeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteConnection connec = new SQLiteConnection();
        string chcon = @"Data source = Comptoir2.sqlite";
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Paramétrage de la connextion
                connec.ConnectionString = chcon;
                connec.Open();
                MessageBox.Show(connec.State.ToString());

                string requete = @"select N° commande from Commandes";
                MessageBox.Show(requete);

                SQLiteCommand cd = new SQLiteCommand();
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.GetType().ToString());
            }
            finally { }
        }
    }
}
