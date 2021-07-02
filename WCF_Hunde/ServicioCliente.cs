using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data.Entity.Core;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        public bool InsertarCliente(ClienteBE objClienteBE)
        {
            //Instanciamos el modelo
            HundeDBEntities MisClientes = new HundeDBEntities();
            try
            {
                //usp
                MisClientes.usp_InsertarCliente(objClienteBE.Tipo_cliente, objClienteBE.nom_cliente,
                    objClienteBE.ape_pat_cliente, objClienteBE.ape_mat_cliente, objClienteBE.direccion_cliente,
                    objClienteBE.cel_cliente, objClienteBE.email_cliente, objClienteBE.es_dueno,
                    objClienteBE.es_empleado, objClienteBE.id_ubigeo, objClienteBE.dni_cliente,
                    objClienteBE.usu_reg_cli, objClienteBE.estado_cli);
                return true;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public ClienteBE ConsultarCliente(string strCod)
        {
            HundeDBEntities MisClientes = new HundeDBEntities();
            try
            {
                //Obtiene la istancia de cliente con LINQ
                Tb_Cliente objConsulta = (from objCli in MisClientes.Tb_Cliente
                                          where objCli.cod_cli == strCod
                                          select objCli).FirstOrDefault();
                //Crea una instancia del clienteBE para traer sus resultados
                ClienteBE objCliente = new ClienteBE();

                objCliente.cod_cli = objConsulta.cod_cli;

                if (objConsulta.Tipo_cliente == 1)
                {
                    objCliente.tipo = "Persona Natural";
                }
                else
                {
                    objCliente.tipo = "Persona Juridica";
                }
                objCliente.nom_cliente = objConsulta.nom_cliente;
                objCliente.ape_pat_cliente = objConsulta.ape_pat_cliente;
                objCliente.ape_mat_cliente = objConsulta.ape_mat_cliente;
                objCliente.direccion_cliente = objConsulta.direccion_cliente;
                objCliente.email_cliente = objConsulta.email_cliente;
                if (objConsulta.es_dueno == 1)
                {
                    objCliente.dueno = "Dueño";
                }
                else
                {
                    objCliente.dueno = "Familiar";
                }

                if (objConsulta.es_empleado == 1)
                {
                    objCliente.empleado = "Empleado";
                }
                else
                {
                    objCliente.empleado = "Cliente";
                }

                objCliente.dni_cliente = objConsulta.dni_cliente;

                if (objConsulta.estado_cli == 1)
                {
                    objCliente.estado = "Activo";
                }
                else
                {
                    objCliente.estado = "Inactivo";
                }

                return objCliente;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public bool ActualizarCliente(ClienteBE objClienteBE)
        {
            HundeDBEntities MisClientes = new HundeDBEntities();

            try
            {
                //usp
                MisClientes.usp_ActualizarCliente(objClienteBE.Tipo_cliente, objClienteBE.nom_cliente,
                    objClienteBE.ape_pat_cliente, objClienteBE.ape_mat_cliente, objClienteBE.direccion_cliente,
                    objClienteBE.cel_cliente, objClienteBE.email_cliente, objClienteBE.es_dueno,
                    objClienteBE.es_empleado, objClienteBE.id_ubigeo, objClienteBE.dni_cliente,
                    objClienteBE.usu_ult_modificacion_cli, objClienteBE.fecha_ult_modificacion_cli,
                    objClienteBE.estado_cli, objClienteBE.cod_cli);
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool EliminarCliente(string strCod)
        {
            HundeDBEntities MisClientes = new HundeDBEntities();
            try
            {
                //usp
                MisClientes.usp_EliminarCliente(strCod);

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

     
        public List<ClienteBE> ListarClientes()
        {
            HundeDBEntities MisClientes = new HundeDBEntities();
            try
            {
                List<ClienteBE> objListaCliente = new List<ClienteBE>();
                var query = (from objClient in MisClientes.Tb_Cliente
                             select objClient);

                foreach (var objCliente in query)
                {
                    //Creamos una instancia del cliente para retornar el resultado
                    ClienteBE objClienteBE = new ClienteBE();

                    objClienteBE.cod_cli = objCliente.cod_cli;
                    objClienteBE.apellidos_nombre = objCliente.ape_pat_cliente + "," + objCliente.ape_mat_cliente + " , " + objCliente.nom_cliente;
                    objClienteBE.direccion_cliente = objCliente.direccion_cliente;
                    objClienteBE.cel_cliente = objCliente.cel_cliente;
                    objClienteBE.email_cliente = objCliente.email_cliente;
                    //objClienteBE.dueno = objCliente.es_dueno;
                    if (objClienteBE.es_dueno == 1)
                    {
                        objClienteBE.dueno = "Dueño";
                    }
                    else
                    {
                        objClienteBE.dueno = "Familiar";
                    }
                    objClienteBE.dni_cliente = objCliente.dni_cliente;
                    objClienteBE.estado_cli = Convert.ToInt16(objCliente.estado_cli);
                    if (objClienteBE.estado_cli == 1)
                    {
                        objClienteBE.estado = "Activo";
                    }
                    else
                    {
                        objClienteBE.estado = "Inactivo";
                    }

                    objListaCliente.Add(objClienteBE);

                }

                return objListaCliente;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
