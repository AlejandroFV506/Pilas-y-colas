using pilaListaEnlazada;

class Program
{
    static void Main(string[] args)
    {
        ListaConPila stack = new ListaConPila();

        // Apilar elementos
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // Mostrar la pila
        Console.WriteLine("Pila después de apilar 10, 20, 30:");
        stack.Display();

        // Desapilar un elemento
        Console.WriteLine("Desapilando: " + stack.Pop());
        Console.WriteLine("Pila después de desapilar:");
        stack.Display();

        // Ver el tope de la pila
        Console.WriteLine("Tope de la pila: " + stack.Peek());
    }
}
