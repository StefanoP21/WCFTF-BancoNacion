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
        public List<PrestamoDC> ListarPrestamos_Cli_Emp(string cod_Cli, string cod_Emp)
        {
            BancoEntities MisPrestamos = new BancoEntities();
            List<PrestamoDC> objPrestamo = new List<PrestamoDC>();
            try
            {
                var query = MisPrestamos.usp_ListarPrestamos_Cli_Emp(cod_Cli, cod_Emp).FirstOrDefault();

                if (query != null)
                {
                    PrestamoDC prestamo = new PrestamoDC
                    {
                        Cod_Pre = query.Codigo,
                        Mon_Pre = Convert.ToSingle(query.Monto),
                        Cuot_Pre = Convert.ToInt16(query.Cuotas),
                        Fec_Sol = query.Fecha_Solicitud,
                        Fec_Rech = query.Fecha_Rechazo,
                        Fec_Can = query.Fecha_Cancelacion,
                        PrestamoEstudio = query.Prestamo_Estudio,
                        CompraDeuda = query.Compra_Deuda,
                        Cod_Cli = query.Cod_Cli,
                        Nom_cli = query.Cliente,
                        Cod_Emp = query.Cod_Emp,
                        Nom_emp = query.Empleado,
                        Cod_Age = query.Cod_Age,
                        Nom_age = query.Agencia,
                        EstadoPrestamo = query.Estado_Prestamo


                    };

                    objPrestamo.Add(prestamo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return objPrestamo;
        }



        public List<PrestamoDC> ListarPrestamosClienteFechas(String strCodigo, DateTime fecIni, DateTime fecFin)
        {
            //Instanciamos el modelo
            BancoEntities MisPrestamos = new BancoEntities();

            try
            {
                //Creamos una lista de PrestamoDC
                List<PrestamoDC> objListaPrestamoDC = new List<PrestamoDC>();

                // Hacemos la consulta con LINQ del Prestamo del cliente entre 2 fechas..
                var query = (from miPrestamo in MisPrestamos.vw_VistaPrestamo
                             where miPrestamo.Cod_Cli == strCodigo && miPrestamo.Fecha_Solicitud >= fecIni && miPrestamo.Fecha_Solicitud <= fecFin
                             select miPrestamo);

                foreach (var resultado in query)
                {
                    PrestamoDC objPrestamoDC = new PrestamoDC();
                    objPrestamoDC.Cod_Pre = resultado.Codigo;
                    objPrestamoDC.Fec_Sol = resultado.Fecha_Solicitud;
                    objPrestamoDC.Fec_Can = resultado.Fecha_Cancelacion;
                    objPrestamoDC.Fec_Rech = resultado.Fecha_Rechazo;
                    objPrestamoDC.PrestamoEstudio = resultado.Prestamo_Estudio;
                    objPrestamoDC.Cuot_Pre = Convert.ToInt16(resultado.Cuotas);
                    objPrestamoDC.Mon_Pre = Convert.ToSingle(resultado.Monto);



                    objListaPrestamoDC.Add(objPrestamoDC);
                }

                return objListaPrestamoDC;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
