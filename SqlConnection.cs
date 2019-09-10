using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SqlConnection : DbConnection
    {
       
        public SqlConnection(string connectionString):base(connectionString)
        {
            
        }

        public override void Close()
        {
            Console.WriteLine("Closing a sql connection");
            IsOpen = false;
        }

        public override void Open()
        {
            Timeout = TimeSpan.FromMinutes(2);
            if (IsOpen)
            {
                throw new InvalidOperationException();
            }
           
                Console.WriteLine("Opening a sql connection with TimeOut:{0}",Timeout);
                IsOpen = true;
           



            
        }
    }
}
