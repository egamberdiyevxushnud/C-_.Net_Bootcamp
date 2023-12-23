using C__9_dars_OOP_Polymorphism_and_etc._9_dars_hotel;
using System.Reflection.Metadata;

#region Calculator
//Hisobla<int> oyla = new Hisobla<int>();
//Console.WriteLine(oyla.Qoshish(2, 4));
//Console.WriteLine(oyla.Bolish(4, 2));
//Console.WriteLine(oyla.Kopaytirish(4, 2));
//Console.WriteLine(oyla.Ayirish(4, 2));
#endregion

Person person = new Person("Tohirjon", "Polvonov", "1");
Person person2 = new Person("Xushnud", "Egamberdiyev", "2");

#region T-1.1 bemorlar qoshish
//person.addPatient(person);
//person.addPatient(person2);
#endregion
#region T-1.2 bemor qidirish
person.addPatient(person2);
person.addPatient(person);

Console.WriteLine("Kerak odamning iddsini kiriting ");
string idd = Console.ReadLine();
person.getPatient(idd);
#endregion

//Nurse shifokor = new Nurse("Yoqubov","Komil","10034","jarroh","10");
//Nurse shifokor2 = new Nurse("sherboyev", "Jovlon", "10023", "stamatolog", "11");

#region T-2.1 shifokor qoshish
//shifokor.addDoctor(shifokor);
//shifokor.addDoctor(shifokor2);
#endregion 

//shifokor.addDoctor(shifokor);
//shifokor.addDoctor(shifokor2);
//Console.WriteLine("Kerakli doctor iddsini kiritng ");
//string idd = Console.ReadLine();
//Console.WriteLine(shifokor.getDoctor(idd).Name);
//Console.WriteLine(shifokor.getDoctor(idd).Surname);
//Console.WriteLine(shifokor.getDoctor(idd).SSN);








