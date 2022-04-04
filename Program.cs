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
		public void InsertAfter (int p_Node, int d)
		{
			Node node = new Node(d);
			node.data = d;
			node.next = null;
			node.prev = null;
			if (p_Node < 0)
			{
				Console.WriteLine("Node harus lebih dari sama dengan 1");
			}
			else
			{
				Node temp = head;
				for (int i = 1; i < p_Node; i++)
				{
					if(temp !=null)
					{
						temp = temp.next;
					}
				}
				if (temp != null)
				{
					node.next = temp.next;
					node.prev = temp;
					temp.next = node;
					if(node.next != null)
					{
						node.next.prev = node;
					}
				}
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

		// FUNGSI DELETE IN THE LAST
		public void DeleteLast ()
		{
			if (head != null)
			{
				if (head.next == null)
				{
					head = null;
				}
				else
				{
					Node temp = head;
					while (temp.next.next != null)
					{
						temp = temp.next;
					}
					Node last = temp.next;
					temp.next = null;
					last = null;
				}
			}
		}

		// FUNGSI DELETE AT INDEX : N
		public void DeleteAt (int p_Node)
		{
			if (p_Node < 0)
			{
				Console.WriteLine("Posisi hapus node harus lebih dari 1");
			}
			else
			{
				Node temp = head;
				for (int i = 1; i < p_Node-1; i++)
				{
					if(temp !=null)
					{
						temp = temp.next;
					}
				}
				if (temp != null && temp.next != null)
				{
					Node delete = temp.next;
					temp.next = temp.next.next; 
					if(temp.next.next != null)
					{
						temp.next.next.prev = temp.next;
					}
					delete = null;
				}
				else 
				{
					Console.Write("\nNode sudah null");
				}
			}
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
			Stack<Int32> st = new Stack<Int32>();
			Console.Write("Masukkan Banyak No : ");
			int input = Convert.ToInt32(Console.ReadLine());

			// Looping Node
			//for (int i = 1; i <= input; i++)
			//{
			//	node.AddNode(i);
			//}

			// Looping Stack
			for (int i = 1; i <= input; i++)
			{
				st.Push(i);
			}
			st.Pop();
			st.Pop();
			foreach (int i in st)
			{
				Console.WriteLine(i);
			}

			// Insertion In The Beginning
			//node.InsertHead(7);

			// Insertion At The End
			//node.AddNode(10);

			//Insertion at index : n
			//node.InsertAfter(5,50);

			// Delete In The Beginning
			//node.DeleteHead();

			// Delete In The End
			//node.DeleteLast();

			// Delete at index : n
			//node.DeleteAt(4);

			// Print All Node
			//node.PrintList(node.head);
			Console.ReadKey();
		}
	}
}