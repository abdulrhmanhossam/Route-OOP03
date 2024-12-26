namespace Demo.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void MyFun01()
        {
            Console.WriteLine($"I am Employee");
        }
        public virtual void Myfun02()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nAge: {Age}");
        }
    }
}
