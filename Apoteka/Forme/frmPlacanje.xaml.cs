using System;
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
    /// Interaction logic for frmPlacanje.xaml
    /// </summary>
    public partial class frmPlacanje : Window
    {
        public SqlConnection konekcija = Konekcija.KreirajKonekciju();

        public frmPlacanje()
        {
            InitializeComponent();
            txtCena.Focus();

            try
            {
                konekcija.Open();


                string vratiProizvode = "select ProizvodID, MarkaProizvoda from tblProizvod";
                DataTable dtProizvodi = new DataTable();
                SqlDataAdapter daProizvodi = new SqlDataAdapter(vratiProizvode, konekcija);
                daProizvodi.Fill(dtProizvodi);

                cbxProizvod.ItemsSource = dtProizvodi.DefaultView;

                
                string vratiFarmaceute = "select FarmaceutID, Ime + ' ' + Prezime + ' ' + JMBG as Farmaceut from tblFarmaceut";
                DataTable dtFarmaceuti = new DataTable();
                SqlDataAdapter daFarmaceuti = new SqlDataAdapter(vratiFarmaceute, konekcija);
                daFarmaceuti.Fill(dtFarmaceuti);

                cbxFarmaceut.ItemsSource = dtFarmaceuti.DefaultView;

                string vratiKupce = "select KupacID, Ime + ' ' + Prezime as Kupac from tblKupac";
                DataTable dtKupci = new DataTable();
                SqlDataAdapter daKupci = new SqlDataAdapter(vratiKupce, konekcija);
                daKupci.Fill(dtKupci);

                cbxKupac.ItemsSource = dtKupci.DefaultView;
  
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }

        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();
                if (MainWindow.azuriraj)
                {
                    DataRowView red = (DataRowView)MainWindow.pomocni;

                    string upit = @"Update tblPlacanje Set Cena =" + txtCena.Text + " , ProizvodID = " + cbxProizvod.SelectedValue + ", FarmaceutID = " + cbxFarmaceut.SelectedValue +
                                    ", KupacID= " + cbxKupac.SelectedValue +
                        "Where PlacanjeID = " + red["ID"];

                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                    MainWindow.pomocni = null;
                    this.Close();
                }
                else
                {
                    string insert = @"insert into tblPlacanje(Cena, ProizvodID, FarmaceutID, KupacID)
                                values (" + txtCena.Text + ", " + cbxProizvod.SelectedValue + ", " + cbxFarmaceut.SelectedValue + ", "
                                    + cbxKupac.SelectedValue + ")";
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
