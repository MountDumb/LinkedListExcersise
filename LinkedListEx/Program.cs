using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LinkedListEx
{
    class Program
    {
        //ClubMember mem1 = new ClubMember(1, "Kaptajn", "Morgan", 99);
        //ClubMember mem2 = new ClubMember(2, "Doctor", "Doom", 666);
        //ClubMember mem3 = new ClubMember(3, "Max", "Power", 22);
        //ClubMember mem4 = new ClubMember(4, "Taylor", "Swift", 12);

        //TorbList<ClubMember> members = new TorbList<ClubMember>();

        static void Main(string[] args)
        {
            Program p = new Program();
            //p.BRun();
            p.Run();
        }

        public void BRun()
        {
            //Initialize a BST which will contain integers
            BinarySearchTree<int> intTree = new BinarySearchTree<int>();

            Random r = new Random(DateTime.Now.Millisecond);
            string trace = "";

            //Insert 5 random integers into the tree
            for (int i = 0; i < 5; i++)
            {
                int randomInt = r.Next(1, 500);
                intTree.Insert(randomInt);
                trace += randomInt + " ";
            }

            // Find the largest value in the tree
            Console.WriteLine("Max: " + intTree.FindMax());

            //Find the smallest value in the tree
            Console.WriteLine("Min: " + intTree.FindMin());

            // Find the root of the tree
            Console.WriteLine("Root: " + intTree.Root.Data);

            // The order in which the elements were added to the tree
            Console.WriteLine("Trace: " + trace);

            // A textual representation of the tree
            Console.WriteLine("Tree: " + intTree);

            Console.ReadLine();
        }

        public void Run()
        {
            int smallSize = 1000;
            int largeSize = smallSize * 10;

            ClubMember[] smallLinear = new ClubMember[smallSize];
            ClubMember[] largeLinear = new ClubMember[largeSize];

            ClubMember[] smallBinary = new ClubMember[smallSize];
            ClubMember[] largeBinary = new ClubMember[largeSize];

            Populate(smallLinear);
            Populate(largeLinear);
            Populate(smallBinary);
            Populate(largeBinary);

            //SearchLinearExample(smallLinear);
            //SearchLinearExample(largeLinear);

            //WriteCollectionToConsole(smallBinary);
            InsertionSort(smallBinary);
            Console.WriteLine();
            //WriteCollectionToConsole(smallBinary);

            BinarySearchExample(smallBinary);
            Console.WriteLine();

            InsertionSort(largeBinary);
            Console.WriteLine();
            BinarySearchExample(smallBinary);
            
            Console.ReadLine();

        }

        public void SearchLinearExample(IComparable[] arr)
        {
            //Method should have a return type. This is purely for measuring time.
            Stopwatch sw = new Stopwatch();
            //int counter = 0;
            Random rand = new Random();
            IComparable[] temp = new ClubMember[3];

            for (int i = 0; i < 3; i++)
            {
                temp[i] = arr[rand.Next(arr.Length)];
            }


            sw.Start();
            for (int i = 0; i < 999; i++)
            {
                foreach (var item in temp)
                {
                    for (int ii= 0; ii < arr.Length; ii++)
                    {
                        if (arr[i].Equals(item))
                        {
                            Console.WriteLine("Found " + item.ToString() + " at postion " + ii + " in arr");
                        }
                    }

                }
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

           

        }

        public void BinarySearchExample(IComparable[] input)
        {
            // Generate array with 3 people to search for.
            Random rand = new Random();
            IComparable[] temp = new ClubMember[3];

            for (int i = 0; i < 3; i++)
            {
                temp[i] = input[rand.Next(input.Length)];
            }

            // The actual search algorithm.
            bool running = true;
            int min = 0;
            int max = input.Count();
            int guess;

            if (min > max) { Console.WriteLine("Item not present"); }
            Stopwatch sw = new Stopwatch();

            sw.Start();


            for (int i = 0; i < 999; i++)
            {
                foreach (var item in temp)
                {
                    running = true;
                    while (running)
                    {
                        guess = (min + max) / 2;
                      
                        if (input[guess].CompareTo(item) == 1)
                        {
                            max--;
                        }
                        else if (input[guess].CompareTo(item) == -1)
                        {
                            min++;
                        }
                        if (input[guess].CompareTo(item) == 0)
                        {
                            //Console.WriteLine(item + " found at index: " + guess);
                            running = false;
                        }
                    }
                }
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
        

        public void WriteCollectionToConsole(IComparable[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item.ToString());
            }
        }
   
        public void InsertionSort(IComparable[] input)
        {
            Stopwatch sw = new Stopwatch();
            int holePosition;
            IComparable objectInCollection;

            sw.Start();
            for (int i = 1; i < input.Count(); i++)
            {
                objectInCollection = input[i];
                holePosition = i;

                while (holePosition > 0 && input[holePosition - 1].CompareTo(objectInCollection) == 1)
                {
                    input[holePosition] = input[holePosition - 1];
                    holePosition--;
                }
                input[holePosition] = objectInCollection;
            }
            sw.Stop();

            Console.WriteLine(sw.Elapsed);
        }

        public void Populate(ClubMember[] toBePopulated)
        {
            for (int i = 0; i < toBePopulated.Length; i++)
            {
                toBePopulated[i] = CMFactory.GetClubMember();
            }
        }

        //public void Run()
        //{

        //    members.Insert(mem1);
        //    members.Insert(mem2);
        //    members.Insert(mem3);
        //    members.Insert(mem4);

        //    Console.WriteLine(members.ToString());

        //    Console.WriteLine(members.GetLength());
        //    Console.WriteLine(members.GetCount());

        //    members.Remove(3);
        //    //members.Insert(new ClubMember(54, "Foo", "Bar", 122), -10);

        //    Console.WriteLine(members.ToString());

        //    Console.WriteLine(members.GetLength());
        //    Console.WriteLine(members.GetCount());

        //    Console.WriteLine(members[2].ToString());

        //    Console.ReadKey();
        //}
    }
}
