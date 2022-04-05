using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1_William
{
    public class Fournisseur
    {
        private int FournisseurId;
        private string NomCompagnie;
        private string NomContact;
        private string TitreContact;
        private string Adresse;
        private string Ville;
        private string Province;
        private string CodePostal;
        private string Pays;
        private string Telephone;
        private string PageWeb;
        private static int NbFournmisseur;

        public Fournisseur()
        { NbFournmisseur++; }

        public Fournisseur(string NomCompagnie, string NomContact, string TitreContact, string Adresse, string Ville, string Province, string CodePostal, string Pays, string Telephone)
        {
            this.NomCompagnie = NomCompagnie;
            this.NomContact = NomContact;
            this.TitreContact = TitreContact;
            this.Adresse = Adresse;
            this.Ville = Ville;
            this.Province = Province;
            this.CodePostal = CodePostal;
            this.Pays = Pays;
            this.Telephone = Telephone;
            NbFournmisseur++;
        }

        public static void AfficherFournisseur1()
        {
            Fournisseur Fournisseur1 = new("Pavlova Ltd.","Ian Devling","Marketing Manager ","74 Rose St.Moonie Ponds","Melbourne","Victoria","3058","Australia","(03) 444 - 2343");
            Console.WriteLine($"{Fournisseur1.NomCompagnie} | {Fournisseur1.NomContact} | {Fournisseur1.TitreContact} | {Fournisseur1.Adresse} | {Fournisseur1.Ville} | {Fournisseur1.Province} | {Fournisseur1.CodePostal} | {Fournisseur1.Pays} | {Fournisseur1.Telephone}");
        }

        public static void AfficherFournisseur2()
        {
            Fournisseur Fournisseur2 = new( "Refrescos Americanas LTDA","Carlos Diaz Marketing Manager","Av.das Americanas","12.890","Sao Paulo", "NULL", "5442","Brazil","(11) 555 4640");
            Console.WriteLine($"{Fournisseur2.NomCompagnie} | {Fournisseur2.NomContact} | {Fournisseur2.TitreContact} | {Fournisseur2.Adresse} | {Fournisseur2.Ville} | {Fournisseur2.Province} | {Fournisseur2.CodePostal} | {Fournisseur2.Pays} | {Fournisseur2.Telephone}");
        }

        public static void AfficherFournisseur3()
        {
            Fournisseur Fournisseur3 = new("Heli Süßwaren GmbH & Co.KG","Petra Winkler","Sales Manager","Tiergartenstraße 5","Berlin","Baltimore","10785","Germany","(010) 9984510");
            Console.WriteLine($"{Fournisseur3.NomCompagnie} | {Fournisseur3.NomContact} | {Fournisseur3.TitreContact} | {Fournisseur3.Adresse} | {Fournisseur3.Ville} | {Fournisseur3.Province} | {Fournisseur3.CodePostal} | {Fournisseur3.Pays} | {Fournisseur3.Telephone}");
        }

        public static int AfficherNbFournisseur()
        { return NbFournmisseur; }
    }
}
