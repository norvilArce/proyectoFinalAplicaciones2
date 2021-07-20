using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        HundeDBEntities MisClientes = new HundeDBEntities();
        public bool InsertarCliente(ClienteBE objClienteBE)
        {
            try
            {
                MisClientes.usp_InsertarCliente(objClienteBE.nom_cliente,
                    objClienteBE.ape_cliente, objClienteBE.direccion_cliente,
                    objClienteBE.cel_cliente, objClienteBE.email_cliente, objClienteBE.es_dueno,
                    objClienteBE.id_ubigeo, objClienteBE.dni_cliente,
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
            try
            {
                Tb_Cliente objConsulta = (from objCli in MisClientes.Tb_Cliente
                                          where objCli.cod_cli == strCod
                                          select objCli).FirstOrDefault();

                ClienteBE objCliente = new ClienteBE();

                objCliente.cod_cli = objConsulta.cod_cli;

                objCliente.nom_cliente = objConsulta.nom_cliente;
                objCliente.ape_cliente = objConsulta.ape_cliente;
                objCliente.dni_cliente = objConsulta.dni_cliente;
                objCliente.direccion_cliente = objConsulta.direccion_cliente;
                objCliente.cel_cliente = objConsulta.cel_cliente;
                objCliente.email_cliente = objConsulta.email_cliente;
                objCliente.id_ubigeo = objConsulta.id_ubigeo;
                objCliente.estado_cli = Convert.ToInt16(objConsulta.estado_cli);
                objCliente.es_dueno = Convert.ToInt16(objConsulta.es_dueno);

                if (objConsulta.es_dueno == 1)
                {
                    objCliente.dueno = "Dueño";
                }
                else if (objConsulta.es_dueno == 2)
                {
                    objCliente.dueno = "Familiar";
                }

                objCliente.usu_reg_cli = objConsulta.usu_reg_cli;
                objCliente.fec_reg_cli = Convert.ToDateTime(objConsulta.fec_reg_cli);
                objCliente.usu_ult_modificacion_cli = objConsulta.usu_ult_modificacion_cli;
                objCliente.fecha_ult_modificacion_cli = Convert.ToDateTime(objConsulta.fecha_ult_modificacion_cli);

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

            try
            {
                MisClientes.usp_ActualizarCliente(objClienteBE.nom_cliente,
                    objClienteBE.ape_cliente, objClienteBE.direccion_cliente,
                    objClienteBE.cel_cliente, objClienteBE.email_cliente, objClienteBE.es_dueno,
                    objClienteBE.id_ubigeo, objClienteBE.dni_cliente,
                    objClienteBE.usu_ult_modificacion_cli,
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
            try
            {
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
            try
            {
                List<ClienteBE> objListaCliente = new List<ClienteBE>();
                var query = (from objClient in MisClientes.Tb_Cliente
                             select objClient);

                foreach (var objCliente in query)
                {
                    ClienteBE objClienteBE = new ClienteBE();

                    objClienteBE.cod_cli = objCliente.cod_cli;
                    objClienteBE.apellidos_nombre = objCliente.nom_cliente + ", " + objCliente.ape_cliente;
                    objClienteBE.direccion_cliente = objCliente.direccion_cliente;
                    objClienteBE.cel_cliente = objCliente.cel_cliente;
                    objClienteBE.email_cliente = objCliente.email_cliente;
                    objClienteBE.id_ubigeo = objCliente.id_ubigeo;
                    objClienteBE.es_dueno = Convert.ToInt16(objCliente.es_dueno);
                    if (objCliente.es_dueno == 1)
                    {
                        objClienteBE.dueno = "Dueño";
                    }
                    else
                    {
                        objClienteBE.dueno = "Familiar";
                    }
                    objClienteBE.dni_cliente = objCliente.dni_cliente;
                    objClienteBE.usu_reg_cli = objCliente.usu_reg_cli;
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