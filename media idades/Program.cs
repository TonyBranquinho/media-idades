using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_idades {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade, individuos;
            double media, soma;

            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR.");
            }
            else {
                individuos = 0;
                soma = 0;

                while (idade >= 0) {
                    soma = soma + idade;
                    individuos = individuos + 1;
                    idade = int.Parse(Console.ReadLine());
                }
            
                media = soma / individuos;
                Console.WriteLine("Media = " + media.ToString("F2", CI));
            
            }
        }
    }
}
