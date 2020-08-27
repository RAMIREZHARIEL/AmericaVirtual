using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Challenge_AmericaVirtual.Models;
using Challenge_AmericaVirtual.Services;
using MySql.Data.MySqlClient;

namespace Challenge_AmericaVirtual.Services
{
    public class UserServices
    {

        public static bool InsertUser(User user)
        {
            bool returnValue;
            DataBaseAdmin DB = new DataBaseAdmin();
            try
            {
                DB.query("insert into User (mail, password) values ('" + user.mail + "','" + user.password + "')");
                DB.openConnection();
                DB.executeConnection();
                returnValue = true;
                return returnValue;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DB.closeConnection();
            }
        }

        public static User SearchUser(String mail, String password)
        {
            User user = null;
            DataBaseAdmin DB = new DataBaseAdmin();
            try
            {
                DB.query("select * from User where mail ='" + mail + "' and password='" + password + "'");
                DB.openConnection();
                DB.executeConnection();
                MySqlDataReader reader;
                reader = DB.Comando.ExecuteReader();
                while (reader.Read())
                {
                    user = new User();
                    user.mail = (String)(reader["mail"]);
                    user.password = (String)(reader["password"]);
                    user.id = Int32.Parse(reader["id"].ToString());
                }
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DB.closeConnection();
            }
        }

       
    }
}