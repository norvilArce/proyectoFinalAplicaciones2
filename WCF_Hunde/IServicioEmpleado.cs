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

        [OperationContract]
        List<Empleado> ListarSupervisores();
        [OperationContract]
        List<Empleado> EmpleadosPorDepartamento(String idDepa);

    }

    //data contractual
    [DataContract]
    [Serializable]
    public class Empleado
    {
        private String mvarcod_emp;
        private Int16 mvarcod_rol;
        private Int16 mvartipo_emp;
        private String mvarnom_emp;
        private String mvarape_emp;
        private String mvardir_emp;
        private String mvarid_ubigeo;
        private DateTime mvarfecha_ingreso;
        private Int16 mvarsueldo;
        private String mvaremail_emp;
        private String mvarcod_supervisor;
        private String mvarus_ureg_emp;
        private DateTime mvarfecha_reg_emp;
        private String mvarusu_ult_modificacion_emp;
        private DateTime mvarfecha_ult_modificacion_emp;
        private Boolean mvarestado_emp;

        //CAMPOS EXTRA
        private String mvarprovincia;
        private String mvardepartamento;
        private String mvardistrito;
        private String mvarrol;
        private String mvarsup;
        private String mvarestado;
        private String mvarnom_ape;

        [DataMember]
        public String cod_emp
        {
            get { return mvarcod_emp; }
            set { mvarcod_emp = value; }
        }
        [DataMember]
        public Int16 cod_rol
        {
            get { return mvarcod_rol; }
            set { mvarcod_rol = value; }
        }
        [DataMember]
        public Int16 tipo_emp
        {
            get { return mvartipo_emp; }
            set { mvartipo_emp = value; }
        }
        [DataMember]
        public String nom_emp
        {
            get { return mvarnom_emp; }
            set { mvarnom_emp = value; }
        }
        [DataMember]
        public String ape_emp
        {
            get { return mvarape_emp; }
            set { mvarape_emp = value; }
        }
        [DataMember]
        public String dir_emp
        {
            get { return mvardir_emp; }
            set { mvardir_emp = value; }
        }
        [DataMember]
        public String id_ubigeo
        {
            get { return mvarid_ubigeo; }
            set { mvarid_ubigeo = value; }
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
        public String us_ureg_emp
        {
            get { return mvarus_ureg_emp; }
            set { mvarus_ureg_emp = value; }
        }
        [DataMember]
        public DateTime fecha_reg_emp
        {
            get { return mvarfecha_reg_emp; }
            set { mvarfecha_reg_emp = value; }
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

        [DataMember]
        public String provincia
        {
            get { return mvarprovincia; }
            set { mvarprovincia = value; }
        }
        [DataMember]
        public String departamento
        {
            get { return mvardepartamento; }
            set { mvardepartamento = value; }
        }
        [DataMember]
        public String distrito
        {
            get { return mvardistrito; }
            set { mvardistrito = value; }
        }
        [DataMember]
        public String rol
        {
            get { return mvarrol; }
            set { mvarrol = value; }
        }
        [DataMember]
        public String sup
        {
            get { return mvarsup; }
            set { mvarsup = value; }
        }
        [DataMember]
        public String estado
        {
            get { return mvarestado; }
            set { mvarestado = value; }
        }
        [DataMember]
        public String nom_ape
        {
            get { return mvarnom_ape; }
            set { mvarnom_ape = value; }
        }

    }
}
