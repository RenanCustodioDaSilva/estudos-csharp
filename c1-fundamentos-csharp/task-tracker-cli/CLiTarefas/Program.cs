using System;
using System.Collections.Generic;


namespace TaskTrackerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            List<String> tarefas = new List<String>();
            do
            {
                Console.WriteLine("TASK TRAKER CLI");
                Console.WriteLine("1 - criar nova tarefa");
                Console.WriteLine("2 - listar tarefas");
                Console.WriteLine("0 - sair da operaçao");
                Console.WriteLine("escolha uma opçao: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1;
                }
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n[+] Funcionalide: criar tarefa:");
                        string tarefa = Console.ReadLine();
                        tarefas.Add(tarefa);
                        Console.WriteLine("\n tarefa armazenada com sucesso!");
                        Pausar();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n[*] Funcionalidade: Listar Tarefas");
                        foreach (String item in tarefas)
                        {
                            Console.WriteLine("-" + item);
                        }
                        Pausar();
                        break;

                    case 0:
                        Console.WriteLine("\n[!] Encerrando a aplicação... Até mais!");
                        break;
                    default:
                        Console.WriteLine("\n[x] entrada invalida digite apenas numeros validos no menu");
                        break;

                }
            } while (opcao != 0
            );


                static void Pausar() {
                    Console.WriteLine("\n Presione enter para voltar ao menu");
                    Console.ReadLine();
                }




            }



        }
    }
