namespace C__19_dars_DateTime
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //Console.WriteLine("Yil");
            //int yil = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Oy");
            //int oy = int.Parse(Console.ReadLine());

            //Console.WriteLine("Kun");
            //int kun = Convert.ToInt32(Console.ReadLine());

            //DateTime dataTime = new DateTime(yil, oy, kun);
            //Console.WriteLine(DateTime.Now - dataTime);

            string path = "C:\\Users\\hp\\Desktop\\c#\\.Net C# Bootcamp";
            string path2 = "D:\\Mytxt2.txt";

            string sourse = "Assalomu\n aleykum";

            DirectoryInfo directory = new DirectoryInfo(path);

            Console.WriteLine(directory.Parent);

            //shu pathdagi hamma filelarni oberadi
            string[] files = Directory.GetFiles(path);

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            

            //pathdagi hamma folderlarni olib beradi
            string[] strings = Directory.GetDirectories(path);

            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }






            //IEnumerable<string> file = new List<string>() { sourse };

            //File.AppendAllLines(path, file);

            //string[] valus =  File.ReadAllLines(path);

            //foreach (string val in valus)
            //{
            //    Console.WriteLine(val);
            //}

            //using(StreamWriter streamWriter = new StreamWriter(path))
            //{
            //    streamWriter.WriteLine(sourse);
            //}

            //using(StreamReader streamReader = new StreamReader(path))
            //{
            //    Console.WriteLine(streamReader.ReadToEnd ());
            //}
        }
    }
}
 