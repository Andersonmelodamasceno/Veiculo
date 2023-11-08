namespace ConsoleApp2.Entities
{
    public class Telefone
    {
        public int Id { get; set; } 
        public string Numero { get; set; }
        public string Ddd { get; set; }

        public Telefone(int id, string numero, string ddd)
        {
            Id = id;
            Numero = numero;
            Ddd = ddd;
        }
    }
}