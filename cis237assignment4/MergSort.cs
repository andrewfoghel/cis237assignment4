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
          
            //create arrays to sort left and right values
            IComparable[] aux = new IComparable[arr.Length];
            int i = low;
            int j = mid + 1;

            //copy array
            for (int k = 0; k<arr.Length; k++)
            {
                    aux[k] = arr[k];   
            }

            for(int k = 0; k <= high; k++)
            {
                if (aux[k]!=null)
                {
                    if (i > mid)
                    {
                        arr[k] = aux[j++];
                    }
                    else if (j > high)
                    {
                        arr[k] = aux[i++];
                    }
                    else if (aux[j].CompareTo(aux[i]) < 0)
                    {
                        arr[k] = aux[j++];
                    }
                    else
                    {
                        arr[k] = aux[i++];
                    }
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

