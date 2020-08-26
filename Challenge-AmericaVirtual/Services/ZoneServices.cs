using Challenge_AmericaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Net;

namespace Challenge_AmericaVirtual.Services
{
    public class ZoneServices
    {
        public static Forecast SearchWeather(String Country, int City)
        {
            
            var url = "http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=a86bcaa9eaa1e45dbd7db3679c52e59d";
            WebClient webClient = new WebClient();
            var dates = webClient.DownloadString(url);
            var rs = JsonConvert.DeserializeObject<Forecast.Result>(dates);
            float humidity  = rs.main.humidity;
            
            
            
            return new Forecast();
        }

        public static List<City> CityList(String country)
        {
            DataBaseAdmin dataBase = new DataBaseAdmin();
            List<City> ListReturn = new List<City>();
            City city;
            try
            {
                dataBase.query("Select CiudadID, CiudadNombre from Ciudad where PaisCodigo='"+country+"'");
                dataBase.openConnection();
                dataBase.executeConnection();
                MySqlDataReader reader;
                reader = dataBase.Comando.ExecuteReader();
                while (reader.Read())
                {
                    city = new City();
                    city.countryCode = country;
                    city.name = (String)(reader["CiudadNombre"]);
                    city.id = int.Parse(reader["CiudadID"].ToString());
                    ListReturn.Add(city);
                }
                return ListReturn;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataBase.closeConnection();
            }

        }

        public static List<Country> CountryList ()
        {
            DataBaseAdmin dataBase = new DataBaseAdmin();
            List<Country> ListReturn= new List<Country>();
            Country country;
            try
            {
                dataBase.query("Select PaisCodigo, PaisNombre from Pais");
                dataBase.openConnection();
                dataBase.executeConnection();
                MySqlDataReader reader;
                reader = dataBase.Comando.ExecuteReader();
                while (reader.Read())
                {
                    country = new Country();
                    country.code = (String)(reader["PaisCodigo"]);
                    country.name = (String)(reader["PaisNombre"]);
                    ListReturn.Add(country);
                }
                return ListReturn;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataBase.closeConnection();
            }

        }

    }
}