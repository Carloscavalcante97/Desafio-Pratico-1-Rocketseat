
namespace DesafioPratico_1;

public class Concatenacao
{
    public string nome { get; set; }
    public string sobrenome { get; set; }
    public void nomeCompleto()
    {
        Console.WriteLine($"Nome completo: {nome} {sobrenome}");
    }
}
