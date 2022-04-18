using System;
using System.Data.OleDb;


namespace shoptest
{
        class Program
    {

        static bool Check(string login, string password)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Valery\Documents\shop.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString); //создание подключения к бд
            connection.Open();
            OleDbCommand command = new OleDbCommand("Select * from Logins where login='"+login+"' and pass='"+password+"'", connection);//Create command
            var n = command.ExecuteScalar();

            connection.Close();
            return (n != null);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Check("admin","admi"));
            Console.WriteLine("Hello World!");
        }
    }
}
