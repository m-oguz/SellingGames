using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    class GameManager : IGameService
    {

        List<Game> games = new List<Game>();



        public void AddGame(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName + " has been added.");

        }

        public void DeleteGame(Game game)
        {
            games.Remove(game);
            Console.WriteLine(game.GameName + "  was removed");

        }

        public void ListTheGames()
        {
            Console.WriteLine("---------------GAMES SAVED TO THE DATABASE----------");
            foreach (var game in games)
            {
                Console.WriteLine(game.GameID + "  " + game.GameName + " " + game.GamePrice);
            }
            Console.WriteLine("---------------END OF THE GAME LIST----------------");
            Console.WriteLine("");
            Console.WriteLine("");



        }

        public void UpdateGame(Game game, double newPrice)
        {
            game.GamePrice = newPrice;
            Console.WriteLine("Updated : " + game.GameName + " Price: " + game.GamePrice);
        }
    }
}
