using pilaListaEnlazada;

namespace TestListaPila
{
    [TestClass]
    public class TestListaPila
    {
        [TestMethod]
        public void TestPushAndPeek()
        {
            // Arrange
            ListaConPila stack = new ListaConPila();

            // Act
            stack.Push(10);
            stack.Push(20);

            // Assert
            Assert.AreEqual(20, stack.Peek()); // El tope debe ser 20
        }

        [TestMethod]
        public void TestPop()
        {
            // Arrange
            ListaConPila stack = new ListaConPila();
            stack.Push(10);
            stack.Push(20);

            // Act
            int poppedValue = stack.Pop();

            // Assert
            Assert.AreEqual(20, poppedValue); // El valor desapilado debe ser 20
            Assert.AreEqual(10, stack.Peek()); // El nuevo tope debe ser 10
        }

        [TestMethod]
        public void TestIsEmpty()
        {
            // Arrange
            ListaConPila stack = new ListaConPila();

            // Act & Assert
            Assert.IsTrue(stack.IsEmpty()); // La pila debe estar vacía inicialmente

            stack.Push(10);
            Assert.IsFalse(stack.IsEmpty()); // La pila no debe estar vacía después de apilar

            stack.Pop();
            Assert.IsTrue(stack.IsEmpty()); // La pila debe estar vacía después de desapilar
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPopOnEmptyStack()
        {
            // Arrange
            ListaConPila stack = new ListaConPila();

            // Act
            stack.Pop(); // Esto debería lanzar una excepción

            // Assert
            // La excepción se espera, por lo que la prueba pasa si se lanza
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPeekOnEmptyStack()
        {
            // Arrange
            ListaConPila stack = new ListaConPila();

            // Act
            stack.Peek(); // Esto debería lanzar una excepción

            // Assert
            // La excepción se espera, por lo que la prueba pasa si se lanza
        }

        [TestMethod]
        public void TestDisplay()
        {
            // Arrange
            ListaConPila stack = new ListaConPila();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Act
            using (var consoleOutput = new ConsoleOutput())
            {
                stack.Display();

                // Assert
                Assert.AreEqual("30 -> 20 -> 10", consoleOutput.GetOutput().Trim());
            }
        }
    }

    // Clase auxiliar para capturar la salida de la consola
    public class ConsoleOutput : IDisposable
    {
        private readonly StringWriter _stringWriter;
        private readonly TextWriter _originalOutput;

        public ConsoleOutput()
        {
            _stringWriter = new StringWriter();
            _originalOutput = Console.Out;
            Console.SetOut(_stringWriter);
        }

        public string GetOutput()
        {
            return _stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(_originalOutput);
            _stringWriter.Dispose();
        }
    }
}