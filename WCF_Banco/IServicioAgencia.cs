using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioAgencia" in both code and config file together.
    [ServiceContract]
    public interface IServicioAgencia
    {
        [OperationContract]
        List<AgenciaDC> ListarAgencia();
    }

    [DataContract]
    [Serializable]
    public class AgenciaDC
    {
        [DataMember]
        public String Cod_Age { get; set; }
        [DataMember]
        public String Nom_Age { get; set; }
        [DataMember]
        public String Dir_Age { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
    }
}
