using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_y_colas
{

    public class ArrayStack
    {
        private int[] stack;
        private int top;
        private int size;

        public ArrayStack(int size)
        {
            this.size = size;
            stack = new int[size];
            top = -1;
        }

        public void Push(int element)
        {
            if (top == size - 1)
            {
                Console.WriteLine("Stack Lleno");
            }
            else
            {
                stack[++top] = element;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack vacio");
                return -1;
            }
            else
            {
                return stack[top--];
            }
        }

        public int Top() 
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Vacio");
                return -1;
            }
            else
            {
                return stack[top];
            }
        }

    }
}
