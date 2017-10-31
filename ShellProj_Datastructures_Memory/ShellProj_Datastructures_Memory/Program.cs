﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    class Program
    {
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            bool run = true;
            while (true)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            bool move = true;
            while (true)
            {
                Console.WriteLine("Please write a word starting with + to add it to the lost or - to remove it from the list");
               
                string input = Console.ReadLine();
                char nav = input[0];
                string value;
                int sizeOflist = 0;

                switch (nav)
                {
                    case '+':
                        value = input.Substring(1);
                         theList.Add(value);
                        sizeOflist = theList.Count;
                        


                        break;
                    case '-':
                        value = input.Substring(1);
                        theList.Remove(value);
                        sizeOflist = theList.Count;
                        break;
                    case '0':
                        return;
                   



                }
                
                Console.WriteLine("capacity of the list now is: "+sizeOflist);



              
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> Testqueue = new Queue<string>();
          
            int Qsize;
            
            
            List<string> theList = new List<string>();
            while (true)

            {
                Console.Write("Enter + to get your self in the queue or - to get out: ");
                string input = Console.ReadLine();
                char nav = input[0];

                switch (nav)
                {
                    case '+':
                        Console.WriteLine("Provide your name: ");
                        string inputname = Console.ReadLine();


                        Testqueue.Enqueue(inputname);
                        Qsize = Testqueue.Count;
                        Console.WriteLine( "The current queue size is : " + Qsize);



                        break;
                    case '-':
                        Testqueue.Dequeue();
                        Qsize = Testqueue.Count;
                        Console.WriteLine("queue has " + Qsize + " people below");
                        foreach (var item in Testqueue)
                        {
                            
                            Console.WriteLine(item);
                        }
                        
                        break;

                    case '0':
                        return;

                    default:
                        break;
                }
                
               

            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack<string> moshen = new Stack<string>();
            

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
        }

    }
}
