using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    public class ClubMember : IComparable
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public ClubMember(int memid, string fname, string lname, int age)
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

        public int CompareTo(object obj)
        {
            ClubMember cm = obj as ClubMember;

            if (this.MemberId < cm.MemberId)
            {
                return 1;
            }
            else if (this.MemberId > cm.MemberId)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }



        public override bool Equals(object obj)
        {
            if (this.ToString() == obj.ToString())
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            
            return base.GetHashCode();
        }
    }
}
