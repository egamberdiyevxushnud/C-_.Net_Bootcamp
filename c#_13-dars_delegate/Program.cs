using bank;
public class BankAccount
{
    public delegate double Account(double sum, int years);
    public static void Main(string[] args)
    {
        Kredit Kredit = new Kredit();
        while (true)
        {
            #region Tanlov qismi
            Console.Clear();
            Console.Write("Kredit olmoqchi bolgan turni tanglang: \n" +
                "<<Ipoteka>> Ipoteka kredit\n" +
                "<<Mashina>> Mahina kredit\n" +
                "<<Maqsadsiz>> Maqsadsiz kredit\n" +
                "<<Imtiyozli>> Imtiyozli kredit\n" +
                "<<Ta'lim>> Ta'lim kredit\n" +
                "<<Remove>> Dasturni tugatish.\n" +
                ">> ");


            string Tanlandi = Console.ReadLine()!;
            #endregion
            #region Ipoteka kredit
            if (Tanlandi == "Ipoteka")
            {
                Console.Clear();
                Console.Write("Miqdor kiriting>> ");
                double sum = double.Parse(Console.ReadLine()!);
                
                
                Console.Write("Necha yilga olmoqchisiz>> ");
                int year = int.Parse(Console.ReadLine()!);
                Account account1 = Kredit.Ipoteka;
                
                Console.WriteLine(account1(sum, year));
                Console.ReadKey();
            }
            #endregion
            #region Mashina kredit
            else if (Tanlandi == "Mahina")
            {
                Console.Clear();
                Console.Write("Miqdor kiriting>> ");
                
                double sum = double.Parse(Console.ReadLine()!);
                Console.Write("Necha yilga olmoqchisiz>> ");
                
                int year = int.Parse(Console.ReadLine()!);
                Account account2 = Kredit.Mashina;
                
                Console.WriteLine(account2(sum, year));
                Console.ReadKey();
            }
            #endregion
            #region Maqsadsiz kredit
            else if (Tanlandi == "Maqsadsiz")
            {
                Console.Clear();
                Console.Write("Miqdor kiriting>> ");

                double sum = double.Parse(Console.ReadLine()!);
                Console.Write("Necha yilga olmoqchisiz>> ");
                
                int year = int.Parse(Console.ReadLine()!);
                Account account3 = Kredit.Maqsadsiz;
                
                Console.WriteLine(account3(sum, year));
                Console.ReadKey();
            }
            #endregion
            #region Imtiyozli kredit
            else if (Tanlandi == "Imtiyozli")
            {
                Console.Clear(); 
                Console.Write("Miqdor kiriting>> ");
                
                double sum = double.Parse(Console.ReadLine()!);
                Console.Write("Necha yilga olmoqchisiz>> ");
                
                int year = int.Parse(Console.ReadLine()!);
                Account account4 = Kredit.Imtiyozli;
                
                Console.WriteLine(account4(sum, year));
                Console.ReadKey();
            }
            #endregion
            #region Talim kredit
            else if (Tanlandi == "Ta'lim")
            {
                Console.Clear();
                Console.Write("Miqdor kiriting>> ");
                
                double sum = double.Parse(Console.ReadLine()!);
                Console.Write("Necha yilga olmoqchisiz>> ");

                int year = int.Parse(Console.ReadLine()!);
                Account account5 = Kredit.Talim;
                
                Console.WriteLine(account5(sum, year));
                Console.ReadKey();
            }
            #endregion
            #region
            else if (Tanlandi == "Remove")
            {
                Console.Clear();
                Console.WriteLine("Hizmatimizdan foydalanganingiz uchun rahmat!");
                break;
            }
            #endregion
            else { Console.WriteLine("Bunday tanlov yo'q!"); }
        }

    }
}