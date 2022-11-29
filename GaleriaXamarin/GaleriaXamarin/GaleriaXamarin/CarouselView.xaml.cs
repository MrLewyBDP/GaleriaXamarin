using System;
using System.Collections.Generic;
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
        public Page1(Obiekt Wybrany, int podzialKlik)
        {
            this.Wybrany = Wybrany;
            this.podzialKlik = podzialKlik;
            InitializeComponent();
        }
    }
}