
namespace teste
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Pessoa(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double aumento)
        {
            Salario = Salario * (100 + aumento) / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }
    }
}
