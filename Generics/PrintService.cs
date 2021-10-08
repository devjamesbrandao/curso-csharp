using System;

namespace Generics
{
    public class PrintService<T>
    {
        private T[] _values = new T[2];

        private int _count = 0;

        public void AddValor(T Valor)
        {
            if (_count == 2) {
                throw new InvalidOperationException("Array cheio!");
            }

            _values[_count] = Valor;
            
            _count++;
            
        }

        public T Primeiro() {
            if (_count == 0) {
                throw new InvalidOperationException("Array vazio!");
            }
            return _values[0];
        }

        public void Imprime() {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++) {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0) {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
        }

    }
