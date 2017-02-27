using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    class Program
    {
        ClassMember mem1 = new ClassMember(1, "Kaptajn", "Morgan", 99);
        ClassMember mem2 = new ClassMember(2, "Doctor", "Doom", 666);
        ClassMember mem3 = new ClassMember(3, "Max", "Power", 22);
        ClassMember mem4 = new ClassMember(4, "Taylor", "Swift", 12);

        TorbList<ClassMember> members = new TorbList<ClassMember>();
        
        static void Main(string[] args)
        {
           Program p = new Program();
           p.Run();      
        }

        public void Run()
        {
            
            members.Insert(mem1);
            members.Insert(mem2);
            members.Insert(mem3);
            members.Insert(mem4);

            Console.WriteLine(members.ToString());

            members.Remove(3);
            //members.Insert(new ClassMember(54, "Foo", "Bar", 122), -10);

            Console.WriteLine(members.ToString());
      
            Console.ReadKey();
        }
    }
}
