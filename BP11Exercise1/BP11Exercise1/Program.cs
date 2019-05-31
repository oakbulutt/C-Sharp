using System;

namespace BP11Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Oguzhan";
            p.LastName = "Akbulut";
            p.Introduce();

            Person p1 = new Person("Oguzhan", "Akbulut");
            p1.Introduce();

            Employee e = new Employee();
            e.FirstName = "Dominika";
            e.LastName = "Minkiewicz";
            e.Position = "C# Developer";
            e.Introduce();
            e.SignList();

            Employee e1 = new Employee("Dominika", "Minkiewicz", "C# Developer");
            e1.Introduce();
            e1.SignList();

            Student s = new Student();
            s.FirstName = "İrem";
            s.LastName = "Akbulut";
            s.IndexNumber = 123456;
            s.Introduce();
            s.EnrollToCourse();

            Student s1 = new Student("İrem", "Akbulut", 12345678);
            s1.Introduce();
            s1.EnrollToCourse();

            Client c = new Client();
            c.FirstName = "Murat";
            c.LastName = "Akbulut";
            c.ShippingAddress = "Bahçelerüstü mahallesi 51. sokak 8/11 Mamak - Ankara";
            c.Introduce();
            c.OrderGoods();

            Client c1 = new Client("Murat", "Akbulut", "Bahçelerüstü mahallesi 51. sokak 8/11 Mamak - Ankara");
            c1.Introduce();
            c1.OrderGoods();

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
