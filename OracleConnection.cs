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
            
        }
        public override void Close()
        {
            Console.WriteLine("Closing a oracle connection");
            IsOpen = false;
        }

        public override void Open()
        {
            Timeout = TimeSpan.FromMinutes(5);
            if (IsOpen)
            {
                throw new InvalidOperationException();
            }
            Console.WriteLine("Opening a oracle connection with Timeout:{0} ",Timeout);
            IsOpen = true;
        }
    }
}
