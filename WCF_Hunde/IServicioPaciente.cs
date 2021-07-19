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
        PacienteBE ConsultarPacientes(String strCodPaciente);
        [OperationContract]
        List<PacienteBE> ConsultarPacientesPorRaza(Int16 codRaza);
        [OperationContract]
        List<PacienteBE> ConsultarPacientesPorTratamiento(Int16 codTratamiento);
        [OperationContract]
        List<PacienteBE> ListarPacientesDetallados();
        [OperationContract]
        List<PacienteBE> ListarPacientes();
        [OperationContract]
        Boolean InsertarPaciente(PacienteBE pacienteBE);
        [OperationContract]
        Boolean ActualizarPaciente(PacienteBE pacienteBE);
    }

    [DataContract]
    [Serializable]
    public class PacienteBE
    {
        private String mvarcod_pac;
        private String mvarnom_pac;
        private Int16 mvarcod_raza;
        private DateTime mvarfec_nac_pac;
        private Int16 mvarsexo;
        private Int16 mvarcod_color;
        private Double mvarlongitud;
        private Double mvarpeso;
        private DateTime mvarult_vis_pac;
        private Byte[] mvarfoto;
        private String mvarobs_pac;
        private int mvarest_pac;

        //campos especiales
        private String mvarraza;
        private String mvarcolor;
        private String mvartipo;
        private String mvarsexo_str;

        [DataMember]
        public String cod_pac
        {
            get { return mvarcod_pac; }
            set { mvarcod_pac = value; }
        }

        [DataMember]
        public String nom_pac
        {
            get { return mvarnom_pac; }
            set { mvarnom_pac = value; }
        }

        [DataMember]
        public Int16 cod_raza
        {
            get { return mvarcod_raza; }
            set { mvarcod_raza = value; }
        }

        [DataMember]
        public DateTime fec_nac_pac
        {
            get { return mvarfec_nac_pac; }
            set { mvarfec_nac_pac = value; }
        }

        [DataMember]
        public Int16 sexo
        {
            get { return mvarsexo; }
            set { mvarsexo = value; }
        }

        [DataMember]
        public Int16 cod_color
        {
            get { return mvarcod_color; }
            set { mvarcod_color = value; }
        }

        [DataMember]
        public Double longitud
        {
            get { return mvarlongitud; }
            set { mvarlongitud = value; }
        }

        [DataMember]
        public Double peso
        {
            get { return mvarpeso; }
            set { mvarpeso = value; }
        }

        [DataMember]
        public DateTime ult_vis_pac
        {
            get { return mvarult_vis_pac; }
            set { mvarult_vis_pac = value; }
        }

        [DataMember]
        public Byte[] foto
        {
            get { return mvarfoto; }
            set { mvarfoto = value; }
        }

        [DataMember]
        public String observaciones
        {
            get { return mvarobs_pac; }
            set { mvarobs_pac = value; }
        }

        [DataMember]
        public int est_pac
        {
            get { return mvarest_pac; }
            set { mvarest_pac = value; }
        }
        [DataMember]
        public String raza
        {
            get { return mvarraza; }
            set { mvarraza = value; }
        }
        [DataMember]
        public String color
        {
            get { return mvarcolor; }
            set { mvarcolor = value; }
        }
        [DataMember]
        public String tipo
        {
            get { return mvartipo; }
            set { mvartipo = value; }
        }
        [DataMember]
        public String str_sexo
        {
            get { return mvarsexo_str; }
            set { mvarsexo_str = value; }
        }
    }
}
