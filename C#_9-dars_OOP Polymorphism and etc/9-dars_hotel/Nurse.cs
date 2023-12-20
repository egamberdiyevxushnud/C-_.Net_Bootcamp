using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__9_dars_OOP_Polymorphism_and_etc._9_dars_hotel
{
    internal class Nurse : Person
    {
        public string Specialist { get; set; }
        public string Idd { get; set; }
        public Nurse(string name, string surname, string ssn,string specialist, string idd) : base(name, surname, ssn)
        {
            Specialist = specialist;
            Idd = idd;
        }

        public List<Person> doctor = new List<Person>();

        // doctor qo'shish
        public void addDoctor(Person hamshira)
        {
            doctor.Add(hamshira);
            Console.WriteLine("Doktor muvaffaqiyatli qo'shildi\t");
        }

        
        public Person? getDoctor(string ssn1)
        {
            foreach (Person person1 in doctor)
            {

                if (Idd == ssn1)
                {
                    return person1;
                }
            }
            return null;
        } 


    }
}
