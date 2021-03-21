using SellMyGames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer, Game game)
        {
            gamer.GamesBought.Add(game);
            Console.WriteLine("....................................................................");

            Console.WriteLine(gamer.FirstName.ToUpper() + " bought  " + game.GameName.ToUpper() + " for " + game.GamePrice + "Euros.");
            Console.Write(gamer.FirstName.ToUpper() + "'s gamelist now includes : ");
            foreach (var g in gamer.GamesBought)
            {

                Console.Write(g.GameName + ", ");

            }
            Console.WriteLine(" ");

            Console.WriteLine("....................................................................");

            Console.WriteLine(" ");
        }


        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {


            double newPrice = (game.GamePrice / 100) * (100 - campaign.DiscountAmount);
            gamer.GamesBought.Add(game);



            Console.WriteLine("....................................................................");

            Console.WriteLine(gamer.FirstName.ToUpper() + " bought  " + game.GameName.ToUpper() + " for " + newPrice + "Euros.");
            Console.Write(gamer.FirstName.ToUpper() + "'s gamelist now includes : ");
            foreach (var g in gamer.GamesBought)
            {

                Console.Write(g.GameName + ", ");

            }
            Console.WriteLine(" ");

            Console.WriteLine("....................................................................");

            Console.WriteLine(" ");

        }
    }
}
