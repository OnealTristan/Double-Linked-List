using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
	class Program
	{
		class Node
		{
			public int data;
			public Node next;
			public Node prev;
			public Node (int d)
			{
				data = d;
				next = null;
				prev = null;
			}
		}

		class LinkedList
		{
			public Node head;
			public void AddNode (int d)
			{
				Node node = new Node(d);
				if (head == null)
				{
					node.prev = null;
					head = node;
				}
				else
				{
					Node temp = head;
					while (temp.next != null)
					{
						temp = temp.next;
					}
					temp.next = node;
					node.prev = temp;
				}
				Console.Write(node.data);
			}
			public void InsertHead (int d)
			{
				Node node = new Node(d);
				node.next = head;
				node.prev = null;
				if (head != null)
				{
					head.prev = node;
				}
				head = node;
				Console.Write(head.data);
			}
			public void InsertEnd (int d)
			{
				Node node = new Node(d);
				node.next = node;
				Console.Write(node.next);
			}
		}
		static void Main(string[] args)
		{
			LinkedList node = new LinkedList();
			Console.Write("Masukkan Banyak Node : ");
			int input = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= input; i++)
			{
				node.AddNode(i);
			}
			node.InsertHead(1);
			Console.ReadKey();
		}
	}
}
