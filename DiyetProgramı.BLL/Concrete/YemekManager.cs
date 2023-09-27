using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DiyetProgramı.BLL.Concrete
{
    public class YemekManager : BaseManager<Yemek>
    {
        private YemekRepo _repo;
        public YemekManager(BaseRepo<Yemek> baseRepo) : base(baseRepo)
        {
            _repo = (YemekRepo?)baseRepo;
        }
        public  IEnumerable<Yemek> GetAll()
        {
            return _repo.GetAll();
        }

        public IEnumerable<Yemek> EnCokYenenYemek()
        {
            return _repo.EnCokYenenYemek();
        }

        public IEnumerable<Yemek> GünSonuRapor()
        {
            return _repo.GünSonuRapor();
        }

        public decimal GünSonuToplamKalori()
        {
            return GünSonuRapor().Sum(x => x.Ogunler.Sum(x => x.YenilenKalori));
        }

        public IEnumerable<Yemek> HaftalikAylikRapor(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            return _repo.HaftalikAylikRapor(baslangicTarihi,bitisTarihi);
        }
    }
}
