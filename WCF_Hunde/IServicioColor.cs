using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioColor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioColor
    {
        [OperationContract]
        List<Color> ListarColores();
    }

    [Serializable]
    [DataContract]
    public class Color
    {
        private Int16 mvarcod_color;
        private String mvarnom_color;

        [DataMember]
        public String nom_color
        {
            get { return mvarnom_color; }
            set { mvarnom_color = value; }
        }
        [DataMember]
        public Int16 cod_color
        {
            get { return mvarcod_color; }
            set { mvarcod_color = value; }
        }
    }
}