using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Queue<T>
    {
        //Create new linked list for queue with s
        IGenericLinkedList<T> queueList = new GenericLinkedList<T>();

        //Implement Enqueue method, add to back for O(1) and not O(N)
        public void enqueue(T toQueue)
        {
            queueList.addToBack(toQueue);
        }
       
        //Implement Dequeue, Remove from front
        public T dequeue()
        {
            return queueList.removeFromFront();
        }


        public int size()
        {
            return queueList.size;
        }

    }
}
