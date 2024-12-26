using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class PartTimeEmployee: Employee
    {
        public int CountOfHours { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine($"I am PartTimeEmployee");
        }

        public override void Myfun02()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nAge: {Age}\n CountOfHours: {CountOfHours}");
        }
    }
}
