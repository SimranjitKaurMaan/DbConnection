using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class DBCommand
    {
        public string Command { get; set; }

        public DbConnection DbConnection { get; set; }
        public DBCommand(DbConnection dbConnection, string command)
        {

            if (string.IsNullOrEmpty(command) || dbConnection == null)
            {
                throw new NullReferenceException();
            }

            DbConnection = dbConnection;
            Command = command;

        }

        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("command is runnning:{0}", Command);
            DbConnection.Close();
        }
    }
}
