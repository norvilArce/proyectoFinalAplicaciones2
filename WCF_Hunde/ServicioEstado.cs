using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEstado" en el código y en el archivo de configuración a la vez.
    public class ServicioEstado : IServicioEstado
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public List<Estado> ListarEstados()
        {
            try
            {
                List<Estado> estados = new List<Estado>();
                var query = from est in hundeDB.Tb_Estado
                            select est;

                foreach (var i in query)
                {
                    Estado estado = new Estado();

                    estado.cod_estado = Convert.ToInt16(i.cod_estado);
                    estado.conducta = i.conducta;
                    estado.est_nut = i.est_nutricional;
                    estado.actividad = i.actividad;

                    estados.Add(estado);
                }
                return estados;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
