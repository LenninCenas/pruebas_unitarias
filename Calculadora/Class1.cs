namespace Calculadora
{
    // Clase básica de calculadora
    public class Calculadora
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
