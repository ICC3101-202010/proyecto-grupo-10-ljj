using System;
using System.Collections.Generic;
using System.Threading;
namespace Entrega2ProyectoLJJ
{
    public class User
    {
        private string plan;
        private string email;
        private string password;
        private List<Profile> ListOfProfiles = new List<Profile>();
        private List<User> ListOfUser = new List<User>();
        public User(string plan, string email, string password)
        {
            this.plan = plan;
            this.email = email;
            this.password = password;
        }
        public void TypeOfPlan()
        {
            Console.WriteLine("¿Que plan le desea agregar a esta cuenta?(premium or free)");
            string newplan = Console.ReadLine();
            plan = newplan;
        }
        public void CreateUser(string plan, string email, string password)
        {   
            User user = new User(plan, email, password);
            ListOfUser.Add(user);
            Console.WriteLine("Usuario creado con exito");
            Thread.Sleep(1000);
        }
        public void CreateProfile(string username, bool privacy)
        {
            Profile profile = new Profile(username, privacy);
            ListOfProfiles.Add(profile);
            Console.WriteLine("Perfil creado con exito");
            Thread.Sleep(1000);
        }
        public List<Profile> GetListOfProfiles()
        {
            return ListOfProfiles;
        }
        public void Quit()
        {

        }
    }
}
