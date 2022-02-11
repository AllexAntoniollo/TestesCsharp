using System;
using System.Collections.Generic;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Pessoa> lista = new List<Pessoa>();

            Console.Write("Quantos Funcionários vão ser cadastrados? ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < numero; i++)
            {
                int x = i + 1;
                Console.WriteLine("Numero #" + x);
                Console.Write("Id:");
                var id = int.Parse(Console.ReadLine());
                Console.Write("Nome:");
                var nome = Console.ReadLine();
                Console.Write("Salário:");
                var salario = double.Parse(Console.ReadLine());
                lista.Add(new Pessoa(id, nome, salario));
                Console.WriteLine();

            }

            Console.Write("Entre com o Id do funcionário que vai ter modificação salarial: ");
            var y = int.Parse(Console.ReadLine());
            Pessoa pessoaId = lista.Find(x => x.Id == y);
            if(pessoaId != null)
            {
                Console.Write("Qual vai ser a porcentagem do aumento? ");
                var z = double.Parse(Console.ReadLine());
                pessoaId.Aumento(z);

            }
            else
            {
                Console.WriteLine("Esse id não existe.");
            }

          


            
             Console.WriteLine("Lista de Funcionários:");

             foreach(Pessoa obj in lista)
             {
                 Console.WriteLine(obj.ToString());
             }




        }
    }
}
