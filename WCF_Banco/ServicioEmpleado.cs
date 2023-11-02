using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioEmpleado" in both code and config file together.
    public class ServicioEmpleado : IServicioEmpleado
    {
        BancoEntities MiBanco = new BancoEntities();

        public Boolean ActualizarEmpleado(EmpleadoDC objEmpleado)
        {
            try
            {
                MiBanco.usp_ActualizarEmpleado(objEmpleado.Cod_Emp, objEmpleado.Num_doc_Emp, objEmpleado.Tip_doc_Emp.ToString(), objEmpleado.Nom_Emp, objEmpleado.Ape_pat_Emp, objEmpleado.Ape_mat_Emp, objEmpleado.Tel_Emp, objEmpleado.Cor_Emp, objEmpleado.Img_Emp, objEmpleado.Id_Ubigeo, objEmpleado.Est_Emp.ToString(), objEmpleado.Usu_Ult_Mod);

                MiBanco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EmpleadoDC ConsultarEmpleado(string strCodigo)
        {
            try
            {
                EmpleadoDC objEmpleado = new EmpleadoDC();

                var query = MiBanco.usp_ConsultarEmpleado(strCodigo);

                foreach (var resultado in query)
                {
                    objEmpleado.Cod_Emp = resultado.Codigo;
                    objEmpleado.Num_doc_Emp = resultado.Numero_Documento;
                    objEmpleado.Tip_doc_Emp = Convert.ToInt16(resultado.Tip_doc_Emp);
                    objEmpleado.Nom_Emp = resultado.Nombre;
                    objEmpleado.Ape_pat_Emp = resultado.Apellido_Paterno;
                    objEmpleado.Ape_mat_Emp = resultado.Apellido_Materno;
                    objEmpleado.Tel_Emp = resultado.Telefono;
                    objEmpleado.Cor_Emp = resultado.Correo;
                    objEmpleado.Img_Emp = resultado.Imagen;
                    objEmpleado.Id_Ubigeo = resultado.Id_Ubigeo;
                    objEmpleado.Est_Emp = Convert.ToInt16(resultado.Est_Emp);
                }

                return objEmpleado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarEmpleado(string strCodigo)
        {
            try
            {
                MiBanco.usp_EliminarEmpleado(strCodigo);

                MiBanco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarEmpleado(EmpleadoDC objEmpleado)
        {
            try
            {
                MiBanco.usp_InsertarEmpleado(objEmpleado.Num_doc_Emp, objEmpleado.Tip_doc_Emp.ToString(), objEmpleado.Nom_Emp, objEmpleado.Ape_pat_Emp, objEmpleado.Ape_mat_Emp, objEmpleado.Tel_Emp, objEmpleado.Cor_Emp, objEmpleado.Img_Emp, objEmpleado.Id_Ubigeo, objEmpleado.Est_Emp.ToString(), objEmpleado.Usu_Registro);

                MiBanco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmpleadoDC> ListarEmpleado()
        {
            try
            {
                List<EmpleadoDC> objEmpleado = new List<EmpleadoDC>();

                var query = MiBanco.usp_ListarEmpleado();

                foreach (var resultado in query)
                {
                    EmpleadoDC objEmpleadoDC = new EmpleadoDC();
                    objEmpleadoDC.Cod_Emp = resultado.Codigo;
                    objEmpleadoDC.Num_doc_Emp = resultado.Numero_Documento;
                    objEmpleadoDC.Tip_doc_Emp = Convert.ToInt16(resultado.Tip_doc_Emp);
                    objEmpleadoDC.Tipo_Documento = resultado.Tipo_Documento;
                    objEmpleadoDC.Nom_Emp = resultado.Nombre;
                    objEmpleadoDC.Ape_pat_Emp = resultado.Apellido_Paterno;
                    objEmpleadoDC.Ape_mat_Emp = resultado.Apellido_Materno;
                    objEmpleadoDC.Tel_Emp = resultado.Telefono;
                    objEmpleadoDC.Cor_Emp = resultado.Correo;
                    objEmpleadoDC.Img_Emp = resultado.Imagen;
                    objEmpleadoDC.Id_Ubigeo = resultado.Id_Ubigeo;
                    objEmpleadoDC.Departamento = resultado.Departamento;
                    objEmpleadoDC.Provincia = resultado.Provincia;
                    objEmpleadoDC.Distrito = resultado.Distrito;
                    objEmpleadoDC.Est_Emp = Convert.ToInt16(resultado.Est_Emp);
                    objEmpleadoDC.Estado = resultado.Estado;
                    objEmpleadoDC.Usu_Registro = resultado.Usu_Registro;
                    objEmpleadoDC.Fec_Registro = Convert.ToDateTime(resultado.Fec_Registro);
                    objEmpleadoDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;
                    objEmpleadoDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);

                    objEmpleado.Add(objEmpleadoDC);
                }

                return objEmpleado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
