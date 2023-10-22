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
        BancoEntities MiBanco = new BancoEntities();
        public bool ActualizarCuenta(CuentaDC objCuentaDC)
        {
            try
            {
                MiBanco.usp_ActualizarCuenta(objCuentaDC.Num_Cuen, objCuentaDC.Tip_Mon.ToString(), Convert.ToInt16(objCuentaDC.Sal_Cuen), objCuentaDC.Tipo.ToString(), objCuentaDC.Cod_Cli, objCuentaDC.Cod_Age, objCuentaDC.Est_Cuen.ToString(), objCuentaDC.Usu_Ult_Mod);

                MiBanco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CuentaDC ConsultarCuenta(string strCodigo)
        {
            try
            {
                CuentaDC objCuenta = new CuentaDC();

                var query = MiBanco.usp_ConsultarCuenta(strCodigo);

                foreach (var resultado in query)
                {
                    objCuenta.Num_Cuen = resultado.Numero_Cuenta;
                    objCuenta.Tip_Mon = Convert.ToInt16(resultado.Tip_Mon);
                    objCuenta.Sal_Cuen = Convert.ToSingle(resultado.Saldo_Cuenta);
                    objCuenta.Tipo = Convert.ToInt16(resultado.Tipo);
                    objCuenta.Fec_Aper = Convert.ToDateTime(resultado.Fecha_Apertura);
                    objCuenta.Cod_Cli = resultado.Codigo_Cliente;
                    objCuenta.Cod_Age = resultado.Codigo_Agencia;
                    objCuenta.Est_Cuen = Convert.ToInt16(resultado.Est_Cuen);
                }

                return objCuenta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarCuenta(string strCodigo)
        {
            try
            {
                MiBanco.usp_EliminarCuenta(strCodigo);

                MiBanco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool InsertarCuenta(CuentaDC objCuenta)
        {
            try
            {
                MiBanco.usp_InsertarCuenta(objCuenta.Tip_Mon.ToString(), Convert.ToInt16(objCuenta.Sal_Cuen), objCuenta.Tipo.ToString(), objCuenta.Fec_Aper, objCuenta.Cod_Cli, objCuenta.Cod_Age, objCuenta.Est_Cuen.ToString(), objCuenta.Usu_Registro);

                MiBanco.SaveChanges();

                return true;    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CuentaDC> ListarCuenta()
        {
            try
            {
                List<CuentaDC> objCuenta = new List<CuentaDC>();

                var query = MiBanco.usp_ListarCuenta();

                foreach (var resultado in query)
                {
                    CuentaDC objCuentaDC = new CuentaDC();

                    objCuentaDC.Num_Cuen = resultado.Numero_Cuenta;
                    objCuentaDC.Nom_Cli = resultado.Nombre_Cliente;
                    objCuentaDC.Ape_Pat_Cli = resultado.Apellido_Paterno;
                    objCuentaDC.Ape_Mat_Cli = resultado.Apellido_Materno;
                    objCuentaDC.Tip_Mon = Convert.ToInt16(resultado.Tip_Mon);
                    objCuentaDC.Tipo_Moneda = resultado.Tipo_Moneda;
                    objCuentaDC.Sal_Cuen = Convert.ToSingle(resultado.Saldo_Cuenta);
                    objCuentaDC.Tipo = Convert.ToInt16(resultado.Tipo);
                    objCuentaDC.Tipo_Cuenta = resultado.Tipo_Cuenta;
                    objCuentaDC.Fec_Aper = Convert.ToDateTime(resultado.Fecha_Apertura);
                    objCuentaDC.Cod_Cli = resultado.Codigo_Cliente;
                    objCuentaDC.Cod_Age = resultado.Codigo_Agencia;
                    objCuentaDC.Est_Cuen = Convert.ToInt16(resultado.Est_Cuen);
                    objCuentaDC.Estado_Cuenta = resultado.Estado_Cuenta;
                    objCuentaDC.Usu_Registro = resultado.Usuario_Registro;
                    objCuentaDC.Fec_Registro = Convert.ToDateTime(resultado.Fecha_Registro);
                    objCuentaDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;
                    objCuentaDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_ult_Mod);

                    objCuenta.Add(objCuentaDC);
                }

                return objCuenta;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
