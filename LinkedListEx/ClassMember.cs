using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    public class ClassMember
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public ClassMember(int memid, string fname, string lname, int age)
        {
            MemberId = memid;
            FirstName = fname;
            LastName = lname;
            Age = age;
        }

        public override string ToString()
        {

            return $"[{MemberId}], {FirstName}, {LastName}, {Age}";


        }
    }
}
