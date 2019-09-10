using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class OracleConnection : DbConnection
    {
        
        public OracleConnection(string connectionString):base(connectionString)
        {
            Timeout = TimeSpan.FromMinutes(5);
        }
        public override void Close()
        {
            Console.WriteLine("Closing a oracle connection");
            IsOpen = false;
        }

        public override void Open()
        {
            if (IsOpen)
            {
                throw new InvalidOperationException();
            }
            Console.WriteLine("Opening a oracle connection with Timeout:{0} ",Timeout);
            IsOpen = true;
        }
    }
}
