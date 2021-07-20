using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEstado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEstado
    {
        [OperationContract]
        List<Estado> ListarEstados();
    }

    public class Estado
    {
        private Int16 mvarcod_estado;
        private String mvarconducta;
        private String mvarest_nut;
        private String mvaract;

        [DataMember]
        public Int16 cod_estado
        {
            get { return mvarcod_estado; }
            set { mvarcod_estado = value; }
        }
        [DataMember]
        public String conducta
        {
            get { return mvarconducta; }
            set { mvarconducta = value; }
        }
        [DataMember]
        public String est_nut
        {
            get { return mvarest_nut; }
            set { mvarest_nut = value; }
        }
        [DataMember]
        public String actividad
        {
            get { return mvaract; }
            set { mvaract = value; }
        }
    }
}
