using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer()
            {
                FirstName = "Joe",
                LastName = "Callahan",
                YearsOld = 22
            };
            //defaulted duplicate interface method
            Console.WriteLine(cust.GetAgeInDays());

            Console.WriteLine(cust.GetCustomerName());

            //casting explicitly implemented interface method 
            Console.WriteLine(((IGetName2)cust).GetCustomerName());

            
        }
    }
}
