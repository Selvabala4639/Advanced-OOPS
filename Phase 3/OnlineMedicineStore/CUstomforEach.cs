using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
namespace OnlineMedicineStore
{
    /// <summary>
    /// This class is used to run foreach loop for custom list.
    /// </summary>
    /// <typeparam name="Type"></typeparam> <summary>
    /// 
    /// </summary>
    /// <typeparam name="Type"></typeparam>
        public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        /// <summary>
        /// position is the index of an element in an array
        /// </summary> <summary>
        /// 
        /// </summary>
        int position;
        /// <summary>
        /// This method is used to return an array of position.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }
        /// <summary>
        /// This method is used to move the position to next position.
        /// </summary>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if(position < _count-1)
            {
                position ++;
                return true;
            }
            Reset();
            return false;
        }
        /// <summary>
        /// After end of loop reset method will set the position back to -1.
        /// </summary> <summary>
        /// 
        /// </summary>
        public void Reset()
        {
            position=-1;
        }
        /// <summary>
        /// Current property return the array element.
        /// </summary>
        /// <value></value>
        public object Current{get {return _array[position];}}

        
    }
    
}