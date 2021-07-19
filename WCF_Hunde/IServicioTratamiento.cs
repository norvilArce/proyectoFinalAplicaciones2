using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioTratamiento" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioTratamiento
    {
        [OperationContract]
        List<Tratamiento> listarTratamientos();
    }

    [DataContract]
    [Serializable]
    public class Tratamiento
    {
        private Int16 mvarcod_trat;
        private String mvarnom_trat;
        private Int16 mvarest_trat;

        [DataMember]
        public Int16 cod_trat
        {
            get { return mvarcod_trat; }
            set { mvarcod_trat = value; }
        }
        [DataMember]
        public String nom_trat
        {
            get { return mvarnom_trat; }
            set { mvarnom_trat = value; }
        }
        [DataMember]
        public Int16 est_trat
        {
            get { return mvarest_trat; }
            set { mvarest_trat = value; }
        }

    }
}
