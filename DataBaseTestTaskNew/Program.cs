using System;

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