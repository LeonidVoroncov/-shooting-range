using System;

namespace ShootingRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new object[3] {
                new Person
                { 
                    Surname = "Иванов",
                    DateBirth = "17.08.2002",
                    Gender = "мужской",
                    Status = "Гражданский",
                    License = false,
                    TypeGun = "АК-47"
                },
                new Person
                {
                    Surname = "Патров",
                    DateBirth = "17.08.2002",
                    Gender = "мужской",
                    Status = "Гражданский",
                    License = true,
                    TypeGun = "АК-47"
                },
                new Person
                {
                    Surname = "Сидоров",
                    DateBirth = "17.08.2002",
                    Gender = "мужской",
                    Status = "Военный",
                    TypeGun = "АК-47"
                }
            };
            foreach(var element in array)
            {
                Console.WriteLine(element.License);
            }           
            Console.ReadKey();
        }
    }
}
