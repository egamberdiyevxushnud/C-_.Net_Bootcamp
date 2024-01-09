namespace C__18_dars_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    File.WriteAllBytes("c:/alamlar.mp3", new byte[] { 12, 123, 14, 85, 26, 36 });
            //    string[] contens = new string[]
            //    {
            //        "Hello - salom",
            //        "world - dunyo",
            //        "Buy - sotib olish",
            //        "Goodbye - xayr",
            //        "i don't buy this - Men bunga isgonmayman"
            //    };

            //    File.WriteAllLines("D:/4000.txt", contens);

            //File.AppendAllText("D:/alamlar.txt", "Hafa - sad\n Hursand - happy");
            File.AppendAllText("D:/alamlar.txt", "Hafa - sad\n Hursand - happy");

            //string[] res =  File.ReadAllLines("D:/alamlar.txt");
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            string path = "D:/alamlar.txt";
            if (File.Exists(path))
            {
               
                Console.WriteLine("File ochirildi");
            }
            else
            {
                Console.WriteLine("Mavjud emas file ");
            }
        }
    }
}
