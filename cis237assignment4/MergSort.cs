using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergSort
    {
        public IComparable[] merge(IComparable[] arr, int low, int high)
        {
            //if array is single is a single index return that array
            if (high - low < 2)
            {
                return new IComparable[] { arr[low] };
            }
            //calculate middle of array 
            int middle = low + ((high - low) / 2);
            //new Icomparable array to store values from the left
            IComparable[] left = merge(arr, low, middle);
            //new icomparable array to store values from the right
            IComparable[] right = merge(arr, middle, high);

           
            //New Icomparable array to stor the sorted values
            IComparable[] results = new IComparable[left.Length + right.Length];
            // int for index of the left
            int indexL = 0;
            //int for index of the right
            int indexR = 0;
            //I for loops
            int i = 0;
            //for loop to start sorting and merging 
            for (; indexL < left.Length && indexR < right.Length; i++)
                {
                    if (left[indexL].CompareTo(right[indexR]) < 0)
                    {
                        results[i] = left[indexL];
                        indexL++;
                    }
                    else
                    {
                        results[i] = right[indexR];
                        indexR++;
                    }
                }
                //copy remaining elements
                while (indexL < left.Length)
                {
                    results[i++] = left[indexL++];
                }
                while (indexR < right.Length)
                {
                    results[i++] = right[indexR++];
                }
                return results;
            }


        }
    }
