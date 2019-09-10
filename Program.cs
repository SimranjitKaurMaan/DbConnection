using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
           var OracleConnection= new OracleConnection("Banana Database");
            OracleConnection.Open();
            OracleConnection.Close();
            Console.WriteLine();

            var SqlConnection = new SqlConnection("Cheese Database");
            SqlConnection.Open();
           // SqlConnection.Open();
            SqlConnection.Close();
            Console.WriteLine();
        }
    }
}
