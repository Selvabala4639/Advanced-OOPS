using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Collections;
namespace MetroCardManagement
{
    
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }
        /// <summary>
        /// MoveNext compares position and count of an array. It returns true if pposition is avaliable.
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (position < _count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        /// <summary>
        /// Reset is used to set the position value back to -1 after completeing foreach loop.
        /// </summary>
        public void Reset()
        {
            position = -1;
        }
        /// <summary>
        /// Current property returns the value of the current position.
        /// </summary>
        /// <value></value>
        public Object Current { get { return _array[position]; } }
    }
}