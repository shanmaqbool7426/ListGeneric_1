using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(21);
            numbers.Add(23);
            numbers.Add(24);
            numbers.Add(25);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            List<string> names = new List<string>();
            //names.Add("ali");
            //names.Add("Ahmad");
            //names.Add("adil");
            Student std1 = new Student();
            std1.Id = 10;
            std1.Name = "shan";
            std1.classStag = "16th";
            Student std2 = new Student();
            std2.Id = 11;
            std2.Name = "ali";
            std2.classStag = "15th";
            Student std3 = new Student();
            std3.Id = 12;
            std3.Name = "eshan";
            std3.classStag = "14th";
            List<Student> student = new List<Student>();
            student.Add(std1);
            student.Add(std2);
            student.Add(std3);
;            foreach (var item in student)
            {
                Console.WriteLine("the name={0} the id={1} the classstag{2}",item.Id,item.Name,item.classStag);
            }
            Console.ReadLine();
        }
    }
}
