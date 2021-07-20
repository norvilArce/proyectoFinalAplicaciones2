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
                hundeDB.usp_InsertarEmpleado(empleado.cod_rol, empleado.tipo_emp, empleado.nom_emp, empleado.ape_emp,
                    empleado.dir_emp, empleado.id_ubigeo, empleado.fecha_ingreso, empleado.sueldo, empleado.email_emp,
                    empleado.cod_supervisor, empleado.us_ureg_emp, Convert.ToInt16(empleado.estado_emp));
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
                //LINQ 
                Tb_Empleado currentEmpleado = (from emp in hundeDB.Tb_Empleado
                                               where emp.cod_emp == codEmpl
                                               select emp).FirstOrDefault();

                Empleado empleado = new Empleado();

                if (currentEmpleado != null)
                {
                    empleado.cod_emp = currentEmpleado.cod_emp;
                    empleado.cod_rol = Convert.ToInt16(currentEmpleado.cod_rol);
                    empleado.tipo_emp = Convert.ToInt16(currentEmpleado.tipo_emp);
                    empleado.nom_emp = currentEmpleado.nom_empleado;
                    empleado.ape_emp = currentEmpleado.ape_empleado;
                    empleado.dir_emp = currentEmpleado.direccion_empleado;
                    empleado.id_ubigeo = currentEmpleado.id_ubigeo;
                    empleado.fecha_ingreso = currentEmpleado.fecha_ingreso;
                    empleado.sueldo = Convert.ToInt16(currentEmpleado.sueldo);
                    empleado.email_emp = currentEmpleado.email_emp;
                    empleado.cod_supervisor = currentEmpleado.cod_supervisor;
                    empleado.us_ureg_emp = currentEmpleado.usu_reg_cli;
                    empleado.fecha_reg_emp = Convert.ToDateTime(currentEmpleado.fec_reg_cli);
                    empleado.usu_ult_modificacion_emp = currentEmpleado.usu_ult_modificacion_emp;
                    empleado.fecha_ult_modificacion_emp = Convert.ToDateTime(currentEmpleado.fecha_ult_modificacion_emp);
                    empleado.estado_emp = Convert.ToBoolean(currentEmpleado.estado_emp);

                    empleado.rol = currentEmpleado.Tb_Rol.nom_rol;
                    empleado.nom_ape = currentEmpleado.nom_empleado + ' ' + currentEmpleado.ape_empleado;
                }

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
                hundeDB.usp_ActualizarEmpleado(empleado.cod_rol, empleado.tipo_emp, empleado.nom_emp, empleado.ape_emp,
                    empleado.dir_emp, empleado.id_ubigeo, empleado.fecha_ingreso, empleado.sueldo, empleado.email_emp,
                    empleado.cod_supervisor, empleado.usu_ult_modificacion_emp, Convert.ToInt16(empleado.estado_emp), empleado.cod_emp);

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
                    currentEmpleado.cod_rol = Convert.ToInt16(emp.cod_rol);
                    currentEmpleado.tipo_emp = Convert.ToInt16(emp.tipo_emp);
                    currentEmpleado.nom_emp = emp.nom_empleado;
                    currentEmpleado.ape_emp = emp.ape_empleado;
                    currentEmpleado.dir_emp = emp.direccion_empleado;
                    currentEmpleado.id_ubigeo = emp.id_ubigeo;
                    currentEmpleado.fecha_ingreso = emp.fecha_ingreso;
                    currentEmpleado.sueldo = Convert.ToInt16(emp.sueldo);
                    currentEmpleado.email_emp = emp.email_emp;
                    currentEmpleado.cod_supervisor = emp.cod_supervisor;
                    currentEmpleado.us_ureg_emp = emp.usu_reg_cli;
                    currentEmpleado.fecha_reg_emp = Convert.ToDateTime(emp.fec_reg_cli);
                    currentEmpleado.usu_ult_modificacion_emp = emp.usu_ult_modificacion_emp;
                    currentEmpleado.fecha_ult_modificacion_emp = Convert.ToDateTime(emp.fecha_ult_modificacion_emp);
                    currentEmpleado.estado_emp = Convert.ToBoolean(emp.estado_emp);

                    currentEmpleado.rol = emp.Tb_Rol.nom_rol;
                    currentEmpleado.sup = emp.Tb_Empleado2.nom_empleado + ' ' + emp.Tb_Empleado2.ape_empleado;
                    currentEmpleado.estado = emp.estado_emp == 1 ? "Activo" : "Inactivo";
                    currentEmpleado.nom_ape = currentEmpleado.nom_emp + ' ' + currentEmpleado.ape_emp;

                    empleados.Add(currentEmpleado);
                }

                return empleados;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Empleado> ListarSupervisores()
        {
            try
            {
                //LINQ 

                List<Empleado> empleados = new List<Empleado>();

                var query = (from emp in hundeDB.Tb_Empleado
                             where emp.tipo_emp == 1
                             select emp);

                foreach (var emp in query)
                {
                    Empleado currentEmpleado = new Empleado();

                    currentEmpleado.cod_emp = emp.cod_emp;
                    currentEmpleado.cod_rol = Convert.ToInt16(emp.cod_rol);
                    currentEmpleado.tipo_emp = Convert.ToInt16(emp.tipo_emp);
                    currentEmpleado.nom_emp = emp.nom_empleado;
                    currentEmpleado.ape_emp = emp.ape_empleado;
                    currentEmpleado.dir_emp = emp.direccion_empleado;
                    currentEmpleado.id_ubigeo = emp.id_ubigeo;
                    currentEmpleado.fecha_ingreso = emp.fecha_ingreso;
                    currentEmpleado.sueldo = Convert.ToInt16(emp.sueldo);
                    currentEmpleado.email_emp = emp.email_emp;
                    currentEmpleado.cod_supervisor = emp.cod_supervisor;
                    currentEmpleado.us_ureg_emp = emp.usu_reg_cli;
                    currentEmpleado.fecha_reg_emp = Convert.ToDateTime(emp.fec_reg_cli);
                    currentEmpleado.usu_ult_modificacion_emp = emp.usu_ult_modificacion_emp;
                    currentEmpleado.fecha_ult_modificacion_emp = Convert.ToDateTime(emp.fecha_ult_modificacion_emp);
                    currentEmpleado.estado_emp = Convert.ToBoolean(emp.estado_emp);

                    currentEmpleado.nom_ape = currentEmpleado.nom_emp + ' ' + currentEmpleado.ape_emp;

                    empleados.Add(currentEmpleado);
                }

                return empleados;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Empleado> EmpleadosPorDepartamento(String idDepa)
        {
            try
            {
                List<Empleado> empleados = new List<Empleado>();

                var query = hundeDB.usp_EmpleadosPorDepartamento(idDepa);

                foreach (var emp in query)
                {
                    Empleado currentEmpleado = new Empleado();

                    currentEmpleado.cod_emp = emp.cod_emp;
                    currentEmpleado.cod_rol = Convert.ToInt16(emp.cod_rol);
                    currentEmpleado.tipo_emp = Convert.ToInt16(emp.tipo_emp);
                    currentEmpleado.nom_emp = emp.nom_empleado;
                    currentEmpleado.ape_emp = emp.ape_empleado;
                    currentEmpleado.dir_emp = emp.direccion_empleado;
                    currentEmpleado.id_ubigeo = emp.id_ubigeo;
                    currentEmpleado.fecha_ingreso = emp.fecha_ingreso;
                    currentEmpleado.sueldo = Convert.ToInt16(emp.sueldo);
                    currentEmpleado.email_emp = emp.email_emp;
                    currentEmpleado.cod_supervisor = emp.cod_supervisor;
                    currentEmpleado.us_ureg_emp = emp.usu_reg_cli;
                    currentEmpleado.fecha_reg_emp = Convert.ToDateTime(emp.fec_reg_cli);
                    currentEmpleado.usu_ult_modificacion_emp = emp.usu_ult_modificacion_emp;
                    currentEmpleado.fecha_ult_modificacion_emp = Convert.ToDateTime(emp.fecha_ult_modificacion_emp);
                    currentEmpleado.estado_emp = Convert.ToBoolean(emp.estado_emp);

                    currentEmpleado.departamento = emp.Departamento;
                    currentEmpleado.provincia = emp.Provincia;
                    currentEmpleado.distrito = emp.Distrito;

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
