using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEmpleado" en el código y en el archivo de configuración a la vez.
    public class ServicioEmpleado : IServicioEmpleado
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public Boolean insertarEmpleado(Cliente cliente, Empleado empleado)
        {
            try
            {
                //usp
                hundeDB.usp_InsertarEmpleado(cliente.Tipo_ciente, cliente.nom_cliente, cliente.ape_pat_cliente, cliente.ape_mat_cliente,
                    cliente.direccion_cliente, cliente.cel_cliente, cliente.email_cliente, Convert.ToInt16(cliente.es_dueno),
                    Convert.ToInt16(cliente.es_empleado), cliente.id_ubigeo, cliente.dni_cliente, cliente.usu_reg_cli,
                    Convert.ToInt16(cliente.estado_cli), empleado.rol_emp, empleado.fecha_ingreso, empleado.sueldo, empleado.cod_supervisor,
                    Convert.ToInt16(empleado.estado_emp));
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public List<Empleado> listarEmpleados()
        {
            try
            {
                //LINQ vista

                List<Empleado> empleados = new List<Empleado>();

                var query = (from emp in hundeDB.vw_ClientesSonEmpleados
                             select emp);

                foreach (var emp in query)
                {
                    Empleado empleado = new Empleado();

                    empleado.cod_emp = emp.cod_emp;
                    empleado.rol_emp = Convert.ToInt16(emp.rol_emp);
                    empleado.fecha_ingreso = emp.fecha_ingreso;
                    empleado.sueldo = Convert.ToInt16(emp.sueldo);
                    empleado.email_emp = emp.email_emp;
                    empleado.cod_supervisor = emp.cod_supervisor;
                    empleado.cod_cli = emp.cod_cli;
                    empleado.usu_ult_modificacion_emp = emp.usu_ult_modificacion_emp;
                    empleado.fecha_ult_modificacion_emp = Convert.ToDateTime(emp.fecha_ult_modificacion_emp);
                    empleado.estado_emp = Convert.ToBoolean(emp.estado_emp);

                    empleado.Tipo_ciente = Convert.ToInt16(emp.tipo_ciente);
                    empleado.nom_cliente = emp.nom_cliente;
                    empleado.ape_pat_cliente = emp.ape_pat_cliente;
                    empleado.ape_mat_cliente = emp.ape_mat_cliente;
                    empleado.direccion_cliente = emp.direccion_cliente;
                    empleado.cel_cliente = emp.cel_cliente;
                    empleado.email_cliente = emp.email_cliente;
                    empleado.es_dueno = Convert.ToBoolean(emp.es_dueno);
                    empleado.es_empleado = Convert.ToBoolean(emp.es_empleado);
                    empleado.id_ubigeo = emp.id_ubigeo;
                    empleado.dni_cliente = emp.dni_cliente;
                    empleado.usu_reg_cli = emp.usu_reg_cli;
                    empleado.fec_reg_cli = Convert.ToDateTime(emp.fec_reg_cli);
                    empleado.usu_ult_modificacion_cli = emp.usu_ult_modificacion_cli;
                    empleado.fecha_ult_modificacion_cli = Convert.ToDateTime(emp.fecha_ult_modificacion_cli);
                    empleado.estado_cli = Convert.ToBoolean(emp.estado_cli);

                    empleados.Add(empleado);
                }

                return empleados;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean actualizarEmpleado(Empleado empleado)
        {
            try
            {
                //usp
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean eliminarEmpleado(String codEmpl)
        {
            try
            {
                //usp
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Empleado getEmpleado(String codEmpl)
        {
            Empleado empleado = new Empleado();
            try
            {
                //LINQ vista
                return empleado;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}