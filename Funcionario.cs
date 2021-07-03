using System;

namespace Curso
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario}";
        }
        public void Aumento(double porc)
        {
            Salario = ((Salario * porc) / 100)+Salario;
        }
    }
}
