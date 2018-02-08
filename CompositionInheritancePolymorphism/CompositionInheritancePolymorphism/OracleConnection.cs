using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionInheritancePolymorphism
{
    public class OracleConnection : DBConnection
    {
        //tutaj indywidualne pola dla klasy dziedziczącej

        public OracleConnection(string connectionString)
            :base(connectionString)
        {}

        public override void open()
        {
            if ((String.IsNullOrWhiteSpace(_connectionString)))
            {
                throw new InvalidOperationException("Not a valid connection string");
            }
            else
            {
                Console.WriteLine("Nawiązuję połączenie (ConnectionString: {0}, Timeout: {1}) ", _connectionString, timeout);                
            }
        }

        public override void close()
        {
            Console.WriteLine("Zamykam połączenie ({0})", _connectionString);
            Console.ReadLine();
        }

    }
}
