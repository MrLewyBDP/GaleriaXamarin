using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GaleriaXamarin
{
    public partial class MainPage : ContentPage
    {
        public Obiekt Wybrany = null;
        public int iloscPodzialow;
        Obiekt Ryby = new Obiekt(
                new string[] { "Morskie", "Słodkowodne" },
                new string[] { "morskie.jpg", "slodkie.jpg" },
                new PodObiekt[] {
                    new PodObiekt(0, "makrela", "makrela.jpg", "makrela jest rybą morską"),
                    new PodObiekt(0, "śledź", "sledz.jpg", "śledź jest rybą morską"),
                    new PodObiekt(0, "tuńczyk", "tunczyk.jpg", "tuńczyk jest rybą morską"),
                    new PodObiekt(1, "karp", "karp.jpg", "karp jest rybą słodkowodną"),
                    new PodObiekt(1, "karaś", "karas.jpg", "karaś jest rybą słodkowodną"),
                    new PodObiekt(1, "pstrąg", "pstrag.jpg", "pstrąg jest rybą słodkowodną")
                }
            );
        Obiekt Gady = new Obiekt(
            new string[] { "Węże", "Jaszczurki", "Żółwie", "Krokodyle" },
            new string[] { "weze.jpg", "jaszczurki.jpg", "zolwie.jpg", "krokodyle.jpg" },
            new PodObiekt[] {
                    new PodObiekt(0, "Gniewosz Plamisty", "gniewosz.jpg", "Gniewosz Pospolity jest wężem"),
                    new PodObiekt(0, "Wąż Eskulapa", "eskulapa.jpg", "Wąż Eskulapa jest wężem"),
                    new PodObiekt(0, "Żmija Zygzakowata", "zmija.jpg", "Żmija Zygzakowata jest wężem"),
                    new PodObiekt(0, "Zaskroniec Zwyczajny", "zaskroniec.jpg", "Zaskroniec Zwyczajny jest wężem"),
                    new PodObiekt(1, "jaszczurka zwinka", "zwinka.jpg", "jaszczurka zwinka jest jaszczurką"),
                    new PodObiekt(1, "padalec", "padalec.jpg", "padalec jest jaszczurką"),
                    new PodObiekt(1, "jaszczurka żyworodna", "zyworodna.jpg", "jaszczurka żyworodna jest jaszczurką"),
                    new PodObiekt(1, "murówka zwyczajna", "murowka.jpg", "murówka zwyczajna jest jaszczurką"),
                    new PodObiekt(2, "Żółw Błotny", "blotny.jpg", "Żółw Błotny jest żółwiem"),
                    new PodObiekt(3, "Krokodyl Amerykański", "amerykanski.jpg", "Krokodyl Amerykański jest krokodylem"),
                    new PodObiekt(3, "Krokodyl Australijski", "australijski.jpg", "Krokodyl Australijski jest krokodylem")
            }
        );
        Obiekt Plazy = new Obiekt(
            new string[] { "Płazy ogoniaste", "Płazy bezogonowe" },
            new string[] { "ogoniaste.jpg", "bezogonowe.jpg" },
            new PodObiekt[] {
                    new PodObiekt(0, "Salamandra Plamista", "salamandra.jpg", "Salamandra Plamista jest płazem ogoniastym"),
                    new PodObiekt(0, "Traszka Zwyczajna", "zwyczajna.jpg", "Traszka Zwyczajna jest płazem ogoniastym"),
                    new PodObiekt(0, "Traszka Grzebieniasta", "grzebieniasta.jpg", "Traszka Grzebieniasta jest płazem ogoniastym"),
                    new PodObiekt(1, "Grzebiuszka Ziemna", "ziemna.jpg", "Grzebiuszka Ziemna jest płazem bezogonowym"),
                    new PodObiekt(1, "Ropucha Szara", "ropucha.jpg", "Ropucha Szara jest płazem bezogonowym")
            }
        );
        Obiekt Ssaki = new Obiekt(
            new string[] { "Stekowce", "Torbacze", "Łożyskowce" },
            new string[] { "stekowce.jpg", "torbacze.jpg", "lozyskowce.jpg" },
            new PodObiekt[] {
                    new PodObiekt(0, "Dziobak", "dziobak.jpg", "Dziobak jest stekowcem"),
                    new PodObiekt(0, "Kolczatka", "kolczatka.jpg", "Kolczatka jest stekowcem"),
                    new PodObiekt(1, "Kangur", "kangur.jpg", "Kangur jest torbaczem"),
                    new PodObiekt(1, "Koala", "koala.jpg", "Koala jest torbaczem"),
                    new PodObiekt(1, "wiewiórka workowata", "workowata.jpg", "wiewiórka workowata jest torbaczem"),
                    new PodObiekt(2, "Człowiek", "czlowiek.jpg", "Człowiek jest łożyskowcem"),
                    new PodObiekt(2, "Świnia", "swinia.jpg", "Świnia jest łożyskowcem"),
                    new PodObiekt(2, "Królik", "krolik.jpg", "Królik jest łożyskowcem"),
            }
        );
        public MainPage()
        {
            InitializeComponent();
            //Obiekt[] Wszystko = { Ryby, Gady, Plazy, Ssaki };
        }

        private void but1_Clicked(object sender, EventArgs e)
        {
            Wybrany = Ryby;
            iloscPodzialow = Wybrany.Podzial.Length;
            visible();
            wyswietl();
        }

        private void but2_Clicked(object sender, EventArgs e)
        {
            Wybrany = Gady;
            iloscPodzialow = Wybrany.Podzial.Length;
            visible();
            wyswietl();
        }

        private void but3_Clicked(object sender, EventArgs e)
        {
            Wybrany = Plazy;
            iloscPodzialow = Wybrany.Podzial.Length;
            visible();
            wyswietl();
        }

        private void but4_Clicked(object sender, EventArgs e)
        {
            Wybrany = Ssaki;
            iloscPodzialow = Wybrany.Podzial.Length;
            visible();
            wyswietl();
        }

        private void visible()
        {
            lr1c1.IsVisible = true;
            ir1c1.IsVisible = true;
            lr2c0.IsVisible = true;
            ir2c0.IsVisible = true;
            lr2c1.IsVisible = true;
            ir2c1.IsVisible = true;
        }

        private void wyswietl()
        {
            int i = 0;
            lr1c0.Text = Wybrany.Podzial[i];
            ir1c0.Source = Wybrany.zdjeciaPodzial[i];
            i++;
            if (i < iloscPodzialow)
            {
                lr1c1.Text = Wybrany.Podzial[i];
                ir1c1.Source = Wybrany.zdjeciaPodzial[i];
                i++;
                if (i < iloscPodzialow)
                {
                    lr2c0.Text = Wybrany.Podzial[i];
                    ir2c0.Source = Wybrany.zdjeciaPodzial[i];
                    i++;
                    if (i < iloscPodzialow)
                    {
                        lr2c1.Text = Wybrany.Podzial[i];
                        ir2c1.Source = Wybrany.zdjeciaPodzial[i];
                        i++;
                    }
                    else
                    {
                        lr2c1.IsVisible = false;
                        ir2c1.IsVisible = false;
                    }
                }
                else
                {
                    lr2c0.IsVisible = false;
                    ir2c0.IsVisible = false;
                    lr2c1.IsVisible = false;
                    ir2c1.IsVisible = false;
                }
            }
            else
            {
                lr1c1.IsVisible = false;
                ir1c1.IsVisible=false;
                lr2c0.IsVisible=false;
                ir2c0.IsVisible = false;
                lr2c1.IsVisible = false;
                ir2c1.IsVisible = false;
            }
        }

        private void ir1c0_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1(Wybrany, 0));
        }

        private void ir1c1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1(Wybrany, 1));
        }

        private void ir2c0_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1(Wybrany, 2));
        }

        private void ir2c1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1(Wybrany, 3));
        }
    }
}
