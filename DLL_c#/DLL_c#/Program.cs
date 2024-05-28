using System;

public class DoublyLinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node Prev;

        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    private Node head;

    public DoublyLinkedList()
    {
        head = null;
    }

    public void Insert(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
        newNode.Prev = current;
    }

    public void Delete(int data)
    {
        if (head == null)
        {
            return;
        }

        Node current = head;
        while (current != null && current.Data != data)
        {
            current = current.Next;
        }

        if (current == null)
        {
            return;
        }

        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }
        else
        {
            head = current.Next;
        }

        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }
    }

    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        DoublyLinkedList list = new DoublyLinkedList();

        list.Insert(1);
        list.Insert(2);
        list.Insert(3);
        list.Insert(4);

        Console.WriteLine("Список после вставки элементов:");
        list.PrintList();

        list.Delete(3);

        Console.WriteLine("Список после удаления элемента 3:");
        list.PrintList();

        list.Delete(1);

        Console.WriteLine("Список после удаления элемента 1:");
        list.PrintList();

        list.Delete(4);

        Console.WriteLine("Список после удаления элемента 4:");
        list.PrintList();
    }
}
