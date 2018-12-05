using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesConsoleApp
{
    class Customer : IGetAge, IGetName, IGetName2
    {
        public int YearsOld { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //standard implementation of interface method
        public int GetAgeInDays()
        {
            return YearsOld * 365;
        }
        //defaulting one of the duplicate named methods by implementing it normally
        public string GetCustomerName()
        {
            return FirstName + " " + LastName;
        }
        //explicitly implemented method signature
        string IGetName2.GetCustomerName()
        {
            return LastName + " " + FirstName;
        }
    }

}
