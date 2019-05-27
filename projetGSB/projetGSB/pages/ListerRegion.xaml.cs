
using projetGSB.classeMetier;
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
	public partial class ListerRegion : ContentPage
	{
		public ListerRegion ()
		{
			InitializeComponent ();
            lstRegion();

        }

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
        public async void lstRegion()
        {
            lvToutesLesRegions.ItemsSource = await App.GstWS.GetAllRegionsAsync();
        }

        private async void BtnStat_ClickedAsync(object sender, EventArgs e)
        {
            StatistiqueRegion page = new StatistiqueRegion();
            await Navigation.PushModalAsync(page);
            
        }

        private async void BtnInserer_ClickedAsync(object sender, EventArgs e)
        {
            InsererRegions page = new InsererRegions();
            await Navigation.PushModalAsync(page);
 
         
        }

        private async void LvToutesLesRegions_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
       classeMetier.Region laRegionSelectionne = (lvToutesLesRegions.SelectedItem as classeMetier.Region);
            ModifierRegion page = new ModifierRegion(laRegionSelectionne);
            await Navigation.PushModalAsync(page);
        }

       
    }
}