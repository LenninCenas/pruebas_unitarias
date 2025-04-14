using NUnit.Framework;
using Calculadora;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        private Calculadora _calculadora;

        [SetUp]
        public void Setup()
        {
            // Inicializar la instancia de la calculadora antes de cada prueba
            _calculadora = new Calculadora();
        }

        [Test]
        public void Sumar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int resultado = _calculadora.Sumar(a, b);

            // Assert
            Assert.AreEqual(8, resultado, "La suma de 5 y 3 debería ser 8.");
        }

        [Test]
        public void Restar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int resultado = _calculadora.Restar(a, b);

            // Assert
            Assert.AreEqual(2, resultado, "La resta de 5 y 3 debería ser 2.");
        }

        [Test]
        public void Multiplicar_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int resultado = _calculadora.Multiplicar(a, b);

            // Assert
            Assert.AreEqual(15, resultado, "La multiplicación de 5 y 3 debería ser 15.");
        }

        [Test]
        public void Dividir_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Act
            int resultado = _calculadora.Dividir(a, b);

            // Assert
            Assert.AreEqual(2, resultado, "La división de 6 y 3 debería ser 2.");
        }

        [Test]
        public void Dividir_EntreCero_LanzaExcepcion()
        {
            // Arrange
            int a = 6;
            int b = 0;

            // Act & Assert
            Assert.Throws<System.DivideByZeroException>(() => _calculadora.Dividir(a, b), "Dividir entre cero debería lanzar una excepción.");
        }
    }
}