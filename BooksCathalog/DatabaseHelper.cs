using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksCathalog
{
    internal class DatabaseHelper
    {
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqliteConn;
            sqliteConn = new SQLiteConnection("Data Source=C:/MyData/Repos/IT/Project-BooksCathalog_Csharp/BooksCathalog/Cathalog.db; Version = 3;");
            try
            {
                sqliteConn.Open();
                Console.WriteLine("Database open");
            }
            catch
            {

            }
            return sqliteConn;
        }

        public static void InsertAuthor(SQLiteConnection conn)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "INSERT INTO Authors (col) VALUES ('Sample Text') ";
            sqliteCommand.ExecuteNonQuery();
        }

        public static void ReadAuthors(SQLiteConnection conn)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "SELECT * FROM Authors;";
            sqliteReader= sqliteCommand.ExecuteReader();
            while (sqliteReader.Read())
            {
                int id = sqliteReader.GetInt32(sqliteReader.GetOrdinal("id"));
                string readerString = sqliteReader.GetString(sqliteReader.GetOrdinal("Name"));
                Console.WriteLine($"ID: {id}, Name: {readerString}");
            }

        }

    }
}
