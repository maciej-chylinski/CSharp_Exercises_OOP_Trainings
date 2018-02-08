using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionInheritancePolymorphism
{
    class DbCommand
    {
        public DBConnection _dbConnection;
        public string _instruction;

        public DbCommand(DBConnection dbConnection, string instruction)
        {
            if (dbConnection != null)
                _dbConnection = dbConnection;
            else
                throw new InvalidOperationException("ConnectionString nie może być null");

            if ((String.IsNullOrWhiteSpace(instruction)) || (instruction == ""))
            {
                throw new InvalidOperationException("Instrukcja nie może być pusta");
            }
            else
            {
                _instruction = instruction;
            }
        }

        public void Execute(DbCommand dbCommand)
        {
            _dbConnection.open();
            Console.WriteLine("Wykonuję instrukcję: " + dbCommand._instruction);
            _dbConnection.close();
        }

        /*
            + Design a class called DbCommand for executing an instruction against the database. 
            A DbCommand cannot be in a valid state without having a connection. So in the constructor of
            this class, pass a DbConnection. Don’t forget to cater for the null.
            + Each DbCommand should also have the instruction to be sent to the database:
                - In case of SQL Server, this instruction is expressed in T-SQL language. Use a string to represent this instruction.
                - Again, a command cannot be in a valid state without this instruction. So make sure to receive it in the constructor and 
                cater for the null reference or an empty string.

           + Each command should be executable. So we need to create a method called Execute(). 
           In this method, we need a simple implementation as follows:
                - Open the connection
                - Run the instruction
                - Close the connection
            
            Note that here, inside the DbCommand, we have a reference to DbConnection. Depending on
            the type of DbConnection sent at runtime, opening and closing a connection will be different.
            For example, if we initialize this DbCommand with a SqlConnection, we will open and close a
            connection to a Sql Server database. This is polymorphism. 
            Interestingly, DbCommand doesn’t care about how a connection is opened or closed. 
            It’s not the responsibility of the DbCommand. All it cares about is to send an instruction to a database.
            For running the instruction, simply output it to the Console. 
            
            + In the main method, initialize a DbCommand with some string as the instruction and a
            SqlConnection. Execute the command and see the result on the console.
            + Then, swap the SqlConnection with an OracleConnection and see polymorphism in action.
         
         */
    }
}
