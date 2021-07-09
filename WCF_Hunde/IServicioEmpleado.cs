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
        Boolean InsertarEmpleado(Empleado empleado);

        [OperationContract]
        Empleado ConsultarEmpleado(String codEmpl);
                
        [OperationContract]
        Boolean ActualizarEmpleado(Empleado empleado);

        [OperationContract]
        Boolean EliminarEmpleado(String codEmpl);

        [OperationContract]
        List<Empleado> ListarEmpleados();
    }

    //data contractual
    [DataContract]
    [Serializable]
    public class Empleado
    {
		private String mvarcod_emp;
		private Int16 mvarrol_emp;
        private String mvarnom_empleado;
        private String mvarape_empleado;
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
		public String nom_empleado
        {
            get { return mvarnom_empleado; }
            set { mvarnom_empleado = value; }
        }
		[DataMember]		
		public String ape_empleado
        {
            get { return mvarape_empleado; }
            set { mvarape_empleado = value; }
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
}
