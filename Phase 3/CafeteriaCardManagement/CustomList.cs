using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListDS
{
    public partial class CustomList<Type>  //Generic class
    {
        private int _count ;
        private int _capacity;

        public int Count { get{return _count;}}
        public int Capacity { get{return _capacity;}  }
        public Type this[int index]    //Creating a indexer for the new list for getting array elements 
        {
            get{return _array[index];}
            set{_array[index] = value;}
        }

        private Type[] _array;   //We can specify the datatype of the list while creating list (If we use int datatype, Type will be replaced with int)

        public CustomList()
        {
            _count=0;     //while initialising count will be set to 0.
            _capacity=4;  // default value of capacity is 4.
            _array = new Type[_capacity];   //creating array with a size of 4.
        }
        public CustomList(int size)   //parameterized constructor for CustomList
        {
            _count =0; 
            _capacity = size;
            _array = new Type[_capacity];  //creating the array with the given size which is passed through the parameter size
        }

        public void Add(Type element)    //Add method for adding the element to the list.
        {
            if(_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;   //assigning the element to its position
            _count++;  //incrementing the count for the next element to assign itss respective index.
        }
        void GrowSize()
        {
            _capacity *= _capacity;
            Type[] temp = new Type[_capacity];
            for(int i =0; i<_count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        public void AddRange(CustomList<Type> elements)    //Adding new elements from differnet list to the CustomList using AddRange method.
        {
            _capacity = _count+elements.Count+4;   //capacity of the CustomList is elongated else it will throw index out of range.
            Type[] temp = new Type[_capacity];    //creating temp array of size elongated capacity
            for(int i =0; i<_count; i++)
            {
                temp[i] = _array[i];
            }
            for(int j = _count,i=0; j<_count + elements.Count; j++, i++)
            {
                temp[j] = elements[i];
                
            }
            _array = temp;
            _count = _count + elements.Count;
        }
    }
}