using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace projetGSB.classeMetier
{
    public class GstWebServices
    {
        // Membres privés de la classe
        private HttpClient ws;
        private string reponse;

        // Constructeur de la classe
        public GstWebServices()
        {
            ws = new HttpClient();
        }

        // Méthodes qui vont appeler les API PHP

        public async Task<List<Region>> GetAllRegionsAsync()
        {
            reponse = await ws.GetStringAsync(App.LocalHost + "regions/GetAllRegions.php");
            List<Region> lesRegions = JsonConvert.DeserializeObject<List<Region>>(reponse);
            return lesRegions;
        }
        public async Task<List<Secteur>> recupSec_Code()
        {
            reponse = await ws.GetStringAsync(App.LocalHost + "regions/GetSec_code.php");
            List<Secteur> lesSecteurs = JsonConvert.DeserializeObject<List<Secteur>>(reponse);
            return lesSecteurs;
        }

        public async Task InsertRegions(string IdRegion,string sec_code,string reg_nom)
        {
            await ws.GetStringAsync(App.LocalHost + "regions/InsertRegions.php?REG_CODE=" + IdRegion+"&SEC_CODE="+sec_code+"&REG_NOM="+reg_nom);
        }

        public async Task<List<StatRegion>> GetNbRegionBySecteurAsync()
        {
            reponse = await ws.GetStringAsync(App.LocalHost + "regions/GetNbRegionBySecteur.php");
            List<StatRegion> nbRegBySect = JsonConvert.DeserializeObject<List<StatRegion>>(reponse);
            return nbRegBySect;
        }

        public async Task<List<StatRegion>> GetRegMinAndMaxVisiteurAsync()
        {
            reponse = await ws.GetStringAsync(App.LocalHost + "regions/GetRegMinAndMaxVisiteur.php");
            List<StatRegion> resultat = JsonConvert.DeserializeObject<List<StatRegion>>(reponse);
            return resultat;
        }

        public async Task modifierRegion(string idRegion,string sec_code,string reg_nom )
        {
            await ws.GetStringAsync(App.LocalHost + "regions/updateRegion.php?reg_code="+idRegion+"&sec_code="+sec_code+"&reg_nom="+reg_nom);

        }
        public async Task modifierIdRegion(string reg_nom)
        {
            await ws.GetStringAsync(App.LocalHost + "regions/updateIdRegion.php?reg_nom="+ reg_nom);

        }
    }
}
