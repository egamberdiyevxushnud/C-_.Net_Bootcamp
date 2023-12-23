
using C__11_dars_tuple_Ilist;
using System;
using System.Reflection;

public class Program
{
    #region Main
    public static void Main(string[] args)
    {
        // Real names for the students
        string[] studentFirstNames =
            [
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Emma",
                "Frank",
                "Grace",
                "Henry",
                "Isabel",
                "Jack",
                "Katie",
                "Liam",
                "Mia",
                "Nathan",
                "Olivia",
                "Paul",
                "Quinn",
                "Rachel",
                "Samuel",
                "Tara"
                ];

        // Real last names for the students
        string[] studentLastNames =
            [
                "Smith",
                "Johnson",
                "Williams",
                "Jones",
                "Brown",
                "Davis",
                "Miller",
                "Wilson",
                "Moore",
                "Taylor",
                "Anderson",
                "Thomas",
                "Jackson",
                "White",
                "Harris",
                "Martin",
                "Thompson",
                "Young",
                "Clark",
                "Walker"
                ];

        Student[] unsortedStudents = new Student[20];

        for (int i = 1; i <= studentFirstNames.Length; i++)
        {
            var student = new Student
            {
                Id = i,
                FirstName = studentFirstNames[i-1],
                LastName = studentLastNames[i - 1]
            };

            unsortedStudents[i-1] = student;
        }
        
        // TODO Consolega unsortedStudents elementlarini chiqaring (use while loop)
        // TODO unsortedStudents elementlarini birma-bir sortedStudentsga qo'shing

        var sortedStudents = new SortedList<int, Student>();
        #region 1 , 2 va 3 -misollar

        //int sum = 0;
        //while (sum < unsortedStudents.Length)
        //{
        //    #region 2-siga yeshim
        //    sortedStudents.Add(unsortedStudents[sum].Id, unsortedStudents[sum]);
        //    #endregion
        //    Console.WriteLine($"ID: {unsortedStudents[sum].Id}, Name: {unsortedStudents[sum].FirstName} {unsortedStudents[sum].LastName}");
        //    sum++;
        //}

        #region 3-siga yechim
        //foreach (var item in sortedStudents)
        //{
        //    Console.WriteLine($"{item.Value.FirstName}");
        //}
        #endregion

        #endregion

        // TODO Consolega unsortedStudents elementlarini chiqaring (use for each loop)

        #region 4-misol
        //foreach (var item in unsortedStudents)
        //{
        //    Console.WriteLine($"Id : {item.Id}, {item.FirstName},{item.LastName}");
        //}
        #endregion

        var studentsQueueForFood = new Queue<Student>();
        // TODO studentsQueueForFood  queue ga  Id 3, 4, 8, 17, 1, 6, 12 studentlarni qo'shing (Enqueue).
        // Har bir studentni ketma-ketlikda consolega chiqaring Masalan. Shu Idga ega bo'lgan ovqatga navbatga turdi
        // Har bir studentni ketma-ketlikda consolega chiqaring Masalan. Shu Idga ega bo'lgan student ovqatni oldi.
        #region 5-6-7 - Misollar
        //for (int i = 0; i < unsortedStudents.Length; i++)
        //{
        //    if (unsortedStudents[i].Id == 3 || unsortedStudents[i].Id == 4 || unsortedStudents[i].Id == 8 || unsortedStudents[i].Id == 17
        //        || unsortedStudents[i].Id == 1 || unsortedStudents[i].Id == 6 || unsortedStudents[i].Id == 12)
        //    {
        //        studentsQueueForFood.Enqueue(unsortedStudents[i]);
        //    }
        //}
        #region 6-misol
        //foreach (var item in studentsQueueForFood)
        //{
        //    Console.WriteLine($"{item.Id} Idga ega bo'lgan ovqatga navbatga turdi");
        //}
        #endregion
        #region 7-misol
        //foreach (var item in studentsQueueForFood)
        //{
        //    Console.WriteLine($"{item.Id} Idga ega bo'lgan ovqatga navbatga turdi");
        //}

        #endregion

        #endregion


        var studentsEnrolledMathCourse = new HashSet<Student>();
        // TODO 1, 3, 5, 6, 8, 18, 15, 13, 20 id li studentlarni matematika kursiga qo'shing.
        #region 9-misol
        //for (int i = 0; i < unsortedStudents.Length; i++)
        //{
        //    if (unsortedStudents[i].Id == 1 || unsortedStudents[i].Id == 3 || unsortedStudents[i].Id == 5 || unsortedStudents[i].Id == 6
        //        || unsortedStudents[i].Id == 8 || unsortedStudents[i].Id == 18 || unsortedStudents[i].Id == 15 ||
        //        unsortedStudents[i].Id == 13 || unsortedStudents[i].Id == 20)
        //    {
        //        studentsEnrolledMathCourse.Add(unsortedStudents[i]);
        //    }
        //}
        #endregion

        var studentsEnrolledEnglishCourse = new HashSet<Student>();
        // TODO 1, 2, 9, 6, 8, 7, 15, 13, 20 id li studentlarni ingliz tili kursiga qo'shing.
        #region 10-misol
        //for (int i = 0; i < unsortedStudents.Length; i++)
        //{
        //    if (unsortedStudents[i].Id == 1 || unsortedStudents[i].Id == 2 || unsortedStudents[i].Id == 9 || unsortedStudents[i].Id == 6
        //        || unsortedStudents[i].Id == 8 || unsortedStudents[i].Id == 7 || unsortedStudents[i].Id == 15 ||
        //        unsortedStudents[i].Id == 13 || unsortedStudents[i].Id == 20)
        //    {
        //        studentsEnrolledMathCourse.Add(unsortedStudents[i]);
        //    }
        //}
        #endregion

        #region 11-misol
        // TODO matematika va ingliz tiliga bir vaqtda qatnashayotgan studentlarni consolega chiqaring (IntersectWith) 
        //foreach (var item in studentsEnrolledMathCourse)
        //{
        //    if (studentsEnrolledEnglishCourse.Contains(item))
        //    {
        //        //Console.WriteLine($"ikkala tilga ham boradigon studentlar => Id : {item.Id} , {item.LastName} {item.FirstName}");
        //        Console.WriteLine("rt");
        //    }
        //}
        #endregion

        // TODO faqat matematikaga(ingliz tiliga emas) qatnashayotgan studentlarni consolega chiqaring (ExceptWith)

        // TODO faqat ingliz tiliga(matematikaga emas) qatnashayotgan studentlarni consolega chiqaring (ExceptWith)

        // TODO istalgan kursga qatnashayotgan studentlarni consolega chiqaring. (UnionWith)

        // HashSetlar reference type. UnionWith, ExceptWith va IntersectWith chaqirilgan hashSetlarni o'zgartiradi.

        // studentlarni id isiga ko'ra jurnalda saqlang. ma'lumotlarni sorted Listdan olib keling.
        var classJournal = new Dictionary<int, Student>();
        // studentlarni jurnalini Consolega chiqaring.
    }
    #endregion
}