using System;
using Algoritmo1;
using static System.Console;

namespace ListaEnlaza
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumar misSumas = new Sumar();
            int numero = 0;

            while (numero != 4)
            {
                WriteLine("INDIQUE CUÁL ES EL TIPO DE SUMA QUE DESEA REALIZAR: ");
                WriteLine(System.Environment.NewLine);
                WriteLine("SUMAR: ");
                WriteLine("1. Dos números");
                WriteLine("2. Diez números");
                WriteLine("3. La cantidad de número que sea de su preferencia");
                WriteLine("4. Salir");
                WriteLine(System.Environment.NewLine);

                numero = Convert.ToInt32(ReadLine());
                switch (numero)
                {
                    case 1:
                        WriteLine("Digite dos números");
                        WriteLine("Número 1: ");
                        int numero1 = Convert.ToInt32(ReadLine());
                        WriteLine("Número 2: ");
                        int numero2 = Convert.ToInt32(ReadLine());
                        WriteLine("A continuación el resultado de la suma: ");
                        int totalSuma = misSumas.SumarDosNumeros(numero1, numero2);
                        WriteLine(totalSuma);

                        WriteLine(System.Environment.NewLine);
                        break;
                    case 2:
                        WriteLine("Digite 10 números: ");
                        int resultadoSuma = misSumas.SumarDiezNumeros();
                        WriteLine(resultadoSuma);

                        WriteLine(System.Environment.NewLine);
                        break;
                    case 3:
                        WriteLine("Ingrese la cantidad de números que desea sumar: ");
                        int Ncantidad = Convert.ToInt32(ReadLine());
                        int resultadoDeLaSuma = misSumas.SumarNCantidadNumeros(Ncantidad);
                        WriteLine(resultadoDeLaSuma);

                        WriteLine(System.Environment.NewLine);
                        break;
                    case 4:
                        ReadKey();
                        break;
                }
            }
        }
    }
}