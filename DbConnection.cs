using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public static TimeSpan Timeout { get; set; }
        public bool IsOpen;


        public DbConnection(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
            {
                throw new NullReferenceException("Please give a valid connection");
            }

            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
        
    }
}
