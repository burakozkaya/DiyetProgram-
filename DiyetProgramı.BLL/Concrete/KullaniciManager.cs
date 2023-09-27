using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Concrete;

namespace DiyetProgramı.BLL.Concrete
{
    public class KullaniciManager : BaseManager<Kullanici>
    {
        private KullaniciRepo _repo;
        public KullaniciManager(BaseRepo<Kullanici> baseRepo) : base(baseRepo)
        {
            _repo = (KullaniciRepo?)baseRepo;
        }

        public bool UserLogin(string email,string password)//giriş 
        {
            return _repo.UserLogin(email,password);
        }

        public bool ValidUser(string username)//kayıt
        {
            return _repo.ValidUser(username);
        }

        public bool ValidMail(string username)//kayıt
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(username, pattern);
        }

        public bool ValidPassword(string password)
        {
            bool tempLower = false;
            bool tempUpper = false;
            bool tempSpec = false;
            foreach (var VARIABLE in password)
            {
                if (Char.IsLower(VARIABLE))
                    tempLower = true;
                else if (Char.IsUpper(VARIABLE))
                    tempUpper = true;
                else if (Char.IsSymbol(VARIABLE) || Char.IsPunctuation(VARIABLE))
                    tempSpec = true;
            }

            if (tempSpec && tempUpper && tempLower)
                return true;
            return false;
        }

        public int UserId(string userName)
        {
            return _repo.GetUserId(userName);
        }
    }
}
