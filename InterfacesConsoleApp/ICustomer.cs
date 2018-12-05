using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesConsoleApp
{
    interface IGetName
    {
        string GetCustomerName();
    }

    interface IGetName2 
    {
        string GetCustomerName();
    }

    interface IGetAge
    {
        int GetAgeInDays();
    }
}
