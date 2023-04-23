
namespace Ejercicio_10
{
    internal class Program
    {
        /**
         * Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
         *      bool Validar(int valor, int min, int max)
         *          valor: dato a validar.
         *          min: mínimo valor incluido.
         *          max: máximo valor incluido.
         * 
         * Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
         * Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
         * 
         * Nota: Utilizar variables escalares, NO utilizar vectores/arrays.
         */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_10";
            const int CANTIDAD = 10;
            const int MINIMO = -100;
            const int MAXIMO = 100;
            string? aux;
            int numero;
            int min = 0;
            int max = 0;
            int total = 0;
            double promedio;

            for(int i = 1; i <= CANTIDAD; i++)
            {
                Console.Write("Ingrese el numero {0}: ", i);
                aux = Console.ReadLine();

                while ( ! int.TryParse(aux, out numero) || ! Validador.Validar(numero, MINIMO, MAXIMO) )
                {
                    Console.Write("Error. Debe ingresar un numero entre {0} y {1}. Reingrese el numero {2}: ", MINIMO, MAXIMO, i);
                    aux = Console.ReadLine();
                }

                total += numero;

                if(i == 0)
                {
                    min = numero;
                    max = numero;
                }
                
                if(numero > max)
                {
                    max = numero;
                }

                if(numero < min)
                {
                    min = numero;
                }
            }

            promedio = (double) total / CANTIDAD;

            Console.WriteLine($"\nValor minimo ingresado: {min}");
            Console.WriteLine($"Valor maximo ingresado: {max}");
            Console.WriteLine("Valor total: {0} (promedio {1:N2})", total, promedio);

        }
    }
}