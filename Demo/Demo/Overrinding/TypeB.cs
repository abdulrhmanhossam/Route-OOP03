namespace Demo.Overrinding
{
    internal class TypeB: TypeA
    {
        public int B { get; set; }

        public TypeB(int a, int b):base(a)
        {
            B = b;
        }

        public void MyMethod01()
        {
            Console.WriteLine("I am [Child]");
        }

        public override void MyMethod02()
        {
            Console.WriteLine($"Taype A=A {A} Taype B=B {B}");
        }
    }
}
