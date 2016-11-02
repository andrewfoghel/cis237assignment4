using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
   
    interface IGenericLinkedList<T>
    {
        //since the type we want has come into this interface as type T we will use T as the type for the data
        //this means that if this linkedlist is declared with T being a string it will hold strings etc.
        void addToFront(T tData);
        void addToBack(T tData);
        T removeFromFront();
        T removeFromBack();

      

        void Display();

        bool isEmpty { get; }
        int size { get; }
    }
}
