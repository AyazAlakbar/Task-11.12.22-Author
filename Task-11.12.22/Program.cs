using System;
using System.Collections.Generic;

namespace Task_11._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Author author1 = new Author();
            author1.Name = "Murad";
            author1.Surname = "Qasimov";
            author1.Age=22;

            Author author2 = new Author();
            author2.Name = "Nihad";
            author2.Surname = "Alakbarov";
            author2.Age = 42;

            Author author3 = new Author();
            author3.Name = "Orxan";
            author3.Surname = "Aliyev";
            author3.Age = 46;

            Author author4 = new Author();
            author4.Name = "Ayaz";
            author4.Surname = "Alakbarov";
            author4.Age = 32;

            Author author5 = new Author();
            author5.Name = "Qurban";
            author5.Surname = "Abdullayev";
            author5.Age = 51;

            List<Author> pers = new List<Author>();
            pers.Add(author1);
            pers.Add(author2);
            pers.Add(author3);
            pers.Add(author4);
            pers.Add(author5);





            foreach (var author in pers)
            {
                if (author.Age>40)
                { 
                    Console.WriteLine(author.Name + " " + author.Surname);

                }
               
            }
        }
    }
}
