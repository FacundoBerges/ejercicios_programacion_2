namespace Ejercicio_10
{
    internal class Validador
    {
        /// <summary>
        /// Metodo que recibe un valor a validar, y valores minimo y maximo de rango. 
        /// Devuelve true en caso de que se encuentre dentro del rango, y caso contrario, false.
        /// </summary>
        /// <param name="valor">Valor a validar</param>
        /// <param name="min">Rango minimo permitido</param>
        /// <param name="max"></param>
        /// <returns>true si se encuentra dentro del rango min-max, caso contrario false</returns>
        public static bool Validar(int valor, int min, int max)
        {
            return (valor > min) && (valor < max);
        }

        public static bool EsNumeroEntero(string valor)
        {
            return int.TryParse(valor, out _);
        }
    }
}
