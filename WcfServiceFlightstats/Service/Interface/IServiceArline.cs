using WcfServiceFlightstats.AirportSoapApiService;
using WcfServiceFlightstats.AirportsV1SoapService;
using WcfServiceFlightstats.ArlinesV1SoapService;
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Collections.Generic;

namespace WcfServiceFlightstats.Service.Interface
{
    [ServiceContract]
    public interface IServiceArline
    {
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Xml, UriTemplate = "/Companhias")]
        airline[] ObterTodasCompanhiasAereas();

        //[OperationContract]
        //[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Xml, UriTemplate = "/Aeroportos/{codigo}")]
        //airport[] ObterDescricaoAeroportosDeterminadoPais(string codigo);

        //[OperationContract]
        //[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Xml, UriTemplate = "/Partidas")]
        //responseAirportStatus ObterPartidasVoos(string airport = "CGH", int year = 2017, int month = 9, int day = 30, int hourOfday = 18, int numHour = 1, bool utc = false, string carrier = "", string codTtpe = "", int maxFlight = 5);

        //[OperationContract]
        //[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Xml, UriTemplate = "/Chegadas")]
        //responseAirportStatus ObterChegadasVoos(string airport = "CGH", int year = 2017, int month = 9, int day = 30, int hourOfday = 18, int numHour = 1, bool utc = false, string carrier = "", string codTtpe = "", int maxFlight = 5);

    }
    
}
