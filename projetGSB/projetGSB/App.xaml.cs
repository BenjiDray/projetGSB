using projetGSB.classeMetier;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace projetGSB
{
    public partial class App : Application
    {

        public static string LocalHost { get; set; }
        public static GstVisiteur Gst { get; set; }
        public static List<Visiteur> lesVisiteurs { get; set; }
       public static List<Labo> lesLabo { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Gst = new GstVisiteur();
            //LocalHost = "http://localhost/mesprojets/gsb/";
            LocalHost = "http://benjamin.sio19ingetis.lan/ppe4/";
            lesVisiteurs = new List<Visiteur>();
            lesLabo = new List<Labo>();

        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
