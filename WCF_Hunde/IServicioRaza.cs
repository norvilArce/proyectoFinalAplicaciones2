using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioRaza" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioRaza
    {
        [OperationContract]
        List<Raza> listarRazas();
        [OperationContract]
        List<Raza> listarRazasPorTipo(Int16 codTipo);
    }

    [Serializable]
    [DataContract]
    public class Raza
    {
        private Int16 mvarcod_raza;
        private String mvarnom_raza;
        private Int16 mvarcod_tipo;

        [DataMember]
        public Int16 cod_raza
        {
            get { return mvarcod_raza; }
            set { mvarcod_raza = value; }
        }
        [DataMember]
        public String nom_raza
        {
            get { return mvarnom_raza; }
            set { mvarnom_raza = value; }
        }
        [DataMember]
        public Int16 cod_tipo
        {
            get { return mvarcod_tipo; }
            set { mvarcod_tipo = value; }
        }
    }
}
