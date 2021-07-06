using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        Boolean InsertarClient(ClienteBE objClienteBE);

        [OperationContract]
        ClienteBE ConsultarCliente(String strCod);

        [OperationContract]
        Boolean ActualizarCliente(ClienteBE objClienteBE);

        [OperationContract]
        Boolean EliminarCliente(String strCod);

        [OperationContract]
        List<ClienteBE> ListarClientes();
    }

    [DataContract]
    [Serializable]

    public class ClienteBE
    {

        //Datos privados de la tabla Tb_Cliente
        private String mvarcod_cli;
        private Int16 mvartipo_cliente;
        //Adicion tipo especial para cliente
        private String mvartipo_cli;

        private String mvarnom_cliente;
        private String mvarape_pat_cliente;
        private String mvarape_mat_cliente;
        //Adiccion campo especial para nombres
        private String mvarapellidos_nombre;

        private String mvardireccion_cliente;
        private String mvarcel_cliente;
        private String mvaremail_cliente;
        private Int16 mvares_dueno;
        //Adiccion campo especial para dueño
        private String mvarduenopaciente;

        private Int16 mvares_empleado;
        //Adiccion campo especial para empleado
        private String mvarcliente_empleado;

        private String mvarid_ubigeo;
        private String mvardni_cliente;
        private String mvarusu_reg_cli;
        private DateTime mvarfec_reg_cli;
        private String mvarusu_ult_modificacion_cli;
        private DateTime mvarfecha_ult_modificacion_cli;
        private Int16 mvarestado_cli;
        //Adiccion campo especial para empleado
        private String mvarestadocliente;

        [DataMember]
        public String cod_cli
        {
            get { return mvarcod_cli; }
            set { mvarcod_cli = value; }
        }

        [DataMember]
        public Int16 Tipo_cliente
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
        public Int16 es_dueno
        {
            get { return mvares_dueno; }
            set { mvares_dueno = value; }
        }

        [DataMember]
        public Int16 es_empleado
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
        public Int16 estado_cli
        {
            get { return mvarestado_cli; }
            set { mvarestado_cli = value; }
        }

        //Campos especiales
        [DataMember]
        public String tipo
        {
            get { return mvartipo_cli; }
            set { mvartipo_cli = value; }
        }

        [DataMember]
        public String dueno
        {
            get { return mvarduenopaciente; }
            set { mvarduenopaciente = value; }
        }

        [DataMember]
        public String empleado
        {
            get { return mvarcliente_empleado; }
            set { mvarcliente_empleado = value; }
        }

        [DataMember]
        public String estado
        {
            get { return mvarestadocliente; }
            set { mvarestadocliente = value; }
        }

        [DataMember]
        public String apellidos_nombre
        {
            get { return mvarapellidos_nombre; }
            set { mvarapellidos_nombre = value; }
        }
    }

}
