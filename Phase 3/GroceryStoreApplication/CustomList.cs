using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        private Type[] _array;

        public Type this[int index]
        {
            get { return  _array[index];}
            set { _array[index] =value ;}
        }
        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }

        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                Growsize();
            }
            _array[_count] = element;
            _count++;
        }
        public void Growsize()
        {
            _capacity *= _capacity;
            Type[] tempArray = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                tempArray[i] = _array[i];
            }
            _array = tempArray;
        }
        public void AddRange(CustomList<Type> elements)   
        {
            _capacity = _count+elements.Count+4;   
            Type[] tempArray = new Type[_capacity];    
            for(int i =0; i<_count; i++)
            {
                tempArray[i] = _array[i];
            }
            for(int j = _count,i=0; j<_count + elements.Count; j++, i++)
            {
                tempArray[j] = elements[i];
            }
            _array = tempArray;
            _count = _count + elements.Count;
        }
    }
}