using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.Entities.Concrete;

public class OgunYemek : BaseEntity
{
    public int OgunId { get; set; }
    public int YemekId { get; set; }

    //Nav Property
    public Yemek Yemek { get; set; }
    public Ogun Ogun { get; set; }
}