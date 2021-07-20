using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioTipoPaciente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioTipoPaciente
    {
        [OperationContract]
        List<TipoPaciente> listarTipos();
        [OperationContract]
        TipoPaciente TipoPorRaza(Int16 codRaza);
    }

    [Serializable]
    [DataContract]
    public class TipoPaciente
    {
        private Int16 mvarcod_tipo;
        private String mvarnom_tipo;

        [DataMember]
        public String nom_tipo
        {
            get { return mvarnom_tipo; }
            set { mvarnom_tipo = value; }
        }
        [DataMember]
        public Int16 cod_tipo
        {
            get { return mvarcod_tipo; }
            set { mvarcod_tipo = value; }
        }
    }
}
