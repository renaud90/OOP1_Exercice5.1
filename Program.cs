using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Exercice5._1
{
    /// <summary>
    ///     Structure qui représente les informations sur une personne. 
    /// </summary>
    public struct Personne
    {
        public string Prenom;
        public string Nom;
        public char Sexe;
        public int Age;
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            TraiterTous(3);
            Console.ReadKey();
        }

        /// <summary>
        ///     Affiche une ligne de caractères * pour le formatage à la console
        /// </summary>
        public static void AfficherSepareteur()
        {
            Console.WriteLine("**********************************************************");
        }

        /// <summary>
        ///     Demande des informations à l'utilisateur pour la création d'une instance de la structure Personne
        /// </summary>
        /// <returns>Structure Personne</returns>
        public static Personne DemanderInfo()
        {
            Personne info = new Personne();
            Console.WriteLine("Entrez votre nom de famille:");
            info.Nom = Console.ReadLine();
            Console.WriteLine("Entrez votre nom de prénom:");
            info.Prenom = Console.ReadLine();
            Console.WriteLine("Entrez votre sexe (H ou F):");
            info.Sexe = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Entrez votre âge (en nombre):");
            info.Age = Convert.ToInt32(Console.ReadLine());
            return info;
        }

        /// <summary>
        ///     Affiche les information contenu dans une structure Personne à la console.
        /// </summary>
        /// <param name="info">Une structure Personne doit être donnée en argument</param>
        public static void AfficherInfo(Personne info)
        {
            Console.WriteLine($"Nom: {info.Nom}");
            Console.WriteLine($"Prénom: {info.Prenom}");
            Console.WriteLine($"Sexe: {info.Sexe}");
            Console.WriteLine($"Âge: {info.Age}");
        }


        /// <summary>
        ///     Demande et affiche les informations d'un nombre de personnes désiré.
        /// </summary>
        /// <param name="nPersonnes">Nombre d'éxécution du traitement de personne</param>
        public static void TraiterTous(int nPersonnes)
        {
            Personne[] personnes = new Personne[nPersonnes];
            for(int i = 0; i < nPersonnes; i++)
            {
                Personne info = DemanderInfo();
                personnes[i] = info;
                AfficherSepareteur();
                
            }
            for(int j = 0; j < nPersonnes; j++)
            {
                Console.WriteLine($"PERSONNE {j + 1}");
                AfficherInfo(personnes[j]);
                AfficherSepareteur();
            }
        }
    }
}
