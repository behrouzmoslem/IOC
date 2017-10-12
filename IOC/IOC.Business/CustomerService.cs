using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Common.Entities;
using IOC.DataBase;

namespace IOC.Business
{
    public class CustomerService
    {
        private ICustomerRepository repository { get; set; }
        public CustomerService(ICustomerRepository repository)
        {
            this.repository = repository;
        } 


        public void Add(Customer customer)
        {
            repository.Add(customer);
        }

    } 
}
