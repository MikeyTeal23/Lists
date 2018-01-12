using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLists
{
    public class MyDoubleLinkedList
    {
        private LinkedList<string> list = new LinkedList<string>();

        public LinkedList<string> getList()
        {
            return list;
        }

        public void createNewList()
        {
            add("Fred");
            add("Wilma");
            add("Betty");
            add("Barney");
        }

        public void add(string s)
        {
            list.AddLast(s);
        }

        public LinkedListNode<string> getNodeOfStringIfInList(string s)
        {
            foreach (var value in list)
            {
                if (value == s)
                {
                    return (list.Find(s));
                }
            }

            return null;
        }

        public void deleteNodeWithString(string s)
        {
            LinkedListNode<string> targetNode = list.Find(s);
            LinkedListNode<string> previousNode = null;
            LinkedListNode<string> currentNode = list.First;

            while (currentNode != null)
            {
                if (currentNode == targetNode)
                {
                    list.Remove(currentNode);
                }
                else
                {
                    previousNode = currentNode;
                }
                currentNode = currentNode.Next;
            }
        }

        public string[] getStringArrayOfValues()
        {
            return list.ToArray();
        }
    }
}
