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
                new string[] { "morskie.png", "slodkie.png" },
                new PodObiekt[] {
                    new PodObiekt(0, "makrela", "makrela.png", "makrela jest rybą morską"),
                    new PodObiekt(0, "śledź", "sledz.png", "śledź jest rybą morską"),
                    new PodObiekt(0, "tuńczyk", "tunczyk.png", "tuńczyk jest rybą morską"),
                    new PodObiekt(1, "karp", "karp.png", "karp jest rybą słodkowodną"),
                    new PodObiekt(1, "karaś", "karas.png", "karaś jest rybą słodkowodną"),
                    new PodObiekt(1, "pstrąg", "pstrag.png", "pstrąg jest rybą słodkowodną")
                }
            );
        Obiekt Gady = new Obiekt(
            new string[] { "Węże", "Jaszczurki", "Żółwie", "Krokodyle" },
            new string[] { "weze.png", "jaszczurki.png", "zolwie.png", "krokodyle.png" },
            new PodObiekt[] {
                    new PodObiekt(0, "Gniewosz Plamisty", "gniewosz.png", "Gniewosz Pospolity jest wężem"),
                    new PodObiekt(0, "Wąż Eskulapa", "eskulapa.png", "Wąż Eskulapa jest wężem"),
                    new PodObiekt(0, "Żmija Zygzakowata", "zmija.png", "Żmija Zygzakowata jest wężem"),
                    new PodObiekt(0, "Zaskroniec Zwyczajny", "zaskroniec.png", "Zaskroniec Zwyczajny jest wężem"),
                    new PodObiekt(1, "jaszczurka zwinka", "zwinka.png", "jaszczurka zwinka jest jaszczurką"),
                    new PodObiekt(1, "padalec", "padalec.png", "padalec jest jaszczurką"),
                    new PodObiekt(1, "jaszczurka żyworodna", "zyworodna.png", "jaszczurka żyworodna jest jaszczurką"),
                    new PodObiekt(1, "murówka zwyczajna", "murowka.png", "murówka zwyczajna jest jaszczurką"),
                    new PodObiekt(2, "Żółw Błotny", "blotny.png", "Żółw Błotny jest żółwiem"),
                    new PodObiekt(3, "Krokodyl Amerykański", "amerykanski.png", "Krokodyl Amerykański jest krokodylem"),
                    new PodObiekt(3, "Krokodyl Australijski", "australijski.png", "Krokodyl Australijski jest krokodylem")
            }
        );
        Obiekt Plazy = new Obiekt(
            new string[] { "Płazy ogoniaste", "Płazy bezogonowe" },
            new string[] { "ogoniaste.png", "bezogonowe.png" },
            new PodObiekt[] {
                    new PodObiekt(0, "Salamandra Plamista", "salamandra.png", "Salamandra Plamista jest płazem ogoniastym"),
                    new PodObiekt(0, "Traszka Zwyczajna", "zwyczajna.png", "Traszka Zwyczajna jest płazem ogoniastym"),
                    new PodObiekt(0, "Traszka Grzebieniasta", "grzebieniasta.png", "Traszka Grzebieniasta jest płazem ogoniastym"),
                    new PodObiekt(1, "Grzebiuszka Ziemna", "ziemna.png", "Grzebiuszka Ziemna jest płazem bezogonowym"),
                    new PodObiekt(1, "Ropucha Szara", "ropucha.png", "Ropucha Szara jest płazem bezogonowym")
            }
        );
        Obiekt Ssaki = new Obiekt(
            new string[] { "Stekowce", "Torbacze", "Łożyskowce" },
            new string[] { "stekowce.png", "torbacze.png", "lozyskowce.png" },
            new PodObiekt[] {
                    new PodObiekt(0, "Dziobak", "dziobak.png", "Dziobak jest stekowcem"),
                    new PodObiekt(0, "Kolczatka", "kolczatka.png", "Kolczatka jest stekowcem"),
                    new PodObiekt(1, "Kangur", "kangur.png", "Kangur jest torbaczem"),
                    new PodObiekt(1, "Koala", "koala.png", "Koala jest torbaczem"),
                    new PodObiekt(1, "wiewiórka workowata", "workowata.png", "wiewiórka workowata jest torbaczem"),
                    new PodObiekt(2, "Człowiek", "czlowiek.png", "Człowiek jest łożyskowcem"),
                    new PodObiekt(2, "Świnia", "swinia.png", "Świnia jest łożyskowcem"),
                    new PodObiekt(2, "Królik", "krolik.png", "Królik jest łożyskowcem"),
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
