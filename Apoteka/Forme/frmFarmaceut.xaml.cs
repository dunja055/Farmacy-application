﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
namespace Apoteka.Forme
{
    /// <summary>
    /// Interaction logic for frmFarmaceut.xaml
    /// </summary>
    public partial class frmFarmaceut : Window
    {
        public SqlConnection konekcija = Konekcija.KreirajKonekciju();
        public frmFarmaceut()
        {
            InitializeComponent();
            txtIme.Focus();
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();

                if (MainWindow.azuriraj)
                {

                    DataRowView red = (DataRowView)MainWindow.pomocni;

                    string upit = @"Update tblFarmaceut Set Ime ='" + txtIme.Text + "' , Prezime = '" + txtPrezime.Text + "', Username = '" + txtUsername.Text +
                                    "', Password = '" + txtPassword.Text + "' , JMBG ='" + txtJMBG.Text +
                                      "' Where FarmaceutID=" + red["ID"];

                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                    MainWindow.pomocni = null;
                    this.Close();
                }
                else
                {
                    string insert = @"insert into tblFarmaceut(Ime, Prezime, Username, Password, JMBG)
                                values ('" + txtIme.Text + "', '" + txtPrezime.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtJMBG.Text + "');";
                    SqlCommand cmd = new SqlCommand(insert, konekcija);
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Unos odredjenih vrednosti nije validan.", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        private void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
