using System.Collections;

namespace C__9_dars_OOP_Polymorphism_and_etc._9_dars_hotel
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SSN { get; set; }

        public Person(string name, string surname, string ssn)
        {
            Name = name;
            Surname = surname;
            SSN = ssn;

        }

        public List<Person> patients = new List<Person>();

        // Bemorni qo'shish
        public void addPatient(Person person)
        {
            patients.Add(person);
            Console.WriteLine("Bemor muvaffaqiyatli qo'shildi\t");
        }

        //Bemorni qidirish
        public void getPatient(string ssn)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].SSN == ssn)
                {
                    Console.WriteLine("Bu foydalanuvchi bor\t");
                    Console.WriteLine(patients[i].Name);
                    Console.WriteLine(patients[i].Surname);
                    Console.WriteLine(patients[i].SSN);
                }
            }
            Console.WriteLine("exception is thrown\n budney aydili odam yoq");
        }
    }


}
