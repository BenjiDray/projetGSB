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
	public partial class InsererVisiteur : ContentPage
	{
		public InsererVisiteur ()
		{
			InitializeComponent ();
            listeDesLaboAsync();
		}
        
       private async void listeDesLaboAsync()
        {
           lstLabo.ItemsSource = await App.Gst.lstLabo();
        }
        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            var selectedItem = picker.SelectedItem; 
        }
        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            ListerVisiteur page = new ListerVisiteur();
            await Navigation.PushModalAsync(page);

        }
        // voici le bouton pour insere le visiteur
        private async void BtnValider_Clicked(object sender, EventArgs e)
        {
        
        await App.Gst.insererVisiteurAsync(txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtCP.Text, txtVille.Text, (lstLabo.SelectedItem as Labo).lab_code);
        MainPage page = new MainPage();
        await Navigation.PushModalAsync(page);
            
            
        }

     
    }
}