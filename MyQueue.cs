using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLists
{
    public class MyQueue
    {
        private Queue<string> queue = new Queue<string>();

        public Queue<string> getQueue()
        {
            return queue;
        }

        public void createNewQueue()
        {
            add("Fred");
            add("Wilma");
            add("Betty");
            add("Barney");
        }

        public void add(string s)
        {
            queue.Enqueue(s);
        }

        public int getPositionOfStringIfInList(string s)
        {
            Queue<string> tempQueue = queue;
            int counter = 0;
            if (queue.Contains(s))
            {
                foreach (var value in tempQueue)
                {
                    if (value == s)
                    {
                        return counter;
                    }
                    counter++;
                }
            }
            return 99999;
        }

        public void deleteItemWithValue(string s)
        {
            Queue<string> newQueue = new Queue<string>();
            int counter = 0;

            foreach (var value in queue)
            {
                if (value != s || counter > 0)
                {
                    newQueue.Enqueue(value);
                }
                if (value == s)
                {
                    counter++;
                }
            }

            queue = newQueue;
        }

        public string[] getStringArrayOfValues()
        {
            return queue.ToArray();
        }
    }
}
