using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioMedicina" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioMedicina
    {
        [OperationContract]
        List<Medicina> ConsultarMedicinaProveedor(String codProv);
        [OperationContract]
        List<Medicina> ListarMedicinas();
    }

    [DataContract]
    [Serializable]
    public class Medicina
    {

        private Int16 mvarcod_med;
        private String mvarnombre_medicina;
        private Single mvarprecio;

        [DataMember]
        public Int16 cod_med
        {
            get { return mvarcod_med; }
            set { mvarcod_med = value; }
        }

        [DataMember]
        public String nombre_medicina
        {
            get { return mvarnombre_medicina; }
            set { mvarnombre_medicina = value; }
        }
        [DataMember]
        public Single precio
        {
            get { return mvarprecio; }
            set { mvarprecio = value; }
        }
    }
}
