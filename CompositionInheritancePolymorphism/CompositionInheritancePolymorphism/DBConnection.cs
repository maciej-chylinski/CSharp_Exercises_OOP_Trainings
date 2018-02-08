using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionInheritancePolymorphism
{
    /*
    A DbConnection will not be in a valid state if it doesn’t have a connection string. 
    You need to: 
    + pass a connection string in the constructor of this class. 
    + take into account the scenarios where null or an empty string is sent as the connection string. 
    Make sure to throw an exception to guarantee that your class will always be in a valid state.
    + Our DbConnection should also have two methods for opening and closing a connection.
    + We don’t know how to open or close a connection in a DbConnection and this should be left to the
    classes that derive from DbConnection. These classes (eg SqlConnection or OracleConnection)
    will provide the actual implementation. So you need to declare these methods as abstract.        
    */
    public abstract class DBConnection
    {
        public string _connectionString { get; set; }
        public TimeSpan timeout { get; set; }

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        //public abstract void open(string _connectionString, TimeSpan timeout);
        //public abstract void close(string _connectionString);
        public abstract void open();
        public abstract void close();
    }
}
