using Pilas_y_colas;

class program
{
    static void Main()
    {
        ArrayStack stack = new ArrayStack(3);

        stack.Push(5);
        stack.Push(35);
        stack.Push(15);
        stack.Push(40); //El stack va a estar lleno

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Top());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}