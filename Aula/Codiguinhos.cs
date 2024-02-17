using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public static class Codiguinhos
    {
        [STAThread]
        public static void Ifem()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10) /// || (a == b)) && (a == b)) pode fazer isso tambem
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");
            // é possível utilizar um if sem chaves { } apenas se houver apenas uma instrução dentro dele.
            // Isso é conhecido como "forma de expressão" do if.
            // Se houver mais de uma instrução, as chaves são obrigatórias.
            if (a + b > 1)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }
        }
        public static void Continua()
        {
            int counter = 0;
            while (counter < 10) 
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;        // precisa do cifrão pra usar a variavel
            }
            int counterToo = 0;
            do
            { 
                Console.WriteLine($"The counter is {counterToo}");
                counterToo++;
            }
            while (counterToo < 10);
        }
        public static void ParaComeTeuCU()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Contador {i}");
            // Você pode aninhar um loop dentro do outro para formar pares:

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }
        public static void ParOuImpar()
        {
            int sum = 0;
            for (int number = 1; number < 21; number++)
                if (number % 2 == 0)
                    Console.WriteLine($"Pares {number}");

            for (int number = 1; number < 21; number++)
                if (number % 2 == 1)
                    Console.WriteLine($"Impares {number}");
        }

        public static void Listaralho()
        {
            var names = new List<string> { "Coisa", "Ana", "Felipe" };
            foreach (var name in names)
            {   // pode fazer com letra ($"Hello {name.ToUpper()}!");
                Console.WriteLine(name.ToUpper());
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToLower()}!");
            }
            Console.WriteLine($"Primeiro nome: {names[0]}.");
            Console.WriteLine($"Adcionei {names[2]} e {names[3]} para a lista.");
            Console.WriteLine($"Tem {names.Count} Pessoas");
            var index = names.IndexOf("Felipe");
            if (index != -1)
            {
                Console.WriteLine($"O nome {names[index]} Ta no {index} lugar");
            }
            var notFound = names.IndexOf("Nome sem lista");
            Console.WriteLine($"Quando não encontra aparece {notFound}");
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Diferente {name.ToUpper()}!");
            }
            Console.WriteLine();

            var fibonacciNumbers = new List<int> { 1, 1 };
            // var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; pega o segundo item
            // var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; // e o terceiro
            //
            // fibonacciNumbers.Add(previous + previous2); // soma e adciona na lista
            //
            // foreach (var item in fibonacciNumbers)
            //{
            //   Console.WriteLine(item);
            //}
            //
            // todos os numero de fibonacci

            while (fibonacciNumbers.Count < 20)
            {
                var antes = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var antes2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(antes + antes2);
            }
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }

    }
}
