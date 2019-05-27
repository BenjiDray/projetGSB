using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projetGSB.classeMetier
{
    public class GstVisiteur
    {
        private HttpClient ws;
        private string reponse;
        public GstVisiteur()
        {
            ws = new HttpClient();
        }

        public async Task<List<Visiteur>> lstVisiteur()
        {
            reponse = await ws.GetStringAsync(App.LocalHost + "visiteurs/listeDesVisiteurs.php");
            List<Visiteur> listVisiteur = JsonConvert.DeserializeObject<List<Visiteur>>(reponse);
            return listVisiteur;
        }

        public async Task<List<Labo>> lstLabo()
        {
            reponse = await ws.GetStringAsync(App.LocalHost + "visiteurs/listeLabo.php");
            List<Labo> listeLabo = JsonConvert.DeserializeObject<List<Labo>>(reponse);
            return listeLabo;
        }

        public async Task insererVisiteurAsync(string vis_nom, string vis_prenom, string vis_adresse, string vis_cp, string vis_ville, string lab_code)
        {
            await ws.GetStringAsync(App.LocalHost + "visiteurs/insertVisiteur.php?vis_nom=" + vis_nom + "&vis_prenom=" + vis_prenom + "&vis_adresse=" + vis_adresse + "&vis_cp=" + vis_cp + "&vis_ville=" + vis_ville + "&lab_code=" + lab_code);

        }

        public async Task modifierVisiteur(string vis_nom, string vis_prenom, string vis_adresse, string vis_ville, string vis_cp, string idVisiteur)
        {
            await ws.GetStringAsync(App.LocalHost + "visiteurs/updateVisiteur.php?vis_nom=" + vis_nom + "&vis_prenom=" + vis_prenom + "&vis_adresse=" + vis_adresse + "&vis_cp=" + vis_cp + "&vis_ville=" + vis_ville + "&vis_matricule=" + idVisiteur);

        }

        public async Task insererTravailVisiteur(string vis_matricule,string reg_code)
        {
            await ws.GetStringAsync(App.LocalHost + "visiteurs/insertTravailVisiteur.php?vis_matricule="+vis_matricule + "&reg_code="+reg_code);

        }


    }
}
