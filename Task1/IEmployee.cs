using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Module;

namespace Task1
{
    public interface IEmployee
    {
         string Name { get; set; }
         int Age { get; set; }
         DateTime DateOfStart { get; set; }
         int Salary { get; set; }
         prof prof { get; set; }
    }
}
