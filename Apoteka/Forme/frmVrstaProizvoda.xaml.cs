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
    /// Interaction logic for frmVrstaProizvoda.xaml
    /// </summary>
    public partial class frmVrstaProizvoda : Window
    {
        public SqlConnection konekcija = Konekcija.KreirajKonekciju();
        public frmVrstaProizvoda()
        {
            InitializeComponent();
            txtVrstaProizvoda.Focus();
           
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();
                if (MainWindow.azuriraj)
                {

                    DataRowView red = (DataRowView)MainWindow.pomocni;

                    string upit = @"Update tblVrstaProizvoda Set VrstaProizvoda ='" + txtVrstaProizvoda.Text + "' , NazivProizvoda = '" 
                        + txtNazivProizvoda.Text + "', Recept = " + Convert.ToInt32(chBoxRecept.IsChecked) +
                                    ", Sifra = '" + txtSifra.Text +
                                      "' Where VrstaProizvodaID=" + red["ID"];

                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                    MainWindow.pomocni = null;
                    this.Close();
                }

                else
                {
                    string insert = @"insert into tblVrstaProizvoda(VrstaProizvoda, NazivProizvoda, Recept, Sifra)
                                values ('" + txtVrstaProizvoda.Text + "', '" + txtNazivProizvoda.Text + "', " + Convert.ToInt32(chBoxRecept.IsChecked) 
                                + ", '" + txtSifra.Text
                                   + "');";
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
