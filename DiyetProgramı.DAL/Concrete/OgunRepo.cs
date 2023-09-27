using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Concrete;

namespace DiyetProgramı.DAL.Concrete
{
    public class OgunRepo : BaseRepo<Ogun>
    {
        public OgunRepo(int kullaniciId) : base(kullaniciId)
        {
        }

        public override IEnumerable<Ogun> GetAll()
        {
            return base.GetAll().Where(x=>x.KullaniciId==_kullaniciId);
        }
    }
}
