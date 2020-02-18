using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracker
{
    enum GenderTypes
    {
        Male,
        Female,
        NotDisclosed,
    }
    enum VeteranTypes
    {
        Veteran,
        NotAVeteran,
        NotDisclosed,
    }
    class person
    {
        public int age;
        public string name;
        public string ssn;
        public GenderTypes gender;
        public VeteranTypes veteranStatus;
        public override string ToString()
        {
            return $"age:{age} name:{name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            person p1;
            person p2;
            person p3;

            p1 = new person();
            p2 = new person();
            p3 = p1;

            p1.age = 10;
            p1.name = "Brian";
            p1.ssn = "000-00-0000";
            p1.gender = GenderTypes.Male;
            p1.veteranStatus = VeteranTypes.NotDisclosed;

            p2.age = 20;
            p2.name = "Carol";
            p2.ssn = "000-00-0000";
            p2.gender = GenderTypes.Female;
            p2.veteranStatus = VeteranTypes.NotAVeteran;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
