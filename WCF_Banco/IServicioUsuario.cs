using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioUsuario" in both code and config file together.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        UsuarioDC ConsultarUsuario(String strLogin);
    }

    [DataContract]
    [Serializable]
    public class UsuarioDC
    {
        [DataMember]
        public String Login_Usuario { get; set; }
        [DataMember]
        public String Pass_Usuario { get; set; }
        [DataMember]
        public Int16 Niv_Usuario { get; set; }
        [DataMember]
        public Int16 Est_Usuario { get; set; }
        [DataMember]
        public DateTime Fec_Registro { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
    }
}
