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

    }

    // Creamos la data contractual de Proveedores
    [DataContract]
    [Serializable]
    public class ProveedorBE
    {
        private String mvarcod_prov;
        private String mvarraz_soc;
        private String mvaruc_prov;
        private String mvardir_prov;
        private String mvarid_ubigeo;
        private String mvartel_prov;
        private String mvaremail_prov;
        private String mvarrep_ven_prov;
        private String mvarusu_reg;
        private DateTime mvarfec_reg_prov;
        private String mvarusu_ult_mod;
        private DateTime mvarfec_ult_mod;
        private int mvarestado_prov;

        [DataMember]
        public String cod_prov
        {
            get { return mvarcod_prov; }
            set { mvarcod_prov = value; }
        }
        [DataMember]
        public String raz_soc
        {
            get { return mvarraz_soc; }
            set { mvarraz_soc = value; }
        }
        [DataMember]
        public String ruc_prov
        {
            get { return mvaruc_prov; }
            set { mvaruc_prov = value; }
        }
        [DataMember]
        public String dir_prov
        {
            get { return mvardir_prov; }
            set { mvardir_prov = value; }
        }
        [DataMember]
        public String id_ubigeo
        {
            get { return mvarid_ubigeo; }
            set { mvarid_ubigeo = value; }
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
        public String usu_reg
        {
            get { return mvarusu_reg; }
            set { mvarusu_reg = value; }
        }
        [DataMember]
        public DateTime fec_reg_prov
        {
            get { return mvarfec_reg_prov; }
            set { mvarfec_reg_prov = value; }
        }
        [DataMember]
        public String usu_ult_mod
        {
            get { return mvarusu_ult_mod; }
            set { mvarusu_ult_mod = value; }
        }
        [DataMember]
        public DateTime fec_ult_mod
        {
            get { return mvarfec_ult_mod; }
            set { mvarfec_ult_mod = value; }
        }
        [DataMember]
        public int estado_prov
        {
            get { return mvarestado_prov; }
            set { mvarestado_prov = value; }
        }
    }

}
