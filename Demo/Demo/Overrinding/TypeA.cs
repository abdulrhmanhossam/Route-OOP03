namespace Demo.Overrinding
{
    internal class TypeA
    {
        public TypeA(int a)
        {
            A = a;
        }
        public TypeA()
        {
            
        }

        public int A { get; set; }

        public void MyMethod01()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void MyMethod02()
        {
            Console.WriteLine($"Taype A=A {A}");
        }
    }
}
