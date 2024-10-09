
namespace DesafioPratico_1;

public static class Calculadora
{
    public static int soma(int numero1, int numero2)=> numero1 + numero2;
    public static int subtrair(int numero1, int numero2)=> numero1 - numero2;
    public static int multiplicar(int numero1, int numero2)=> numero1 * numero2;
    public static int dividir(int numero1, int numero2)
    {
        if (numero2 != 0) return numero1 / numero2;
        return 0;
    }
    public static int media(int numero1, int numero2)
    {
        return (numero1 + numero2)/2;

    }
}
