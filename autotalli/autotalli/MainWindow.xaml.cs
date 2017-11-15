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
using JAMK.IT;

namespace autotalli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot;//muuttuja on käytettävissä kaikissa tämän luokan metodeissa ja tapahtumankäsittelijöissä

        private const string polku = @"d:\\H4143\TTOS0200\kuvia\\";
            public MainWindow()
        {
            //tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
           
            //pyydetään BL-kerrokselta autot ja näytetään ne käyttäjälle kutsutaan staattista metodia
            autot = JAMK.IT.Autotalli.HaeAutot();

            NaytaKuva("autotalli.png");
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            dgAutot.ItemsSource = autot;

        }
        private void NaytaKuva(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //lisätään kuvatiedostojen vakiopolku
                url = polku + url;
                //kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAuto.Stretch = Stretch.Fill;
                imgAuto.Source = pic;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom. olemme itse populoineet DataGridin Auto-olioilla joten kukin DataGridin jäsen/alkio on itseasiassa Auto-olio
            Object obj = dgAutot.SelectedItem;
            if (obj!=null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //näkyviin audit
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }
    }

}
