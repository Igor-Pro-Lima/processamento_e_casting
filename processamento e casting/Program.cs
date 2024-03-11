using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processamento_e_casting {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y, z;
            double a;
            x = 10;
            y = 20;
            z = 30;
            a = 9 * z;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //Comentário: Multiplicação básica
            Console.WriteLine(z);
            Console.WriteLine(a.ToString("F2", CI));

            //Comentário: Calculando a área de um trapézio 
            Console.WriteLine();
            Console.WriteLine("CALCULANDO A AREA DE UM TRAPEZIO");
            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;
            area = (b1 + b2) / 2.0 * h;
            Console.WriteLine(area.ToString("F2", CI));

            //Comentário: Casting
            Console.WriteLine();
            Console.WriteLine("CASTING");
            int d, e;
            double resultado;

            d = 15;
            e = 4;
            resultado = (double)d / e;
            Console.WriteLine(resultado.ToString("F4", CI));

            //Comeentário: ConvertendoVariáveis 
            Console.WriteLine();
            Console.WriteLine("CONVERTENDO VARIAVEIS");
            double a1;
            int a2;
            a1 = 10.3;
            a2 = (int)a1;
            Console.WriteLine(a2);
        }
    }
}
