using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List <Funcionario>();
            Console.WriteLine("Quantos funcionários irão ser coisados?");
            int aux = int.Parse(Console.ReadLine());
            for (int i = 0; i< aux; i++)
            {
                Console.WriteLine("id");
                int lul = int.Parse(Console.ReadLine());
                Console.WriteLine("nome");
                string nome = Console.ReadLine();
                Console.WriteLine("salario");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(lul, nome, salario));
            }
            Console.WriteLine("passa o id do aumento");
            int id = int.Parse(Console.ReadLine());
            Funcionario a = list.Find(x => x.Id == id);
            Console.WriteLine("passa o aumento");
            double aum = double.Parse(Console.ReadLine());
            a.Aumento(aum);
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

            
        }
    }
}
