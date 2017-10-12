using System.Data.Entity;
using IOC.Common.Entities;

namespace IOC.DataBase.MSSQL
{
    public class MyDbApplication : DbContext
    {
        public MyDbApplication()  
        {
        }

        public DbSet<Customer> Customers { get; set; }

    }
}