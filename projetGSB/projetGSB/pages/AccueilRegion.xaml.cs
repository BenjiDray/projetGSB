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
	public partial class AccueilRegion : ContentPage
	{
		public AccueilRegion ()
		{
			InitializeComponent ();
		}

        private async void BtnModifierRegion_ClickedAsync(object sender, EventArgs e)
        {
            ModifierRegions page = new ModifierRegions();
            await Navigation.PushModalAsync(page);
        }

        private async void BtnListerRegion_ClickedAsync(object sender, EventArgs e)
        {
            ListerRegion page = new ListerRegion();
            await Navigation.PushModalAsync(page);
        }

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}