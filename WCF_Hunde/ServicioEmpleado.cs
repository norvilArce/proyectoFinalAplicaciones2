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
        public Boolean InsertarEmpleado(Empleado empleado)
        {
            try
            {
                //usp
                hundeDB.usp_InsertarEmpleado(empleado.rol_emp, empleado.nom_empleado, empleado.ape_empleado, empleado.fecha_ingreso,
                    empleado.sueldo, empleado.email_emp, empleado.cod_supervisor, Convert.ToInt16(empleado.estado_emp));
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }


        public Empleado ConsultarEmpleado(String codEmpl)
        {
            try
            {
                //LINQ vista
                Tb_Empleado currentEmpleado = (from emp in hundeDB.Tb_Empleado
                                                           where emp.cod_emp == codEmpl
                                                           select emp).FirstOrDefault();

                Empleado empleado = new Empleado();

                empleado.cod_emp = currentEmpleado.cod_emp;
                empleado.rol_emp = Convert.ToInt16(currentEmpleado.rol_emp);
                empleado.nom_empleado = currentEmpleado.nom_empleado;
                empleado.ape_empleado = currentEmpleado.ape_empleado;
                empleado.fecha_ingreso = currentEmpleado.fecha_ingreso;
                empleado.sueldo = Convert.ToInt16(currentEmpleado.sueldo);
                empleado.email_emp = currentEmpleado.email_emp;
                empleado.cod_supervisor = currentEmpleado.cod_supervisor;
                empleado.usu_ult_modificacion_emp = currentEmpleado.usu_ult_modificacion_emp;
                empleado.fecha_ult_modificacion_emp = Convert.ToDateTime(currentEmpleado.fecha_ult_modificacion_emp);
                empleado.estado_emp = Convert.ToBoolean(currentEmpleado.estado_emp);

                return empleado;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Boolean ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                //usp
                hundeDB.usp_ActualizarEmpleado(empleado.rol_emp, empleado.nom_empleado, empleado.ape_empleado,
                    empleado.fecha_ingreso, empleado.sueldo, empleado.email_emp,
                    empleado.cod_supervisor, empleado.usu_ult_modificacion_emp, empleado.fecha_ult_modificacion_emp,
                    Convert.ToInt16(empleado.estado_emp), empleado.cod_emp);
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Boolean EliminarEmpleado(String codEmpl)
        {
            try
            {
                hundeDB.usp_EliminarEmpleado(codEmpl);
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Empleado> ListarEmpleados()
        {
            try
            {
                //LINQ 

                List<Empleado> empleados = new List<Empleado>();

                var query = (from emp in hundeDB.Tb_Empleado
                             select emp);

                foreach (var emp in query)
                {
                    Empleado currentEmpleado = new Empleado();

                    currentEmpleado.cod_emp = emp.cod_emp;
                    currentEmpleado.rol_emp = Convert.ToInt16(emp.rol_emp);
                    currentEmpleado.nom_empleado = emp.nom_empleado;
                    currentEmpleado.ape_empleado = emp.ape_empleado;
                    currentEmpleado.fecha_ingreso = emp.fecha_ingreso;
                    currentEmpleado.sueldo = Convert.ToInt16(emp.sueldo);
                    currentEmpleado.email_emp = emp.email_emp;
                    currentEmpleado.cod_supervisor = emp.cod_supervisor;
                    currentEmpleado.usu_ult_modificacion_emp = emp.usu_ult_modificacion_emp;
                    currentEmpleado.fecha_ult_modificacion_emp = Convert.ToDateTime(emp.fecha_ult_modificacion_emp);
                    currentEmpleado.estado_emp = Convert.ToBoolean(emp.estado_emp);

                    empleados.Add(currentEmpleado);
                }

                return empleados;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
