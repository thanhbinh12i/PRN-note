using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entities
{
    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public override string? ToString() => $"{Id} {Name} {Yob} {Salary}";
    }
}
//class lecturer cabinet xuất hiện, code y chang