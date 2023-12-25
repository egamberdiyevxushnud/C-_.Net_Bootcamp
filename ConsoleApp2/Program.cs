namespace ConsoleApp2
{
    internal class Program
    {
        static delegate void Mydelegate(int a, int b);
        public void Main(string[] args)
        {
            Mydelegate del = new Mydelegate(MethodA);
            MethodB("qiymat", del);
        }

        public void MethodB(string message, Mydelegate del)
        {
            del.Invoke(33, 77);
            Console.WriteLine(message);
        }

        public void MethodA(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
