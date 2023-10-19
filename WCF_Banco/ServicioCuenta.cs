using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioCuenta" in both code and config file together.
    public class ServicioCuenta : IServicioCuenta
    {
        public bool ActualizarCuenta(CuentaDC objCuentaDC)
        {
            throw new NotImplementedException();
        }

        public CuentaDC ConsultarCuenta(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCuenta(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public bool InsertarCuenta(CuentaDC objCuenta)
        {
            throw new NotImplementedException();
        }

        public List<CuentaDC> ListarCuenta()
        {
            throw new NotImplementedException();
        }
    }
}
