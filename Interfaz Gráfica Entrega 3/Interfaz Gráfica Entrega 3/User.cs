using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Interfaz_Gráfica_Entrega_3
{
    [Serializable]
    public class User
    {
        private string plan;
        private string email;
        private string password;
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
        }
        public List<User> GetListOfUser()
        {
            return ListOfUser;
        }
        public string GetEmail()
        {
            return email;
        }
        public string GetPassword()
        {
            return password;
        }

    }
}
