using System;

namespace APP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test d'un menu
            int choix = 0;
            int boucle1 = 0;
            Console.WriteLine("Entre un nombre entre plus petit que 3: ");
            //while (!(int.TryParse(Console.ReadLine(),out choix)) || choix > 2 || choix < 0)
            //{
            //    Console.WriteLine("Entre un nombre valide");
            //}
            while (boucle1 == 0)
            {
                try
                {
                    choix = int.Parse(Console.ReadLine());
                    boucle1 = 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vous n'avez pas entré un nombre \nEntrer un nombre:");
                    boucle1 = 0;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Vous avez entrer un nombre trop grand ou trop petit, veillez entrer un nombre qui rentre dans 32 bits");
                    boucle1 = 0;

                }
                catch (Exception)
                {
                    Console.WriteLine("Exception non reconnu, veillez entrer un nombre valide svp:");
                    boucle1 = 0;

                }
            }

            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Pow(999,99));
            



            switch (choix)
            {
                case 1:
                    Console.WriteLine("test");
                    break;
                case 2:
                    int a = 27;
                    break;
                case 3:
                    int x = 0;
                    Console.WriteLine("Entre un nombre dont tu veux connaitre la table:");
                    while (!(int.TryParse(Console.ReadLine(), out x)))
                    {
                        Console.WriteLine("Entre un nombre valide:");
                    }
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", i, x, i * x);
                    }
                    break;
                default:
                    Console.ReadKey();
                    break;
            }

        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Théorie___entrainement
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Tabelaux
//            //int[] tableaunb = new int[3]; //On défini entre [] les nombres de variables que l'on veut.
//            //int[] tableaunbdefini = new int[] { 1, 2, 3, 4 }; //En ne mettant rien on ne définit pas le nombre de variable, le nb de variable sera défini  après entre {}.
//            //string[] tabstring = new string[] { "Janvier", "Février", "Mars", "Avril" };
//            //Array.Sort(tabstring); //Pour trier dans l'ordre alphabétique.
//            //Console.WriteLine(tableaunbdefini[0] + tabstring[0]);
//            //Console.WriteLine("La longueur du tableau est de: " + tabstring.Length); //[Varialbe].Length = longueur du tableau.
//            //foreach (string compte in tabstring)
//            //{
//            //    Console.WriteLine(compte);
//            //}
//            //int[,] tab2dint = new int[2, 3]; //Tableau de 2 lignes et 3 colonnes. (c'est un tableau rectangulaire.   
//            //string[,] tab2dstring = { { "11", "12", "13" }, { "21", "22", "23" } }; //On peut aussi noter directement les variables. (ici, 2 lignes et 3 colonnes)
//            //Console.WriteLine(tab2dstring[1, 2]);
//            //_______________________________________________________________________________________________________________________________________________________________
//            //Méthodes
//            Console.WriteLine("Entrer l'agent présent sur le compte de la première personne: ");
//            Double compte1 = Double.Parse(Console.ReadLine());
//            Pause();
//            Console.WriteLine("Entrer l'agent présent sur le compte de la deuxième personne: ");
//            Double compte2 = Double.Parse(Console.ReadLine());
//            Pause();
//            Console.WriteLine("La somme d'argent sur les 2 compte vaut: " + Somme(compte1, compte2));
//            int choix = 0;
//            while (!(int.TryParse(Console.ReadLine(),)))
//            {

//            }

//        }
//        //Méthodes
//        public static void Pause() //On peut mettre Pause n'importe ou dans la class Program.
//        {
//            Console.WriteLine("Appuye sur une touche pour continuer.");
//            Console.ReadKey(true); // Pour marquer une pause.
//        }
//        public static Double Somme(Double nb1, Double nb2)
//        {
//            return nb1 + nb2; // On utilise Return pour "Retourner" la somme.
//        }



//    }
//}

