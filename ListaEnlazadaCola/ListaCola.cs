using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaCola
{
    public class ListaCola
    {
        private Nodo frente;
        private Nodo final;
        private int tamaño;

        public ListaCola()
        {
            frente = null;
            final = null;
            tamaño = 0;
        }

        public void Encolar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (final == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }
            tamaño++;
        }

        public int Desencolar()
        {
            if (frente == null)
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            int valor = frente.Valor;
            frente = frente.Siguiente;
            if (frente == null)
            {
                final = null;
            }
            tamaño--;
            return valor;
        }

        public int Frente()
        {
            if (frente == null)
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            return frente.Valor;
        }

        public int Tamaño()
        {
            return tamaño;
        }

        public bool EstaVacia()
        {
            return tamaño == 0;
        }

        public override string ToString()
        {
            if (frente == null)
            {
                return "[]";
            }

            string resultado = "[";
            Nodo temp = frente;
            while (temp != null)
            {
                resultado += temp.Valor;
                if (temp.Siguiente != null)
                {
                    resultado += ", ";
                }
                temp = temp.Siguiente;
            }
            resultado += "]";
            return resultado;
        }
    }
}
