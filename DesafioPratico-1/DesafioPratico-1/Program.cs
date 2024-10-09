namespace DesafioPratico_1;

class Program
{
    static void Main(string[] args)
    {
        //Exercicio 1
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome");
        string sobrenome = Console.ReadLine();
        Console.WriteLine("Digite sua mensagem: ");
        string mensagem = Console.ReadLine();
        string resultado = $"Olá, {nome}! {mensagem}";
        //Exercicio 2
        Console.WriteLine(resultado);
        Concatenacao concatenacao = new Concatenacao();
        concatenacao.nome = nome;
        concatenacao.sobrenome = sobrenome;
        concatenacao.nomeCompleto();
        //Exercicio 3
        Console.WriteLine(Calculadora.soma(numero1: 14,numero2: 5));
        Console.WriteLine(Calculadora.subtrair(numero1: 14,numero2: 5));
        Console.WriteLine(Calculadora.multiplicar(numero1: 14,numero2: 5));
        Console.WriteLine(Calculadora.dividir(numero1: 14,numero2: 5));
        Console.WriteLine(Calculadora.media(numero1: 14,numero2: 5));
        //Exercicio 4
        Console.WriteLine("Digite a palavra: ");
        string palavra = Console.ReadLine();
        string palavraSemEspaco = palavra.Trim();
        Console.WriteLine(palavraSemEspaco.Length);
        //Exercicio 5
        Console.WriteLine(PlacaCarro.ValidarPlaca("abc1342"));
        Console.WriteLine(PlacaCarro.ValidarPlaca("abc13423"));
        Console.WriteLine(PlacaCarro.ValidarPlaca("ab12342"));
        Console.WriteLine(PlacaCarro.ValidarPlaca("abc134a"));
        //Exercicio 6
        ExibirData data = new ExibirData();
        Console.WriteLine(ExibirData.ExibirDataAtual());
    }
}
