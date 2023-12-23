//Console.WriteLine("Birinchi sonni kiriting ");
//int? a = int.Parse(Console.ReadLine());
//Console.WriteLine("Ikkinchi sonni kiriting ");
//int? b = int.Parse(Console.ReadLine());

//int? c;

//if (a != null )
//{
//    c = a;
//}
//if (b!= null)
//{
//    c = b;
//}

//if (b != null && a != null)
//{
//    c = a;

//}
//Console.WriteLine(c);

using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 10;
        Console.WriteLine(funcsiya2(() => funcsiya(a)));
    }

    public static int funcsiya(int a)
    {
        return a;
    }

    public static int funcsiya2(Func<int> b)
    {
        return b();
    }
}

