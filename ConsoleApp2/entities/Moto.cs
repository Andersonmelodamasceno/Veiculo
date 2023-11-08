using ConsoleApp2.Entities;

namespace ConsoleApp2.entities
{
    public class Moto : Veiculo
    {
        public int Capacidade { get; set; }

        public Moto(int qtdRodas, Guid placa, Guid proprietarioId, Guid documentacao, int capacidade)
            : base(qtdRodas, placa, proprietarioId, documentacao)
        {
            Capacidade = 2;
        }
    }
}

