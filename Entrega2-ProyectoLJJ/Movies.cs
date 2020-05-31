using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2ProyectoLJJ
{
    public class Movies
    {
        private string name;
        private List<Actor> actors;
        private List<string> categories;
        private string studio;
        private int year;
        private string description;
        private List<int> qualification;
        private int duration;
        private int reproduction;
        private int users;
        private bool favourite;
        private string resolution;
        //falta image y file
        public Movies(string name, List<string> categories, List<Actor> actors, string studio, int year, string description, int duration)
        {
            this.name = name;
            this.categories = categories;
            this.actors = actors;
            this.studio = studio;
            this.year = year;
            this.description = description;
            this.duration = duration;
        }
        public string GetName()
        {
            return name;
        }
        //Import(file)
        //Stop(file)
        public int GetDuration()
        {
            return duration;
        }
        public List<Actor> GetActors()
        {
            return actors;
        }
        public List<string> GetCategories()
        {
            return categories;
        }
        public string GetResolution()
        {
            return resolution;
        }
        //NumberOfReproduction(reproduction)
        //NumberOfUsers(users)
        public void Qualification(Movies m, int q)
        {
            qualification.Add(q);
            Console.WriteLine("La película " + m.GetName() + "se calificó con un " + qualification);
        }
        public double GetQualification()
        {
            return qualification.Average();
        }
        //AddImage(image)
        public void AddActors(Actor actor)
        {
            actors.Add(actor);
        }
        //NextMovie(file)
        //GoForward(file)
        //GoBackwards(file)
        public static string ShowOptions(List<string> options)
        {
            int i = 0;
            Console.WriteLine("\n\nSelecciona una opcion:");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }
            return options[Convert.ToInt16(Console.ReadLine())];
        }
        public static List<Movies> Search(List<string> filter, List<Movies> movielist)
        {
            List<Movies> moviesSearched = new List<Movies>();
            foreach (string f in filter)
            {
                if (f == "Palabras clave")
                {

                }
                else if (f == "Persona")
                {
                    Console.WriteLine("Nombre del actor");
                    string name = Console.ReadLine();
                    foreach (Movies movie in movielist)
                    {
                        foreach (Actor actor in movie.GetActors())
                        {
                            if (name == actor.GetName())
                            {
                                if (moviesSearched.Contains(movie) == false)
                                {
                                    moviesSearched.Add(movie);
                                }
                            }
                        }
                    }
                }
                else if (f == "Características de la persona")
                {
                    Console.WriteLine("¿Cuáles características desea considerar en la búsqueda?");
                    Console.WriteLine("Para terminar, pulse ENTER solamente.");
                    bool a = true;
                    while (a)
                    {
                        string option = Movies.ShowOptions(new List<string>() { "Nombre", "Biografía", "Participación en películas",
                        "Sexo", "Edad" });
                        if (option == "Nombre")
                        {
                            Console.WriteLine("Ingrese el nombre solicitado:");
                            string name = Console.ReadLine();
                            foreach (Movies movie in movielist)
                            {
                                foreach (Actor actor in movie.GetActors())
                                {
                                    if (name == actor.GetName())
                                    {
                                        if (moviesSearched.Contains(movie) == false)
                                        {
                                            moviesSearched.Add(movie);
                                        }
                                    }
                                }
                            }
                        }
                        if (option == "Biografía")
                        {
                            Console.WriteLine("Ingrese la biografía de la persona o parte de ella:");
                            string biography = Console.ReadLine();
                            foreach (Movies movie in movielist)
                            {
                                foreach (Actor actor in movie.GetActors())
                                {
                                    if (actor.GetBiography().Contains(biography))
                                    {
                                        if (moviesSearched.Contains(movie) == false)
                                        {
                                            moviesSearched.Add(movie);
                                        }
                                    }
                                }
                            }
                        }
                        if (option == "Participación en películas")
                        {
                            bool b = true;
                            List<string> participation = new List<string>();
                            while (b)
                            {
                                Console.WriteLine("Ingrese, una a la vez,  las películas en las que ha participado " +
                                    "(presione ENTER solamente para terminar):");
                                string p = Console.ReadLine();
                                if (p == "")
                                {
                                    b = false;
                                }
                                else
                                {
                                    participation.Add(p);
                                }
                            }
                            foreach (Movies movie in movielist)
                            {
                                foreach (Actor actor in movie.GetActors())
                                {
                                    foreach (string p1 in actor.GetParticipation())
                                    {
                                        foreach (string p2 in participation)
                                        {
                                            if (p1 == p2)
                                            {
                                                if (moviesSearched.Contains(movie) == false)
                                                {
                                                    moviesSearched.Add(movie);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (option == "Sexo")
                        {
                            Console.WriteLine("¿La persona es hombre o mujer?");
                            string gender = Console.ReadLine();
                            foreach (Movies movie in movielist)
                            {
                                foreach (Actor actor in movie.GetActors())
                                {
                                    if (gender == actor.GetGender())
                                    {
                                        if (moviesSearched.Contains(movie) == false)
                                        {
                                            moviesSearched.Add(movie);
                                        }
                                    }
                                }
                            }
                        }

                        if (option == "Edad")
                        {
                            Console.WriteLine("Edad mínima de la persona:");
                            int min = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Edad máxima de la persona:");
                            int max = Convert.ToInt32(Console.ReadLine());
                            foreach (Movies movie in movielist)
                            {
                                foreach (Actor actor in movie.GetActors())
                                {
                                    if (min <= actor.GetAge() && max >= actor.GetAge())
                                    {
                                        if (moviesSearched.Contains(movie) == false)
                                        {
                                            moviesSearched.Add(movie);
                                        }
                                    }
                                }
                            }
                        }
                        if (option == "")
                        {
                            a = false;
                        }
                    }
                }
                else if (f == "Resolución")
                {
                    Console.WriteLine("Tipo de resolución (ingresarla del estilo axb):");
                    string choice = Console.ReadLine();
                    foreach (Movies movie in movielist)
                    {
                        if (choice == movie.GetResolution())
                        {
                            if (moviesSearched.Contains(movie) == false)
                            {
                                moviesSearched.Add(movie);
                            }
                        }
                    }
                }
                else if (f == "Evaluación")
                {
                    Console.WriteLine("Valor mínimo de evaluación promedio de la película:");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor máximo de evaluación promedio de la película:");
                    int max = Convert.ToInt32(Console.ReadLine());
                    foreach (Movies movie in movielist)
                    {
                        if (movie.GetQualification() >= min && movie.GetQualification() <= max)
                        {
                            if (moviesSearched.Contains(movie) == false)
                            {
                                moviesSearched.Add(movie);
                            }
                        }
                    }
                }
                else if (f == "Categoría")
                {
                    Console.WriteLine("Nombre de la categoría:");
                    string choice = Console.ReadLine();
                    foreach (Movies movie in movielist)
                    {
                        foreach (string categorie in movie.GetCategories())
                        {
                            if (choice == categorie)
                            {
                                if (moviesSearched.Contains(movie) == false)
                                {
                                    moviesSearched.Add(movie);
                                }
                            }
                        }
                    }
                }
            }
            foreach (Movies movie in moviesSearched)
            {
                Console.WriteLine(movie.GetName());
            }
            return moviesSearched;
        }
    }
}
