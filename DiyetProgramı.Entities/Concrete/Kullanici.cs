using DiyetProgramı.Entities.Abstract;

namespace DiyetProgramı.Entities.Concrete;

public class Kullanici : IEntity
{
    public int Id { get; set; }
    public string KullaniciMail { get; set; }
    public string KullaniciSifre { get; set; }


    //Nav Property
    public List<Ogun> Ogunler { get; set; }
}