using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }



    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Uptaded!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");
        }

        
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Uptaded!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");
        }

    }
    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added!");
        }

        public void Update()
        {
            Console.WriteLine("MySql Uptaded!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted!");
        }

    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
