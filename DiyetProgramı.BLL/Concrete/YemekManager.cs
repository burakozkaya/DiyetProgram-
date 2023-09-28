using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;
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

        public IEnumerable<Yemek> GünSonuRapor(DateTime dateTime)
        {
            return _repo.GünSonuRapor(dateTime);
        }

        public decimal GünSonuToplamKalori(DateTime dateTime)
        {
            return GünSonuRapor(dateTime).Sum(x => x.Ogunler.Sum(x => x.YenilenKalori));
        }

        public IEnumerable<Yemek> HaftalikAylikRaporOgun(DateTime baslangicTarihi, DateTime bitisTarihi,OgunIsmi ogunIsmi)
        {
            return _repo.HaftalikAylikRapor(baslangicTarihi,bitisTarihi).Where(x=>x.Ogunler.Any(x=>x.OgunIsmi == ogunIsmi));
        }
        public IEnumerable<Yemek> HaftalikAylikRaporKategori(DateTime baslangicTarihi, DateTime bitisTarihi,YemekKategorileri yemekKategorileri)
        {
            return _repo.HaftalikAylikRapor(baslangicTarihi, bitisTarihi).Where(x=>x.Kategorileri == yemekKategorileri);
        }
    }
}
