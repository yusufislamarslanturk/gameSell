using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gameSell.Abstract;
using gameSell.Entites;
using gameSell.Concrete;

namespace gameSell.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sell(User user, List<Game> games, Campaign campaign)
        {

            double satisFiyati = 0;
            foreach (var item in games)
            {
                satisFiyati += item.Price;

            }
            satisFiyati *= campaign.DiscountRate;


            foreach (var item in games)
            {
                Console.Write(item.Name + " ");
            }
            Console.Write(" " + user.Name + " adlı kullanıcıya ");
            Console.Write(satisFiyati + " fiyatla satıldı.\n");
        }
    }
}
