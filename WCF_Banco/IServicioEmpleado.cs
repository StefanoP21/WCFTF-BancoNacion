using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioEmpleado" in both code and config file together.
    [ServiceContract]
    public interface IServicioEmpleado
    {
        [OperationContract]
        List<EmpleadoDC> ListarEmpleado();
        [OperationContract]
        EmpleadoDC ConsultarEmpleado(String strCodigo);
        [OperationContract]
        Boolean InsertarEmpleado(EmpleadoDC objEmpleado);
        [OperationContract]
        Boolean ActualizarEmpleado(EmpleadoDC objEmpleado);
        [OperationContract]
        Boolean EliminarEmpleado(String strCodigo);
    }

    [DataContract]
    [Serializable]
    public class EmpleadoDC
    {
        [DataMember]
        public String Cod_Emp { get; set; }
        [DataMember]
        public String Num_doc_Emp { get; set; }
        [DataMember]
        public Int16 Tip_doc_Emp { get; set; }
        [DataMember]
        public String Nom_Emp { get; set; }
        [DataMember]
        public String Ape_pat_Emp { get; set; }
        [DataMember]
        public String Ape_mat_Emp { get; set; }
        [DataMember]
        public String Tel_Emp { get; set; }
        [DataMember]
        public String Cor_Emp { get; set; }
        [DataMember]
        public Byte[] Img_Emp { get; set; }
        [DataMember]
        public String Id_Ubigeo { get; set; }
        [DataMember]
        public Int16 Est_Emp { get; set; }
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
