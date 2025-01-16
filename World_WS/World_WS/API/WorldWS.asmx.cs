using World_WS.DB;
using World_WS.Entities;
using System.Collections.Generic;
using System.Web.Services;

namespace World_WS.API
    {
    /// <summary>
    /// Summary description for WorldWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WorldWS : WebService
        {

        [WebMethod]
        public List<City> GetAllCities()
            {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.GetAllCities();
            }

        [WebMethod]
        public Country GetCountryByCode(string code)
            {
            CountryRepository countryRepository = new CountryRepository();
            return countryRepository.GetCountryByCode(code);
            }

        [WebMethod]
        public City GetCityByName(string name)
            {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.GetCityByName(name);
            }

        [WebMethod]
        public List<City> GetCitiesFromCountry(string countryName)
            {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.GetCitiesFromCountry(countryName);
            }
        }
    }
