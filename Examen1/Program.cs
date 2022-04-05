using System;
using static System.Console;

namespace Evaluation1_William
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Evaluation1_William");
            WriteLine("Client 1");
            Client.Afficherclient1();
            WriteLine("Client 2");
            Client.Afficherclient2();
            WriteLine("Client 3");
            Client.Afficherclient3();
            WriteLine("Il y a {0} clients", Client.AfficherNbClient());
            WriteLine();
            WriteLine("Fournisseur 1");
            Fournisseur.AfficherFournisseur1();
            WriteLine("Fournisseur 2");
            Fournisseur.AfficherFournisseur2();
            WriteLine("Fournisseur 3");
            Fournisseur.AfficherFournisseur3();
            WriteLine("Il y a {0} Fournisseurs", Fournisseur.AfficherNbFournisseur());
            WriteLine();
            WriteLine("Commande 1");
            Commande.AfficherCommande1();
            WriteLine("Commande 2");
            Commande.AfficherCommande2();
            WriteLine("Commande 3");
            Commande.AfficherCommande3();
            WriteLine("Il y a {0} Commandes", Commande.AfficherNbCommande());
        }
    }
}
