using SellMyGames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    interface ISalesService
    {
        public void Sell(Gamer gamer, Game games);

    }
}
