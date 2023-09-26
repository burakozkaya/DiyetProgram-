using DiyetProgramı.Entities.Abstract;

namespace DiyetProgramı.Entities.Concrete;

public class Ogun : IEntity
{
    public int Id { get; set; }
    public int KullaniciId { get; set; }
    public DateTime OgunVakti { get; set; }


    //Nav Property
    public Kullanici Kullanici {get; set; }
    public List<Yemek> Yemekler { get; set; }
}