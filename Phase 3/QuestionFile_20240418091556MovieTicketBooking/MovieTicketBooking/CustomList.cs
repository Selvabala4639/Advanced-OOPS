using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public partial class CustomList<Type>

    {
        private static int _count;
        private static int _capacity;
        private static Type[] _array;

        public int Count { get; set; }
        public int Capacity { get; set; }

        public Type this[int index]
        {
            get { return _array[index]; }
            set {_array[index] = value ; }
        }

        public  CustomList()
        {
            _count =0;
            _capacity =4;
            _array = new Type[_capacity];
        }

        public CustomList(int size)
        {
            _count =0;
            _capacity =size;
            _array = new Type[_capacity];
        }

        public  void Add(Type element)
        {
            if(_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }

        public  void GrowSize()
        {
            _capacity *= _capacity;
            Type[] temp = new Type[_capacity];
            for(int i =0; i<_count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
            //_count = _count ;
        }
    }
}