using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Size of list: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var list = new List<Student>();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Birthday(dd/mm/yyyy): ");
                var str = Console.ReadLine();
                Console.WriteLine();
                var birthday = ChangeToDateTime(str);
                Console.Write("Score: ");
                var score = double.Parse(Console.ReadLine());
                Console.WriteLine();
                list.Add(new Student(name, birthday, score));
            }
            list = list.OrderBy(x => x.Score).ToList();
            foreach(var stu in list)
            {
                Console.WriteLine(stu.ToString());
            }
            Console.ReadKey();
        }
        static DateTime ChangeToDateTime(string str)
        {
            var arr = str.Split('/');
            var day = int.Parse(arr[0]);
            var month = int.Parse(arr[1]);
            var year = int.Parse(arr[2]);
            return new DateTime(year, month, day);
        }
    }
}
