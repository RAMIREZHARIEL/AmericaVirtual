using Challenge_AmericaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace Challenge_AmericaVirtual.Services
{
    public class ZoneServices
    {
        public static Forecast.Result SearchWeather(String city)
        {

            try
            {
                var Coords = SearchCoord(city);

                var Forecast = SearchForecast(Coords);

                return Forecast;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static  Forecast.Result SearchForecast(City.Result city)
        {
            var urlForecast = "http://api.openweathermap.org/data/2.5/onecall?lat=" + city.coord.lat + "&lon=" + city.coord.lon + "&exclude=minutely,hourly&APPID=a86bcaa9eaa1e45dbd7db3679c52e59d&units=metric";
            WebClient webClient = new WebClient();
            var dates = webClient.DownloadString(urlForecast);
            var Forecast = JsonConvert.DeserializeObject<Forecast.Result>(dates);
            return Forecast;
        }

        private static City.Result SearchCoord(string city)
        {
            var urlCoord = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&APPID=a86bcaa9eaa1e45dbd7db3679c52e59d&units=metric";
            WebClient webClient = new WebClient();
            var dates = webClient.DownloadString(urlCoord);
            var CityCoord = JsonConvert.DeserializeObject<City.Result>(dates);
            return CityCoord;
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