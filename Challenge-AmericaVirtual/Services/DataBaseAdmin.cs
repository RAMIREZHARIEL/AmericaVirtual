using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Challenge_AmericaVirtual.Services
{
    public class DataBaseAdmin
    {
        public static string connectionString = "server=127.0.0.1;uid=root;pwd=ROOT;database=americavirtual";

        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public MySqlDataReader Lector
        {
            get { return reader; }
        }
        public MySqlCommand Comando
        {
            get { return command; }
        }

        public DataBaseAdmin()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void query(string query)
        {

            command = new MySqlCommand();
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