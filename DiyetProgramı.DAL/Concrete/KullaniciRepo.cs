using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Concrete;

namespace DiyetProgramı.DAL.Concrete
{
    public class KullaniciRepo : BaseRepo<Kullanici>
    {
        public KullaniciRepo(int kullaniciId) : base(kullaniciId)
        {
        }

        public bool ValidUser(string username)
        {
            if(_dbSet.Any(x=>x.KullaniciMail == username))
                return false;
            return true;
        }

        public bool UserLogin(Kullanici kullanici)
        {
            var user = _dbSet.SingleOrDefault(x => x.KullaniciMail == kullanici.KullaniciMail);
            if(user == null) 
                return false;
            if (user.KullaniciSifre != kullanici.KullaniciSifre)
                return false;
            return true;
        }

        public int GetUserId(string userName)
        {
            return  _dbSet.Single(x => x.KullaniciMail == userName).Id;
        }
    }
    
}
