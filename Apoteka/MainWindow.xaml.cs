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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using Apoteka.Forme;

namespace Apoteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SqlConnection konekcija = Konekcija.KreirajKonekciju();
        public static bool azuriraj;
        public static object pomocni;
        //Metoda koja popunjava pocetni dataGrid
        private void PocetniDataGrid(DataGrid grid)
        {
            try
            {
                string upit = "select DobavljacID as ID, Ime, Prezime, Cena, Kontakt, PIB from tblDobavljac";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(upit, konekcija);

                DataTable dt = new DataTable("Dobavljac");
                dataAdapter.Fill(dt);
                dataGridCentralni.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            PocetniDataGrid(dataGridCentralni);
        }
        //PRIKAZ
        private void btnDobavljaci_Click(object sender, RoutedEventArgs e)
        {
            //DODAJ
            btnDodajDobavljaca.Visibility = Visibility.Visible;

            btnDodajFarmaceuta.Visibility = Visibility.Collapsed;
            btnDodajKupca.Visibility = Visibility.Collapsed;
            btnDodajNabavku.Visibility = Visibility.Collapsed;
            btnDodajPlacanje.Visibility = Visibility.Collapsed;
            btnDodajProizvod.Visibility = Visibility.Collapsed;
            btnDodajVrstuProizvoda.Visibility = Visibility.Collapsed;

            //IZMENI
            btnIzmeniDobavljaca.Visibility = Visibility.Visible;

            btnIzmeniFarmaceuta.Visibility = Visibility.Collapsed;
            btnIzmeniKupca.Visibility = Visibility.Collapsed;
            btnIzmeniNabavku.Visibility = Visibility.Collapsed;
            btnIzmeniPlacanje.Visibility = Visibility.Collapsed;
            btnIzmeniProizvod.Visibility = Visibility.Collapsed;
            btnIzmeniVrstuProizvoda.Visibility = Visibility.Collapsed;

            //OBRISI
            btnObrisiDobavljaca.Visibility = Visibility.Visible;

            btnObrisiFarmaceuta.Visibility = Visibility.Collapsed;
            btnObrisiKupca.Visibility = Visibility.Collapsed;
            btnObrisiNabavku.Visibility = Visibility.Collapsed;
            btnObrisiPlacanje.Visibility = Visibility.Collapsed;
            btnObrisiProizvod.Visibility = Visibility.Collapsed;
            btnObrisiVrstuProizvoda.Visibility = Visibility.Collapsed;

            //ISPIS
            PocetniDataGrid(dataGridCentralni);
        }

        private void btnFarmaceuti_Click(object sender, RoutedEventArgs e)
        {
            //DODAJ
            btnDodajFarmaceuta.Visibility = Visibility.Visible;

            btnDodajDobavljaca.Visibility = Visibility.Collapsed;
            btnDodajKupca.Visibility = Visibility.Collapsed;
            btnDodajNabavku.Visibility = Visibility.Collapsed;
            btnDodajPlacanje.Visibility = Visibility.Collapsed;
            btnDodajProizvod.Visibility = Visibility.Collapsed;
            btnDodajVrstuProizvoda.Visibility = Visibility.Collapsed;

            //IZMENI
            btnIzmeniFarmaceuta.Visibility = Visibility.Visible;

            btnIzmeniDobavljaca.Visibility = Visibility.Collapsed;
            btnIzmeniKupca.Visibility = Visibility.Collapsed;
            btnIzmeniNabavku.Visibility = Visibility.Collapsed;
            btnIzmeniPlacanje.Visibility = Visibility.Collapsed;
            btnIzmeniProizvod.Visibility = Visibility.Collapsed;
            btnIzmeniVrstuProizvoda.Visibility = Visibility.Collapsed;

            //OBRISI
            btnObrisiFarmaceuta.Visibility = Visibility.Visible;

            btnObrisiDobavljaca.Visibility = Visibility.Collapsed;
            btnObrisiKupca.Visibility = Visibility.Collapsed;
            btnObrisiNabavku.Visibility = Visibility.Collapsed;
            btnObrisiPlacanje.Visibility = Visibility.Collapsed;
            btnObrisiProizvod.Visibility = Visibility.Collapsed;
            btnObrisiVrstuProizvoda.Visibility = Visibility.Collapsed;

            //ISPIS

            try
            {
                konekcija.Open();

                string upit = "select FarmaceutID as ID, Ime + ' ' + Prezime as Farmaceut, JMBG from tblFarmaceut";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(upit, konekcija);

                DataTable dt = new DataTable("Farmaceut");
                dataAdapter.Fill(dt);
                dataGridCentralni.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        private void btnKupci_Click(object sender, RoutedEventArgs e)
        {
            //DODAJ
            btnDodajKupca.Visibility = Visibility.Visible;

            btnDodajDobavljaca.Visibility = Visibility.Collapsed;
            btnDodajFarmaceuta.Visibility = Visibility.Collapsed;
            btnDodajNabavku.Visibility = Visibility.Collapsed;
            btnDodajPlacanje.Visibility = Visibility.Collapsed;
            btnDodajProizvod.Visibility = Visibility.Collapsed;
            btnDodajVrstuProizvoda.Visibility = Visibility.Collapsed;

            //IZMENI
            btnIzmeniKupca.Visibility = Visibility.Visible;

            btnIzmeniDobavljaca.Visibility = Visibility.Collapsed;
            btnIzmeniFarmaceuta.Visibility = Visibility.Collapsed;
            btnIzmeniNabavku.Visibility = Visibility.Collapsed;
            btnIzmeniPlacanje.Visibility = Visibility.Collapsed;
            btnIzmeniProizvod.Visibility = Visibility.Collapsed;
            btnIzmeniVrstuProizvoda.Visibility = Visibility.Collapsed;

            //OBRISI
            btnObrisiKupca.Visibility = Visibility.Visible;

            btnObrisiDobavljaca.Visibility = Visibility.Collapsed;
            btnObrisiFarmaceuta.Visibility = Visibility.Collapsed;
            btnObrisiNabavku.Visibility = Visibility.Collapsed;
            btnObrisiPlacanje.Visibility = Visibility.Collapsed;
            btnObrisiProizvod.Visibility = Visibility.Collapsed;
            btnObrisiVrstuProizvoda.Visibility = Visibility.Collapsed;

            //ISPIS

            try
            {
                konekcija.Open();

                string upit = "select KupacID as ID, Ime + ' ' + Prezime as Kupac from tblKupac";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(upit, konekcija);

                DataTable dt = new DataTable("Kupac");
                dataAdapter.Fill(dt);
                dataGridCentralni.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }

        }

        private void btnNabavke_Click(object sender, RoutedEventArgs e)
        {
            //DODAJ
            btnDodajNabavku.Visibility = Visibility.Visible;

            btnDodajDobavljaca.Visibility = Visibility.Collapsed;
            btnDodajKupca.Visibility = Visibility.Collapsed;
            btnDodajFarmaceuta.Visibility = Visibility.Collapsed;
            btnDodajPlacanje.Visibility = Visibility.Collapsed;
            btnDodajProizvod.Visibility = Visibility.Collapsed;
            btnDodajVrstuProizvoda.Visibility = Visibility.Collapsed;

            //IZMENI
            btnIzmeniNabavku.Visibility = Visibility.Visible;

            btnIzmeniDobavljaca.Visibility = Visibility.Collapsed;
            btnIzmeniKupca.Visibility = Visibility.Collapsed;
            btnIzmeniFarmaceuta.Visibility = Visibility.Collapsed;
            btnIzmeniPlacanje.Visibility = Visibility.Collapsed;
            btnIzmeniProizvod.Visibility = Visibility.Collapsed;
            btnIzmeniVrstuProizvoda.Visibility = Visibility.Collapsed;

            //OBRISI
            btnObrisiNabavku.Visibility = Visibility.Visible;

            btnObrisiDobavljaca.Visibility = Visibility.Collapsed;
            btnObrisiKupca.Visibility = Visibility.Collapsed;
            btnObrisiFarmaceuta.Visibility = Visibility.Collapsed;
            btnObrisiPlacanje.Visibility = Visibility.Collapsed;
            btnObrisiProizvod.Visibility = Visibility.Collapsed;
            btnObrisiVrstuProizvoda.Visibility = Visibility.Collapsed;

            //ISPIS

            try
            {
                konekcija.Open();

                string upit = @"Select NabavkaID as ID , tblNabavka.Cena, MarkaProizvoda as Proizvod, Ime + ' ' + Prezime as Dobavljac 
                                from tblNabavka inner join tblProizvod on tblNabavka.ProizvodID = tblProizvod.ProizvodID  
                                inner join tblDobavljac on tblNabavka.DobavljacID = tblDobavljac.DobavljacID";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(upit, konekcija);

                DataTable dt = new DataTable("Nabavka");
                dataAdapter.Fill(dt);
                dataGridCentralni.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        private void btnPlacanje_Click(object sender, RoutedEventArgs e)
        {
            //DODAJ
            btnDodajPlacanje.Visibility = Visibility.Visible;

            btnDodajDobavljaca.Visibility = Visibility.Collapsed;
            btnDodajKupca.Visibility = Visibility.Collapsed;
            btnDodajNabavku.Visibility = Visibility.Collapsed;
            btnDodajFarmaceuta.Visibility = Visibility.Collapsed;
            btnDodajProizvod.Visibility = Visibility.Collapsed;
            btnDodajVrstuProizvoda.Visibility = Visibility.Collapsed;

            //IZMENI
            btnIzmeniPlacanje.Visibility = Visibility.Visible;

            btnIzmeniDobavljaca.Visibility = Visibility.Collapsed;
            btnIzmeniKupca.Visibility = Visibility.Collapsed;
            btnIzmeniNabavku.Visibility = Visibility.Collapsed;
            btnIzmeniFarmaceuta.Visibility = Visibility.Collapsed;
            btnIzmeniProizvod.Visibility = Visibility.Collapsed;
            btnIzmeniVrstuProizvoda.Visibility = Visibility.Collapsed;

            //OBRISI
            btnObrisiPlacanje.Visibility = Visibility.Visible;

            btnObrisiDobavljaca.Visibility = Visibility.Collapsed;
            btnObrisiKupca.Visibility = Visibility.Collapsed;
            btnObrisiNabavku.Visibility = Visibility.Collapsed;
            btnObrisiFarmaceuta.Visibility = Visibility.Collapsed;
            btnObrisiProizvod.Visibility = Visibility.Collapsed;
            btnObrisiVrstuProizvoda.Visibility = Visibility.Collapsed;

            //ISPIS

            try
            {
                konekcija.Open();

                string upit = @"Select PlacanjeID as ID, tblPlacanje.Cena, MarkaProizvoda as Proizvod, tblFarmaceut.Ime + ' ' + tblFarmaceut.Prezime as Farmaceut,
                               tblKupac.Ime + ' ' + tblKupac.Prezime as Kupac 
                               from tblPlacanje  inner join tblProizvod on tblPlacanje.ProizvodID = tblProizvod.ProizvodID
                               inner join tblFarmaceut on tblPlacanje.FarmaceutID = tblFarmaceut.FarmaceutID
                               inner join tblKupac on tblPlacanje.KupacID = tblKupac.KupacID";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(upit, konekcija);

                DataTable dt = new DataTable("Placanje");
                dataAdapter.Fill(dt);
                dataGridCentralni.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        private void btnProizvodi_Click(object sender, RoutedEventArgs e)
        {
            //DODAJ
            btnDodajProizvod.Visibility = Visibility.Visible;

            btnDodajDobavljaca.Visibility = Visibility.Collapsed;
            btnDodajKupca.Visibility = Visibility.Collapsed;
            btnDodajNabavku.Visibility = Visibility.Collapsed;
            btnDodajPlacanje.Visibility = Visibility.Collapsed;
            btnDodajFarmaceuta.Visibility = Visibility.Collapsed;
            btnDodajVrstuProizvoda.Visibility = Visibility.Collapsed;

            //IZMENI
            btnIzmeniProizvod.Visibility = Visibility.Visible;

            btnIzmeniDobavljaca.Visibility = Visibility.Collapsed;
            btnIzmeniKupca.Visibility = Visibility.Collapsed;
            btnIzmeniNabavku.Visibility = Visibility.Collapsed;
            btnIzmeniPlacanje.Visibility = Visibility.Collapsed;
            btnIzmeniFarmaceuta.Visibility = Visibility.Collapsed;
            btnIzmeniVrstuProizvoda.Visibility = Visibility.Collapsed;

            //OBRISI
            btnObrisiProizvod.Visibility = Visibility.Visible;

            btnObrisiDobavljaca.Visibility = Visibility.Collapsed;
            btnObrisiKupca.Visibility = Visibility.Collapsed;
            btnObrisiNabavku.Visibility = Visibility.Collapsed;
            btnObrisiPlacanje.Visibility = Visibility.Collapsed;
            btnObrisiFarmaceuta.Visibility = Visibility.Collapsed;
            btnObrisiVrstuProizvoda.Visibility = Visibility.Collapsed;

            //ISPIS

            try
            {
                konekcija.Open();

                string upit = @"Select ProizvodID as ID, MarkaProizvoda as 'Marka proizvoda', Kolicina, Cena, VrstaProizvoda as VrstaProizvoda 
                               from tblProizvod  inner join tblVrstaProizvoda on tblProizvod.VrstaProizvodaID = tblVrstaProizvoda.VrstaProizvodaID";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(upit, konekcija);

                DataTable dt = new DataTable("Proizvod");
                dataAdapter.Fill(dt);
                dataGridCentralni.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        private void btnVrsteProizvoda_Click(object sender, RoutedEventArgs e)
        {
            //DODAJ
            btnDodajVrstuProizvoda.Visibility = Visibility.Visible;

            btnDodajDobavljaca.Visibility = Visibility.Collapsed;
            btnDodajKupca.Visibility = Visibility.Collapsed;
            btnDodajNabavku.Visibility = Visibility.Collapsed;
            btnDodajPlacanje.Visibility = Visibility.Collapsed;
            btnDodajProizvod.Visibility = Visibility.Collapsed;
            btnDodajFarmaceuta.Visibility = Visibility.Collapsed;

            //IZMENI
            btnIzmeniVrstuProizvoda.Visibility = Visibility.Visible;

            btnIzmeniDobavljaca.Visibility = Visibility.Collapsed;
            btnIzmeniKupca.Visibility = Visibility.Collapsed;
            btnIzmeniNabavku.Visibility = Visibility.Collapsed;
            btnIzmeniPlacanje.Visibility = Visibility.Collapsed;
            btnIzmeniProizvod.Visibility = Visibility.Collapsed;
            btnIzmeniFarmaceuta.Visibility = Visibility.Collapsed;

            //OBRISI
            btnObrisiVrstuProizvoda.Visibility = Visibility.Visible;

            btnObrisiDobavljaca.Visibility = Visibility.Collapsed;
            btnObrisiKupca.Visibility = Visibility.Collapsed;
            btnObrisiNabavku.Visibility = Visibility.Collapsed;
            btnObrisiPlacanje.Visibility = Visibility.Collapsed;
            btnObrisiProizvod.Visibility = Visibility.Collapsed;
            btnObrisiFarmaceuta.Visibility = Visibility.Collapsed;

            //ISPIS

            try
            {
                konekcija.Open();

                string upit = "select VrstaProizvodaID as ID, VrstaProizvoda, NazivProizvoda, Recept, Sifra from tblVrstaProizvoda";
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(upit, konekcija);

                DataTable dt = new DataTable("VrstaProizvoda");
                dataAdapter.Fill(dt);
                dataGridCentralni.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }
        //DODAJ
        private void btnDodajDobavljaca_Click(object sender, RoutedEventArgs e)
        {
            frmDobavljac prozor = new frmDobavljac();
            prozor.ShowDialog();
            PocetniDataGrid(dataGridCentralni); //refresh
        }

        private void btnDodajFarmaceuta_Click(object sender, RoutedEventArgs e)
        {
            frmFarmaceut prozor = new frmFarmaceut();
            prozor.ShowDialog();
            btnFarmaceuti_Click(sender, e); //refresh grida

        }

        private void btnDodajKupca_Click(object sender, RoutedEventArgs e)
        {
            frmKupac prozor = new frmKupac();
            prozor.ShowDialog();
            btnKupci_Click(sender, e); //refresh grida

        }

        private void btnDodajNabavku_Click(object sender, RoutedEventArgs e)
        {
            frmNabavka prozor = new frmNabavka();
            prozor.ShowDialog();
            btnNabavke_Click(sender, e); //refresh grida

        }

        private void btnDodajPlacanje_Click(object sender, RoutedEventArgs e)
        {
            frmPlacanje prozor = new frmPlacanje();
            prozor.ShowDialog();
            btnPlacanje_Click(sender, e); //refresh grida
        }

        private void btnDodajProizvod_Click(object sender, RoutedEventArgs e)
        {
            frmProizvod prozor = new frmProizvod();
            prozor.ShowDialog();
            btnProizvodi_Click(sender, e); //refresh grida

        }

        private void btnDodajVrstuProizvoda_Click(object sender, RoutedEventArgs e)
        {
            frmVrstaProizvoda prozor = new frmVrstaProizvoda();
            prozor.ShowDialog();
            btnVrsteProizvoda_Click(sender, e); //refresh grida
        }

        //IZMENI
        private void btnIzmeniDobavljaca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                azuriraj = true;

                frmDobavljac prozor = new frmDobavljac();
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                pomocni = red; //da zapamti ID
                string upit = "select * from tblDobavljac where DobavljacID = " + red["ID"];
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    prozor.txtIme.Text = citac["Ime"].ToString();
                    prozor.txtPrezime.Text = citac["Prezime"].ToString();
                    prozor.txtCena.Text = citac["Cena"].ToString();
                    prozor.txtKontakt.Text = citac["Kontakt"].ToString();
                    prozor.txtPIB.Text = citac["PIB"].ToString();
                }
                prozor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste selektovali red.", "Obavestenje");
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                PocetniDataGrid(dataGridCentralni);
                azuriraj = false; //pri izmeni je true al kada ga izmeni treba da postavi na false
            }
        }

        private void btnIzmeniFarmaceuta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                azuriraj = true;

                frmFarmaceut prozor = new frmFarmaceut();
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                pomocni = red; //da zapamti ID
                string upit = "select * from tblFarmaceut where FarmaceutID = " + red["ID"];
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    prozor.txtIme.Text = citac["Ime"].ToString();
                    prozor.txtPrezime.Text = citac["Prezime"].ToString();
                    prozor.txtUsername.Text = citac["Username"].ToString();
                    prozor.txtPassword.Text = citac["Password"].ToString();
                    prozor.txtJMBG.Text = citac["JMBG"].ToString();

                }
                prozor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste selektovali red.", "Obavestenje");
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnFarmaceuti_Click(sender, e);
                azuriraj = false; //pri izmeni je true al kada ga izmeni treba da postavi na false
            }
        }

        private void btnIzmeniKupca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                azuriraj = true;

                frmKupac prozor = new frmKupac();
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                pomocni = red; //da zapamti ID
                string upit = "select * from tblKupac where KupacID = " + red["ID"];
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    prozor.txtIme.Text = citac["Ime"].ToString();
                    prozor.txtPrezime.Text = citac["Prezime"].ToString();
                    prozor.txtJMBG.Text = citac["JMBG"].ToString();
                    

                }
                prozor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste selektovali red.", "Obavestenje");
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnKupci_Click(sender, e);
                azuriraj = false; //pri izmeni je true al kada ga izmeni treba da postavi na false
            }
        }

        private void btnIzmeniNabavku_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                azuriraj = true;

                frmNabavka prozor = new frmNabavka();
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                pomocni = red; //da zapamti ID

                string upit = "select * from tblNabavka where NabavkaID = " + red["ID"];
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    prozor.txtCena.Text = citac["Cena"].ToString();
                    prozor.cbxProizvod.SelectedValue = citac["ProizvodID"].ToString();
                    prozor.cbxDobavljac.SelectedValue = citac["DobavljacID"].ToString();
                }
                prozor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste selektovali red.", "Obavestenje");
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnNabavke_Click(sender, e);
                azuriraj = false; //pri izmeni je true al kada ga izmeni treba da postavi na false
            }
        }

        private void btnIzmeniPlacanje_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                azuriraj = true;

                frmPlacanje prozor = new frmPlacanje();
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                pomocni = red; //da zapamti ID

                string upit = "select * from tblPlacanje where PlacanjeID = " + red["ID"];
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    prozor.txtCena.Text = citac["Cena"].ToString();
                    prozor.cbxProizvod.SelectedValue = citac["ProizvodID"].ToString();
                    prozor.cbxFarmaceut.SelectedValue = citac["FarmaceutID"].ToString();
                    prozor.cbxKupac.SelectedValue = citac["KupacID"].ToString();
                }
                prozor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste selektovali red.", "Obavestenje");
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnPlacanje_Click(sender, e);
                azuriraj = false; //pri izmeni je true al kada ga izmeni treba da postavi na false
            }
        }

        private void btnIzmeniProizvod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                azuriraj = true;

                frmProizvod prozor = new frmProizvod();
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                pomocni = red; //da zapamti ID

                string upit = "select * from tblProizvod where ProizvodID = " + red["ID"];
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    prozor.txtMarkaProizvoda.Text = citac["MarkaProizvoda"].ToString();
                    prozor.txtKolicina.Text = citac["Kolicina"].ToString();
                    prozor.txtCena.Text = citac["Cena"].ToString();
                    prozor.cbxVrstaProizvoda.SelectedValue = citac["VrstaProizvodaID"].ToString();
                }
                prozor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste selektovali red.", "Obavestenje");
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnProizvodi_Click(sender, e);
                azuriraj = false; //pri izmeni je true al kada ga izmeni treba da postavi na false
            }
        }

        private void btnIzmeniVrstuProizvoda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                azuriraj = true;

                frmVrstaProizvoda prozor = new frmVrstaProizvoda();
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                pomocni = red; //da zapamti ID

                string upit = "select * from tblVrstaProizvoda where VrstaProizvodaID = " + red["ID"];
                SqlCommand komanda = new SqlCommand(upit, konekcija);
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    prozor.txtVrstaProizvoda.Text = citac["VrstaProizvoda"].ToString();
                    prozor.txtNazivProizvoda.Text = citac["NazivProizvoda"].ToString();
                    prozor.chBoxRecept.IsChecked = (bool)citac["Recept"];
                    prozor.txtSifra.Text = citac["Sifra"].ToString();                   
                }
                prozor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste selektovali red.", "Obavestenje");
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnVrsteProizvoda_Click(sender, e);
                azuriraj = false; //pri izmeni je true al kada ga izmeni treba da postavi na false
            }
        }

        //OBRISI
        private void btnObrisiDobavljaca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                string upit = @"Delete from tblDobavljac Where DobavljacID=" + red["ID"];

                MessageBoxResult rezultat = MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (rezultat == MessageBoxResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Potrebno je da selektujete odgovarajuci red!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Postoje povezani podaci u drugim tabelama!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                PocetniDataGrid(dataGridCentralni);
            }
        }

        private void btnObrisiFarmaceuta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                string upit = @"Delete from tblFarmaceut Where FarmaceutID=" + red["ID"];

                MessageBoxResult rezultat = MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (rezultat == MessageBoxResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Potrebno je da selektujete odgovarajuci red!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Postoje povezani podaci u drugim tabelama!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnFarmaceuti_Click(sender, e);
            }
        }

        private void btnObrisiKupca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                string upit = @"Delete from tblKupac Where KupacID=" + red["ID"];

                MessageBoxResult rezultat = MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (rezultat == MessageBoxResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Potrebno je da selektujete odgovarajuci red!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Postoje povezani podaci u drugim tabelama!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnKupci_Click(sender, e);
            }
        }

        private void btnObrisiNabavku_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                string upit = @"Delete from tblNabavka Where NabavkaID=" + red["ID"];

                MessageBoxResult rezultat = MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (rezultat == MessageBoxResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Potrebno je da selektujete odgovarajuci red!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Postoje povezani podaci u drugim tabelama!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnNabavke_Click(sender, e);
            }
        }

        private void btnObrisiPlacanje_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                string upit = @"Delete from tblPlacanje Where PlacanjeID=" + red["ID"];

                MessageBoxResult rezultat = MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (rezultat == MessageBoxResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Potrebno je da selektujete odgovarajuci red!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Postoje povezani podaci u drugim tabelama!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnPlacanje_Click(sender, e);
            }
        }

        private void btnObrisiProizvod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                string upit = @"Delete from tblProizvod Where ProizvodID=" + red["ID"];

                MessageBoxResult rezultat = MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (rezultat == MessageBoxResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Potrebno je da selektujete odgovarajuci red!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Postoje povezani podaci u drugim tabelama!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnProizvodi_Click(sender, e);
            }
        }

        private void btnObrisiVrstuProizvoda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();

                DataRowView red = (DataRowView)dataGridCentralni.SelectedItems[0];

                string upit = @"Delete from tblVrstaProizvoda Where VrstaProizvodaID=" + red["ID"];

                MessageBoxResult rezultat = MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (rezultat == MessageBoxResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(upit, konekcija);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Potrebno je da selektujete odgovarajuci red!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Postoje povezani podaci u drugim tabelama!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
                btnVrsteProizvoda_Click(sender, e);
            }
        }
    }
}
