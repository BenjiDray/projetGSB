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
	public partial class ListerVisiteur : ContentPage
	{

		public ListerVisiteur ()
		{
			InitializeComponent ();
            listeDesVisiteur();
		}
        public async void listeDesVisiteur()
        {
           
            lstVisiteurs.ItemsSource = await App.Gst.lstVisiteur();
        }
        private async void BtnInsererVisiteur_ClickedAsync(object sender, EventArgs e)
        {
            InsererVisiteur page = new InsererVisiteur();
            await Navigation.PushModalAsync(page);
        }
        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }


        private async void LstVisiteurs_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Visiteur levisiteurSelectionne = (lstVisiteurs.SelectedItem as Visiteur);
            ModifierVisiteur page = new ModifierVisiteur(levisiteurSelectionne);
           await Navigation.PushModalAsync(page);
        }

       
    }
}