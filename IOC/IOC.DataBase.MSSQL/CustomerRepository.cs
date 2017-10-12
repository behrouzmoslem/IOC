using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Common.Entities;

namespace IOC.DataBase.MSSQL
{
    public class CustomerRepository: ICustomerRepository
    {
        public void Add(Customer customer)
        {
           var db = new MyDbApplication();
            db.Customers.Add(customer);
            db.SaveChanges();
        }
    }
}
