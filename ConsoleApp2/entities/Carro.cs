using ConsoleApp2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{ public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }
        public int Capacidade { get; set; }
        public Carro(int qtdRodas, Guid placa, Guid proprietarioId, Guid documentacao, int numeroPortas)
            : base(qtdRodas, placa, proprietarioId, documentacao)
        {
            NumeroPortas = numeroPortas;
            Capacidade = 5;
        }
    } 
}
