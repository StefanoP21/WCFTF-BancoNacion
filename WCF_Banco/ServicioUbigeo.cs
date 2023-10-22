using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Banco
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioUbigeo" in both code and config file together.
    public class ServicioUbigeo : IServicioUbigeo
    {
        BancoEntities Banco = new BancoEntities();

        public List<UbigeoDC> Ubigeo_Departamentos()
        {
            try
            {
                List<UbigeoDC> objListaUbigeoDC = new List<UbigeoDC>();

                var query = Banco.usp_Ubigeo_Departamentos();

                foreach (var item in query)
                {
                    UbigeoDC objUbigeoDC = new UbigeoDC();

                    objUbigeoDC.IdDepa = item.ID_Departamento;
                    objUbigeoDC.Departamento = item.Departamento;

                    objListaUbigeoDC.Add(objUbigeoDC);
                }

                return objListaUbigeoDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UbigeoDC> Ubigeo_ProvinciasDepartamento(string strIdDep)
        {
            try
            {
                List<UbigeoDC> objListaUbigeoDC = new List<UbigeoDC>();

                var query = Banco.usp_Ubigeo_ProvinciasDepartamento(strIdDep);

                foreach (var item in query)
                {
                    UbigeoDC objUbigeoDC = new UbigeoDC();

                    objUbigeoDC.IdProv = item.ID_Provincia;
                    objUbigeoDC.Provincia = item.Provincia;

                    objListaUbigeoDC.Add(objUbigeoDC);
                }

                return objListaUbigeoDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UbigeoDC> Ubigeo_DistritosProvinciaDepartamento(string strIdDep, string strIdProv)
        {
            try
            {
                List<UbigeoDC> objListaUbigeoDC = new List<UbigeoDC>();

                var query = Banco.usp_Ubigeo_DistritosProvinciaDepartamento(strIdDep, strIdProv);

                foreach (var item in query)
                {
                    UbigeoDC objUbigeoDC = new UbigeoDC();

                    objUbigeoDC.IdDist = item.ID_Distrito;
                    objUbigeoDC.Distrito = item.Distrito;

                    objListaUbigeoDC.Add(objUbigeoDC);
                }

                return objListaUbigeoDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
