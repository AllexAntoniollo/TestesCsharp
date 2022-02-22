using System;
using System.Collections.Generic;
using teste.Entities;
using teste.Entities.Enums;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------DEPARTAMENTO-----------");
            Console.Write("Entre com o nome do Departamento: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-----------TRABALHADOR-----------");
            Console.WriteLine("Entre com os dados do trabalhador:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: R$");
            double salarioBase = double.Parse(Console.ReadLine());

            Department dept = new Department(departamento);
            Worker trabalhador = new Worker(nome, salarioBase, level, dept);
            Console.WriteLine("---------------------------------");
            Console.Write("Quantos contratos para esse trabalhador: ");
            int quantidadeContratos = int.Parse(Console.ReadLine());
            for(int i = 1; i <= quantidadeContratos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Entre com o contrato #{i}:");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: R$");
                int valorPorHora = int.Parse(Console.ReadLine());
                Console.Write("Quantidade de horas: ");
                int horas = int.Parse(Console.ReadLine());
                HourContract contrato = new HourContract(valorPorHora, horas, data);
                trabalhador.AddContract(contrato);

            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.Write("Entre com o mês e ano para calcular Income (MM/YYYY): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));


            Console.Write("Name: ");
            Console.WriteLine(trabalhador.Name);
            Console.Write("Department: ");
            Console.WriteLine(trabalhador.Department.Name);
            Console.Write("Income for " + mesAno +": R$" );

            Console.WriteLine(trabalhador.Income(ano, mes));







        }
    }
}
