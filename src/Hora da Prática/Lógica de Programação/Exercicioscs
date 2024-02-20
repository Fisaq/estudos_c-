using System;
using System.Collections.Generic;

class Program
{

    public static void Exercicio1()
    {

        int notaMedia;

        Console.WriteLine("Informe o valor da sua nota:\nR: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out notaMedia))
        {
            if (notaMedia <= 5)
            {
                Console.WriteLine("\nNota insuficiente para aprovação.");
            }
            else
            {
                Console.WriteLine("\nNota suficiente para aprovação.");
            }
        }
    }

    public static void Exercicio2()
    {
        List<string> linguagens = new List<string>();

        linguagens.Add("JavaScript");
        linguagens.Add("Java");
        linguagens.Add("C#");

        foreach (string ling in linguagens)
        {
            if (ling == "C#")
            {
                Console.WriteLine(ling);
                break;
            }
        }

    }

    public static void Exercicio3(int n)
    {
        int soma = 0;
        List<int> numeros = new List<int>();

        for (int i = 0; i <= n; i++)
        {
            soma += 10;
            numeros.Add(soma);
        }

        Console.WriteLine("----- Lista ----- ");

        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"Posição {n} da lista: {numeros[n - 1]}");
    }

    public static void Exercicio4(float a, float b)
    {
        float soma = a + b;
        float sub = a - b;
        float mult = a * b;
        float div = a / b;

        Console.WriteLine($"\nSoma: {soma}");
        Console.WriteLine($"Subtração: {sub}");
        Console.WriteLine($"Multiplicação: {mult}");
        Console.WriteLine($"Divisão: {div}");
    }

    public static void Exercicio5()
    {
        Dictionary<string, List<int>> notasPorAluno = new Dictionary<string, List<int>>();

        notasPorAluno.Add("Isaque", new List<int> { 10, 8, 5 });
        notasPorAluno.Add("Ludmila", new List<int> { 10, 9, 8 });
        notasPorAluno.Add("Vinicius", new List<int> { 10, 10, 9 });

        Console.WriteLine("------ MÉDIA ALUNOS -------\n");
        foreach (var aluno in notasPorAluno)
        {
            int soma = 0;
            List<int> notas = aluno.Value;

            foreach (int nota in notas)
            {
                soma += nota;
            }
            float media = (float)soma / notas.Count;
            Console.WriteLine($"{aluno.Key} - {media:F1}");
        }
    }


    public static void Main(string[] args)
    {
        int sair = 0;

        do
        {
            Console.WriteLine("\n----- MENU -----\n");
            Console.WriteLine("[1] Ex 01\n[2] Ex 02\n[3] Ex 03\n[4] Ex 04\n[5] Ex 05\n\n[9] Sair\n");
            Console.Write("R: ");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:

                    Console.WriteLine("\nFavor informe uma posição N: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int n))
                    {
                        Exercicio3(n);
                    }
                    break;
                case 4:

                    Console.Write("\nInforme o valor de A: ");
                    string input1 = Console.ReadLine();

                    Console.Write("\nInforme o valor de B: ");
                    string input2 = Console.ReadLine();

                    if ((float.TryParse(input1, out float a)) && (float.TryParse(input2, out float b)))
                    {
                        Exercicio4(a, b);
                    }

                    break;
                case 5:

                    Exercicio5();
                    break;
                case 9:
                    Console.WriteLine("\nFim do Programa!");
                    sair += 1;
                    break;
                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        } while (sair < 1);

    }
}
