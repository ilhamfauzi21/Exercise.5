using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_081
{
    class Node
    {
        public char info;
        public Node next;
        public Node(char i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Queues
    {
        Node ITEM;
        Node ID;

        public Queues()
        {

            ITEM = null;
            ID = null;
        }
        public void insert(char element)
        {
            Node el;
            el = new Node(element, null);


            if (ITEM == null)
            {
                ITEM = el;
            }
            else
            {
                ID.next = el;
            }
            ID = el;
        }
        public int delete()
        {
            Node tmp;
            Console.WriteLine("\nThe element delete from the queue is " + ITEM + "\n");

            tmp = ITEM;
            ITEM = ITEM.next;

            if (ITEM == null)
            {
                ID = null;
            }
            return tmp.info;

        }
        public void display()
        {
            Node ITEM_position;
            ITEM_position = ITEM;

            if ((ITEM_position == null) && (ID == null))
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("\nElements in the queue are...\n");

            while (ITEM_position != ID)
            {
                Console.WriteLine(ITEM_position.info);
                ITEM_position = ITEM_position.next;
            }
            if (ITEM_position == ID)
            {
                Console.WriteLine(ITEM_position.info);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter Character: ");
                                char c = Convert.ToChar(Console.ReadLine());
                                Console.WriteLine();
                                q.insert(c);
                            }
                            break;
                        case '2':
                            {
                                q.delete();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered");
                }
            }
        }
    }
}
//ALGORITMA PENCARIAN YANG SAYA KETAHUI YAITU ada Cara kerja dengan pohon binner
//Cara kerja dari algoritma ini adalah dengan melakukan pengecekan data secara berulang kali dengan membuang setengah jumlah data sampai menemukan sebuah kecocokan. Dengan konsep seperti ini, lingkup pencarian data akan semakin mengecil setiap melakukan proses perulangan.
