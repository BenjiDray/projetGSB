using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projetGSB.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatistiqueRegion : ContentPage
	{
		public StatistiqueRegion ()
		{
			InitializeComponent ();
            nbRegionBySecteurs();
            //lstStatRegion();
            
        }
        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            ListerRegion page = new ListerRegion();
            await Navigation.PushModalAsync(page);
        }
        public async void nbRegionBySecteurs()
        {
            lvNbRegionBySecteur.ItemsSource = await App.GstWS.GetNbRegionBySecteurAsync();
        }

        //public async void lstStatRegion()
        //{
          //  lvNbRegionBySecteur.ItemsSource = await App.GstWS.GetRegMinAndMaxVisiteurAsync();
        //}

    }
}