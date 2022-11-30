using System;
using System.Globalization;
using System.Collections.Generic;


namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registred?  ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> list = new List<Pessoa>(); 

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Pessoa(id, nome, salario));
                Console.WriteLine();

            }

            Console.WriteLine("Digite o id do funcionario que teve acrescimo de salario: ");
            int searchId = int.Parse(Console.ReadLine());

            Pessoa emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.WriteLine("Digite a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Esse id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada: ");

            foreach (Pessoa obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Atualizacao de teste");
        }
    }
}
