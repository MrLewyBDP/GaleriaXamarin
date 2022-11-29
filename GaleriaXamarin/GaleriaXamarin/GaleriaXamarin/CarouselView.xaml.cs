using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GaleriaXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        Obiekt Wybrany;
        int podzialKlik;
        List<PodObiekt> podObiekty = new List<PodObiekt>();
        public ObservableCollection<PodObiekt> PodObiektyOC { get; set; } = new ObservableCollection<PodObiekt>();
        
        public Page1(Obiekt Wybrany, int podzialKlik)
        {
            this.Wybrany = Wybrany;
            this.podzialKlik = podzialKlik;
            
            PodObiekt[] podObiektyArray = podObiekty.ToArray();
            InitializeComponent();
            BindingContext = this;
            for (int i = 0; i < Wybrany.podPodzial.Length; i++)
            {
                if (Wybrany.podPodzial[i].podzial == podzialKlik)
                {
                    PodObiektyOC.Add(Wybrany.podPodzial[i]);
                }
            }



        }
    }
}