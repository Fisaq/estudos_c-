using System;

public class Titular
{
    private string cpf;

    public string Nome { get; set; }

    public string CPF
    {
        get { return cpf; }
        set
        {
            if (value.Length != 11)
            {
                Console.WriteLine("\nCPF Inválido");
            }
            else
            {
                cpf = value;
            }
        }
    }

    public Conta Conta { get; set; }

    public void ExibirDadosTitular()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"\nCPF: {CPF}");
    }
}

public class Conta
{
    private int agencia;
    private int numConta;
    private float saldo;
    private float limite;

    public Titular Titular { get; set; }

    public int Agencia
    {
        get { return agencia; }
        set { agencia = value; }
    }
    public int NumeroConta
    {
        get { return numConta; }
        set { numConta = value; }
    }
    public float Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }
    public float Limite
    {
        get { return limite; }
        set { limite = value; }
    }

    public void ExibirInformacoes()
    {

        if (Titular != null)
        {
            Console.WriteLine("---- INFORMAÇÕES DA CONTA -----");

            Titular.ExibirDadosTitular();
            Console.WriteLine($"\nAgência: {Agencia}");
            Console.WriteLine($"\nConta: {NumeroConta}");
            Console.WriteLine($"\n\nSaldo: {Saldo}");
            Console.WriteLine($"\nLimite: {Limite}");
        }
        else
        {
            Console.WriteLine("\nSem dados de conta para exibir.");
        }
    }
}

public class Program
{

    public static void Main()
    {
        Conta conta1 = new Conta();
        Titular titular1 = new Titular();

        titular1.Nome = "João";
        titular1.CPF = "02456677701";
        titular1.Conta = conta1;

        titular1.Conta.Titular = titular1;
        titular1.Conta.Agencia = 023024092;
        titular1.Conta.NumeroConta = 12345;
        titular1.Conta.Saldo = 1000;
        titular1.Conta.Limite = 2000;
        conta1.ExibirInformacoes();
    }

}
