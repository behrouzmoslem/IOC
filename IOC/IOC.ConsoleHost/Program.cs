using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Business;
using IOC.Common.Entities;
using IOC.Database.File;
using IOC.DataBase;
using IOC.DataBase.MSSQL;

namespace IOC.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer() {Id = 1,Name="Behrouz"};
            var repositoryMsSql = new CustomerRepository();
            var repositoryFile = new CustomerFileRepository();
            var customerServiceMsSql = new CustomerService(repositoryMsSql);
            customerServiceMsSql.Add(customer);

            var customerServiceFile = new CustomerService(repositoryFile);
            customerServiceFile.Add(customer);
        }
    }
}
