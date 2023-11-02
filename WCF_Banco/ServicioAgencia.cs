using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioAgencia" in both code and config file together.
    public class ServicioAgencia : IServicioAgencia
    {
        BancoEntities Banco = new BancoEntities();

        public List<AgenciaDC> ListarAgencia()
        {
            try
            {
                // Creamos la lista de agencias
                List<AgenciaDC> objListaAgenciaDC = new List<AgenciaDC>();

                // Creamos un query
                var query = Banco.usp_ListarAgencia();

                // Recorremos el query
                foreach (var item in query)
                {
                    AgenciaDC objAgenciaDC = new AgenciaDC();

                    objAgenciaDC.Cod_Age = item.Codigo_Agencia;
                    objAgenciaDC.Nom_Age = item.Nombre_Agencia;
                    objAgenciaDC.Dir_Age = item.Direccion_Agencia;
                    objAgenciaDC.Id_Ubigeo = item.Id_Ubigeo;

                    objListaAgenciaDC.Add(objAgenciaDC);
                }

                return objListaAgenciaDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
