using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace Harleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Debut");
            AfficheAllVehicule();
            /*AjouterHarleys();
            AfficheAllVehicule();*/
            MAJ();
            AfficheAllVehicule();
            supp();
            Console.WriteLine("Fin");
            Console.ReadLine();
        }
        
        //Méthodes
        static void AfficheAllVehicule()
        {
            HarleyProvider harleyProvider = new HarleyProvider();
            foreach (EntityHarley harley in harleyProvider.GetAllHarleys())
            {
                Console.WriteLine(harley);
            }
        }

        static void AjouterHarleys()
        {
            Console.WriteLine("Création d'une Harley dans le garage");
            HarleyProvider provider = new HarleyProvider();
            provider.Create(new EntityHarley { Couleur = "Noire", Modele = "883 Iron", Reservoir=12 });
            provider.Create(new EntityHarley { Couleur = "Rouge", Modele = "1200 Nighster", Reservoir = 12 });
            provider.Create(new EntityHarley { Couleur = "Grise", Modele = "1200 Forty Height", Reservoir = 12 });
            provider.Create(new EntityHarley { Couleur = "Noire", Modele = "Fat boy", Reservoir = 25 });
            Console.WriteLine("Création terminée");
        }

        static void MAJ()
        {
            Console.WriteLine("Mise à jour de la couleur");
            HarleyProvider provider = new HarleyProvider();
            foreach (EntityHarley harley in provider.GetAllHarleys())
            {
                if (harley.Couleur == "Noire")
                {
                    harley.Couleur = "Violet";
                }
                provider.Update(harley);
            }
            Console.WriteLine("Mise à jour terminée");
        }

        static void supp()
        {
            Console.WriteLine("Suppression de Harley");
            HarleyProvider provider = new HarleyProvider();
            foreach (EntityHarley harley in provider.GetAllHarleys())
            {
                if (harley.Id > 4)
                {
                    provider.Delete(harley);
                }
            }
            Console.WriteLine("Supression réussie");
          
        }
    }
}
