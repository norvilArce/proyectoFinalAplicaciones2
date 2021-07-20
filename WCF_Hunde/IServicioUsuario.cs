using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        Usuario ConsultarUsuario(String strLogin);
    }

    [DataContract]
    [Serializable]
    public class Usuario
    {
        private String mvarlogin_usuario;
        private String mvarpass_usuario;
        private Int16 mvarniv_usuario;
        private Int16 mvarest_usuario;
        private DateTime mvarfec_registro;
        private String mvarusu_reg_usu;
        private String mvarcod_emp;

        [DataMember]
        public String login_usuario
        {
            get { return mvarlogin_usuario; }
            set { mvarlogin_usuario = value; }
        }
        [DataMember]
        public String pass_usuario
        {
            get { return mvarpass_usuario; }
            set { mvarpass_usuario = value; }
        }
        [DataMember]
        public Int16 niv_usuario
        {
            get { return mvarniv_usuario; }
            set { mvarniv_usuario = value; }
        }
        [DataMember]
        public Int16 est_usuario
        {
            get { return mvarest_usuario; }
            set { mvarest_usuario = value; }
        }
        [DataMember]
        public DateTime fec_registro
        {
            get { return mvarfec_registro; }
            set { mvarfec_registro = value; }
        }
        [DataMember]
        public String usu_reg_usu
        {
            get { return mvarusu_reg_usu; }
            set { mvarusu_reg_usu = value; }
        }
        [DataMember]
        public String cod_emp
        {
            get { return mvarcod_emp; }
            set { mvarcod_emp = value; }
        }
    }
}
