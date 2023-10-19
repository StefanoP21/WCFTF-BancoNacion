using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioCliente" in both code and config file together.
    public class ServicioCliente : IServicioCliente
    {
        public bool ActualizarCliente(ClienteDC objCliente)
        {
            throw new NotImplementedException();
        }

        public ClienteDC ConsultarCliente(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public ClienteDC ConsultarClienteDNI(string strDNI)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCliente(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public bool InsertarCliente(ClienteDC objCliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteDC> ListarCliente()
        {
            throw new NotImplementedException();
        }
    }
}
