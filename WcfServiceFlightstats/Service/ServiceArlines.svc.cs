using WcfServiceFlightstats.ArlinesV1SoapService;
using WcfServiceFlightstats.Service.Interface;
using WcfServiceFlightstats.AirportsV1SoapService;
using WcfServiceFlightstats.AirportSoapApiService;
using System.ServiceModel.Activation;
using System.Configuration;
using System.Xml.Serialization;
using System.Linq;

namespace WcfServiceFlightstats.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceArlines : IServiceArline
    {
        private static airlinesServiceClient _airlinesserviceClient;
        private static airportsServiceClient _airportsServiceClient;
        private static airportServiceClient  _airportServiceClientApi;
        
        private string _appId = ConfigurationManager.AppSettings["appId"];
        private string _appKey = ConfigurationManager.AppSettings["appKey"];
        private string _extendedOptions = ConfigurationManager.AppSettings["extendedOptions"];



        public airport[] ObterDescricaoAeroportosDeterminadoPais(string codigo = "BR")
        {
            return ObterAirportsServiceClient().countryCode_airports(_appId, _appKey, "BR", _extendedOptions);
        }

        public airline[] ObterTodasCompanhiasAereas()
        {
            return ObterAirlineServiceClient().allAirlines(_appId, _appKey, _extendedOptions);
        }

        public flightStatusV2[] ObterChegadasVoos(string airport = "CGH", int year = 2017, int month = 9, int day = 30, int hourOfday = 18, int numHour = 1, bool utc = false, string carrier = "", string codTtpe = "", int maxFlight = 5)
        {
            return ObterairportServiceClientApi().airportStatus_arr(_appId, _appKey, airport, year, month, day, hourOfday, false, numHour, carrier, codTtpe, maxFlight, _extendedOptions).flightStatuses;
        }

        public flightStatusV2[] ObterPartidasVoos(string airport = "CGH", int year = 2017, int month = 9, int day = 30, int hourOfday = 18, int numHour = 1, bool utc = false, string carrier = "", string codTtpe = "", int maxFlight = 5)
        {
            return ObterairportServiceClientApi().airportStatus_dep(_appId, _appKey, airport, year, month, day, hourOfday, false, numHour, carrier, codTtpe, maxFlight, _extendedOptions).flightStatuses.ToArray();
        }

        private airlinesServiceClient ObterAirlineServiceClient()
        {
            if (_airlinesserviceClient == null) return new airlinesServiceClient();
            return _airlinesserviceClient;
        }


        private airportsServiceClient ObterAirportsServiceClient()
        {
            if (_airportsServiceClient == null) return new airportsServiceClient();

            return _airportsServiceClient;
        }

        private airportServiceClient ObterairportServiceClientApi()
        {
            if (_airportServiceClientApi == null) return new airportServiceClient();

            return _airportServiceClientApi;
        }

    }
}
