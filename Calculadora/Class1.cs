namespace Calculadora
{
    // Interfaz para la calculadora
    public interface ICalculadora
    {
        int Sumar(int a, int b);
        int Restar(int a, int b);
        int Multiplicar(int a, int b);
        int Dividir(int a, int b);
    }

    // Clase básica de calculadora
    public class Calculadora : ICalculadora
    {
        // Método para sumar dos números
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        // Método para restar dos números
        public int Restar(int a, int b)
        {
            return a - b;
        }

        // Método para multiplicar dos números
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método para dividir dos números
        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException("No se puede dividir entre cero.");
            }
            return a / b;
        }
    }
}
