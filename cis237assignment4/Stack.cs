using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Stack<T>
    {

        //Create a new LinkedList to add droids into stack
        IGenericLinkedList<T> stackList = new GenericLinkedList<T>();

        //Implement push method, add droid to front 
        public void push(T toStack)
        {
            stackList.addToFront(toStack);
        }
        //Implement pop method, Last in First out so we also need to remove from the front, 
        public T pop()
        {
           return stackList.removeFromFront();
        }
        
        public bool isEmpty()
        {
            return stackList.isEmpty;
        }
        public void Display()
        {
            stackList.Display();
        }
        public int size()
        {
            return stackList.size;
        }
    }
}
