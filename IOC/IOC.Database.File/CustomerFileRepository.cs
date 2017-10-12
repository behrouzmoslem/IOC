using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Common.Entities;
using IOC.DataBase;
using Newtonsoft.Json;

namespace IOC.Database.File
{
    public class CustomerFileRepository:ICustomerRepository
    {
        public void Add(Customer customer)
        {
            var json = JsonConvert.SerializeObject(customer);
            System.IO.File.AppendAllText($@"D:\Learned\MyIOC\IOC\IOC\IOC.Database.File\fileRepository.txt", json);
        }
    }
}
