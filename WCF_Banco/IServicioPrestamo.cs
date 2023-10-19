using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioPrestamo" in both code and config file together.
    [ServiceContract]
    public interface IServicioPrestamo
    {
        [OperationContract]
        List<PrestamoDC> ListarPrestamos();
        [OperationContract]
        PrestamoDC ConsultarPrestamos();
        [OperationContract]
        Boolean InsertarPrestamo(PrestamoDC objPrestamo);
        [OperationContract]
        Boolean ActualizarPrestamo(PrestamoDC objPrestamo);
        [OperationContract]
        Boolean EliminarPrestamo(string strCodigo);
        [OperationContract]
        List<PrestamoDC> ListarPrestamosAnuales();
        [OperationContract]
        List<PrestamoDC> PrestamosCliente(String Num_doc_cli);
    }

    [DataContract]
    [Serializable]
    public class PrestamoDC
    {
        [DataMember]
        public String Cod_Pre { get; set; }
        [DataMember]
        public Single Mon_Pre { get; set; }
        [DataMember]
        public Int16 Cuot_Pre { get; set; }
        [DataMember]
        public DateTime Fec_Sol { get; set; }
        [DataMember]
        public DateTime Fec_Rech { get; set; }
        [DataMember]
        public DateTime Fec_Can { get; set; }
        [DataMember]
        public Int16 Pre_Est { get; set; }
        [DataMember]
        public Int16 Com_Deu { get; set; }
        [DataMember]
        public String Cod_Cli { get; set; }
        [DataMember]
        public String Cod_Emp { get; set; }
        [DataMember]
        public String Cod_Age { get; set; }
        [DataMember]
        public Int16 Est_Pre { get; set; }
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
