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
        //private int _index;

        public T this[int key]
        {
            get { return Search(key); }
        }

      

        public TorbList()
        {
            
        }

        public bool Contains(T obj)
        {
            Node<T> temp = _head;

            while (temp.Next != null)
            {
                if (temp.Data.Equals(obj))
                {
                    return true;
                }
                temp = temp.Next;
                
            }
            return false;
        }

        public int IndexOf(T input)
        {
            Node<T> temp = _head;
            int i = 0;

            while (_head.Next != null)
            {
                if (Contains(input))
                {
                    return i;
                }
                else
                {
                    temp = temp.Next;
                    i++;
                }
            }
            return -1;
            
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

        //Helpers

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
            Node<T> NodeToBeAdded = new Node<T>(data);

            if (_head == null)
            {
                _head = NodeToBeAdded;
                //_head = new Node<T>();
                //_head.Data = data;
                //_head.Next = null; 
            }
            else
            {
                Node<T> dataToAdd = new Node<T>(data);
                Node<T> indexOfLastElement = _head;

                while (indexOfLastElement.Next != null)
                {
                    indexOfLastElement = indexOfLastElement.Next;
                }
                indexOfLastElement.Next = dataToAdd;
                
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

        public int GetLength()
        {
            int output = 0;
            Node<T> countingNode = _head;

            while (countingNode.Next != null)
            {
                output++;
                countingNode = countingNode.Next;
            }
            return output;
        }

        public int GetCount()
        {
            return GetLength() + 1;
        }


    }
}
