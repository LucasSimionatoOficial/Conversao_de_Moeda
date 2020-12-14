using System;
using ConversorDeMoeda.classes;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            bool continuar2;
            string valor = "";
            float valor2;
            while(continuar){
                continuar2 = true;
                while (continuar2)
                {
                    Console.WriteLine("Qual valor voce deseja converter?");
                    valor = Console.ReadLine();
                    if (Single.TryParse(valor, out valor2)){
                        continuar2 = false;
                    } else{
                        Console.WriteLine("Digite apenas numeros");
                    }
                }
                valor2 = float.Parse(valor);
                Console.Write("1 - Dolar para Real\n2 - Real para Dolar\n3 - Dolar para Euro\n4 - Euro para Dolar\n5 - Euro para Real\n6 - Real para euro\n");
                switch(Console.ReadLine()){
                    case "1":
                        Console.WriteLine("Convertido o valor e de " + Conversor.DolarParaReal(valor2));
                        break;
                    case "2":
                        Console.WriteLine("Convertido o valor e de " + Conversor.RealParaDolar(valor2));
                        break;
                    case "3":
                        Console.WriteLine("Convertido o valor e de " + Conversor.DolarParaEuro(valor2));
                        break;
                    case "4":
                        Console.WriteLine("Convertido o valor e de " + Conversor.EuroParaDolar(valor2));
                        break;
                    case "5":
                        Console.WriteLine("Convertido o valor e de " + Conversor.DolarParaReal(Conversor.EuroParaDolar(valor2)));
                        break;
                    case "6":
                        Console.WriteLine("Convertido o valor e de " + Conversor.DolarParaEuro(Conversor.RealParaDolar(valor2)));
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
            }
        }
    }
}
