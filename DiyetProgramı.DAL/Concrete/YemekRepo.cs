﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;
using Microsoft.EntityFrameworkCore;

namespace DiyetProgramı.DAL.Concrete
{
    public class YemekRepo : BaseRepo<Yemek>
    {
        public YemekRepo(int kullaniciId) : base(kullaniciId)
        {
        }

        public override List<Yemek> GetAll()
        {
            return _dbSet
                .Include(x => x.Ogunler)
                .ThenInclude(ogun => ogun.Kullanici)
                .ToList();
        }

        public List<YemekRaporu> YemekRapor()
        {
            return _dbSet
                .Select(yemek => new YemekRaporu
                {
                    YemekAdi = yemek.YemekAdi,
                    Sabah = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.sabah)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    SabahOgleArasi = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.sabahogleArasi)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    Oglen = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.oglen)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    Ikindi = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.ikindi)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    Aksam = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.aksam)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    Yatsi = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.yatsi)
                        .Sum(ogun => ogun.YemekPorsiyon)
                })
                .ToList();
        }
        public List<Yemek> EnCokYenenYemek()
        {
            var yemeklerx = new List<Yemek>();
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
                .Take(10)
                .ToList();
            
            foreach (var yemek in yemeklerDb)
            {
                yemeklerx.Add(yemeklerDb.SingleOrDefault(x=>x.Id == yemek.Id));
            }
            return yemeklerx;
        }

        public List<Yemek> GünSonuRapor(DateTime dateTime)
        {
            return _dbSet
                .Include(x => x.Ogunler)
                .ThenInclude(x => x.Kullanici)
                .Where(x => x.Ogunler.Any(x => x.KullaniciId == _kullaniciId &&
                                               x.OgunVakti.Day == dateTime.Day && 
                                               x.OgunVakti.Month == dateTime.Month &&
                                               x.OgunVakti.Year == dateTime.Year))
                .ToList();
        }

        public List<Yemek> HaftalikAylikRaporKullanici(DateTime baslangicTarihi, DateTime bitisTarihi,YemekKategorileri yemekKategorileri)
        {
            
                return _dbSet
                    .Include(x => x.Ogunler)
                    .ThenInclude(x => x.Kullanici)
                    .Where(x =>x.Kategorileri == yemekKategorileri && x.Ogunler.Any(ogun => ogun.KullaniciId == _kullaniciId &&
                                                      ogun.OgunVakti >= baslangicTarihi &&
                                                      ogun.OgunVakti <= bitisTarihi))
                    .ToList();
        }
        public List<Yemek> HaftalikAylikRapor(DateTime baslangicTarihi, DateTime bitisTarihi,YemekKategorileri yemekKategorileri)
        {

            return _dbSet
                .Include(x => x.Ogunler)
                .Where(x => x.Ogunler.Any(ogun => ogun.OgunVakti >= baslangicTarihi &&
                                                        ogun.OgunVakti <= bitisTarihi && x.Kategorileri == yemekKategorileri))
                .ToList();
        }

        public override void Delete(Yemek entity)
        {
            if (_dbSet.Include(x => x.Ogunler).Any(x => x.Ogunler.Any(x => x.YemekId == entity.Id)))
                throw new Exception();
            _dbSet.Remove(entity);
            SaveChanges();

        }
    }
}
