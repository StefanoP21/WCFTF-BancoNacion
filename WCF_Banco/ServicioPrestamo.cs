using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioPrestamo" in both code and config file together.
    public class ServicioPrestamo : IServicioPrestamo
    {
        public bool ActualizarPrestamo(PrestamoDC objPrestamo)
        {
            throw new NotImplementedException();
        }

        public PrestamoDC ConsultarPrestamos()
        {
            throw new NotImplementedException();
        }

        public bool EliminarPrestamo(string strCodigo)
        {
            throw new NotImplementedException();
        }

        public bool InsertarPrestamo(PrestamoDC objPrestamo)
        {
            throw new NotImplementedException();
        }

        public List<PrestamoDC> ListarPrestamos()
        {
            throw new NotImplementedException();
        }

        public List<PrestamoDC> ListarPrestamosAnuales()
        {
            throw new NotImplementedException();
        }

        public List<PrestamoDC> PrestamosCliente(string Num_doc_cli)
        {
            throw new NotImplementedException();
        }
    }
}
