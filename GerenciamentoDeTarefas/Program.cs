﻿using GerenciamentoDeTarefas.Entidades;
using GerenciamentoDeTarefas.Senha;

namespace GerenciamentoDeTarefas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Gerenciamento de Tarefas!");
            //switch case que seleciona o cargo
            bool sair = false;
            do
            {
                Console.WriteLine("Escolha o tipo de usuário:");
                Console.WriteLine("1. Tech Leader");
                Console.WriteLine("2. Desenvolvedor");
                Console.WriteLine("0. Sair");

                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        TechLeader.AcessarComoTechLeader();
                        break;
                    case 2:
                        Desenvolvedor.AcessarComoDesenvolvedor();
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                        break;
                }

            } while (!sair);
        } 
        }
    }


