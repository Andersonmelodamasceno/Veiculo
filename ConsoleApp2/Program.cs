using ConsoleApp2.entities;
using ConsoleApp2.Entities;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                
                Telefone telefone = new Telefone(1, "123456789", "11");

              
                Console.WriteLine("Detalhes do Telefone:");
                Console.WriteLine($"ID: {telefone.Id}");
                Console.WriteLine($"Número: {telefone.Numero}");
                Console.WriteLine($"DDD: {telefone.Ddd}");
                Console.WriteLine("");
            }



            Veiculo veiculo = new Veiculo(4, Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());

            Carro carro = new Carro(4, Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 4);

            Moto moto = new Moto(2, Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 1);

          
            Console.WriteLine("Detalhes do Veículo:");
            Console.WriteLine($"Quantidade de Rodas: {veiculo.QTDrodas}");
            Console.WriteLine($"Placa: {veiculo.Placa}");
            Console.WriteLine($"Proprietário ID: {veiculo.ProprietarioId}");
            Console.WriteLine($"Documentação: {veiculo.Documentacao}");
            Console.WriteLine();

            Console.WriteLine("Detalhes do Carro:");
            Console.WriteLine($"Quantidade de Rodas: {carro.QTDrodas}");
            Console.WriteLine($"Placa: {carro.Placa}");
            Console.WriteLine($"Proprietário ID: {carro.ProprietarioId}");
            Console.WriteLine($"Documentação: {carro.Documentacao}");
            Console.WriteLine($"Número de Portas: {carro.NumeroPortas}");
            Console.WriteLine();

            Console.WriteLine("Detalhes da Moto:");
            Console.WriteLine($"Quantidade de Rodas: {moto.QTDrodas}");
            Console.WriteLine($"Placa: {moto.Placa}");
            Console.WriteLine($"Proprietário ID: {moto.ProprietarioId}");
            Console.WriteLine($"Documentação: {moto.Documentacao}");
            Console.WriteLine($"Capacidade: {moto.Capacidade}");
        }
    }
}