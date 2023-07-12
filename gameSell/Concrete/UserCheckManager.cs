using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gameSell.Abstract;

namespace gameSell.Concrete
{
    class UserCheckManager : IUserCheckService
    {
        public bool CheckUser()
        {
            return true;
        }
    }
}
