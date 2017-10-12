using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Common.Entities;

namespace IOC.DataBase
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
    }
}
