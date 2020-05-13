using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2ProyectoLJJ
{
    public class Movies : Controller
    {
        private string gender;
        private string name;
        private List<Actor> actors;
        private List<string> categories;
        private string studio;
        private int year;
        private string description;
        private List<int> qualification;
        private int duration;
        private int reproduction = 0;
        private int users;
        private bool favourite;
        //falta image y file
        public Movies(string name, List<string> categories, string gender, List<Actor> actors, string studio, int year, string description, int duration)
        {
            this.name = name;
            this.categories = categories;
            this.gender = gender;
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
        public int GetDuration()
        {
            return duration;
        }
        public void NumberOfReproduction()
        {
            reproduction += 1;
        }
        public void Qualification(Movies m, int q)
        {
            qualification.Add(q);
            Console.WriteLine("La película " + m.GetName() + "se calificó con un " + qualification);
        }
        public void AddActors(Actor actor)
        {
            actors.Add(actor);
        }
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
        public override string Search()
        {
            return "las busquedas se estan implementando, en la siguiente actualizacion estaran disponibles";
        }
    }
}
