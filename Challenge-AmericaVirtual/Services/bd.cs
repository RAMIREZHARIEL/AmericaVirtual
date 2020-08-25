using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Challenge_AmericaVirtual.Services
{
    public class bd
    {

        public static string connectionString = "Data Source = C:/Users/Ramir/source/repos/Challenge-AmericaVirtual/bdLite.s3db";
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataReader reader;

        public SQLiteDataReader Lector
        {
            get { return reader; }
        }
        public SQLiteCommand Comando
        {
            get { return command; }
        }

        public bd()
        {
            connection = new SQLiteConnection(connectionString);
        }

        public void query(string query)
        {

            command = new SQLiteCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void openConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        public void executeConnection()
        {

            try
            {
                command.Connection = connection;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void executeQuery()
        {
            try
            {
                command.Connection = connection;
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }



}