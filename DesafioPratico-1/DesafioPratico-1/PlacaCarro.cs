
namespace DesafioPratico_1;

public static class PlacaCarro
{
    public static bool ValidarPlaca(string placa)
    {
        if (placa.Length != 7) return false;
        else if (!placa.Substring(0, 3).All(char.IsLetter)) return false;
        else if (!placa.Substring(3, 4).All(char.IsNumber)) return false;
        return true;
    }
}
