using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DynamicArray
{
    class MatrixArray<T> : IArray<T>
    {
        IArray< T[]> array;



        int vector;
        int size ;

        public MatrixArray()
        {
            array = new SingleArray<T[]>();
            vector = 100;
            size = 0;
        }


        public void add(T item)
        {
            if (size == array.getSize() * vector)
            {
                array.add(new T[vector]);
            }

            array.get(size / vector)[size % vector] = item;
            size++;
        }



        public int getSize()
        {
            return size;
        }

        public void add(T item, int index)
        {

        }

        public void delete(T itemDefoult, int index)
        {

        }


        public T get(int index)
        {
            return array.get(size/vector)[size%vector];
        }
    }
}
