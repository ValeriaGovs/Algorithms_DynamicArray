using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DynamicArray
{
    class FactorArray<T> : IArray<T>
    {


        public T[] array;
        int factor;
        int size = 0;

        public FactorArray()
        {
            factor = 2;
            array = new T[10];
        }


        public void add(T item)
        {
            if (size == array.Length)
                resize();

            array[getSize()] = item;
            size++;
        }


        private void resize()
        {
            T[] newArray = new T[getSize() * factor+1];
            if (array.Length != 0)
                array.CopyTo(newArray, 0);
            array = newArray;
        }


        public int getSize()
        {
            return size;
        }


        public void add(T item, int index)
        {
            if (index > size + 1)
            {
                // ничего не делаем, т.к. элемента под таким индексом просто нет еще.
                Console.WriteLine($"такого индекса не существует ");
            }
            else
            {
                if (size == array.Length - 1)
                {
                    T[] newArray = new T[size * factor + 1];
                    for (int i = 0; i < index; i++)
                    {
                        newArray[i] = array[i];
                    }
                    newArray[index] = item;
                    size++;
                    for (int i = index; i < array.Length; i++)
                    {
                        newArray[i + 1] = array[i];
                    }
                    array = newArray;
                }
                else
                {
                    for (int i = size - 1; i >= index; i--)
                    {
                        array[i + 1] = array[i];
                    }
                    array[index] = item;
                    size++;
                }
            }
        }

        public void delete(T itemDefoult, int index)
        {
            if (index > size)
            {
                // ничего не делаем, т.к. элемента под таким индексом просто нет еще.
                Console.WriteLine($"такого индекса не существует ");

            }
            else
            {

                for (int i = index; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[size - 1] = itemDefoult;
                size--;
            }
        }



        public T get(int index)
        {
            return array[index];
        }
    }   
}
