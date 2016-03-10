﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // MyLinkedList linked = new MyLinkedList();
            // linked.Add(15);
            // linked.Add(23);
            // int testNode = linked.Head.Num;
            // int testNode2 = linked.Tail.Num;

            // // Console.WriteLine(linked.Length);
            // Console.WriteLine(testNode);
            // Console.WriteLine(testNode2);

            int[] nums = {0, 0, 0, 0, 1, 1, 0, 0, 0, 3, 3, 3, 1, 1, 0};
            MyLinkedList testList = new MyLinkedList();


            foreach(int num in nums)
            {
                testList.Add(num);
            }

            // System.Type type = testList.GetType();
            // Console.WriteLine(testList);
            // foreach(int num in testList)
            // {
            //     int number = num.Num;
            //     Console.WriteLine(number);
            // }

            MyLinkedList.squish(testList);
        }
    }

    /// <summary>
    /// Create your own definition of linkedlist first
    /// squish() takes your linked list and, wherever two or more consecutive items are
    /// equals(), it removes duplicate nodes so that only one consecutive copy
    /// remains. Hence, no two consecutive items in this list are equals() upon
    /// completion of the procedure.
    ///
    /// After squish() executes, the list may well be shorter than when squish()
    /// began. No extra items are added to make up for those removed.
    /// For example, if the input list is [ 0 0 0 0 1 1 0 0 0 3 3 3 1 1 0 ], the
    /// output list is [ 0 1 0 3 1 0 ].
    /// </summary>

    public class MyLinkedList
    {
        // fields
        Node head = null;
        Node tail = null;
        int length = 0;

        public Node Head
        {
            get
            {
                return head;
            }
            private set
            {
                head = value;
            }
        }

        public Node Tail
        {
            get
            {
                return tail;
            }
            private set
            {
                tail = value;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            private set
            {
                length = value;
            }
        }

        // properties
        // these should be modifiable only by this class

        // does this need to be public or private or what??
        public class Node
        {
          // fields
          int num;
          Node next;

          // properties
          public int Num
          {
              get
              {
                  return num;
              }
              set
              {
                  num = value;
              }
          }
          public Node Next
          {
              get
              {
                  return next;
              }
              set
              {
                  next = value;
              }
          }

          // destructor -- TODO!
          // ~Node()
          // {

          // }

          // constructor
          public Node(int number)
          {
              num = number;
          }
        }

        // add new val to node
        public Node Add(int num)
        {
            // new node
            Node newNode = new Node(num);
            length++;
            // if first node, set as head
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                tail.Next = newNode;
            }
            tail = newNode;
            return newNode;
        }

        public static void squish(MyLinkedList list)
        {
            // Fill in your solution here.
            // get head, traverse
            // if val is same, remove link, update link (temp var)
            // deconstruct node

            // bool type = list.GetType() == typeof(MyLinkedList);
            // Console.WriteLine(list);

            // check for null?
            Node currNode = list.Head;
            Node nextNode = currNode.Next;
            int i = 0;

            // if (currNode == null) {
            //   Console.WriteLine("head is null");
            //   return;
            // }

            while(i < list.Length - 1)
            {
                // int currNum = currNode.Num;
                // int nextNum = nextNode.Num;

                // Console.WriteLine(currNum);
                // Console.WriteLine(nextNum);

                if (currNode.Num == nextNode.Num)
                {

                    // // Node  = nextNode.Next;
                    Node connectOverNode = nextNode.Next;
                    // currNode.Next = connectOverNode;
                //     // need to do deconstruct
                    Console.WriteLine(connectOverNode);
                }
                else
                {
                    i++;
                }

                currNode = nextNode;
                nextNode = currNode.Next;
            }
            Console.WriteLine("what");

            Node currNodeEach = list.Head;
            // to show squished list
            for (int j = 0; j < list.Length; j++)
            {

                int nodeVal = currNodeEach.Num;
                Console.WriteLine("Curr Node Val:" + nodeVal);
                currNodeEach = currNodeEach.Next;
            }
        }
    }

}

// fields
// properties (get/set)
// methods
// constructors