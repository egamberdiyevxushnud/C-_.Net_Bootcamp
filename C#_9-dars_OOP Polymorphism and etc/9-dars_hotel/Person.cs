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

        public ArrayList bemorlar = new ArrayList();

        // Bemorni qo'shish
        public void addPatient(Person person)
        {
            //var bemor = new Person(ismi, familiyasi, ssn);
            bemorlar.Add(person);
            Console.WriteLine("Bemor muvaffaqiyatli qo'shildi");
            foreach(Person i in person.bemorlar)
{
                Console.Write(i.Name+ " ,");
                Console.Write(i.Surname + ", ");
                Console.Write(i.SSN);
            }
        }
    }


}
