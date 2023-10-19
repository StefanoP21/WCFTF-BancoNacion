using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioCliente" in both code and config file together.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        List<ClienteDC> ListarCliente();
        [OperationContract]
        ClienteDC ConsultarCliente(String strCodigo);
        [OperationContract]
        ClienteDC ConsultarClienteDNI(String strDNI);
        [OperationContract]
        Boolean InsertarCliente(ClienteDC objCliente);
        [OperationContract]
        Boolean ActualizarCliente(ClienteDC objCliente);
        [OperationContract]
        Boolean EliminarCliente(String strCodigo);
    }

    [DataContract]
    [Serializable]
    public class ClienteDC
    {
        [DataMember]
        public String Cod_Cli { get; set; }
        [DataMember]
        public String Num_doc_Cli { get; set; }
        [DataMember]
        public Int16 Tip_doc_Cli { get; set; }
        [DataMember]
        public String Nom_Cli { get; set; }
        [DataMember]
        public String Ape_pat_Cli { get; set; }
        [DataMember]
        public String Ape_mat_Cli { get; set; }
        [DataMember]
        public String Tel_Cli { get; set; }
        [DataMember]
        public String Cor_Cli { get; set; }
        [DataMember]
        public String Dir_Cli { get; set; }
        [DataMember]
        public DateTime Fec_nac_Cli { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public Int16 Est_Cli { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public DateTime Fec_Registro { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }
    }
}
