using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DynamicArray
{
    public class SingleArray<T> : IArray<T>
    {
        public T[] array;


        public SingleArray()
        {
            array = new T[0];
        }


        public void add(T item)
        {
            resize();
            array[getSize() - 1] = item;
        }


        private void resize()
        {
            T[] newArray = new T [getSize() + 1];
            if (array.Length!=0)
                array.CopyTo( newArray,0);
            array = newArray;
        }


        public int getSize()
        {
            return array.Length;
        }


        public void add(T item, int index)
        {
            int size = getSize();
            if (index > size + 1)
            {
                // ничего не делаем, т.к. элемента под таким индексом просто нет еще.
                Console.WriteLine($"такого индекса не существует ");
                
            }
            else 
            {
                T[] newArray = new T[size + 1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[index] =item;
                for (int i = index; i < array.Length; i++)
                {
                    newArray[i+1] = array[i];
                }

                array = newArray;
            }


        }

        public void delete(T itemDefoult, int index )
        {
            int size = getSize();
            if (index > size )
            {
                // ничего не делаем, т.к. элемента под таким индексом просто нет еще.
                Console.WriteLine($"такого индекса не существует ");

            }
            else
            {
                for (int i=index; i< size - 1;i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length-1] = itemDefoult;
            }


        }

        public T get(int index)
        {
            return array[index];
        }

    }
}
