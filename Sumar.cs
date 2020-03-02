using System;
using static System.Console;
namespace Algoritmo1
{
    public class Sumar
    {
        int suma = 0;
        public int SumarDosNumeros(int numero1, int numero2)
        {
            suma = numero1 + numero2;
            return suma;
        }

        public int SumarDiezNumeros()
        {
            int nume = 0;
            for (int n = 1; n <= 10; n++)
            {
                WriteLine("Número: " + n);
                nume = Convert.ToInt32(ReadLine());
                suma = suma + nume;

            }
            WriteLine("Total de la suma: ");
            return suma;
        }
        public int SumarNCantidadNumeros(int Ncantidad)
        {
            int num = 0;
            WriteLine("Digite los números que desea sumar: ");
            for (int x = 1; x <= Ncantidad; x++)
            {
                WriteLine("Número: " + x);
                num = Convert.ToInt32(ReadLine());
                suma = suma + num;
            }
            WriteLine("El resultado de la suma es: ");
            return suma;
        }
    }
}