using System.Security.AccessControl;
using DiyetProgramı.Entities.Abstract;
using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.Entities.Concrete;

public class Yemek : IEntity
{
    public int Id { get; set; }
    public decimal YemekPorsiyon  { get; set; }
    public decimal YemekKalori { get; set; }
    public YemekKategorileri Kategorileri { get; set; }
    public int YemekCesitId { get; set; }
    public int OgunId { get; set; }
    

    //Nav Property
    public YemekCesit YemekCesit { get; set; }
    public Ogun Ogun { get; set; }

}