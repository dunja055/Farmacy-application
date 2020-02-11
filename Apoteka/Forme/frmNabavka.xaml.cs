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
    /// Interaction logic for frmNabavka.xaml
    /// </summary>
    public partial class frmNabavka : Window
    {
        public SqlConnection konekcija = Konekcija.KreirajKonekciju();
        public frmNabavka()
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


                string vratiDobavljace = "select DobavljacID, Ime + ' ' + Prezime + ' ' + PIB as Dobavljac from tblDobavljac";
                DataTable dtDobavljaci = new DataTable();
                SqlDataAdapter daDobavljaci = new SqlDataAdapter(vratiDobavljace, konekcija);
                daDobavljaci.Fill(dtDobavljaci);

                cbxDobavljac.ItemsSource = dtDobavljaci.DefaultView;


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

                    string upit = @"Update tblNabavka Set Cena =" + txtCena.Text + " , ProizvodID = " + cbxProizvod.SelectedValue + ", DobavljacID = " + cbxDobavljac.SelectedValue +
                        "Where NabavkaID = " + red["ID"];

                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                    MainWindow.pomocni = null;
                    this.Close();
                }
                else
                {
                    string insert = @"insert into tblNabavka(Cena, ProizvodID, DobavljacID)
                                values (" + txtCena.Text + ", " + cbxProizvod.SelectedValue + ", " + cbxDobavljac.SelectedValue + ")";
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
