using System;
using System.Collections.Generic;

namespace LocadoraVeiculo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();


            try
            {
                MostrarMenu(veiculos);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
                Console.WriteLine("\nAperte 'Enter' Para Tentar Novamente.");
                Console.ReadLine();
                Console.Clear();
                MostrarMenu(veiculos);
            }
        }

        private static void MostrarMenu(List<Veiculo> veiculos)
        {
            int opcao;

            do
            {
                Console.WriteLine("""
                -------------------MENU-------------------
                Escolha uma opção:

                1- Adicionar Novo Veiculo.
                2- Visualizar Todas os Veiculos.
                3- Procurar um Veiculo.
                4- Alugar Veículo.
                5- Devolver Veículo.
                6- Sair.

                """);

                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("------------------------------------------\n");

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(veiculos);
                        break;
                    case 2:
                        VisualizarTodosVeiculos(veiculos);
                        break;
                    case 3:
                        ProcurarVeiculo(veiculos);
                        break;
                    case 4:
                        AlugarVeiculo(veiculos);
                        break;
                    case 5:
                        DevolverVeiculo(veiculos);
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nAperte 'Enter' Para Tentar Novamente.");
                Console.ReadLine();
                Console.Clear();

            } while (opcao != 6);
        }

        private static void AdicionarVeiculo(List<Veiculo> veiculos)
        {
            Console.WriteLine("Digite as Informações do Veículo: ");
            Console.Write("Placa:");
            string placa = Console.ReadLine();

            if (veiculos.Find(v => v.Placa == placa) != null)
            {
                Console.WriteLine("Veículo já Registrado, Tente Novamente.");
                return;
            }

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Valor de Aluguel Diário: ");
            double aluguelDiario = double.Parse(Console.ReadLine());
            Console.Write("Tipo do Veículo(1- Moto, 2- Carro, 3- Caminhão): ");
            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Veiculo veiculo = new Moto(placa, modelo, marca, ano, aluguelDiario);
                veiculos.Add(veiculo);
            }
            else if (tipo == 2)
            {
                Veiculo veiculo = new Carro(placa, modelo, marca, ano, aluguelDiario);
                veiculos.Add(veiculo);
            }
            else if (tipo == 3)
            {
                Veiculo veiculo = new Caminhao(placa, modelo, marca, ano, aluguelDiario);
                veiculos.Add(veiculo);
            }
            else
            {
                throw new Exception("Valor Inválido, Tente Novamente");
            }

            Console.WriteLine("\nVeículo Adicionado com Sucesso");
        }


        private static void VisualizarTodosVeiculos(List<Veiculo> veiculos)
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum Veículo Cadastrado.");
                return;
            }

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.printar();
                Console.WriteLine();
            }
        }

        private static void ProcurarVeiculo(List<Veiculo> veiculos)
        {
            Console.Write("Digite a Placa do Veículo: ");
            string placa = Console.ReadLine();
            Veiculo veiculo = veiculos.Find(v => v.Placa == placa);
            if (veiculo != null)
            {
                veiculo.printar();
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        private static void AlugarVeiculo(List<Veiculo> veiculos)
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há Véiculos para serem alugados.");
                return;
            }

            VisualizarTodosVeiculos(veiculos);

            Console.Write("Digite a Placa do Veículo que Você Deseja Alugar: ");
            string placa = Console.ReadLine();
            Veiculo veiculo = veiculos.Find(v => v.Placa == placa);
            if (veiculo != null && veiculo.Alugado != true)
            {
                Console.Write("Quantos Dias Você Deseja Alugar? : ");
                int dias = int.Parse(Console.ReadLine());
                veiculo.Alugado = true;
                veiculo.Dias = dias;
                veiculo.printar();
                Console.WriteLine("Veículo Alugado com Sucesso.");
            }
            else
            {
                Console.WriteLine("Veículo não Cadastrado ou Já Alugado");
                return;
            }
        }

        private static void DevolverVeiculo(List<Veiculo> veiculos)
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há Veículos para Serem Alugados.");
                return;
            }

            VisualizarTodosVeiculos(veiculos);

            Console.Write("Digite a Placa do Veículo que Você Deseja Devolver: ");
            string placa = Console.ReadLine();
            Veiculo veiculo = veiculos.Find(v => v.Placa == placa);
            if (veiculo != null && veiculo.Alugado != false)
            {
                veiculo.Alugado = false;
                veiculo.Dias = 0;
                veiculo.printar();
                Console.WriteLine("Veículo Devolvido com Sucesso.");
            }
            else
            {
                Console.WriteLine("\nVeículo não Cadastrado ou já não estava Alugado.");
                return;
            }
        }
    }
}