using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    public class TorbList<T>
    {
        private Node<T> _head;

        public TorbList()
        {

        }

        public void Insert(T data)
        {
            Node<T>dataToAdd = new Node<T>();

            dataToAdd.Data = data;
            dataToAdd.Next = _head;

            _head = dataToAdd;
        }

        public void Insert(T data, int index)
        {
            if (index == 0)
            {
                Insert(data);
            }
            else
            {
                Node<T> nodePriorToIndex = FindIndex(index - 1);
                Node<T> nodeToBeInserted = new Node<T>(data);

                nodeToBeInserted.Next = nodePriorToIndex.Next;
                nodePriorToIndex.Next = nodeToBeInserted;
            }

        }

        public void Remove()
        {
            _head = _head.Next;
            
        }

        public void Remove(int index)
        {
            if (index == 0)
            {
                Remove();
            }
            else
            {
                Node<T> nodePriorToIndex = FindIndex(index - 1);
                Node<T> nodeAtIndex = FindIndex(index);
                nodePriorToIndex.Next = nodeAtIndex.Next;

            }
            

        }

        public T Search(int index)
        {
         
            return FindIndex(index).Data;
            
        }

        private Node<T> FindIndex(int index)
        {
            Node<T> current = _head;
            if (index <= 0) { throw new IndexOutOfRangeException(); }
                            
            for (int i = 0; i < index; i++)
            {
                if (current.Next == null)
                {
                    throw new IndexOutOfRangeException();
                }
                current = current.Next;
            }
            return current;
           


        }

        public void Add(T data)
        {
            if (_head == null)
            {
                _head = new Node<T>();
                _head.Data = data;
                _head.Next = null; ;
            }
            else
            {
                Node<T> dataToAdd = new Node<T>();
                dataToAdd.Data = data;

                Node<T> index = _head;

                while (index.Next != null)
                {
                    index = index.Next;
                }
                index.Next = dataToAdd;
                
             }
        }

        public override string ToString()
        {
            string output = "";
            Node<T> outputNode = _head;

            if (_head != null)
            {
                while (outputNode != null)
                {
                    output += outputNode.Data + "\n";
                    outputNode = outputNode.Next;
               }
                    
            }
            return output;
        }
    }
}
