namespace Calculadora
{
    // Clase que utiliza la calculadora para operaciones más complejas
    public class OperacionesAvanzadas
    {
        private readonly ICalculadora _calculadora;

        public OperacionesAvanzadas(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        // Calcula el área de un rectángulo usando la calculadora
        public int CalcularAreaRectangulo(int baseRectangulo, int altura)
        {
            return _calculadora.Multiplicar(baseRectangulo, altura);
        }

        // Calcula el perímetro de un rectángulo usando la calculadora
        public int CalcularPerimetroRectangulo(int baseRectangulo, int altura)
        {
            // Perímetro = 2 * (base + altura)
            int suma = _calculadora.Sumar(baseRectangulo, altura);
            return _calculadora.Sumar(suma, suma);
        }

        // Calcula el área de un triángulo usando la calculadora
        public int CalcularAreaTriangulo(int baseTriangulo, int altura)
        {
            int multiplicacion = _calculadora.Multiplicar(baseTriangulo, altura);
            return _calculadora.Dividir(multiplicacion, 2);
        }
    }
}