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
           p.Run();      
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

            SearchLinearExample(smallLinear);
            SearchLinearExample(largeBinary);

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
            foreach (var item in temp)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(item))
                    {
                        Console.WriteLine("Found " + item.ToString() + " at postion " + i +  " in arr");
                    }
                }
                
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            // Binary search??

            //Array.Sort(temp);

            //sw.Restart();
            //foreach (var item in temp)
            //{
            //    Console.WriteLine(Array.BinarySearch(arr, temp));

            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

        }

   //     procedure insertionSort(A : array of items )
   //int holePosition
   //int valueToInsert
	
   //for i = 1 to length(A) inclusive do:
	
   //   /* select value to be inserted */
   //   valueToInsert = A[i]
   //   holePosition = i
      
   //   /*locate hole position for the element to be inserted */
		
   //   while holePosition > 0 and A[holePosition - 1] > valueToInsert do:
   //      A[holePosition] = A[holePosition - 1]
   //      holePosition = holePosition - 1
   //   end while
		
   //   /* insert the number at hole position */
   //   A[holePosition] = valueToInsert

   //end for


//end procedure
        public void InsertionSort(IComparable[] input)
        {

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
