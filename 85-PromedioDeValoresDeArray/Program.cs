using System;

//Hacer la media de los valores de un array y mostrar el resultado.

namespace _85_PromedioDeValoresDeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 2, 3, 4, 5, 6 };

            int suma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                suma += valores[i];
            }

            double media = (double)suma / valores.Length;

            Console.WriteLine("La media es " + media);
        }
    }
}
