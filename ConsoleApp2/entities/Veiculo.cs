using System;

namespace ConsoleApp2.Entities
{
    public class Veiculo
    {
        public int QTDrodas { get; set; }
        public Guid Placa { get; set; }
        public Guid ProprietarioId { get; set; }
        public Guid Documentacao { get; set; }

        public Veiculo(int qtdRodas, Guid placa, Guid proprietarioId, Guid documentacao)
        {
            QTDrodas = qtdRodas;
            Placa = placa;
            ProprietarioId = proprietarioId;
            Documentacao = documentacao;
        }
    }
}