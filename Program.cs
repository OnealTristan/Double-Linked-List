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
		public class Node
		{
			public int data;
			public Node next;
			public Node prev;
			public Node (int d)
			{
				data = d;
			}
		}


		// -----FUNGSI INSERTION-----
		// FUNGSI INSERTION (At the end)
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

		// FUNGSI INSERTION AT THE BEGINNING
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

		// FUNGSI INSERTION AT INDEX : N
		public void InsertAfter (Node p_Node, int d)
		{
			Node node = new Node(d);
			if (p_Node == null)
			{
				Console.WriteLine("Node sebelumnya tidak boleh kosong");
				return;
			}
			node.next = p_Node.next;
			p_Node.next = node;
			node.prev = p_Node;
			if (node.next != null)
			{
				node.next.prev = node;
			}
		}


		// -----FUNGSI DELETE-----
		// FUNGSI DELETE AT THE BEGINNING
		public void DeleteHead ()
		{
			if (head != null)
			{
				Node temp = head;
				head = head.next;
				temp = null;
				if(head != null)
				{
					head.prev = null;
				}
			}
		}

		public void DeleteLast ()
		{

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

			// Looping Node
			for (int i = 1; i <= input; i++)
			{
				node.AddNode(i);
			}

			// Insertion In The Beginning
			node.InsertHead(7);

			// Insertion At The End
			node.AddNode(5);

			//Insertion at index : n
			//node.InsertAfter(node.head,5)

			// Delete In The Beginning
			node.DeleteHead();

			// Print All Node
			node.PrintList(node.head);
			Console.ReadKey();
		}
	}
}