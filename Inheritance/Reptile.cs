namespace Inheritance;

public class Reptile : Animal
{
    public Reptile()
    {
        IsAlive = true;
        LegCount = 4;
        LandSeaAir = "Land";
        Age = 0;
    }
    public bool IsColdBlooded {get; set;}
    public bool HasScales {get; set;}
    public string Habitat {get; set;}
    public bool RegenerativeTail {get; set;}
}