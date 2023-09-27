using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Concrete;

namespace DiyetProgramı.BLL.Concrete
{
    public class OgunManager : BaseManager<Ogun>
    {
        private OgunRepo _repo;
        public OgunManager(BaseRepo<Ogun> baseRepo) : base(baseRepo)
        {
            _repo = (OgunRepo?)baseRepo;
        }

        public IEnumerable<Ogun> GetAll()
        {
            return _repo.GetAll();
        }

        public override void InsertManager(Ogun entity)
        {
            var yemek = entity.Yemekler.FirstOrDefault(x => x.Id == entity.Id);
            entity.YenilenKalori = entity.YemekPorsiyon * yemek.Kalori;
            base.InsertManager(entity);
        }
    }
}
