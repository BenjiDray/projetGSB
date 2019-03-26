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
	public partial class ModifierRegions : ContentPage
	{
		public ModifierRegions ()
		{
			InitializeComponent ();
		}

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            AccueilRegion page = new AccueilRegion();
            await Navigation.PushModalAsync(page);
        }
    }
}