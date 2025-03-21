using Pilas_y_colas;

namespace TestArrayPila
{
    [TestClass]
    public class ArrayStackTests
    {
        [TestMethod]
        public void TestPush()
        {
            var stack = new ArrayStack(3);
            stack.Push(5);
            stack.Push(10);

            Assert.AreEqual(10, stack.Top(), "El último elemento debe ser 10.");
        }

        [TestMethod]
        public void testPop()
        {
            var stack = new ArrayStack(3);
            stack.Push(5);
            stack.Push(10);
            int popped = stack.Pop();

            Assert.AreEqual(10, popped, "El elemento eliminado debe ser 10.");
            Assert.AreEqual(5, stack.Top(), "El nuevo elemento superior debe ser 5.");
        }

        [TestMethod]
        public void testPopError()
        {
            var stack = new ArrayStack(3);
            int popped = stack.Pop();

            Assert.AreEqual(-1, popped, "Debe devolver -1 cuando la pila está vacía.");
        }

        [TestMethod]
        public void testPop_()
        {
            var stack = new ArrayStack(3);
            int top = stack.Top();

            Assert.AreEqual(-1, top, "Debe devolver -1 cuando la pila está vacía.");
        }

        [TestMethod]
        public void testPopError_()
        {
            var stack = new ArrayStack(2);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3); // Intento de agregar un tercer elemento en una pila de tamaño 2

            Assert.AreEqual(2, stack.Top(), "El último elemento debe seguir siendo 2 porque la pila está llena.");
        }
    }
}