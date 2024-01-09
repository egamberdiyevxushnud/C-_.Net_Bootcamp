using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text.Json;

namespace C__21_dars_Json_Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Json\Users.json";
            string data = "";

            using (StreamReader sr = new StreamReader(path))
            {
                data = sr.ReadToEnd();
            }

            List<Class1> root = JsonConvert.DeserializeObject<List<Class1>>(data);

            JArray obj = JArray.Parse(data);

            foreach(JArray item in obj)
            {
                if ((int)item["id"] == 0)
                {
                    obj.Remove(item["id"]);
                }
                if ((int)item["userId"] == 0)
                {
                    obj.Remove(item["userId"]);
                }
                if (item["title"].ToString() == "")
                {
                    obj.Remove(item["title"]);
                }
                if (item["boby"].ToString() == "")
                {
                    obj.Remove(item["boby"]);
                }
            }


            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }



        }
    }
}
