using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gameSell.Abstract;
using gameSell.Entites;

namespace gameSell.Concrete
{
    class UserManager : IUserService
    {
        private UserCheckManager userCheckManager;

        public UserManager(UserCheckManager userCheckManager)
        {
            this.userCheckManager = userCheckManager;
        }

        public void Add(User user)
        {
            Console.WriteLine("Kullanıcı Eklendi.");
        }

        public void Delete(User user)
        {
            Console.WriteLine("kullanıcı silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("kullanıcı güncellendi.");
        }
    }
}
