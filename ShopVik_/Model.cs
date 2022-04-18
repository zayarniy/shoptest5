using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ShopVik
{
    class Model
    {
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\shop.accdb";
        public static bool Check(string login, string password)
        {
            OleDbConnection connection = new OleDbConnection(connectionString); //создание подключения к бд
            connection.Open();
            OleDbCommand command = new OleDbCommand("Select * from Accounts where login='" + login + "' and pass='" + password + "'", connection);//Create command
            var n = command.ExecuteScalar();

            connection.Close();
            return (n != null);
        }

        public static string Registration(string login, string password,string firstName,string lastName,string phone,string email,string city)
        {

            OleDbConnection connection = new OleDbConnection(connectionString); //создание подключения к бд
            connection.Open();
            OleDbCommand command = new OleDbCommand("Select * from Accounts where login='" + login + "'", connection);//Create command
            var n = command.ExecuteScalar();
            if (n != null) return "Пользователь " + login + " уже существует";
            string query = @"Insert into Accounts (login, pass, firstname, lastname, phonenumber, email, city) values ('" + login + "','" + password + "','" + firstName + "','" + lastName + "','" + phone + "','" + email + "','" + city + "')";
            System.Diagnostics.Debug.WriteLine(query);
            command = new OleDbCommand(query, connection);//Create command
            n = command.ExecuteNonQuery();
            connection.Close();
            return "Пользователь " + login + " добавлен";
        }



    }
}
