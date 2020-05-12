using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2ProyectoLJJ
{
    public class Actor
    {
        private string name;
        private string biography;
        private List<string> participation;
        private string gender;
        private int age;
        //falta photo

        // falta Participation(Movies movie)
        public Actor(string name, string biography, List<string> participation, string gender, int age)
        {
            this.name = name;
            this.biography = biography;
            this.participation = participation;
            this.gender = gender;
            this.age = age;
        }
    }
}
