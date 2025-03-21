using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilaListaEnlazada
{

    public interface IStack
    {
        void Push(int element); 
        int Pop();              
        int Peek();             
        bool IsEmpty();         
    }


    public class ListaConPila : IStack
    {
        private Node top;

        public ListaConPila()
        {
            top = null;
        }

        public void Push(int element)
        {
            Node newNode = new Node(element);
            newNode.Next = top;
            top = newNode;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La pila está vacía");
            }
            int value = top.Value; // Guardar el valor del tope
            top = top.Next;        // Mover el tope al siguiente nodo
            return value;
        }

        // Devuelve el elemento del tope sin eliminarlo
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La pila está vacía");
            }
            return top.Value;
        }

        // Verifica si la pila está vacía
        public bool IsEmpty()
        {
            return top == null;
        }

        // Muestra los elementos de la pila
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Pila vacía");
                return;
            }
            Node current = top;
            while (current != null)
            {
                Console.Write(current.Value);
                if (current.Next != null)
                {
                    Console.Write(" -> ");
                }
                current = current.Next;
            }
            Console.WriteLine(); // Salto de línea al final
        }
    }
}
