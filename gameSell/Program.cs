using System;
using gameSell.Abstract;
using gameSell.Entites;
using gameSell.Concrete;
using System.Collections.Generic;

namespace gameSell
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { Name = "Safa", Age = 18, ID = 115 };


            IUserService userManager = new UserManager(new UserCheckManager());

            userManager.Add(user1);
            Console.WriteLine();

            Game game1 = new Game
            {
                Name = "Last of Us",
                Id = 12,
                Price = 500
            };

            Game game2 = new Game
            {
                Name = "CS:GO",
                Id = 13,
                Price = 300
            };


            ISaleService saleManager = new SaleManager();

            Campaign campaign = new Campaign
            {
                Name = "Yarısı",
                DiscountRate = 0.5
            };

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign);
            Console.WriteLine();



            List<Game> sepettekiOyunlar = new List<Game>();
            sepettekiOyunlar.Add(game1);
            sepettekiOyunlar.Add(game2);

            saleManager.Sell(user1, sepettekiOyunlar, campaign);





        }
    }
}
