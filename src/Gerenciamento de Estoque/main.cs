using System;
using System.Collections.Generic;

class Program
{
    public static Dictionary<string, int> produtos = new Dictionary<string, int>();

    public static void ArmazenarProduto()
    {
        Console.WriteLine("\nInforme o produto que deseja cadastrar: ");
        Console.Write("R: ");
        string nomeProduto = Console.ReadLine();

        Console.WriteLine("\nInforme a quantidade de itens deste produto: ");
        Console.Write("R: ");
        int quantidade = int.Parse(Console.ReadLine());

        produtos[nomeProduto] = quantidade;
    }

    public static void ExibirProduto()
    {
        Console.WriteLine("\nPRODUTO - QUANTIDADE\n");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.Key} - {produto.Value}");
        }
    }

    public static void BuscarProduto(string nomeProduto)
    {
        if (produtos.ContainsKey(nomeProduto))
        {
            Console.WriteLine("\nPRODUTO - QUANTIDADE\n");
            int quantidade = produtos[nomeProduto];
            Console.WriteLine($"{nomeProduto} - {quantidade}");
        }
        else
        {
            Console.WriteLine("\nProduto não encontrado (verifique a escrita correta ou se já cadastrou este produto).");
        }
    }

    public static void Main()
    {
        int sair = 0;

        while (sair < 1)
        {
            Console.WriteLine("\n------ MENU -----\n");
            Console.WriteLine("[1] Cadastrar Produto\n[2] Listar Produtos\n[3] Procurar produto\n\n[9] Sair\n");
            Console.Write("R: ");
            string input = Console.ReadLine();

            int op;

            {
                if (int.TryParse(input, out op))
                {
                    switch (op)
                    {
                        case 1:
                            ArmazenarProduto();
                            break;
                        case 2:
                            ExibirProduto();
                            break;
                        case 3:
                            Console.WriteLine("Informe o nome do produto: ");
                            Console.WriteLine("R: ");
                            string nomeProduto = Console.ReadLine();
                      
                            BuscarProduto(nomeProduto);
                            break;
                        case 9:
                            Console.WriteLine("Fim do programa!");
                            sair += 1;
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Erro na entrada de dados.");
                }
            }
        }
    }
}
