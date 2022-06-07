using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackPractice();
            //QueuePractice();
            Queue<Order> orders = new Queue<Order>();
            foreach(Order order in ReceiveOrdersFromBranchOne())
            {
                orders.Enqueue(order);
            }
            foreach(Order order in ReceiveOrdersFromBranchTwo())
            {
                orders.Enqueue(order);
            }
            while(orders.Count > 0)
            {
                Order currentOrder = orders.Dequeue();
                currentOrder.ProcessOrder();
            }
        }
        //type three back slashes creates summary section
        /// <summary>
        /// The is a summer about the stack practice method
        /// </summary>
        /// <param name="none"></param>
        /// <returns>void</returns>

        public static void StackPractice()
        {
            //define a stack
            //generic type (only one type)
            Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //while(stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Peek());
            //    stack.Pop();
            //}
            int[] intArray = new int[] { 1, 2, 3, 4 };
            Console.WriteLine($"numbers in array are: ");
            foreach(int num in intArray)
            {
                Console.WriteLine(num);
                stack.Push(num);
            }
            Console.WriteLine("Numbers in stack are: ");
            foreach(int number in stack)
            {
                Console.WriteLine(number);
            }
        }

        public static void QueuePractice()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine($"Value at front of queue: {queue.Peek()}");
            queue.Dequeue();
            Console.WriteLine($"Value at front of queue: {queue.Peek()}");
            queue.Dequeue();
            Console.WriteLine($"Value at front of queue: {queue.Peek()}");
            Console.WriteLine($"Queue count: {queue.Count}");

        }

        static Order[] ReceiveOrdersFromBranchOne()
        {
            Order[] orders = new Order[3]
            {
                new Order(1,10),
                new Order(4,8),
                new Order(6,5),
            };
            return orders;
        }
        static Order[] ReceiveOrdersFromBranchTwo()
        {
            Order[] orders = new Order[3]
            {
                new Order(2,10),
                new Order(3,8),
                new Order(5,5),
            };
            return orders;
        }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public Order(int orderId, int orderQuantity)
        {
            OrderId = orderId;
            OrderQuantity = orderQuantity;
        }
        public void ProcessOrder()
        {
            Console.WriteLine($"Order: {OrderId} processed");
        }
    }

}
