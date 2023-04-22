namespace Ejercicio_01
{
    /**
     * 1.	Ingresar 5 números por consola, guardándolos en una variable escalar. 
     * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
     * 
     * */
    internal class Ejercicio_01
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int max = 0;
            int min = 0;
            int total = 0;
            double average;
            string aux;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write($"Ingrese el numero {i+1}: ");
                    aux = Console.ReadLine();
                } while ( ! int.TryParse(aux, out numeroIngresado) );

                total += numeroIngresado;

                if (i == 0)
                {
                    max = numeroIngresado;
                    min = numeroIngresado;
                }

                if (numeroIngresado > max)
                {
                    max = numeroIngresado;
                }

                if (numeroIngresado < min)
                {
                    min = numeroIngresado;
                }
            }
            Console.WriteLine();

            average = (double) total / 5;

            Console.WriteLine("Maximo numero ingresado: {0}", max);
            Console.WriteLine("Minimo numero ingresado: {0}", min);
            Console.WriteLine("Total de los numeros ingresados: {0}", total);
            Console.WriteLine("Promedio de los numeros ingresados: {0:N2}", average);

            /*
             * Console.WriteLine($"Maximo numero ingresado: {max}");
             * Console.WriteLine($"Minimo numero ingresado: {min}");
             * Console.WriteLine($"Total de los numeros ingresados: {total}");
             * Console.WriteLine($"Promedio de los numeros ingresados: {average}");
             * 
             * 
             */
        }
    }
}