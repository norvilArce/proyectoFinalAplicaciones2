using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public List<Ubigeo> UbigeoDepartamentos()
        {
            try
            {
                List<Ubigeo> ubigeos = new List<Ubigeo>();

                var query = hundeDB.usp_UbigeoDepartamentos();
                foreach (var i in query)
                {
                    Ubigeo ubigeo = new Ubigeo();
                    ubigeo.id_depa = i.IdDepa;
                    ubigeo.departamento = i.Departamento;
                    ubigeos.Add(ubigeo);
                }
                return ubigeos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Ubigeo> Ubigeo_DistritosProvinciaDepartamento(string idDepa, string idProv)
        {
            try
            {
                List<Ubigeo> ubigeos = new List<Ubigeo>();

                var query = hundeDB.usp_Ubigeo_DistritosProvinciaDepartamento(idDepa, idProv);
                foreach (var i in query)
                {
                    Ubigeo ubigeo = new Ubigeo();
                    ubigeo.id_dist = i.IdDist;
                    ubigeo.distrito = i.Distrito;
                    ubigeos.Add(ubigeo);
                }
                return ubigeos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Ubigeo> Ubigeo_ProvinciasDepartamento(string idDepa)
        {
            try
            {
                List<Ubigeo> ubigeos = new List<Ubigeo>();

                var query = hundeDB.usp_Ubigeo_ProvinciasDepartamento(idDepa);
                foreach (var i in query)
                {
                    Ubigeo ubigeo = new Ubigeo();
                    ubigeo.id_prov = i.IdProv;
                    ubigeo.provincia = i.Provincia;
                    ubigeos.Add(ubigeo);
                }
                return ubigeos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
