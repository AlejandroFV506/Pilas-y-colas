using ArrayCola;

class Program
{
    static void Main()
    {
        var cola = new ArrayCola.ArrayCola(5);

        cola.Encolar(1);
        cola.Encolar(2);
        cola.Encolar(3);

        Console.WriteLine(cola.ToString()); // Output: [1, 2, 3]

        Console.WriteLine("Desencolar: " + cola.Desencolar()); // Output: Desencolar: 1

        Console.WriteLine(cola.ToString()); // Output: [2, 3]

        cola.Encolar(4);
        cola.Encolar(5);

        Console.WriteLine(cola.ToString()); // Output: [2, 3, 4, 5]

        Console.WriteLine("Frente: " + cola.Frente()); // Output: Frente: 2

        Console.WriteLine("Tamaño: " + cola.Tamaño()); // Output: Tamaño: 4

        Console.WriteLine("¿Está vacía?: " + cola.EstaVacia()); // Output: ¿Está vacía?: False
        Console.WriteLine("¿Está llena?: " + cola.EstaLlena()); // Output: ¿Está llena?: False
    }
}