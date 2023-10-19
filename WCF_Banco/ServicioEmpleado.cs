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
                // con LINQ
                //var query = (from emp in MiBanco.Tb_Empleado
                //             where emp.Cod_Emp == strCodigo
                //             select emp).FirstOrDefault();

                //if (objEmpleado == null)
                //{
                //    objEmpleado.Cod_Emp = String.Empty;
                //}
                //else
                //{
                //    objEmpleado.Cod_Emp = query.Cod_Emp;
                //    objEmpleado.Num_doc_Emp = query.Num_doc_Emp;
                //    objEmpleado.Tip_doc_Emp = Convert.ToInt16(query.Tip_doc_Emp);
                //    objEmpleado.Nom_Emp = query.Nom_Emp;
                //    objEmpleado.Ape_pat_Emp = query.Ape_pat_Emp;
                //    objEmpleado.Ape_mat_Emp = query.Ape_mat_Emp;
                //    objEmpleado.Tel_Emp = query.Tel_Emp;
                //    objEmpleado.Cor_Emp = query.Cor_Emp;
                //    objEmpleado.Img_Emp = query.Img_Emp;
                //    objEmpleado.Id_Ubigeo = query.Id_Ubigeo;
                //    objEmpleado.Est_Emp = Convert.ToInt16(query.Est_Emp);
                //}

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
                    // objEmpleado.Img_Emp = resultado.Imagen;
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
            MiBanco.usp_EliminarEmpleado(strCodigo);

            MiBanco.SaveChanges();
            return true;
        }

        public Boolean InsertarEmpleado(EmpleadoDC objEmpleado)
        {
            MiBanco.usp_InsertarEmpleado(objEmpleado.Num_doc_Emp, objEmpleado.Tip_doc_Emp.ToString(), objEmpleado.Nom_Emp, objEmpleado.Ape_pat_Emp, objEmpleado.Ape_mat_Emp, objEmpleado.Tel_Emp, objEmpleado.Cor_Emp, objEmpleado.Img_Emp, objEmpleado.Id_Ubigeo, objEmpleado.Est_Emp.ToString(), objEmpleado.Usu_Registro);

            MiBanco.SaveChanges();
            return true;
        }

        public List<EmpleadoDC> ListarEmpleado()
        {
            try
            {
                List<EmpleadoDC> objEmpleado = new List<EmpleadoDC>();
                // con LINQ
                var query = (from emp in MiBanco.Tb_Empleado
                             orderby emp.Cod_Emp 
                             select emp).ToList();

                foreach (var resultado in query)
                {
                    EmpleadoDC objEmpleadoDC = new EmpleadoDC();
                    objEmpleadoDC.Cod_Emp = resultado.Cod_Emp;
                    objEmpleadoDC.Num_doc_Emp = resultado.Num_doc_Emp;
                    objEmpleadoDC.Tip_doc_Emp = Convert.ToInt16(resultado.Tip_doc_Emp);
                    objEmpleadoDC.Nom_Emp = resultado.Nom_Emp;
                    objEmpleadoDC.Ape_pat_Emp = resultado.Ape_pat_Emp;
                    objEmpleadoDC.Ape_mat_Emp = resultado.Ape_mat_Emp;
                    objEmpleadoDC.Tel_Emp = resultado.Tel_Emp;
                    objEmpleadoDC.Cor_Emp = resultado.Cor_Emp;
                    // objEmpleadoDC.Img_Emp = resultado.Img_Emp;
                    objEmpleadoDC.Id_Ubigeo = resultado.Id_Ubigeo;
                    objEmpleadoDC.Est_Emp = Convert.ToInt16(resultado.Est_Emp);
                    objEmpleadoDC.Usu_Registro = resultado.Usu_Registro;
                    objEmpleadoDC.Fec_Registro = Convert.ToDateTime(resultado.Fec_Registro);
                    objEmpleadoDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;
                    objEmpleadoDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);

                    objEmpleado.Add(objEmpleadoDC);
                }

                //var query = MiBanco.usp_ListarEmpleado().ToList();

                //foreach (var resultado in query)
                //{
                //    EmpleadoDC objEmpleadoDC = new EmpleadoDC();

                //    objEmpleadoDC.Cod_Emp = resultado.Codigo;
                //    objEmpleadoDC.Num_doc_Emp = resultado.Numero_Documento;
                //    objEmpleadoDC.Tip_doc_Emp = Convert.ToInt16(resultado.Tip_doc_Emp);
                //    objEmpleadoDC.Nom_Emp = resultado.Nombre;
                //    objEmpleadoDC.Ape_pat_Emp = resultado.Apellido_Paterno;
                //    objEmpleadoDC.Ape_mat_Emp = resultado.Apellido_Materno;
                //    objEmpleadoDC.Tel_Emp = resultado.Telefono;
                //    objEmpleadoDC.Cor_Emp = resultado.Correo;
                //    // objEmpleadoDC.Img_Emp = resultado.Imagen;
                //    objEmpleadoDC.Id_Ubigeo = resultado.Id_Ubigeo;
                //    objEmpleadoDC.Est_Emp = Convert.ToInt16(resultado.Est_Emp);
                //    objEmpleadoDC.Usu_Registro = resultado.Usu_Registro;
                //    objEmpleadoDC.Fec_Registro = Convert.ToDateTime(resultado.Fec_Registro);
                //    objEmpleadoDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;
                //    objEmpleadoDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);

                //    objEmpleado.Add(objEmpleadoDC);
                //}

                return objEmpleado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }
    }
}
