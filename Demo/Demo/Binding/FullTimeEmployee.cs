namespace Demo.Binding
{
    internal class FullTimeEmployee: Employee
    {
        public decimal Salary { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine($"I am FullTimeEmployee");
        }

        public override void Myfun02()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nAge: {Age}\n Salary: {Salary}");
        }
    }
}
