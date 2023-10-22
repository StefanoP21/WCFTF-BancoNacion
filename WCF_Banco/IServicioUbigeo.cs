using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioUbigeo" in both code and config file together.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<UbigeoDC> Ubigeo_Departamentos();
        [OperationContract]
        List<UbigeoDC> Ubigeo_ProvinciasDepartamento(String strIdDep);
        [OperationContract]
        List<UbigeoDC> Ubigeo_DistritosProvinciaDepartamento(String strIdDep, String strIdProv);
    }

    [DataContract]
    [Serializable]
    public class UbigeoDC
    {
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public String IdDepa { get; set; }
        [DataMember]
        public String IdProv { get; set; }
        [DataMember]
        public String IdDist { get; set; }
        [DataMember]
        public String Departamento { get; set; }
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }
    }
}
