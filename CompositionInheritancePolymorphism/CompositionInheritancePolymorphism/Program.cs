using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionInheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            OracleConnection oraConn = new OracleConnection("oracleConnestionString");
            oraConn.timeout = TimeSpan.Parse("0:10");
            SqlConnection sqlConn = new SqlConnection("sqlConnestionString");
            sqlConn.timeout = TimeSpan.Parse("0:5:3");

            //oraConn.open(); oraConn.close();
            //sqlConn.open(); sqlConn.close();


            //+In the main method, initialize a DbCommand with some string as the instruction and a
            //SqlConnection.Execute the command and see the result on the console.            
            DbCommand newDbCommand1 = new DbCommand(sqlConn, "some example instruction");
            newDbCommand1.Execute(newDbCommand1);


            //+Then, swap the SqlConnection with an OracleConnection and see polymorphism in action.
            DbCommand newDbCommand2 = new DbCommand(oraConn, "some example instruction");
            newDbCommand2.Execute(newDbCommand2);



        }
    }
}
