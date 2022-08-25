using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DynamicArray
{
    public interface IArray<T>
    {
        T get(int index);
        void add(T item);
        void add(T item, int index);
        void delete(T itemDefoult, int index);
        int getSize();
        bool isEmpty() { return getSize() == 0; }


    }
}
