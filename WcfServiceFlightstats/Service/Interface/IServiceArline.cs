using WcfServiceFlightstats.AirportSoapApiService;
using WcfServiceFlightstats.AirportsV1SoapService;
using WcfServiceFlightstats.ArlinesV1SoapService;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;

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
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, 
        UriTemplate = "/Partidas")]
        List<flightStatusV2> ObterPartidasVoos();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, 
        UriTemplate = "/Chegadas")]
        List<flightStatusV2> ObterChegadasVoos();
        
    }

}
