using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPaciente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPaciente
    {
        [OperationContract]
        List<PacienteBE> ConsultarPacientesPorRaza(String strRazaPaciente);

        [OperationContract]
        List<PacienteBE> ConsultarPacientesPorFecha(String strCod, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<PacienteBE> ConsultarPacientesPorTratamiento(String strTipoTratamiento);
    }


    [DataContract]
    [Serializable]
    public class PacienteBE
    {
        private String mvarcod_pac;
        private String mvarnom_pac;
        private String mvartipo_pac;
        private String mvarraza;
        private DateTime mvarfec_nac_pac;
        private int mvarsexo;
        private String mvarcolor;
        private Decimal mvarlongitud;
        private Decimal mvarpeso;
        private DateTime mvarult_vis_pac;
        private String mvarfoto;
        private String mvarobservaciones_pac;
        private int mvarest_pac;


        [DataMember]
        public String Cod_pac
        {
            get { return mvarcod_pac; }
            set { mvarcod_pac = value; }
        }

        [DataMember]
        public String Nom_pac
        {
            get { return mvarnom_pac; }
            set { mvarnom_pac = value; }
        }

        [DataMember]
        public String Tipo_pac
        {
            get { return mvartipo_pac; }
            set { mvartipo_pac = value; }
        }

        [DataMember]
        public String Raza
        {
            get { return mvarraza; }
            set { mvarraza = value; }
        }

        [DataMember]
        public DateTime Fec_nac_pac
        {
            get { return mvarfec_nac_pac; }
            set { mvarfec_nac_pac = value; }
        }

        [DataMember]
        public int Sexo
        {
            get { return mvarsexo; }
            set { mvarsexo = value; }
        }

        [DataMember]
        public String Color
        {
            get { return mvarcolor; }
            set { mvarcolor = value; }
        }

        [DataMember]
        public Decimal Longitud
        {
            get { return mvarlongitud; }
            set { mvarlongitud = value; }
        }

        [DataMember]
        public Decimal Peso
        {
            get { return mvarpeso; }
            set { mvarpeso = value; }
        }

        [DataMember]
        public DateTime Ult_vis_pac
        {
            get { return mvarult_vis_pac; }
            set { mvarult_vis_pac = value; }
        }

        [DataMember]
        public String Foto
        {
            get { return mvarfoto; }
            set { mvarfoto = value; }
        }

        [DataMember]
        public String Observaciones
        {
            get { return mvarobservaciones_pac; }
            set { mvarobservaciones_pac = value; }
        }

        [DataMember]
        public int Est_pac
        {
            get { return mvarest_pac; }
            set { mvarest_pac = value; }
        }
    }
}
