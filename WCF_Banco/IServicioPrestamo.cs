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
        List<PrestamoDC> ListarPrestamos_Cli_Emp(String cod_Cli, String cod_Emp);

        [OperationContract]
        List<PrestamoDC> ListarPrestamosClienteFechas(String strCodigo, DateTime fecIni, DateTime fecFin);
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
        public DateTime? Fec_Rech { get; set; }
        [DataMember]
        public DateTime? Fec_Can { get; set; }
        [DataMember]
        public String Cod_Cli { get; set; }
        [DataMember]
        public String Cod_Emp { get; set; }
        [DataMember]
        public String Cod_Age { get; set; }

        //nuevos
        [DataMember]
        public String Nom_cli { get; set; }

        [DataMember]
        public String Nom_emp { get; set; }

        [DataMember]
        public String Nom_age { get; set; }

        [DataMember]
        public String PrestamoEstudio { get; set; }

        [DataMember]
        public String CompraDeuda { get; set; }

        [DataMember]
        public String EstadoPrestamo { get; set; }
    }
}
