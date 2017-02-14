using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5T4
{
    /* Composition is a special type of association
	 User owns Luser. Luser can't live on without User
	 When User dies, Luser dies too
*/

    using System;

    public class User
    {
        private Luser luser = new Luser();

        public User()
        {
            luser.Name = "Arska";
        }

        ~User()
        {
            Console.WriteLine("User " + this.luser.Name + " is destructed");
        }

        public void PrintName()
        {
            Console.WriteLine("Users luser name is " + this.luser.Name);
        }

    };

    public class Luser
    {
        public string Name;
        ~Luser()
        {
            Console.WriteLine("Luser is destructed");
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.PrintName(); // Users luser name is Arska
            user = null;

            GC.Collect(); // User Arska is destructed, Luser is destructed
            Console.ReadLine();
        }
    }
   
}
