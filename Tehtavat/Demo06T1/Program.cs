using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void TestPersonClass()
        {
            //luodaan ns henkilorekisteri
            Persons myFriends = new Persons();
            //lisätään kamuja rekisteriin
            Person friend1 = new Person();
            friend1.Firstname = "Kirisi";
            friend1.Lastname = "Kernell";
            friend1.SocialSecurityNumber = "121270-123D";
            //Lyhyempi tapa luoda ominaisuuksineen
            Person friend2 = new Person { Firstname = "Jack", Lastname = "Russell", SocialSecurityNumber = "1412217-HHH3" };
            Person friend3 = new Person { Firstname = "Dick", Lastname = "Butt", SocialSecurityNumber = "141250-96H3" };
            Person friend4 = new Person { Firstname = "Teppo", Lastname = "testaaja", SocialSecurityNumber = "010101-0010" };
            //lisätään kaverit yksi kerrallaan kaveri rekisteriin
            myFriends.Add(friend1);
            myFriends.Add(friend2);
            myFriends.Add(friend3);
            myFriends.Add(friend4);
            //näytetään tämä rekisteri
            Console.WriteLine("***** kaveroi rekisterisi *******");
            myFriends.ShowPersons();
            //testaaan kaverin hakua
            Console.WriteLine("Anna kverinumero");
            string retval = Console.ReadLine();
            int i = 0;
            if (int.TryParse(retval,out i))
            { 
          
            // huom get-metodi palaittaa null jos indeksij osoittamaa kaveria ei löydy
            Person searchedFriend = myFriends.Get(int.Parse(retval));
            if (searchedFriend !=null)
            { 
            Console.WriteLine(string.Format("Löytyi ystvä nimeltä {0}", searchedFriend.ToString()));
            }
            else
            {
                Console.WriteLine("ei ole");
            }
            }
            //testaan kaverin jhakua Hetulla
            Console.WriteLine("anna kaveri Hetu");
            retval = Console.ReadLine();
            Person searchedPerson = myFriends.Find(retval);
            if (searchedPerson != null)
            Console.WriteLine( searchedPerson.ToString());
            else
                Console.WriteLine(string.Format("ei lpoydy {0}", retval));

        }
        static void Main(string[] args)
        {
            TestPersonClass();
        }
    }
}
