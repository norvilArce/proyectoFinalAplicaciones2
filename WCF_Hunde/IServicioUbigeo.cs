using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<Ubigeo> UbigeoDepartamentos();
        [OperationContract]
        List<Ubigeo> Ubigeo_ProvinciasDepartamento(String idDepa);
        [OperationContract]
        List<Ubigeo> Ubigeo_DistritosProvinciaDepartamento(String idDepa, String idProv);
    }

    [DataContract]
    [Serializable]
    public class Ubigeo
    {
        String mvarid_ubigeo;
        String mvarid_depa;
        String mvarid_prov;
        String mvarid_dist;
        String mvardepartamento;
        String mvarprovincia;
        String mvardistrito;

        [DataMember]
        public String id_Ubigeo
        {
            get { return mvarid_ubigeo; }
            set { mvarid_ubigeo = value; }
        }
        [DataMember]
        public String id_depa
        {
            get { return mvarid_depa; }
            set { mvarid_depa = value; }
        }
        [DataMember]
        public String id_prov
        {
            get { return mvarid_prov; }
            set { mvarid_prov = value; }
        }
        [DataMember]
        public String id_dist
        {
            get { return mvarid_dist; }
            set { mvarid_dist = value; }
        }
        [DataMember]
        public String departamento
        {
            get { return mvardepartamento; }
            set { mvardepartamento = value; }
        }
        [DataMember]
        public String provincia
        {
            get { return mvarprovincia; }
            set { mvarprovincia = value; }
        }
        [DataMember]
        public String distrito
        {
            get { return mvardistrito; }
            set { mvardistrito = value; }
        }
    }
}
