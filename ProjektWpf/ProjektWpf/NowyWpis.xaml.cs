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

namespace ProjektWpf
{
    /// <summary>
    /// Logika interakcji dla klasy NowyWpis.xaml
    /// </summary>
    public partial class NowyWpis : Window
    {
        public NowyWpis()
        {
            InitializeComponent();
        }

        private void BtnOblicz_Click(object sender, RoutedEventArgs e)
        {
            double paliwo, km, cena, spalanie, koszt1km, koszt100km, kosztX;

            ObliczServiceReference.ObliczServiceClient result = new ObliczServiceReference.ObliczServiceClient();

            paliwo = double.Parse(txtPaliwo.Text);
            km = double.Parse(txtKm.Text);
            cena = double.Parse(txtCena.Text);

            spalanie = result.srednieSpalanie(paliwo, km);
            koszt1km = result.koszt1km(paliwo, km, cena);
            koszt100km = result.koszt100km(paliwo, km, cena);
            kosztX = result.kosztXkm(paliwo, km, cena);

            txtSpalanie.Text = spalanie.ToString();
            txtKoszt1km.Text = koszt1km.ToString();
            txtKoszt100km.Text = koszt100km.ToString();
            txtKosztX.Text = kosztX.ToString();
        }
    }
}
