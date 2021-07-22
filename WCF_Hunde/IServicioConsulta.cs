using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioConsulta" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioConsulta
    {
        [OperationContract]
        List<Consulta> ConsultasPorMascota(String codigoMascota);
        [OperationContract]
        List<Consulta> ConsultasPorMedico(String codigoMedico);
        [OperationContract]
        List<Consulta> ConsultasPorFecha(DateTime fechaConsulta);
        [OperationContract]
        List<Consulta> ConsultasPorEstado(Int16 estado);
        [OperationContract]
        List<Consulta> ListarConsultas();
        [OperationContract]
        List<Cita> ListarCitas();
        [OperationContract]
        List<Cita> CitasPorEstado(Int16 estado);
        [OperationContract]
        List<Consulta> ConsultasEntreFechas(DateTime fechaIni, DateTime fechaFin);
        [OperationContract]
        List<Consulta> ConsultasPorMascotaEntreFechas(String codigoMascota, DateTime fechaIni, DateTime fechaFin);
        [OperationContract]
        List<Consulta> ConsultasPorMedicoEntreFechas(String codigoMedico, DateTime fechaIni, DateTime fechaFin);
        [OperationContract]
        Boolean ReservarCita(DateTime FechaHora, String codigoCliente);
        [OperationContract]
        Boolean ActualizarReserva(Cita cita);
        [OperationContract]
        Boolean CancelarReserva(Int16 codigoCita);
        [OperationContract]
        Boolean GenerarConsulta(String codigoPaciente, String codigoEmpleado, Int16 codigoCita);
        [OperationContract]
        Boolean CancelarConsulta(Int16 codigoConsulta);
        [OperationContract]
        Boolean AgregarDetallesDeConsulta(Int16 codigoConsulta, Int16 codigoTratamiento,
            Int16 codigoEstado, Int16 codigoMedicina, String observaciones);
        [OperationContract]
        Consulta VerDetallesDeConsulta(Int16 codigoConsulta);
        [OperationContract]
        Cita VerDetallesDeCita(Int16 codigoCita);
    }

    [DataContract]
    [Serializable]
    public class Consulta
    {
        private Int16 mvarcod_cita;
        private Int16 mvarcod_consulta;
        private String mvarfec_consulta;
        private String mvarhora_consulta;
        private String mvarcod_emp;
        private String mvarnom_emp;
        private String mvarcod_pac;
        private String mvarnom_pac;
        private String mvartipo_pac;
        private String mvarraza_pac;
        private String mvarcolor_pac;
        private String mvarcod_cli;
        private String mvarnom_cli; //persona que lo trajo a la consulta
        private String mvarconduta;
        private String mvarest_nutricional;
        private String mvaractividad;
        private String mvarobservaciones;
        private Int16 mvarestado;
        private Int16 mvarcod_tratamiento;
        private Int16 mvarcod_medicina;

        [DataMember]
        public Int16 cod_cita
        {
            get { return mvarcod_cita; }
            set { mvarcod_cita = value; }
        }
        [DataMember]
        public Int16 cod_consulta
        {
            get { return mvarcod_consulta; }
            set { mvarcod_consulta = value; }
        }

        [DataMember]
        public String fec_consulta
        {
            get { return mvarfec_consulta; }
            set { mvarfec_consulta = value; }
        }

        [DataMember]
        public String hora_consulta
        {
            get { return mvarhora_consulta; }
            set { mvarhora_consulta = value; }
        }

        [DataMember]
        public String cod_emp
        {
            get { return mvarcod_emp; }
            set { mvarcod_emp = value; }
        }

        [DataMember]
        public String nom_emp
        {
            get { return mvarnom_emp; }
            set { mvarnom_emp = value; }
        }

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
        public String tipo_pac
        {
            get { return mvartipo_pac; }
            set { mvartipo_pac = value; }
        }

        [DataMember]
        public String raza_pac
        {
            get { return mvarraza_pac; }
            set { mvarraza_pac = value; }
        }

        [DataMember]
        public String color_pac
        {
            get { return mvarcolor_pac; }
            set { mvarcolor_pac = value; }
        }

        [DataMember]
        public String cod_cli
        {
            get { return mvarcod_cli; }
            set { mvarcod_cli = value; }
        }

        [DataMember]
        public String nom_cli
        {
            get { return mvarnom_cli; }
            set { mvarnom_cli = value; }
        }

        [DataMember]
        public String conduta
        {
            get { return mvarconduta; }
            set { mvarconduta = value; }
        }

        [DataMember]
        public String est_nutricional
        {
            get { return mvarest_nutricional; }
            set { mvarest_nutricional = value; }
        }

        [DataMember]
        public String actividad
        {
            get { return mvaractividad; }
            set { mvaractividad = value; }
        }

        [DataMember]
        public String observaciones
        {
            get { return mvarobservaciones; }
            set { mvarobservaciones = value; }
        }
        [DataMember]
        public Int16 estado
        {
            get { return mvarestado; }
            set { mvarestado = value; }
        }
        [DataMember]
        public Int16 cod_tratamiento
        {
            get { return mvarcod_tratamiento; }
            set { mvarcod_tratamiento = value; }
        }
        [DataMember]
        public Int16 cod_medicina
        {
            get { return mvarcod_medicina; }
            set { mvarcod_medicina = value; }
        }

    }

    [DataContract]
    [Serializable]
    public class Cita
    {
        private Int16 mvarcod_cita;
        private DateTime mvarfec_reserva;
        private DateTime mvarfec_cita;
        private TimeSpan mvarhor_cita;
        private Int16 mvarest_cita;
        private String mvarcod_cli;

        [DataMember]
        public Int16 cod_cita
        {
            get { return mvarcod_cita; }
            set { mvarcod_cita = value; }
        }
        [DataMember]
        public DateTime fec_reserva
        {
            get { return mvarfec_reserva; }
            set { mvarfec_reserva = value; }
        }
        [DataMember]
        public DateTime fec_cita
        {
            get { return mvarfec_cita; }
            set { mvarfec_cita = value; }
        }
        [DataMember]
        public TimeSpan hor_cita
        {
            get { return mvarhor_cita; }
            set { mvarhor_cita = value; }
        }
        [DataMember]
        public Int16 est_cita
        {
            get { return mvarest_cita; }
            set { mvarest_cita = value; }
        }
        [DataMember]
        public String cod_cli
        {
            get { return mvarcod_cli; }
            set { mvarcod_cli = value; }
        }
    }

}

