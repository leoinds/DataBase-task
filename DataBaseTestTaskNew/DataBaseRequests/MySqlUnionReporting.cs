using System;
using MySql.Data.MySqlClient;
using System.IO;

namespace DataBaseTestTaskNew
{
    static class MySqlUnionReporting
    {
        public static void MinmumRunningTimeForTests()
        {
            MySqlConnection connection = new MySqlConnection(MySqlUtil.GetBuilder().ToString());
            string path = Environment.CurrentDirectory+@"/Resources/MinmumRunningTimeForTests.txt";
            StreamWriter myFile = new StreamWriter(path);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
                string sql = "SELECT t.name, min(end_time - start_time) FROM test t join project p on p.id = t.project_id group by t.name order by p.name, t.name";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) //возвр. логическое значение true до тех пор пока есть что читать (строки столбцы)
                {
                    myFile.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
                reader.Close();
                myFile.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine($"Файл сохранен в {path} \n Подключение закрыто...");
            }

        }
        public static void ProjectsWithUniqueTests()
        {
            MySqlConnection connection = new MySqlConnection(MySqlUtil.GetBuilder().ToString());
            string path = Environment.CurrentDirectory + @"/Resources/ProjectsWithUniqueTests.txt";
            StreamWriter myFile = new StreamWriter(path);
            try
            {
                connection.Open();
                Console.WriteLine("Подключение открыто");
                string sql = "select p.name, count(distinct t.name) from project p join test t on t.project_id = p.id group by p.name";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    myFile.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
                reader.Close();
                myFile.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine($"Файл сохранен в {path} \n Подключение закрыто...");
            }
        }
        public static void TestsAfterNovember2015()
        {
            MySqlConnection connection = new MySqlConnection(MySqlUtil.GetBuilder().ToString());
            string path = Environment.CurrentDirectory + @"/Resources/TestsAfterNovember2015.txt";
            StreamWriter myFile = new StreamWriter(path);
            try
            {
                connection.Open();
                Console.WriteLine("Подключение открыто");
                string sql = "select p.name, t.name, start_time from project p join test t on t.project_id = p.id where start_time >= '2015-11-07' order by p.name, t.name";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    myFile.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
                reader.Close();
                myFile.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine($"Файл сохранен в {path} \n Подключение закрыто...");
            }
        }
        public static void NumberOfTestsOnFirefoxAndChrome()
        {
            MySqlConnection connection = new MySqlConnection(MySqlUtil.GetBuilder().ToString());
            string path = Environment.CurrentDirectory + @"/Resources/NumberOfTestsOnFirefoxAndChrome.txt";
            StreamWriter myFile = new StreamWriter(path);
            try
            {
                connection.Open();
                Console.WriteLine("Подключение открыто");
                string sql = "select count(*) from (select * from test where browser = 'Chrome' union select * from test where browser = 'Firefox') as cnt";
                MySqlCommand command = new MySqlCommand(sql, connection);
                string countOfTestsOnFirefoxAndChrome = command.ExecuteScalar().ToString(); //специально заюзал ExecuteScalar т.к. тут только один столбец одно поле
                myFile.WriteLine(countOfTestsOnFirefoxAndChrome);
                myFile.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine($"Файл сохранен в {path} \n Подключение закрыто...");
            }
        }
    }
}
