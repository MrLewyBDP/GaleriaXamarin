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

namespace GaleriaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public int iloscPodzialow;
        Obiekt Ryby = new Obiekt(
                new string[] { "Morskie", "Słodkowodne" },
                new string[] { "/images/morskie.jpg", "/images/slodkie.jpg" },
                new PodObiekt[] {
                    new PodObiekt(0, "makrela", "/images/makrela.jpg", "makrela jest rybą morską"),
                    new PodObiekt(0, "śledź", "/images/sledz.jpg", "śledź jest rybą morską"),
                    new PodObiekt(0, "tuńczyk", "/images/tunczyk.jpg", "tuńczyk jest rybą morską"),
                    new PodObiekt(1, "karp", "/images/karp.jpg", "karp jest rybą słodkowodną"),
                    new PodObiekt(1, "karaś", "/images/karas.jpg", "karaś jest rybą słodkowodną"),
                    new PodObiekt(1, "pstrąg", "/images/pstrag.jpg", "pstrąg jest rybą słodkowodną")
                }
            );
        Obiekt Gady = new Obiekt(
            new string[] { "Węże", "Jaszczurki", "Żółwie", "Krokodyle" },
            new string[] { "/images/weze.jpg", "/images/jaszczurki.jpg", "/images/zolwie.jpg", "/images/krokodyle.jpg" },
            new PodObiekt[] {
                    new PodObiekt(0, "Gniewosz Plamisty", "/images/gniewosz.jpg", "Gniewosz Pospolity jest wężem"),
                    new PodObiekt(0, "Wąż Eskulapa", "/images/eskulapa.jpg", "Wąż Eskulapa jest wężem"),
                    new PodObiekt(0, "Żmija Zygzakowata", "/images/zmija.jpg", "Żmija Zygzakowata jest wężem"),
                    new PodObiekt(0, "Zaskroniec Zwyczajny", "/images/zaskroniec.jpg", "Zaskroniec Zwyczajny jest wężem"),
                    new PodObiekt(1, "jaszczurka zwinka", "/images/zwinka.jpg", "jaszczurka zwinka jest jaszczurką"),
                    new PodObiekt(1, "padalec", "padalec.jpg", "/images/padalec jest jaszczurką"),
                    new PodObiekt(1, "jaszczurka żyworodna", "/images/zyworodna.jpg", "jaszczurka żyworodna jest jaszczurką"),
                    new PodObiekt(1, "murówka zwyczajna", "/images/murowka.jpg", "murówka zwyczajna jest jaszczurką"),
                    new PodObiekt(2, "Żółw Błotny", "/images/blotny.jpg", "Żółw Błotny jest żółwiem"),
                    new PodObiekt(3, "Krokodyl Amerykański", "/images/amerykanski.jpg", "Krokodyl Amerykański jest krokodylem"),
                    new PodObiekt(3, "Krokodyl Australijski", "/images/australijski.jpg", "Krokodyl Australijski jest krokodylem")
            }
        );
        Obiekt Plazy = new Obiekt(
            new string[] { "Płazy ogoniaste", "Płazy bezogonowe" },
            new string[] { "/images/ogoniaste.jpg", "/images/bezogonowe.jpg" },
            new PodObiekt[] {
                    new PodObiekt(0, "Salamandra Plamista", "/images/salamandra.jpg", "Salamandra Plamista jest płazem ogoniastym"),
                    new PodObiekt(0, "Traszka Zwyczajna", "/images/zwyczajna.jpg", "Traszka Zwyczajna jest płazem ogoniastym"),
                    new PodObiekt(0, "Traszka Grzebieniasta", "/images/grzebieniasta.jpg", "Traszka Grzebieniasta jest płazem ogoniastym"),
                    new PodObiekt(1, "Grzebiuszka Ziemna", "/images/ziemna.jpg", "Grzebiuszka Ziemna jest płazem bezogonowym"),
                    new PodObiekt(1, "Ropucha Szara", "/images/ropucha.jpg", "Ropucha Szara jest płazem bezogonowym")
            }
        );
        Obiekt Ssaki = new Obiekt(
            new string[] { "Stekowce", "Torbacze", "Łożyskowce" },
            new string[] { "/images/stekowce.jpg", "/images/torbacze.jpg", "/images/lozyskowce.jpg" },
            new PodObiekt[] {
                    new PodObiekt(0, "Dziobak", "/images/dziobak.jpg", "Dziobak jest stekowcem"),
                    new PodObiekt(0, "Kolczatka", "/images/kolczatka.jpg", "Kolczatka jest stekowcem"),
                    new PodObiekt(1, "Kangur", "/images/kangur.jpg", "Kangur jest torbaczem"),
                    new PodObiekt(1, "Koala", "/images/koala.jpg", "Koala jest torbaczem"),
                    new PodObiekt(1, "wiewiórka workowata", "/images/workowata.jpg", "wiewiórka workowata jest torbaczem"),
                    new PodObiekt(2, "Człowiek", "/images/czlowiek.jpg", "Człowiek jest łożyskowcem"),
                    new PodObiekt(2, "Świnia", "/images/swinia.jpg", "Świnia jest łożyskowcem"),
                    new PodObiekt(2, "Królik", "/images/krolik.jpg", "Królik jest łożyskowcem"),
            }
        );
        public Obiekt Wybrany = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but1_Clicked(object sender, RoutedEventArgs e)
        {
            Wybrany = Ryby;
            iloscPodzialow = Wybrany.Podzial.Length;
            visible();
            wyswietl();
        }

        private void but2_Clicked(object sender, RoutedEventArgs e)
        {
            Wybrany = Gady;
            iloscPodzialow = Wybrany.Podzial.Length;
            visible();
            wyswietl();
        }

        private void but3_Clicked(object sender, RoutedEventArgs e)
        {
            Wybrany = Plazy;
            iloscPodzialow = Wybrany.Podzial.Length;
            visible();
            wyswietl();
        }

        private void but4_Clicked(object sender, RoutedEventArgs e)
        {
            Wybrany = Ssaki;
            iloscPodzialow = Wybrany.Podzial.Length;
            visible();
            wyswietl();
        }

        private void visible()
        {
            lr1c0.Visibility = Visibility.Visible;
            br1c0.Visibility = Visibility.Visible;
            lr1c1.Visibility = Visibility.Visible;
            br1c1.Visibility = Visibility.Visible;
            lr2c0.Visibility = Visibility.Visible;
            br2c0.Visibility = Visibility.Visible;
            lr2c1.Visibility = Visibility.Visible;
            br2c1.Visibility = Visibility.Visible;
        }

        private void wyswietl()
        {
            string resource = "/GaleriaWPF;component";
            int i = 0;
            lr1c0.Content = Wybrany.Podzial[i];
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri(resource + Wybrany.zdjeciaPodzial[i], UriKind.Relative);
            img.EndInit();
            ir1c0.Source = img;
            i++;
            if (i < iloscPodzialow)
            {
                lr1c1.Content = Wybrany.Podzial[i];
                BitmapImage img2 = new BitmapImage();
                img2.BeginInit();
                img2.UriSource = new Uri(resource + Wybrany.zdjeciaPodzial[i], UriKind.Relative);
                img2.EndInit();
                ir1c1.Source = img2;
                i++;
                if (i < iloscPodzialow)
                {
                    lr2c0.Content = Wybrany.Podzial[i];
                    BitmapImage img3 = new BitmapImage();
                    img3.BeginInit();
                    img3.UriSource = new Uri(resource + Wybrany.zdjeciaPodzial[i], UriKind.Relative);
                    img3.EndInit();
                    ir2c0.Source = img3;
                    i++;
                    if (i < iloscPodzialow)
                    {
                        lr2c1.Content = Wybrany.Podzial[i];
                        BitmapImage img4 = new BitmapImage();
                        img4.BeginInit();
                        img4.UriSource = new Uri(resource + Wybrany.zdjeciaPodzial[i], UriKind.Relative);
                        ir2c1.Source = img4;
                        img4.EndInit();
                        i++;
                    }
                    else
                    {
                        lr2c1.Visibility = Visibility.Hidden;
                        br2c1.Visibility = Visibility.Hidden;
                    }
                }
                else
                {
                    lr2c0.Visibility = Visibility.Hidden;
                    br2c0.Visibility = Visibility.Hidden;
                    lr2c1.Visibility = Visibility.Hidden;
                    br2c1.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                lr1c1.Visibility = Visibility.Hidden;
                br1c1.Visibility = Visibility.Hidden;
                lr2c0.Visibility = Visibility.Hidden;
                br2c0.Visibility = Visibility.Hidden;
                lr2c1.Visibility = Visibility.Hidden;
                br2c1.Visibility = Visibility.Hidden;
            }
        }

        private void ir1c0_Clicked(object sender, RoutedEventArgs e)
        {
            PodzialWidok p = new PodzialWidok(Wybrany, 0);
            p.ShowDialog();

        }

        private void ir1c1_Clicked(object sender, RoutedEventArgs e)
        {
            PodzialWidok p = new PodzialWidok(Wybrany, 1);
            p.ShowDialog();
        }

        private void ir2c0_Clicked(object sender, RoutedEventArgs e)
        {
            PodzialWidok p = new PodzialWidok(Wybrany, 3);
            p.ShowDialog();
        }

        private void ir2c1_Clicked(object sender, RoutedEventArgs e)
        {
            PodzialWidok p = new PodzialWidok(Wybrany, 2);
            p.ShowDialog();
        }

    }
}
