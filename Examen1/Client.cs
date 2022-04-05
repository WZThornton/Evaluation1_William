using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Evaluation1_William
{
    public class Client
    {
        private string ClientId;
        private string NomCompagnie;
        private string NomContact;
        private string TitreContact;
        private string Adresse;
        private string Ville;
        private string Province;
        private string CodePostal;
        private string Pays;
        private string Telephones;
        private static int NbClient;

        public Client()
        {
        }

        public Client(string ClientId, string NomCompagnie, string NomContact, string TitreContact, string Adresse, string Ville, string Province, string CodePostal, string Pays, string Telephone)
        { 
            this.ClientId = ClientId;
            this.NomCompagnie = NomCompagnie;
            this.NomContact = NomContact;
            this.TitreContact = TitreContact;
            this.Adresse = Adresse;
            this.Ville = Ville;
            this.Province = Province;
            this.CodePostal = CodePostal;
            this.Pays = Pays;
            this.Telephones = Telephone;
            NbClient++;
        }

        public static void Afficherclient1()
        {
            Client clientManuel = new Client("GROSSR", "GROSELLA-Restaurante", "Manuel Pereira", "Owner", "5e Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela", "(2) 283-2951");
            WriteLine($"{clientManuel.ClientId} | {clientManuel.NomCompagnie} | {clientManuel.NomContact} | {clientManuel.TitreContact} | {clientManuel.Adresse} | {clientManuel.Ville} | {clientManuel.Province} | {clientManuel.CodePostal} | {clientManuel.Pays} | {clientManuel.Telephones}");
        }

        public static void Afficherclient2()
        {
            Client clientMario = new("HANAR", "Hanari Carnes", " Mario Pontes", "Accounting Manager", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil", "(21) 555-0091");
            WriteLine($"{clientMario.ClientId} | {clientMario.NomCompagnie} | {clientMario.NomContact} | {clientMario.TitreContact} | {clientMario.Adresse} | {clientMario.Ville} | {clientMario.Province} | {clientMario.CodePostal} | {clientMario.Pays} | {clientMario.Telephones}");
        }
        public static void Afficherclient3()
        {
            Client clientCarlos = new("HILAA", "HILARION-Abastos", "Carlos Hernandes", "Sales Representative", "Ville Center Plaza 516 Main St.", "San Cristobal", "Tachira", "5022", "Venezuela", "(5) 555-1340");
            WriteLine($"{clientCarlos.ClientId} | {clientCarlos.NomCompagnie} | {clientCarlos.NomContact} | {clientCarlos.TitreContact} | {clientCarlos.Adresse} | {clientCarlos.Ville} | {clientCarlos.Province} | {clientCarlos.CodePostal} | {clientCarlos.Pays} | {clientCarlos.Telephones}");
        }

        public static int AfficherNbClient()
        {
            return NbClient;
        }
    }
}
