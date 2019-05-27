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
	public partial class ModifierRegion : ContentPage
	{
        classeMetier.Region uneRegion = new classeMetier.Region();
		public ModifierRegion (classeMetier.Region laRegion)
		{
            uneRegion = laRegion;
           
			InitializeComponent ();
            lstReg_Codeasync();
            donneDeLaRegion(laRegion);
        }
        private async void lstReg_Codeasync()
        {
            lstsec_code.ItemsSource = await App.GstWS.recupSec_Code();
        }

        private void donneDeLaRegion(classeMetier.Region laRegion)
        {
            txtRegion.Text = laRegion.REG_NOM;
            string idRegion = laRegion.REG_CODE;
        }

        private async void BtnRetour_Clicked(object sender, EventArgs e)
        {
            ListerRegion page = new ListerRegion();
            await Navigation.PushModalAsync(page);
        }

        private async void BtnValider_Clicked(object sender, EventArgs e)
        {
            await App.GstWS.modifierRegion(uneRegion.REG_CODE, (lstsec_code.SelectedItem as Secteur).SEC_CODE,txtRegion.Text);
            await App.GstWS.modifierIdRegion(txtRegion.Text);
            
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}