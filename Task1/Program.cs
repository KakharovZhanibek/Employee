using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Module;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceEmployee Employee = new ServiceEmployee();
            Employee.CreateEmployers();

            foreach (Employee item in Employee.employers)
                Console.WriteLine(item);
            Console.WriteLine("------------");
            foreach(Employee item in Employee.FindManager(prof.klerk))
            {
                Console.WriteLine(item);
            }
        }
    }
}
