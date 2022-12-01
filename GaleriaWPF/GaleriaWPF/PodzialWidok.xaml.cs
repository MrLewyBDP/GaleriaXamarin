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

namespace GaleriaWPF
{
    /// <summary>
    /// Logika interakcji dla klasy Podzial.xaml
    /// </summary>
    public partial class PodzialWidok : Window
    {
        int id = 0;
        List<PodObiekt> podzialPods = new List<PodObiekt>();
        public PodzialWidok(Obiekt Wybrany, int podzialKlik)
        {
            InitializeComponent();
            for(int i=0; i<Wybrany.podPodzial.Length; i++)
            {
                if (Wybrany.podPodzial[i].podzial == podzialKlik)
                    podzialPods.Add(Wybrany.podPodzial[i]);
            }
            wyswietl();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (id == 0)
                id = podzialPods.Count - 1;
            else
                id--;
            wyswietl();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (id == podzialPods.Count - 1)
                id = 0;
            else
                id++;
            wyswietl();
        }

        private void wyswietl()
        {
            string resource = "/GaleriaWPF;component";
            name.Content = podzialPods[id].nazwa;
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri(resource + podzialPods[id].zdjecie, UriKind.Relative);
            img.EndInit();
            image.Source = img;
            desc.Content = podzialPods[id].opis;
        }
    }
}
