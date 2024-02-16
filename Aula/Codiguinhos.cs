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
            // fodase se o if tem chave ou não
            if (a + b > 1)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }
        }

    }
}
