using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    interface IGameService
    {
        public void AddGame(Game game);
        public void UpdateGame(Game game, double newPrice);
        public void DeleteGame(Game game);

        public void ListTheGames();
    }
}
