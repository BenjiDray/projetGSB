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
	public partial class ModifierVisiteur : ContentPage
	{
        Visiteur Visiteur = new Visiteur();
		public ModifierVisiteur (Visiteur unVisiteur)
		{
            Visiteur = unVisiteur;
			InitializeComponent ();
            donneDuVisiteur(unVisiteur);
		}

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            ListerVisiteur page = new ListerVisiteur();
            await Navigation.PushModalAsync(page);
        }
        private void donneDuVisiteur(Visiteur unVisiteur)
        {
            txtNom.Text = unVisiteur.vis_nom;
            txtPrenom.Text = unVisiteur.vis_prenom;
            txtAdresse.Text = unVisiteur.vis_adresse;
            txtVille.Text = unVisiteur.vis_ville;
            txtCP.Text= unVisiteur.vis_cp;
            string idDuVisiteur = unVisiteur.vis_matricule;
        }

        private async  void BtnValider_Clicked(object sender, EventArgs e)
        {
            await App.Gst.modifierVisiteur(txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtVille.Text, txtCP.Text,Visiteur.vis_matricule);
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}