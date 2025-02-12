using System;

namespace DbConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand command;

            while (true)
            {
                Console.Write("Enter a DB to connect to: ");
                var input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "sql":
                        command = new DbCommand(new SqlConnect("SQL"), "Sending SQL intructions to DB.");
                        command.Execute();
                        break;
                    case "oracle":
                        command = new DbCommand(new OracleConnect("ORACLE"), "Sending ORACLE intructions to DB.");
                        command.Execute();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Please enter a valid DB...");
                        break;
                }
                
            }
        }
    }

    public class DbCommand
    {
        private string _instructions { get; set; }
        private readonly DbConnect DbConnect;
        public DbCommand(DbConnect dbConnect, string instructText)
        {
            DbConnect = dbConnect;
            _instructions = instructText;
        }

        public void Execute()
        {
            DbConnect.OpenConnection();
            Console.WriteLine(_instructions);
            DbConnect.CloseConnection();
        }
    }

    public abstract class DbConnect
    {
        public string ConnectionString;
        protected bool IsConnected;

        public DbConnect(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new NullReferenceException("Need Connection Type...");
            }

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SqlConnect : DbConnect
    {
        public SqlConnect(string connectionString)
            : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL Connected");
            IsConnected = true;
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL Closed");
            IsConnected = false;
        }

    }

    public class OracleConnect : DbConnect
    {
        public OracleConnect(string connectionString)
            : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("ORACLE Connected");
            IsConnected = true;
        }

        public override void CloseConnection()
        {
            Console.WriteLine("ORACLE Closed");
            IsConnected = false;
        }

    }

}
