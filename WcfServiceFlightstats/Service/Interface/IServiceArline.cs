using WcfServiceFlightstats.AirportSoapApiService;
using WcfServiceFlightstats.AirportsV1SoapService;
using WcfServiceFlightstats.ArlinesV1SoapService;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System;

namespace WcfServiceFlightstats.Service.Interface
{
    [ServiceContract]
    public interface IServiceArline
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Companhias")]
        airline[] ObterTodasCompanhiasAereas();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/Aeroportos/{codigo}")]
        airport[] ObterDescricaoAeroportosDeterminadoPais(string codigo);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/Partidas")]
        flightStatusV2[] ObterPartidasVoos(string airport = "CGH", int year = 2017, int month = 9, int day = 30, int hourOfday = 18, int numHour = 1, bool utc = false, string carrier = "", string codTtpe = "", int maxFlight = 5);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/Chegadas")]
        flightStatusV2[] ObterChegadasVoos(string airport = "CGH", int year = 2017, int month = 9, int day = 30, int hourOfday = 18, int numHour = 1, bool utc = false, string carrier = "", string codTtpe = "", int maxFlight = 5);

    }
    
}
