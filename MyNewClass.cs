using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDoc
{
    /// <summary>
    /// class to test documenting
    /// A class to store an array for statistics
    /// </summary>
    /// 

    class MyNewClass
    {
        /// <summary>
        /// n the size of the array is passed to the constructor
        /// and stored in the parameter desired array size
        /// </summary>
        int desiredArraySize;
        /// <summary>
        /// contentSize is how much data is currently stored
        /// </summary>
        int contentSize;
        float[] arrayData;

        /// <summary>
        /// class consturctor
        /// </summary>
        /// <param name="n">The size of the array</param>
        public MyNewClass(int n)
        {
            desiredArraySize = n;
            arrayData = new float[n];
            contentSize = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="f">The data to be added</param>
        /// <returns>
        /// 0 if worked
        /// -1 if failed
        /// </returns>
        public int AddData(float f)
        {
            if(contentSize < desiredArraySize)
            {
                arrayData[contentSize++] = f;

                return 0;
            }
            else
            {
                return -1;
            }
        }
        /// <summary>
        /// A function to add data to the class
        /// </summary>
        /// <param name="n">The item in the array</param>
        /// <returns>
        /// arrayData[n] if n <contentSize> 
        /// NaN if n > </contentSize>
        /// </returns>
        public float DataAt(int n)
        {
            if(n < contentSize)
            {
                return arrayData[n];
            }
            else
            {
                return float.NaN;
            }

        }

    }
}
