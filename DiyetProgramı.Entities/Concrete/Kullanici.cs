using DiyetProgramı.Entities.Abstract;
using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.Entities.Concrete;

public class Kullanici : BaseEntity
{
    public string KullaniciMail { get; set; }
    public string KullaniciSifre { get; set; }

    //Nav Property
    public List<Ogun> Ogunler { get; set; }
}