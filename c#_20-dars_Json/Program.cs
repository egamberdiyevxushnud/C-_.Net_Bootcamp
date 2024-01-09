using System.Text.Json;

namespace c__20_dars_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyModel myModel = new MyModel()
            {
                Id = 1,
                FirstName = "Xushnud",
                LastName = "Egamberdiyev",
                Age = 17,
            };

            // json serislizer => model to Json
            // json Deserialazer => Json to Model

            string json = JsonSerializer.Serialize(myModel);

            Console.WriteLine(json);

        }
    }
}
