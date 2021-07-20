using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioRol" en el código y en el archivo de configuración a la vez.
    public class ServicioRol : IServicioRol
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public List<Rol> listarRoles()
        {
            try
            {
                List<Rol> roles = new List<Rol>();

                var query = (from r in hundeDB.Tb_Rol
                             select r);

                foreach (var i in query)
                {
                    Rol rol = new Rol();

                    rol.cod_rol = Convert.ToInt16(i.cod_rol);
                    rol.nom_rol = i.nom_rol;

                    roles.Add(rol);
                }

                return roles;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
