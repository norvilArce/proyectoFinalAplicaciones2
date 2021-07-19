using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioMedicina" en el código y en el archivo de configuración a la vez.
    public class ServicioMedicina : IServicioMedicina
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public List<Medicina> ConsultarMedicinaProveedor(string codProv)
        {
            List<Medicina> medicinas = new List<Medicina>();
            try
            {
                var query = hundeDB.usp_ListarMedicinasPorProveedor(codProv);

                if (query != null)
                {
                    foreach (var i in query)
                    {
                        Medicina medicina = new Medicina();

                        medicina.cod_med = Convert.ToInt16(i.cod_med);
                        medicina.nombre_medicina = i.nombre_medicina;
                        medicina.precio = Convert.ToSingle(i.precio);
                        medicinas.Add(medicina);
                    }
                }
                return medicinas;
            }
            catch (System.NullReferenceException)
            {
                return medicinas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Medicina> ListarMedicinas()
        {
            try
            {
                List<Medicina> medicinas = new List<Medicina>();

                var query = (from med in hundeDB.Tb_Medicina
                             select med);

                foreach (var i in query)
                {
                    Medicina medicina = new Medicina();

                    medicina.cod_med = Convert.ToInt16(i.cod_med);
                    medicina.nombre_medicina = i.nombre_medicina;
                    medicina.precio = Convert.ToSingle(i.precio);
                    medicinas.Add(medicina);
                }
                return medicinas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
