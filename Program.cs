using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
	class Program
	{
		Node head;
		class Node
		{
			public int data;
			public Node next;
			public Node prev;
			public Node (int d)
			{
				data = d;
			}
		}

		public void AddNode (int d)
		{
			Node node = new Node(d);
			Node temp = head;
			node.next = null;
			if (head == null)
			{
				node.prev = null;
				head = node;
				return;
			}
			else
			{
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = node;
				node.prev = temp;
			}
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
		}

		public void PrintList (Node node)
		{
			Node temp = null;
			while (node != null)
			{
				Console.Write(node.data);
				temp = node;
				node = node.next;
			}
		}

		static void Main(string[] args)
		{
			Program node = new Program();
			Console.Write("Masukkan Banyak Node : ");
			int input = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= input; i++)
			{
				node.AddNode(i);
			}
			node.InsertHead(1);
			node.PrintList(node.head);
		}
	}
}
