using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioProveedor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioProveedor
    {
        [OperationContract]
        List<ProveedorBE> ConsultarProveedores();
        [OperationContract]
        ProveedorBE ConsultarProveedorPorCodigo(String strCodigo);

        [OperationContract]
        List<ProveedorBE> ConsultarSupervisor();

        [OperationContract]
        ProveedorBE ConsultarMedicinaProveedor(String srtTipoMedicina);

        [OperationContract]
        List<EstadosBE> ConsultarEstadoProveedorMedicina();

    
    }

    // Creamos la data contractual de Proveedores
    [DataContract]
    [Serializable]
    public class ProveedorBE
    {
        private String mvarcod_prov;
        private String mvanom_prov;
        private String mvaruc_prov;
        private String mvardireccion_prov;
        private String mvartel_prov;
        private String mvaremail_prov;
        private String mvarrep_ven_prov;
        private DateTime mvarfec_reg_prov;
        private int mvarestado_prov;
        private String mvarcod_med;
        private String mvartipo_medicina;
        private String mvarnombre_medicina;

        [DataMember]
        public int Estado
        {
            get { return mvarestado_prov; }
            set { mvarestado_prov = value; }
        }

        [DataMember]
        public String cod_prov
        {
            get { return mvarcod_prov; }
            set { mvarcod_prov = value; }
        }
        [DataMember]
        public String nom_prov
        {
            get { return mvanom_prov; }
            set { mvanom_prov = value; }
        }
        [DataMember]
        public String ruc_prov
        {
            get { return mvaruc_prov; }
            set { mvaruc_prov = value; }
        }
        [DataMember]
        public String direccion_prov
        {
            get { return mvardireccion_prov; }
            set { mvardireccion_prov = value; }
        }
        [DataMember]
        public String tel_prov
        {
            get { return mvartel_prov; }
            set { mvartel_prov = value; }
        }
        [DataMember]
        public String email_prov
        {
            get { return mvaremail_prov; }
            set { mvaremail_prov = value; }
        }
        [DataMember]
        public String rep_ven_prov
        {
            get { return mvarrep_ven_prov; }
            set { mvarrep_ven_prov = value; }
        }
        [DataMember]
        public DateTime fec_reg_prov
        {
            get { return mvarfec_reg_prov; }
            set { mvarfec_reg_prov = value; }
        }
        [DataMember]
        public int estado_prov
        {
            get { return mvarestado_prov; }
            set { mvarestado_prov = value; }
        }

        [DataMember]
        public String cod_med
        {
            get { return mvarcod_med; }
            set { mvarcod_med = value; }
        }

        [DataMember]
        public String tipo_medicina
        {
            get { return mvartipo_medicina; }
            set { mvartipo_medicina = value; }
        }

        [DataMember]
        public String nombre_medicina
        {
            get { return mvarnombre_medicina; }
            set { mvarnombre_medicina = value; }
        }
    }

    [DataContract]
    [Serializable]

    public class EstadosBE
    {

        private String mvarcod_prov;
        private String mvanom_prov;
        private int mvarestado_prov;
        private String mvarcod_med;
        private String mvartipo_medicina;
        private String mvarnombre_medicina;

        [DataMember]
        public String cod_prov
        {
            get { return mvarcod_prov; }
            set { mvarcod_prov = value; }
        }
        [DataMember]
        public String nom_prov
        {
            get { return mvanom_prov; }
            set { mvanom_prov = value; }
        }
        [DataMember]
        public int estado_prov
        {
            get { return mvarestado_prov; }
            set { mvarestado_prov = value; }
        }
        [DataMember]
        public String cod_med
        {
            get { return mvarcod_med; }
            set { mvarcod_med = value; }
        }

        [DataMember]
        public String tipo_medicina
        {
            get { return mvartipo_medicina; }
            set { mvartipo_medicina = value; }
        }

        [DataMember]
        public String nombre_medicina
        {
            get { return mvarnombre_medicina; }
            set { mvarnombre_medicina = value; }
        }
    }
}
