using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore
{
    /// <summary>
    /// CustomList<Type> classs is used to create new custom list for the given type.
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public partial class CustomList<Type>
    {
        /// <summary>
        /// It is a private fiels to count the number of elemets in list.
        /// </summary>
        private int _count;
        /// <summary>
        /// It creates a capacity for list.
        /// </summary>
        private int _capacity;
        /// <summary>
        /// It stores the given data in the form of array.
        /// </summary>       
         private Type[] _array;
         

        public Type this[int index]
        {
            get { return  _array[index];}
            set { _array[index] =value ;}
        }
        /// <summary>
        /// Count property is used to return private field _count.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int Count { get { return _count; } }
        /// <summary>
        /// Capacity property is used to return private field _capacity.
        /// </summary>
        /// <value></value>
        public int Capacity { get { return _capacity; } }
        /// <summary>
        /// It creats a list with a capacity of 4.
        /// </summary>
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// It creats a list of given type with its given size.
        /// </summary>
        /// <param name="size"></param> <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// This method performs adding a new element to the list.
        /// </summary>
        /// <param name="element"></param> <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>

        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                Growsize();
            }
            _array[_count] = element;
            _count++;
        }
        /// <summary>
        /// This method increase the capacity of list if count and capacity are equal.
        /// </summary> <summary>
        /// 
        /// </summary>

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