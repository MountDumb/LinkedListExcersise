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
            int counter = 0;
            Random rand = new Random();
            IComparable[] temp = new ClubMember[2];

            sw.Start();
            while (counter < arr.Length)
            {
                for (int i = 0; i < 2; i++)
                {
                    temp[i] = arr[rand.Next(arr.Length)];
                }
                counter++;
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
