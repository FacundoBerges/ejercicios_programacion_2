namespace Ejercicio_03
{
    /**
     * Mostrar por pantalla todos los números primos que haya hasta el número que 
     * ingrese el usuario por consola.
     * 
     * Validar que el dato ingresado por el usuario sea un número.
     * 
     * Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir". 
     * Si ingresa "salir", cerrar la consola.
     * 
     * Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
     * 
     * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
     */
    internal class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";

            string mensaje = "Ingrese un numero, o salir para finalizar el programa: ";
            string? aux;
            int num = 0;

            do
            {
                Console.Write(mensaje);
                aux = Console.ReadLine();

                if(aux.Trim().ToLower() == "salir")
                {
                    break;
                }

                while( ! int.TryParse(aux, out num) || num <= 0)
                {
                    Console.Write("ERROR! Debe ingresar un numero positivo. {0}", mensaje);
                    aux = Console.ReadLine();
                }


                Console.WriteLine("\nLos numeros primos entre 1 y el numero {0} son:", num);
                for (int i = 2; i < num; i++)
                {
                    if ( esPrimo(i) )
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();

            } while (aux.Trim().ToLower() != "salir");

        }

        static bool esPrimo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}