using System;
using System.Threading;

namespace portalAcademico
{

    public class Program
    {
        public static void MenuAluno()
        {
            Console.WriteLine("---------- MENU ALUNO ----------\n");
            Console.WriteLine("Olá, aluno. \nBem vindo! \n\nO que você quer fazer?");

            Console.Write("[1] Informações Pessoais\n[2] Visualizar Média\n[3] Sair\nR:");
        }

        public static void MenuProfessor()
        {

        }


        public static void Menu()
        {

            int sair = 0;

            while (sair < 1)
            {
                Console.WriteLine("---------- PORTAL ACADÊMICO ----------\n");
                Console.WriteLine("Bem vindo! Por favor nos informe se você é um Aluno ou Professor:");

                Console.Write("[1] Aluno\n[2] Professor\n\nR:");

                int op = int.Parse(Console.ReadLine());

                if (op != 1 && op != 2)
                {
                    Console.WriteLine("\nOpção Inválida.");
                }
                else
                {
                    if (op == 1)
                    {
                        Console.WriteLine("\nLogado como Aluno!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        MenuAluno();
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("\nLogado como Professor!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        MenuProfessor();
                    }
                }
            }
        }

        public static void Main()
        {
            Menu();
        }
    }

}

