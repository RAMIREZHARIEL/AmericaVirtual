using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Challenge_AmericaVirtual.Models;
using Challenge_AmericaVirtual.Services;
using System.Data.SQLite;

namespace Challenge_AmericaVirtual.Services
{
    public class UserServices
    {
        public static bool InsertUser(User user)
        {
            bool returnValue = false;
            bd BD = new bd();
            try
            {
                BD.query("insert into User (mail, password) values ('"+user.mail+"','"+user.password+"')");
                BD.openConnection();
                BD.executeConnection();
                returnValue = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                BD.closeConnection();
            }

            return returnValue; 
        }

        public static User SearchUser (String mail, String password )
        {
                User user = null;
                bd BD = new bd();
            try
            {
                BD.query("select * from User where mail ='"+mail+"' and password='"+password+"'");
                BD.openConnection();
                BD.executeConnection();
                SQLiteDataReader reader;
                reader = BD.Comando.ExecuteReader();
                while(reader.Read())
                {
                    user = new User();
                    user.mail = (String)(reader["mail"]);
                    user.password = (String)(reader["password"]);
                    user.id =  Int32.Parse(reader["id"].ToString());

                }

                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                BD.closeConnection();
            }


        }

    }
}