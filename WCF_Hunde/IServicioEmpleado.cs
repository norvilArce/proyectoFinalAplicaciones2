using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEmpleado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEmpleado
    {
        [OperationContract]
        Boolean insertarEmpleado(Empleado empleado);
        [OperationContract]
        List<Empleado> listarEmpleados(); //en nuestro modelo de negocio, son empleados son tambien clientes
        [OperationContract]
        Boolean actualizarEmpleado(Empleado empleado);
        [OperationContract]
        Boolean eliminarEmpleado(String codEmpl);
        [OperationContract]
        Empleado getEmpleado(String codEmpl);

    }

    //data contractual
    [DataContract]
    [Serializable]
    public class Empleado:Cliente
    {
		private String mvarcod_emp;
		private Int16 mvarrol_emp;
		private DateTime mvarfecha_ingreso;
		private Int16 mvarsueldo;
		private String mvaremail_emp;
		private String mvarcod_supervisor;
        private String mvarusu_ult_modificacion_emp;
        private DateTime mvarfecha_ult_modificacion_emp;
        private Boolean mvarestado_emp;

		[DataMember]		
		public String cod_emp
        {
            get { return mvarcod_emp; }
            set { mvarcod_emp = value; }
        }
		[DataMember]
		public Int16 rol_emp
        {
            get { return mvarrol_emp; }
            set { mvarrol_emp = value; }
        }
		[DataMember]
		public DateTime fecha_ingreso
        {
            get { return mvarfecha_ingreso; }
            set { mvarfecha_ingreso = value; }
        }
		[DataMember]
		public Int16 sueldo
        {
            get { return mvarsueldo; }
            set { mvarsueldo = value; }
        }
        [DataMember]
        public String email_emp
        {
            get { return mvaremail_emp; }
            set { mvaremail_emp = value; }
        }
        [DataMember]
		public String cod_supervisor
        {
            get { return mvarcod_supervisor; }
            set { mvarcod_supervisor = value; }
        }
        [DataMember]
        public String usu_ult_modificacion_emp
        {
            get { return mvarusu_ult_modificacion_emp; }
            set { mvarusu_ult_modificacion_emp = value; }
        }
        [DataMember]
        public DateTime fecha_ult_modificacion_emp
        {
            get { return mvarfecha_ult_modificacion_emp; }
            set { mvarfecha_ult_modificacion_emp = value; }
        }
        [DataMember]
		public Boolean estado_emp
        {
            get { return mvarestado_emp; }
            set { mvarestado_emp = value; }
        }
	}

    [DataContract]
    [Serializable]
    public class Cliente
    {
        private String mvarcod_cli;
        private Int16 mvartipo_cliente;
        private String mvarnom_cliente;
        private String mvarape_pat_cliente;
        private String mvarape_mat_cliente;
        private String mvardireccion_cliente;
        private String mvarcel_cliente;
        private String mvaremail_cliente;

        private Boolean mvares_dueno;
        private Boolean mvares_empleado;
        private String mvarid_ubigeo;
        private String mvardni_cliente;
        private String mvarusu_reg_cli;
        private DateTime mvarfec_reg_cli;
        private String mvarusu_ult_modificacion_cli;
        private DateTime mvarfecha_ult_modificacion_cli;
        private Boolean mvarestado_cli;

        [DataMember]
        public String cod_cli
        {
            get { return mvarcod_cli; }
            set { mvarcod_cli = value; }
        }
        [DataMember]
        public Int16 Tipo_ciente
        {
            get { return mvartipo_cliente; }
            set { mvartipo_cliente = value; }
        }
        [DataMember]
        public String nom_cliente
        {
            get { return mvarnom_cliente; }
            set { mvarnom_cliente = value; }
        }
        [DataMember]
        public String ape_pat_cliente
        {
            get { return mvarape_pat_cliente; }
            set { mvarape_pat_cliente = value; }
        }
        [DataMember]
        public String ape_mat_cliente
        {
            get { return mvarape_mat_cliente; }
            set { mvarape_mat_cliente = value; }
        }
        [DataMember]
        public String direccion_cliente
        {
            get { return mvardireccion_cliente; }
            set { mvardireccion_cliente = value; }
        }
        [DataMember]
        public String cel_cliente
        {
            get { return mvarcel_cliente; }
            set { mvarcel_cliente = value; }
        }
        [DataMember]
        public String email_cliente
        {
            get { return mvaremail_cliente; }
            set { mvaremail_cliente = value; }
        }
        [DataMember]
        public Boolean es_dueno
        {
            get { return mvares_dueno; }
            set { mvares_dueno = value; }
        }
        [DataMember]
        public Boolean es_empleado
        {
            get { return mvares_empleado; }
            set { mvares_empleado = value; }
        }
        [DataMember]
        public String id_ubigeo
        {
            get { return mvarid_ubigeo; }
            set { mvarid_ubigeo = value; }
        }
        [DataMember]
        public String dni_cliente
        {
            get { return mvardni_cliente; }
            set { mvardni_cliente = value; }
        }
        [DataMember]
        public String usu_reg_cli
        {
            get { return mvarusu_reg_cli; }
            set { mvarusu_reg_cli = value; }
        }
        [DataMember]
        public DateTime fec_reg_cli
        {
            get { return mvarfec_reg_cli; }
            set { mvarfec_reg_cli = value; }
        }
        [DataMember]
        public String usu_ult_modificacion_cli
        {
            get { return mvarusu_ult_modificacion_cli; }
            set { mvarusu_ult_modificacion_cli = value; }
        }
        [DataMember]
        public DateTime fecha_ult_modificacion_cli
        {
            get { return mvarfecha_ult_modificacion_cli; }
            set { mvarfecha_ult_modificacion_cli = value; }
        }
        [DataMember]
        public Boolean estado_cli
        {
            get { return mvarestado_cli; }
            set { mvarestado_cli = value; }
        }
    }
}
