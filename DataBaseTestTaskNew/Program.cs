using System;
using System.Data.SqlClient;
using System.Configuration;
using MySqlConnector;
using MySql.Data.MySqlClient;

namespace DataBaseTestTaskNew
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlUnionReporting.MinmumRunningTimeForTests();
            MySqlUnionReporting.ProjectsWithUniqueTests();
            MySqlUnionReporting.TestsAfterNovember2015();
            MySqlUnionReporting.NumberOfTestsOnFirefoxAndChrome();
            Console.Read();
        }
    }
}