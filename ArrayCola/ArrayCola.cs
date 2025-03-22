using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCola
{
    public class ArrayCola
    {
        private int[] elementos;
        private int frente;
        private int final;
        private int capacidad;
        private int tamaño;

        public ArrayCola(int capacidad)
        {
            this.capacidad = capacidad;
            elementos = new int[capacidad];
            frente = 0;
            final = -1;
            tamaño = 0;
        }

        public void Encolar(int valor)
        {
            if (tamaño == capacidad)
            {
                throw new InvalidOperationException("La cola está llena");
            }

            final = (final + 1) % capacidad;
            elementos[final] = valor;
            tamaño++;
        }

        public int Desencolar()
        {
            if (tamaño == 0)
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            int valor = elementos[frente];
            frente = (frente + 1) % capacidad;
            tamaño--;
            return valor;
        }

        public int Frente()
        {
            if (tamaño == 0)
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            return elementos[frente];
        }

        public int Tamaño()
        {
            return tamaño;
        }

        public bool EstaVacia()
        {
            return tamaño == 0;
        }

        public bool EstaLlena()
        {
            return tamaño == capacidad;
        }

        public override string ToString()
        {
            if (tamaño == 0)
            {
                return "[]";
            }

            string resultado = "[";
            for (int i = 0; i < tamaño; i++)
            {
                int indice = (frente + i) % capacidad;
                resultado += elementos[indice];
                if (i < tamaño - 1)
                {
                    resultado += ", ";
                }
            }
            resultado += "]";
            return resultado;
        }
    }
}
    
    
     


