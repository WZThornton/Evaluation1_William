using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1_William
{
    public class Commande
    {
        private int CommandeId;
        private string ClientId;
        private int EmployeId;
        private DateTime DateCommande;
        private DateTime DateRequise;
        private DateTime DateEnvoi;
        private string NomEnvoi;
        private string AdresseEnvoi;
        private string VilleEnvoi;
        private string CodePostalEnvoi;
        private string PaysEnvoi;
        private static int NbCommande;


        public Commande()
        { }


        public Commande(int CommandeId, string ClientId, int EmployeId, DateTime DateCommande, DateTime DateRequise, DateTime DateEnvoi, string NomEnvoi, string AdresseEnvoi, string VilleEnvoi, string CodePostalEnvoi, string PaysEnvoi)
        { 
            this.CommandeId = CommandeId;
            this.ClientId = ClientId;
            this.EmployeId = EmployeId;
            this.DateCommande = DateCommande;
            this.DateRequise = DateRequise;
            this.DateEnvoi = DateEnvoi;
            this.NomEnvoi = NomEnvoi;
            this.AdresseEnvoi = AdresseEnvoi;
            this.VilleEnvoi = VilleEnvoi;
            this.CodePostalEnvoi = CodePostalEnvoi;
            this.PaysEnvoi = PaysEnvoi;
            NbCommande++;
        }

        public static void AfficherCommande1()
        {
            Commande Commande1 = new(10256, "GROSR", 3, new DateTime(1996, 07, 15), new DateTime(1996, 08, 12), new DateTime(1996, 07, 17), "Wellington Importadora", "Rua do Mercado, 12", "Resende", "08737-363", "Brazil");
            Console.WriteLine($"{Commande1.CommandeId} | {Commande1.ClientId} | {Commande1.EmployeId} | {Commande1.DateCommande} | {Commande1.DateRequise} | {Commande1.DateEnvoi} | {Commande1.NomEnvoi} | {Commande1.AdresseEnvoi} | {Commande1.VilleEnvoi} | {Commande1.CodePostalEnvoi} | {Commande1.PaysEnvoi}");
        }

        public static void AfficherCommande2()
        {
            Commande Commande2 = new(10261, "HANAR", 4, new DateTime(1996, 07, 19), new DateTime(1996, 08, 16), new DateTime(1996, 07, 30), "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "02389-673", "Brazil");
            Console.WriteLine($"{Commande2.CommandeId} | {Commande2.ClientId} | {Commande2.EmployeId} | {Commande2.DateCommande} | {Commande2.DateRequise} | {Commande2.DateEnvoi} | {Commande2.NomEnvoi} | {Commande2.AdresseEnvoi} | {Commande2.VilleEnvoi} | {Commande2.CodePostalEnvoi} | {Commande2.PaysEnvoi}");
        }

        public static void AfficherCommande3()
        {
            Commande Commande3 = new(10264, "HILAA", 6, new DateTime(1996, 07, 24), new DateTime(1996, 08, 21), new DateTime(1996, 08, 23), "Folk och fä HB", "Åkergatan 24", "Bräcke", "S-844 67", "Sweden");
            Console.WriteLine($"{Commande3.CommandeId} | {Commande3.ClientId} | {Commande3.EmployeId} | {Commande3.DateCommande} | {Commande3.DateRequise} | {Commande3.DateEnvoi} | {Commande3.NomEnvoi} | {Commande3.AdresseEnvoi} | {Commande3.VilleEnvoi} | {Commande3.CodePostalEnvoi} | {Commande3.PaysEnvoi}");
        }

        public static int AfficherNbCommande()
        {
            return NbCommande;
        }

    }
}
