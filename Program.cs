using System;

namespace TextEditor
    {
        class Program 
            {
                static void Main(string [] args)
                    {
                        Menu();
                    }
                
                static void Menu()
                    {

                    Console.Clear();
                    Console.WriteLine("Qual opção você deseja?");
                    Console.WriteLine("");
                    Console.WriteLine("1 - Abrir um arquivo");
                    Console.WriteLine("2 - Criar um novo arquivo");
                    Console.WriteLine("0 - Sair do programa");

                    short opcao = short.Parse(Console.ReadLine());

                    switch (opcao) {
                        case 0: System.Environment.Exit(0); break;
                        case 1: Abrir(); break;
                        case 2: Criar(); break;
                        default: Menu(); break;
                    }

                static void Abrir()
                    {
                        
                    }

                static void Criar()
                    {
                        
                    }

                    }
        }
    }