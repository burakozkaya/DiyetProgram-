using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Abstract;

namespace DiyetProgramı.Entities.Concrete
{
    public class YemekCesit : IEntity
    {
        public int Id { get; set; }
        public decimal Kalori { get; set; }

        //todo resim eklencek
        //Nav Property
        public List<Yemek> Yemekler { get; set; }
    }
}
