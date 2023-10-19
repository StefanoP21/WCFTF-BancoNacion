using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioCuenta" in both code and config file together.
    [ServiceContract]
    public interface IServicioCuenta
    {
        [OperationContract]
        List<CuentaDC> ListarCuenta();
        [OperationContract]
        CuentaDC ConsultarCuenta(String strCodigo);
        [OperationContract]
        Boolean InsertarCuenta(CuentaDC objCuenta);
        [OperationContract]
        Boolean ActualizarCuenta(CuentaDC objCuentaDC);
        [OperationContract]
        Boolean EliminarCuenta(String strCodigo);
    }

    [DataContract]
    [Serializable]
    public class CuentaDC
    {
        [DataMember]
        public String Num_Cuen { get; set; }
        [DataMember]
        public Int16 Tip_Mon { get; set; }
        [DataMember]
        public Single Sal_Cuen { get; set; }
        [DataMember]
        public Int16 Tipo { get; set; }
        [DataMember]
        public DateTime Fec_Aper { get; set; }
        [DataMember]
        public String Cod_Cli { get; set; }
        [DataMember]
        public String Cod_Age { get; set; }
        [DataMember]
        public Int16 Est_Cuen { get; set; }
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
