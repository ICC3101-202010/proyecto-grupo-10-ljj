using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using WMPLib;
using System.Media;

namespace Movies_Entrega_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string xd = Console.ReadLine() + ".wav";
            WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
            wmp.URL = xd;
            wmp.controls.play();
            
            //List<Actor> totalactors = new List<Actor>();
            //List<string> totalcategories = new List<string>();
            //while (true)
            //{
            //    string option = Movies.ShowOptions(new List<string>() { "Agregar canción", "Ver canciones" });
            //    switch (option)
            //    {
            //        case "Agregar canción":
            //            Console.WriteLine("Nombre de la canción:");
            //            string name = Console.ReadLine();
            //            Console.WriteLine("Categoría(s) a las que pertenece:");
            //            List<string> categories = new List<string>();
            //            while (true)
            //            {
            //                string categorie = Console.ReadLine();
            //                if (categorie == "")
            //                {
            //                    break;
            //                }
            //                else
            //                {
            //                    if (totalcategories.Contains(categorie) == false)
            //                    {
            //                        totalcategories.Add(categorie);
            //                    }
            //                    if (categories.Contains(categorie) == false)
            //                    {
            //                        categories.Add(categorie);
            //                    }
            //                }
            //            }
            //            Console.WriteLine("Género de la canción:");
            //            string gender = Console.ReadLine();
            //            Console.WriteLine("Actor(es) que participan en la película:\n");
            //            List<Actor> actors = new List<Actor>();
            //            while (true)
            //            {
            //                Console.WriteLine("Nombre del actor:");
            //                string nameactor = Console.ReadLine();
            //                Console.WriteLine("Biografía del actor:");
            //                string biographyactor = Console.ReadLine();
            //                Console.WriteLine("Películas en las que ha participado:");
            //                List<string> participationactor = new List<string>();
            //                while (true)
            //                {
            //                    string movie = Console.ReadLine();
            //                    if (movie == "")
            //                    {
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        if (participationactor.Contains(movie) == false)
            //                        {
            //                            participationactor.Add(movie);
            //                        }
            //                    }
            //                }
            //                Console.WriteLine("Género en el que trabaja el actor:");
            //                string genderactor = Console.ReadLine();
            //                Console.WriteLine("Edad del actor:");
            //                int ageactor = Convert.ToInt32(Console.ReadLine());
            //                if (totalactors.Contains(new Actor(nameactor, biographyactor, participationactor, genderactor, ageactor)) == false)
            //                {
            //                    totalactors.Add(new Actor(nameactor, biographyactor, participationactor, genderactor, ageactor));
            //                }
            //                if (actors.Contains(new Actor(nameactor, biographyactor, participationactor, genderactor, ageactor)))
            //                {
            //                    actors.Add(new Actor(nameactor, biographyactor, participationactor, genderactor, ageactor));
            //                }
            //                Console.WriteLine("¿Hay más actores en esta película? si/no");
            //                string answer = Console.ReadLine();
            //                if (answer == "no")
            //                {
            //                    break;
            //                }
            //                else if (answer == "si")
            //                {
            //                    continue;
            //                }
            //            }
            //            Console.WriteLine("Estudio encargado de la película:");
            //            string studio = Console.ReadLine();
            //            Console.WriteLine("Año de lanzamiento:");
            //            int year = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Descripción de la película:");
            //            string description = Console.ReadLine();
            //            Console.WriteLine("Duración de la película:");
            //            int duration = Convert.ToInt32(Console.ReadLine());

            //            break;
            //    }
            //}
            Console.ReadKey();
        }
    }
}
