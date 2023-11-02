using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioUsuario" in both code and config file together.
    public class ServicioUsuario : IServicioUsuario
    {
        BancoEntities Banco = new BancoEntities();

        public UsuarioDC ConsultarUsuario(string strLogin)
        {
            try
            {
                // Creamos un objeto UsuarioDC
                UsuarioDC objUsuarioDC = new UsuarioDC();

                // Creamos un query
                var query = Banco.usp_ConsultarUsuario(strLogin);

                // Recorremos el query
                foreach (var item in query)
                {
                    objUsuarioDC.Login_Usuario = item.Usuario;
                    objUsuarioDC.Pass_Usuario = item.Contraseña;
                    objUsuarioDC.Niv_Usuario = Convert.ToInt16(item.Nivel);
                    objUsuarioDC.Est_Usuario = Convert.ToInt16(item.Estado);
                    objUsuarioDC.Fec_Registro = Convert.ToDateTime(item.Fecha_Registro);
                    objUsuarioDC.Usu_Registro = item.Usuario_Registro;
                }

                return objUsuarioDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
