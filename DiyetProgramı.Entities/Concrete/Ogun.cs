using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.Entities.Concrete;

public class Ogun : BaseEntity
{
    public int KullaniciId { get; set; }
    public OgunIsmi OgunIsmi { get; set; }
    public DateTime OgunVakti { get; set; }
    public decimal YemekPorsiyon { get; set; }
    public decimal YenilenKalori { get; set; }

    //Nav Property
    public Kullanici Kullanici {get; set; }
    public List<Yemek> Yemekler { get; set; }
}