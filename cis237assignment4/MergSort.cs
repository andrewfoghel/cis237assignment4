using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergSort
    {
        public void merge(IComparable[] arr, int low, int mid, int high)
        {
            //Starting Index
            IComparable[] aux = new IComparable[arr.Length];
            int i = low;
            int j = mid + 1;
            //copy array
            for (int k = low; k <= high; k++)
            {
                aux[k] = arr[k];
            }

            for (int k = 0; k <= high; k++)
            {


                if (i > mid)
                {
                    arr[k] = aux[j++];
                }
                else if (j > high)
                {
                    arr[k] = aux[i++];
                }
                else if (aux[i].CompareTo(aux[j]) < 0)
                {
                    arr[k] = aux[j++];
                }
                else
                {
                    arr[k] = aux[i++];
                }

            }
        }

        public void sort(IComparable[] arr, int low, int high)
        {
            if (high <= low)
            {
                return;
            }
            int mid = low + (high - low) / 2;
            sort(arr, low, mid);
            sort(arr, mid + 1, high);
            merge(arr, low, mid, high);
        }

    }

}

