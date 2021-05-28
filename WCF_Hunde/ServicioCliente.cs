using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        public ClienteBE ConsultCliente(string strCod)
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

        public bool DeleteCliente(string strCod)
        {
            HundeDBEntities MisClientes = new HundeDBEntities();
            try
            {
                //Obtenemos con LINQ la instancia del cliente a actualizar
                Tb_Cliente objCliente = (from objClient in MisClientes.Tb_Cliente
                                         where objClient.cod_cli == strCod
                                         select objClient).FirstOrDefault();

                //Removemos el vendedor
                MisClientes.Tb_Cliente.Remove(objCliente);
                MisClientes.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

     
        public List<ClienteBE> GetAllCliente()
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

        public bool InsertCliente(ClienteBE objClienteBE)
        {
            //Instanciamos el modelo
            HundeDBEntities MisClientes = new HundeDBEntities();
            try
            {
                //Crea la instancia del nuevo vendedor
                Tb_Cliente objCliente = new Tb_Cliente();
                //Asignamos las propiedades al nuevo cliente desde el parametro para que sea reconocido por el objeto
                //Codigo vacio a ser llenado de forma automatica incremental
                objCliente.cod_cli = String.Empty;
                objCliente.Tipo_cliente = objClienteBE.Tipo_cliente;
                objCliente.nom_cliente = objClienteBE.nom_cliente;
                objCliente.ape_pat_cliente = objClienteBE.ape_pat_cliente;
                objCliente.ape_mat_cliente = objClienteBE.ape_mat_cliente;
                objCliente.direccion_cliente = objClienteBE.direccion_cliente;
                objCliente.cel_cliente = objClienteBE.cel_cliente;
                objCliente.email_cliente = objClienteBE.email_cliente;
                objCliente.es_dueno = objClienteBE.es_dueno;
                objCliente.es_empleado = objClienteBE.es_empleado;
                objCliente.id_ubigeo = objClienteBE.id_ubigeo;
                objCliente.dni_cliente = objClienteBE.dni_cliente;
                objCliente.usu_reg_cli = objClienteBE.usu_reg_cli;
                objCliente.fec_reg_cli = objClienteBE.fec_reg_cli;
                objCliente.estado_cli = objClienteBE.estado_cli;

                //Agrega nueva instancia
                MisClientes.Tb_Cliente.Add(objCliente);
                return true;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool UpdateCliente(ClienteBE objClienteBE)
        {
            HundeDBEntities MisClientes = new HundeDBEntities();

            try
            {
                //Obtenemos con LINQ el cliente para actualizar
                Tb_Cliente objCliente = (from objClient in MisClientes.Tb_Cliente
                                         where objClient.cod_cli == objClienteBE.cod_cli
                                         select objClient).FirstOrDefault();

                //el vendedor se encuentra identificado

                //Asignamos las propiedades a la instancia de objCliente actualizar desde el parametro objClient
                objCliente.cod_cli = objClienteBE.cod_cli;
                objCliente.Tipo_cliente = objClienteBE.Tipo_cliente;
                objCliente.nom_cliente = objClienteBE.nom_cliente;
                objCliente.ape_pat_cliente = objClienteBE.ape_pat_cliente;
                objCliente.ape_mat_cliente = objClienteBE.ape_mat_cliente;
                objCliente.direccion_cliente = objClienteBE.direccion_cliente;
                objCliente.cel_cliente = objClienteBE.cel_cliente;
                objCliente.email_cliente = objClienteBE.email_cliente;
                objCliente.es_dueno = objClienteBE.es_dueno;
                objCliente.es_empleado = objClienteBE.es_empleado;
                objCliente.id_ubigeo = objClienteBE.id_ubigeo;
                objCliente.dni_cliente = objClienteBE.dni_cliente;
                objCliente.estado_cli = objClienteBE.estado_cli;

                //Agrega nueva instancia
                MisClientes.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
