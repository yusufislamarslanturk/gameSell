using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameSell.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Kampanya Eklendi.!");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi.!");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Guncellendi.!");
        }
    }
}
