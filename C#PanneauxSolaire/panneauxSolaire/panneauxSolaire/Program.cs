using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panneauxSolaire
{
    class Program
    {
     static void panneauxSolaireCalc(double largM, double longM, double hc, double hp, out double nbPanneaux, out double prixTotal)
        {
            double versantToit, npL, npH;
         
            const double lPan = 0.7;
            const double hPan = 1.5;
            const double prixPan = 489;


            versantToit = Math.Pow(Math.Pow((hp - hc), 2) + Math.Pow((largM / 2), 2), 0.5);
            npL = longM / lPan;
            npH = versantToit / hPan;
            nbPanneaux = npL * npH;
            prixTotal = nbPanneaux * prixPan;
            
        }
        static void Main(string[] args)
        {
            double largM, longM, hc, hp, nbPanneaux, prixTotal;
            Console.WriteLine("Entrez la largeur de la maison svp :");
            largM = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la longueur de la maison svp :");
            longM = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la hauteur à la corniche");
            hc = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la hauteur au pignon");
            hp = double.Parse(Console.ReadLine());


            //appel au traitement

            panneauxSolaireCalc(largM, longM, hc, hp, out nbPanneaux, out prixTotal);

            // Affichage
            Console.WriteLine($"le nombre de panneaux est de : {Math.Ceiling(nbPanneaux)}");
            Console.WriteLine($"le prix totale est de :{Math.Ceiling(prixTotal)}");

            Console.ReadLine();
            


        }
    }
}


