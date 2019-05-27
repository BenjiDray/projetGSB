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
	public partial class ListerVisiteurTravail : ContentPage
	{
		public ListerVisiteurTravail ()
		{
			InitializeComponent ();
            listeDesVisiteursTravails();
		}
        public async void listeDesVisiteursTravails()
        {

            lstVisiteursTravail.ItemsSource = await App.Gst.lstVisiteur();
        }

        private void LstVisiteursTravail_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Visiteur levisiteurSelectionne = (lstVisiteursTravail.SelectedItem as Visiteur);
            insereTravailVisiteur page = new insereTravailVisiteur(levisiteurSelectionne);
            Navigation.PushModalAsync(page);
           
        }

        private async void BtnRetour_Clicked(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}