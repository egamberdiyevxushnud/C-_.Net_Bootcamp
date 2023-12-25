Console.WriteLine("tugulgan kunizi kiriting; ");
int kun = int.Parse(Console.ReadLine());
Console.WriteLine("Tugulgan oyizi kiriting");
int oy  = int.Parse(Console.ReadLine());
Console.WriteLine("Tugulgan yilizi kiriting; ");
int yil =  int.Parse(Console.ReadLine());

var birthday = new DateTime(kun, yil, yil);
var now =  DateTime.Now;
TimeSpan result = birthday - now;
Console.WriteLine(result.Days);