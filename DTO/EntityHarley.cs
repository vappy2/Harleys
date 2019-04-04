using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EntityHarley
    {
        //Données membres
        int id;
        string couleur;
        int reservoir;
        int nbChevaux;
        string modele;

        //accesseur
        public string Couleur
        {
            get => couleur;
            set => couleur = value;
        }
        public int Reservoir
        {
            get => reservoir;
            set => reservoir = value;
        }
        public int NbChevaux
        {
            get => nbChevaux;
            set => nbChevaux = value;
        }
        public string Modele
        {
            get => modele;
            set => modele = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }

        //méthode 
        public override string ToString()
        {
            return String.Concat("Je suis une Harley", Modele, "de couleur", Couleur);
        }
    }
}
