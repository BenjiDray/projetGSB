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
	public partial class InsererRegions : ContentPage
	{
		public InsererRegions ()
		{
			InitializeComponent ();
		}

        private async void ButtonRetour_ClickedAsync(object sender, EventArgs e)
        {
            ListerRegion page = new ListerRegion();
            await Navigation.PushModalAsync(page);
        }
        private async void ButtonSubmit_ClickedAsync(object sender, EventArgs e)
        {
            await App.GstWS.InsertRegions(codeRegAInserer.Text, sectRegAInserer.Text, regionAInserer.Text);
            ListerVisiteur page = new ListerVisiteur();
            await Navigation.PushModalAsync(page);
        }
    }
}