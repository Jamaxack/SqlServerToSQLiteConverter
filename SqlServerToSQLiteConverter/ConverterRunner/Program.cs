using System;
using System.Collections.Generic;

namespace ConverterRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlConnString = @"Data Source=localhost;Initial Catalog=Demo;Integrated Security=SSPI;";
            string sqlitePath = "C:/Demo.sqlite";
            string password = null;
            var excludedTables = new List<string>() { "TableNameThatShouldNotBeInSQLIte" };
            SqlServerToSQLiteConverter.SqlServerToSQLite.Process(sqlConnString, sqlitePath, password, false, false, excludedTables);
        }
    }
}
