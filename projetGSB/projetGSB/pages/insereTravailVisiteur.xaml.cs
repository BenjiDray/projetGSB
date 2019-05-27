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
	public partial class insereTravailVisiteur : ContentPage
	{
        Visiteur unvisiteur = new Visiteur();
		public insereTravailVisiteur (Visiteur leVisiteur)
		{
            unvisiteur = leVisiteur;
			InitializeComponent ();
            lstRegion();
		}
        private async void lstRegion()
        {
            lstReg_code.ItemsSource = await App.GstWS.GetAllRegionsAsync();

        }
        private void donneVisiteur()
        {
            string vis_matricule = unvisiteur.vis_matricule;

        }

        private async void BtnRetour_Clicked(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }

       
        
        private async void Btnvalider_Clicked(object sender, EventArgs e)
        {
            await App.Gst.insererTravailVisiteur(unvisiteur.vis_matricule,(lstReg_code.SelectedItem as classeMetier.Region).REG_CODE);
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}