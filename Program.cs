using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRlib;
namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            PreEmployee[] emp = new PreEmployee[4];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new PreEmployee();
                Console.WriteLine("Enter empid:");
                emp[i].Empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the empname:");
                emp[i].EmpName = Console.ReadLine();
                Console.WriteLine("Enter the emp city:");
                emp[i].EmpCity = Console.ReadLine();
                Console.WriteLine("Enter the emplo position:");
                emp[i].EmpPos = Console.ReadLine();
            }
            Console.WriteLine("Details:");
            foreach (var item in emp)
            {
                Console.WriteLine(item.Empid);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.EmpCity);
                Console.WriteLine(item.EmpPos);
            }

            Console.WriteLine("==============");

            int cout = emp.Count();
            Console.WriteLine("Total employees:" + cout);
            Console.ReadLine();
        }
    }
}
