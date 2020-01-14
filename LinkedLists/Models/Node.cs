﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedLists.Models
{
	public class Node
	{
		Node next;
		int data;
		public Node(int data)
		{
			this.data = data;
		}

		public class LinkedList
		{
			Node head;

			public void append(int data)
			{
				if (head == null)
				{
					head = new Node(data);
					return;
				}
				Node current = head;
				while (current.next != null)
				{
					current = current.next;
				}
				current.next = new Node(data);
			}
			public void prepend(int data)
			{
				Node newHead = new Node(data);
				newHead.next = head;
				head = newHead;
			}
			//method for deleting data from inside List
			public void deleteWithValue(int data)
			{
				
				if (head == null) return;
				//if Head is the data we want to delete
				if (head.data == data)
				{
					head = head.next;
				}


				Node current = head;
				while (current.next != null)
				{
					if(current.next.data == data)
					{
						current.next = current.next.next;
						return;
					}
					current = current.next;
				}
			}
		}
	}
	
}
