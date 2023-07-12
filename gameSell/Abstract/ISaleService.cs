using gameSell.Concrete;
using gameSell.Abstract;
using gameSell.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  

namespace gameSell.Abstract
{
    public interface ISaleService
    {

        public void Sell(User user, List<Game> games, Campaign campaign);
    }
}
