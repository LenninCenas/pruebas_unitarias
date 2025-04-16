using NUnit.Framework;
using Moq;
using Calculadora;

namespace Calculadora.Tests
{
    public class CalculadoraIntegrationTests
    {
        private Mock<ICalculadora> _calculadoraMock;
        private OperacionesAvanzadas _operacionesAvanzadas;

        [SetUp]
        public void Setup()
        {
            // Crear un mock de la calculadora
            _calculadoraMock = new Mock<ICalculadora>();
            
            // Configuramos el mock para que use la implementación de la operación Sumar
            _calculadoraMock.Setup(calc => calc.Sumar(It.IsAny<int>(), It.IsAny<int>()))
                .Returns<int, int>((a, b) => a + b);
            
            // Configuramos el mock para que use la implementación de la operación Multiplicar
            _calculadoraMock.Setup(calc => calc.Multiplicar(It.IsAny<int>(), It.IsAny<int>()))
                .Returns<int, int>((a, b) => a * b);
            
            // Configuramos el mock para que use la implementación de la operación Dividir
            _calculadoraMock.Setup(calc => calc.Dividir(It.IsAny<int>(), It.IsAny<int>()))
                .Returns<int, int>((a, b) => a / b);
            
            // Inicializamos la clase de operaciones avanzadas con el mock de la calculadora
            _operacionesAvanzadas = new OperacionesAvanzadas(_calculadoraMock.Object);
        }

        [Test]
        public void CalcularAreaRectangulo_DadoBaseYAltura_RetornaAreaCorrecta()
        {
            // Arrange
            int baseRect = 5;
            int altura = 3;

            // Act
            int resultado = _operacionesAvanzadas.CalcularAreaRectangulo(baseRect, altura);

            // Assert
            Assert.AreEqual(15, resultado, "El área del rectángulo de base 5 y altura 3 debería ser 15.");
            
            // Verificar que se llamó al método Multiplicar de la calculadora
            _calculadoraMock.Verify(calc => calc.Multiplicar(baseRect, altura), Times.Once);
        }

        [Test]
        public void CalcularPerimetroRectangulo_DadoBaseYAltura_RetornaPerimetroCorrecta()
        {
            // Arrange
            int baseRect = 5;
            int altura = 3;

            // Act
            int resultado = _operacionesAvanzadas.CalcularPerimetroRectangulo(baseRect, altura);

            // Assert
            Assert.AreEqual(16, resultado, "El perímetro del rectángulo de base 5 y altura 3 debería ser 16.");
            
            // Verificar que se llamó al método Sumar de la calculadora (se llama 2 veces en este método)
            _calculadoraMock.Verify(calc => calc.Sumar(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(2));
        }
        
        [Test]
        public void CalcularAreaTriangulo_DadoBaseYAltura_RetornaAreaCorrecta()
        {
            // Arrange
            int baseTriangulo = 6;
            int altura = 4;

            // Act
            int resultado = _operacionesAvanzadas.CalcularAreaTriangulo(baseTriangulo, altura);

            // Assert
            Assert.AreEqual(12, resultado, "El área del triángulo de base 6 y altura 4 debería ser 12.");
            
            // Verificar que se llamó al método Multiplicar de la calculadora
            _calculadoraMock.Verify(calc => calc.Multiplicar(baseTriangulo, altura), Times.Once);
            
            // Verificar que se llamó al método Dividir de la calculadora
            _calculadoraMock.Verify(calc => calc.Dividir(24, 2), Times.Once);
        }
    }
}