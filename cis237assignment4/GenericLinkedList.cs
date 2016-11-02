using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericLinkedList<T>:IGenericLinkedList<T>
    {
        protected class Node
        {
            public T data { get; set; }
            public Node next { get; set; }
        }

        protected Node head;
        protected Node tail;
        protected int sizes;
        public bool isEmpty
        {
            get
            {
                return (head == null);
            }
        }

        public int size
        {
            get
            {
                return sizes;
            }
        }

        public void addToFront(T tData)
        {
            Node oldHead = head;
            head = new Node();
            head.data = tData;
            head.next = oldHead;
            sizes++;
            if (sizes == 1)
            {
                tail = head;
            }
        }



        public void addToBack(T tData)
        {
            Node oldTail = tail;
            tail = new Node();
            tail.data = tData;
            tail.next = null;
            if (isEmpty)
            {
                addToFront(tData);
            }
            else
            {
                oldTail.next = tail;
            }
            sizes++;
        }


        public T removeFromFront()
        {
            if (isEmpty)
            {
                throw new Exception("List is Empty");
            }
            T returnData = head.data;
            head = head.next;
            sizes--;
            if (isEmpty)
            {
                tail = null;
            }

            return returnData;
        }

        public T removeFromBack()
        {
            if (isEmpty)
            {
                throw new Exception("List is empty");
            }
            T returnData = tail.data;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
          
                Node current = head;

                while (current.next != tail)
                {
                    current = current.next;
                }
                tail = current; 
                tail.next = null;
            }
           
            return returnData;
        }

        public void Display()
        {
            if (isEmpty)
            {
                Console.WriteLine("This list is Empty");
            }
            else
            {
                Console.WriteLine("This list is:");
                Node current = head;    
                while (current != null)
                {
                    
                    Console.Write(current.data + ", ");
   
                    current = current.next;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
      
        //Initialize all of the variables to default values.
        public GenericLinkedList()
        {
            head = null;
            tail = null;
            sizes = 0;
        }

        //created new virtual method that returns isEmpty value
        public virtual bool empty()
        {
            return isEmpty;
        }
    }
}

