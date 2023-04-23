namespace Ejercicio_02
{

    /**
     * 2.	Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
     *      Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
     * 
     * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
     */
    internal class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";

            double number;
            string? aux;

            do
            {
                Console.Write("Ingrese un numero: ");
                aux = Console.ReadLine();

                if( !double.TryParse(aux, out number) || number <= 0 )
                {
                    number = 0;
                    Console.WriteLine("ERROR. ¡Reingresar número!\n");
                }

            } while (number <= 0);

            Console.WriteLine($"{number}**2 = {Math.Pow(number, 2)}");
            Console.WriteLine($"{number}**3 = {Math.Pow(number, 3)}");
        }
    }
}