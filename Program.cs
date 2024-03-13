using System;

namespace InvertendoCaracteres
{
    class Program
    {
            static void Main()
            {
                Console.WriteLine("Digite uma frase: ");
                string frase = Console.ReadLine();
                string resultado = InverterString(frase);
                Console.WriteLine("String invertida: " + resultado);
                Console.ReadLine();
            }
            static string InverterString(string inputString)
            {
            char[] caracteres = inputString.ToCharArray();
            int inicial = 0;
            int final = caracteres.Length - 1;

            while (inicial < final)
            {
                (caracteres[inicial], caracteres[final]) = (caracteres[final], caracteres[inicial]);
                inicial++;
                final--;
            }
            string resultado = new string(caracteres);
            return resultado;
            }
    }
 }
