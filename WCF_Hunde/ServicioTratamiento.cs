using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTratamiento" en el código y en el archivo de configuración a la vez.
    public class ServicioTratamiento : IServicioTratamiento
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public List<Tratamiento> listarTratamientos()
        {
            List<Tratamiento> tratamientos = new List<Tratamiento>();
            try
            {
                var query = from trat in hundeDB.Tb_Tratamiento
                            select trat;

                foreach (var i in query)
                {
                    Tratamiento tratamiento = new Tratamiento();

                    tratamiento.cod_trat = Convert.ToInt16(i.cod_trat);
                    tratamiento.nom_trat = i.nombre_trat;
                    tratamiento.est_trat = Convert.ToInt16(i.estado_trat);

                    tratamientos.Add(tratamiento);
                }
                return tratamientos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
