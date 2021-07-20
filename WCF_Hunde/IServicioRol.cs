using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioRol" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioRol
    {
        [OperationContract]
        List<Rol> listarRoles();
    }

    public class Rol
    {
        private Int16 mvarcod_rol;
        private String mvarnom_rol;

        [DataMember]
        public Int16 cod_rol
        {
            get { return mvarcod_rol; }
            set { mvarcod_rol = value; }
        }
        [DataMember]
        public String nom_rol
        {
            get { return mvarnom_rol; }
            set { mvarnom_rol = value; }
        }
    }
}
