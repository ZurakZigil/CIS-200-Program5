// Program 5
// CIS 200-01
// Fall 2019
// By: M9888
// Due: 12/3/2019

// File: Test.cs
// This creates three Tree List objects that will be used to contain list of corresponsing value types
// (int, double, string) and will then use Traversal to sort them (based on BinaryTreeLibrary2.cs)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeLibrary2;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            Tree<int>_intList = new Tree<int>(); // creates Tree list of ints 
            Tree<double>_doubleList = new Tree<double>(); // creates Tree list of doubles
            Tree<string>_stringList = new Tree<string>(); // creates Tree list of strings

            //preorder
            _intList.InsertNode(11);//1
            _intList.InsertNode(26);//2
            _intList.InsertNode(35);//3
            _intList.InsertNode(45);//4
            _intList.InsertNode(65);//5
            _intList.InsertNode(86);//6
            _intList.InsertNode(92);//7
            _intList.InsertNode(100);//8
            _intList.InsertNode(108);//9
            _intList.InsertNode(127);//10


            //postorder
            _doubleList.InsertNode(1.5);//1
            _doubleList.InsertNode(2.9);//2
            _doubleList.InsertNode(3.3);//3
            _doubleList.InsertNode(4.1);//4
            _doubleList.InsertNode(6.5);//5
            _doubleList.InsertNode(7.8);//6
            _doubleList.InsertNode(9.11);//7
            _doubleList.InsertNode(10.1);//8
            _doubleList.InsertNode(10.9);//9
            _doubleList.InsertNode(11.7);//10


            //inorder
            _stringList.InsertNode("Nothing");//1
            _stringList.InsertNode("will");//16
            _stringList.InsertNode("come");//2
            _stringList.InsertNode("from");//3
            _stringList.InsertNode("nothing");//4
            _stringList.InsertNode("you");//5
            _stringList.InsertNode("know");//6
            _stringList.InsertNode("what");//7
            _stringList.InsertNode("they");//8
            _stringList.InsertNode("say");//9
            _stringList.InsertNode("Always");//10
            _stringList.InsertNode("look");//11
            _stringList.InsertNode("on");//12
            _stringList.InsertNode("the");//13
            _stringList.InsertNode("bright");//14
            _stringList.InsertNode("side");//15
            _stringList.InsertNode("of");//16
            _stringList.InsertNode("life");//17


            //Using all the lists to for traversals
            //INTS
            Console.WriteLine("INT PreOrder");
            _intList.PreorderTraversal(); //PreOrder
            Console.WriteLine("\n");
            Console.WriteLine("INT PostOrder");
            _intList.PostorderTraversal(); //PostOrder
            Console.WriteLine("\n");
            Console.WriteLine("INT InOrder");
            _intList.InorderTraversal(); //InOrder
            Console.WriteLine("\n");
            Pause();


            //Doubles
            Console.WriteLine("DOUBLE PreOrder");
            _doubleList.PreorderTraversal(); //PreOrder
            Console.WriteLine("\n");
            Console.WriteLine("DOUBLE PostOrder");
            _doubleList.PostorderTraversal(); //PostOrder
            Console.WriteLine("\n");
            Console.WriteLine("DOUBLE InOrder"); 
            _doubleList.InorderTraversal();//InOrder
            Console.WriteLine("\n");
            Pause();

            //Strings
            Console.WriteLine("STRING PreOrder"); 
            _stringList.PreorderTraversal(); //PreOrder
            Console.WriteLine("\n");
            Console.WriteLine("STRING PostOrder"); 
            _stringList.PostorderTraversal(); //PostOrder
            Console.WriteLine("\n");
            Console.WriteLine("STRING InOrder"); 
            _stringList.InorderTraversal(); //InOrder
            Console.ReadLine();
            Pause();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
