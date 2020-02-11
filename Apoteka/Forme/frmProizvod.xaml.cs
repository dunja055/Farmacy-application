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
    /// Interaction logic for frmProizvod.xaml
    /// </summary>
    public partial class frmProizvod : Window
    {
        public SqlConnection konekcija = Konekcija.KreirajKonekciju();
        public frmProizvod()
        {
            InitializeComponent();
            txtMarkaProizvoda.Focus();

            try
            {
                konekcija.Open();


                string vratiVrstuProizvoda = "select VrstaProizvodaID, VrstaProizvoda from tblVrstaProizvoda";
                DataTable dtVrsteProizvoda = new DataTable();
                SqlDataAdapter daVrsteProizvoda = new SqlDataAdapter(vratiVrstuProizvoda, konekcija);
                daVrsteProizvoda.Fill(dtVrsteProizvoda);

                cbxVrstaProizvoda.ItemsSource = dtVrsteProizvoda.DefaultView;

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

                    string upit = @"Update tblProizvod Set MarkaProizvoda ='" + txtMarkaProizvoda.Text + "' , Kolicina = '" + txtKolicina.Text +
                        "', Cena = " + txtCena.Text+ ", VrstaProizvodaID = " + cbxVrstaProizvoda.SelectedValue +
                        "Where ProizvodID = " + red["ID"];

                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                    MainWindow.pomocni = null;
                    this.Close();
                }
                else
                {
                    string insert = @"insert into tblProizvod(MarkaProizvoda, Kolicina, Cena, VrstaProizvodaID)
                                values ('" + txtMarkaProizvoda.Text + "', " + txtKolicina.Text + ", " + txtCena.Text + ", "
                                    + cbxVrstaProizvoda.SelectedValue + ")";
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
