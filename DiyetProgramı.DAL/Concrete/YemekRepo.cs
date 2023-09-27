using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DiyetProgramı.DAL.Concrete
{
    public class YemekRepo : BaseRepo<Yemek>
    {
        public YemekRepo(int kullaniciId) : base(kullaniciId)
        {
        }

        public override IEnumerable<Yemek> GetAll()
        {
            return _dbSet
                .Include(x => x.Ogunler)
                .ThenInclude(ogun => ogun.Kullanici)
                .Where(x => x.Ogunler.Any(ogun => ogun.KullaniciId == _kullaniciId))
                .ToList();
        }

        public IEnumerable<Yemek> EnCokYenenYemek()
        {
            var yemeklerDb = _dbSet.
                Include(x => x.Ogunler)
                .ThenInclude(x => x.Kullanici).ToList();

            var yemekler = yemeklerDb
                .Where(x => x.Ogunler.Any(x => x.KullaniciId == _kullaniciId))
                .GroupBy(x => x.YemekAdi)
                .Select(x => new
                {
                    id = x.Key
                })
                .OrderByDescending(x => x.id)
                .Take(5)
                .ToList();
            var yemeklerx = new List<Yemek>();
            foreach (var yemek in yemeklerx)
            {
                yemeklerx.Add(yemeklerDb.SingleOrDefault(x=>x.Id == yemek.Id));
            }
            return yemeklerx;
        }

        public IEnumerable<Yemek> GünSonuRapor()
        {
            return _dbSet
                .Include(x => x.Ogunler)
                .ThenInclude(x => x.Kullanici)
                .Where(x => x.Ogunler.Any(x => x.KullaniciId == _kullaniciId &&
                                               x.OgunVakti.Day == DateTime.Now.Day && 
                                               x.OgunVakti.Month == DateTime.Now.Month))
                .ToList();
        }

        public IEnumerable<Yemek> HaftalikAylikRapor(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            
                return _dbSet
                    .Include(x => x.Ogunler)
                    .ThenInclude(x => x.Kullanici)
                    .Where(x => x.Ogunler.Any(ogun => ogun.KullaniciId == _kullaniciId &&
                                                      ogun.OgunVakti >= baslangicTarihi &&
                                                      ogun.OgunVakti <= bitisTarihi))
                    .ToList();
        }
    }
}
