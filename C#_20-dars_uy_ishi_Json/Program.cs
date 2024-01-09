using System.Text.Json;

namespace C__20_dars_uy_ishi_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user = new User()
            //{
            //    Id = 1,
            //    Name = "Telefon",
            //    Descpription = "Qora, 128GB",
            //};

            //var UserJsonData = JsonSerializer.Serialize(user);
            //Console.WriteLine(UserJsonData);

            //string JsonTelefon = "{\"Id\":1,\"Name\":\"Telefon\",\"Descpription\":\"Qora, 128GB\"}";

            //var data = JsonSerializer.Deserialize<User>(JsonTelefon);

            //Console.WriteLine(data.Name);
            //Console.WriteLine(data.Id);
            //Console.WriteLine(data.Descpription);

            User user2 = new User();

            string path = "D:\\";
            string name = "Users.json";

            string fulname = Path.Combine(path, name);

            user2.Name = "Telefon";
            user2.Id = 1;
            user2.Descpription = "Name";



            var JsonData = JsonSerializer.Serialize(user2);


            using (StreamWriter sw = new StreamWriter(fulname))
            {
                sw.Write(JsonData);

            }

           
            

            


        }
    }
}
 