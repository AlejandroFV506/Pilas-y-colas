using ListaEnlazadaCola;

class Program
{
    static void Main()
    {
        ListaCola cola = new ListaCola();

        cola.Encolar(6);
        cola.Encolar(3);
        cola.Encolar(9);

        Console.WriteLine(cola.ToString()); // Output: [6, 3, 9]

        Console.WriteLine("Desencolar: " + cola.Desencolar()); // Output: Desencolar: 6

        Console.WriteLine(cola.ToString()); // Output: [3, 9]

        cola.Encolar(8);
        cola.Encolar(1);

        Console.WriteLine(cola.ToString()); // Output: [3, 9, 8, 1]

        Console.WriteLine("Frente: " + cola.Frente()); // Output: Frente: 3

        Console.WriteLine("Tamaño: " + cola.Tamaño()); // Output: Tamaño: 4

        Console.WriteLine("¿Está vacía?: " + cola.EstaVacia()); // Output: ¿Está vacía?: False
    }
}