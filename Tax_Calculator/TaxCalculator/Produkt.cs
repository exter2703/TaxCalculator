namespace TaxCalculator;

public class Produkt
{
    public string Name { get; set; }
    public int Pieces { get; set; }
    public double Tax { get; set; }
    public double Netto { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Pieces} sztuk.)";
    }
}