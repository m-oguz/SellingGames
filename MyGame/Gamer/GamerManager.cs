using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    class GamerManager : IGamerService
    {
        List<Gamer> gamers = new List<Gamer>();
        public void ListTheGamers()
        {

            Console.WriteLine("-------------------  REGISTERED GAMERS  --------------------");
            foreach (var gamer in gamers)
            {
                Console.WriteLine(gamer.Id +  "  " + gamer.FirstName + " " + gamer.LastName.ToUpper()  +"  "+ gamer.DateOfBirth);

            }
            Console.WriteLine("--------------   END OF REGISTERED GAMER LIST   -------------");
            Console.WriteLine("");
            Console.WriteLine("");
        }



        public void Delete(Gamer gamer)
        {
            /*
             * DATABASE PROCESSES HERE
             * DATABASE PROCESSES HERE
             * DATABASE PROCESSES HERE
             */

            gamers.Remove(gamer);
            Console.WriteLine(gamer.FirstName + " was removed");
        }




        public void Register(Gamer gamer)
        {
            /*
             * DATABASE PROCESSES HERE
             * DATABASE PROCESSES HERE
             * DATABASE PROCESSES HERE
             */
            gamers.Add(gamer);
            Console.WriteLine(gamer.FirstName + " has been added to database.");
        }




        public void Update(Gamer gamer)
        {
            /*
             * DATABASE PROCESSES HERE
             * DATABASE PROCESSES HERE
             * DATABASE PROCESSES HERE
             */
            Console.WriteLine(gamer.FirstName + " has been updated.");
        }
    }
}