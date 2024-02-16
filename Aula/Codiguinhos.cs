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

    }
}
