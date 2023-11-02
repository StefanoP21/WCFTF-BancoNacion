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
        BancoEntities Banco = new BancoEntities();

        public List<ClienteDC> ListarCliente()
        {
            try
            {
                // Creamos la lista de clientes
                List<ClienteDC> objListaClienteDC = new List<ClienteDC>();

                // Creamos un query
                var query = Banco.usp_ListarCliente();

                // Recorremos el query
                foreach (var item in query)
                {
                    ClienteDC objClienteDC = new ClienteDC();

                    objClienteDC.Cod_Cli = item.Codigo;
                    objClienteDC.Num_doc_Cli = item.Numero_Documento;
                    objClienteDC.Tip_doc_Cli = Convert.ToInt16(item.Tip_doc_Cli);
                    objClienteDC.Tipo_Documento = item.Tipo_Documento;
                    objClienteDC.Nom_Cli = item.Nombre;
                    objClienteDC.Ape_pat_Cli = item.Apellido_Paterno;
                    objClienteDC.Ape_mat_Cli = item.Apellido_Materno;
                    objClienteDC.Edad = Convert.ToInt16(item.Edad);
                    objClienteDC.Tel_Cli = item.Telefono;
                    objClienteDC.Cor_Cli = item.Correo;
                    objClienteDC.Dir_Cli = item.Direccion;
                    objClienteDC.Fec_nac_Cli = Convert.ToDateTime(item.Fecha_Nacimiento);
                    objClienteDC.Id_Ubigeo = item.Id_Ubigeo;
                    objClienteDC.Departamento = item.Departamento;
                    objClienteDC.Provincia = item.Provincia;
                    objClienteDC.Distrito = item.Distrito;
                    objClienteDC.Est_Cli = Convert.ToInt16(item.Est_Cli);
                    objClienteDC.Estado = item.Estado;
                    objClienteDC.Usu_Registro = item.Usu_Registro;
                    objClienteDC.Fec_Registro = Convert.ToDateTime(item.Fec_Registro);
                    objClienteDC.Usu_Ult_Mod = item.Usu_Ult_Mod;
                    objClienteDC.Fec_Ult_Mod = Convert.ToDateTime(item.Fec_Ult_Mod);

                    objListaClienteDC.Add(objClienteDC);
                }

                return objListaClienteDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteDC ConsultarCliente(string strCodigo)
        {
            try
            {
                // Creamos un objeto ClienteDC
                ClienteDC objClienteDC = new ClienteDC();

                // Creamos un query
                var query = Banco.usp_ConsultarCliente(strCodigo);

                // Recorremos el query
                foreach (var item in query)
                {
                    objClienteDC.Cod_Cli = item.Codigo;
                    objClienteDC.Num_doc_Cli = item.Numero_Documento;
                    objClienteDC.Tip_doc_Cli = Convert.ToInt16(item.Tip_doc_Cli);
                    objClienteDC.Nom_Cli = item.Nombre;
                    objClienteDC.Ape_pat_Cli = item.Apellido_Paterno;
                    objClienteDC.Ape_mat_Cli = item.Apellido_Materno;
                    objClienteDC.Tel_Cli = item.Telefono;
                    objClienteDC.Cor_Cli = item.Correo;
                    objClienteDC.Dir_Cli = item.Direccion;
                    objClienteDC.Fec_nac_Cli = Convert.ToDateTime(item.Fecha_Nacimiento);
                    objClienteDC.Id_Ubigeo = item.Id_Ubigeo;
                    objClienteDC.Est_Cli = Convert.ToInt16(item.Est_Cli);
                }

                return objClienteDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteDC ConsultarClienteDNI(string strDNI)
        {
            try
            {
                // Creamos un objeto ClienteDC
                ClienteDC objClienteDC = new ClienteDC();

                // Creamos un query
                var query = Banco.usp_ConsultarClienteDNI(strDNI);

                // Recorremos el query
                foreach (var item in query)
                {
                    objClienteDC.Cod_Cli = item.Codigo;
                    objClienteDC.Num_doc_Cli = item.Numero_Documento;
                    objClienteDC.Tip_doc_Cli = Convert.ToInt16(item.Tip_doc_Cli);
                    objClienteDC.Nom_Cli = item.Nombre;
                    objClienteDC.Ape_pat_Cli = item.Apellido_Paterno;
                    objClienteDC.Ape_mat_Cli = item.Apellido_Materno;
                    objClienteDC.Tel_Cli = item.Telefono;
                    objClienteDC.Cor_Cli = item.Correo;
                    objClienteDC.Dir_Cli = item.Direccion;
                    objClienteDC.Fec_nac_Cli = Convert.ToDateTime(item.Fecha_Nacimiento);
                    objClienteDC.Id_Ubigeo = item.Id_Ubigeo;
                    objClienteDC.Est_Cli = Convert.ToInt16(item.Est_Cli);
                }

                return objClienteDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool InsertarCliente(ClienteDC objClienteDC)
        {
            try
            {
                Banco.usp_InsertarCliente(
                    objClienteDC.Num_doc_Cli,
                    Convert.ToString(objClienteDC.Tip_doc_Cli),
                    objClienteDC.Nom_Cli,
                    objClienteDC.Ape_pat_Cli,
                    objClienteDC.Ape_mat_Cli,
                    objClienteDC.Tel_Cli,
                    objClienteDC.Cor_Cli,
                    objClienteDC.Dir_Cli,
                    objClienteDC.Fec_nac_Cli,
                    objClienteDC.Id_Ubigeo,
                    Convert.ToString(objClienteDC.Est_Cli),
                    objClienteDC.Usu_Registro
                    );

                // Actualizamos el modelo
                Banco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ActualizarCliente(ClienteDC objClienteDC)
        {
            try
            {
                Banco.usp_ActualizarCliente(
                    objClienteDC.Cod_Cli,
                    objClienteDC.Num_doc_Cli,
                    Convert.ToString(objClienteDC.Tip_doc_Cli),
                    objClienteDC.Nom_Cli,
                    objClienteDC.Ape_pat_Cli,
                    objClienteDC.Ape_mat_Cli,
                    objClienteDC.Tel_Cli,
                    objClienteDC.Cor_Cli,
                    objClienteDC.Dir_Cli,
                    objClienteDC.Fec_nac_Cli,
                    objClienteDC.Id_Ubigeo,
                    Convert.ToString(objClienteDC.Est_Cli),
                    objClienteDC.Usu_Ult_Mod
                    );

                // Actualizamos el modelo
                Banco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarCliente(string strCodigo)
        {
            try
            {
                Banco.usp_EliminarCliente(strCodigo);

                // Actualizamos el modelo
                Banco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
