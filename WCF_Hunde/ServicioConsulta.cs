using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioConsulta" en el código y en el archivo de configuración a la vez.
    public class ServicioConsulta : IServicioConsulta
    {
        HundeDBEntities hundeDB = new HundeDBEntities();

        public bool ReservarCita(DateTime FechaHora, String codigoCliente)
        {
            DateTime fecha = FechaHora.Date;
            TimeSpan hora = FechaHora.TimeOfDay;

            try
            {
                hundeDB.usp_ReservarCita(fecha, hora, codigoCliente);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ActualizarReserva(Cita cita)
        {
            try
            {
                hundeDB.usp_ActualizarReservarCita(cita.fec_cita, cita.hor_cita, cita.cod_cli, cita.cod_cita);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CancelarReserva(Int16 codigoCita)
        {
            try
            {
                hundeDB.usp_CancelarReserva(codigoCita);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool GenerarConsulta(String codigoPaciente, String codigoEmpleado, Int16 codigoCita)
        {
            try
            {
                hundeDB.usp_GenerarConsulta(codigoPaciente, codigoEmpleado, codigoCita);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CancelarConsulta(Int16 codigoConsulta)
        {
            try
            {
                hundeDB.usp_CancelarConsulta(codigoConsulta);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool AgregarDetallesDeConsulta(Int16 codigoConsulta, Int16 codigoTratamiento, Int16 codigoEstado, Int16 codigoMedicina, String observaciones)
        {
            try
            {
                hundeDB.usp_AgregarDetallesDeConsulta(codigoConsulta, codigoTratamiento, codigoEstado, codigoMedicina, observaciones);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Consulta> ConsultasPorFecha(DateTime fechaConsulta)
        {
            try
            {
                List<Consulta> consultas = new List<Consulta>();
                var query = hundeDB.usp_ConsultasPorFecha(fechaConsulta);

                foreach (var i in query)
                {
                    Consulta consulta = new Consulta();
                    consulta.cod_cita = Convert.ToInt16(i.cod_cita);
                    consulta.fec_consulta = i.fecha.ToString().Substring(0, 10);
                    consulta.hora_consulta = i.hora.ToString().Substring(0, 5);
                    consulta.cod_emp = i.cod_emp;
                    consulta.nom_emp = i.medico;
                    consulta.cod_pac = i.cod_pac;
                    consulta.nom_pac = i.mascota;
                    consulta.tipo_pac = i.tipo;
                    consulta.raza_pac = i.raza;
                    consulta.color_pac = i.color;
                    consulta.cod_cli = i.cod_cli;
                    consulta.nom_cli = i.lo_trajo;
                    consulta.conduta = i.conducta;
                    consulta.est_nutricional = i.est_nutricional;
                    consulta.actividad = i.actividad;
                    consulta.observaciones = i.observaciones;

                    consultas.Add(consulta);
                }
                return consultas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Consulta> ConsultasPorMascota(string codigoMascota)
        {
            try
            {
                List<Consulta> consultas = new List<Consulta>();
                var query = hundeDB.usp_ConsultasPorMascota(codigoMascota);

                foreach (var i in query)
                {
                    Consulta consulta = new Consulta();
                    consulta.cod_cita = Convert.ToInt16(i.cod_cita);
                    consulta.fec_consulta = i.fecha.ToString().Substring(0, 10);
                    consulta.hora_consulta = i.hora.ToString().Substring(0, 5);
                    consulta.cod_emp = i.cod_emp;
                    consulta.nom_emp = i.medico;
                    consulta.cod_pac = i.cod_pac;
                    consulta.nom_pac = i.mascota;
                    consulta.tipo_pac = i.tipo;
                    consulta.raza_pac = i.raza;
                    consulta.color_pac = i.color;
                    consulta.cod_cli = i.cod_cli;
                    consulta.nom_cli = i.lo_trajo;
                    consulta.conduta = i.conducta;
                    consulta.est_nutricional = i.est_nutricional;
                    consulta.actividad = i.actividad;
                    consulta.observaciones = i.observaciones;

                    consultas.Add(consulta);
                }
                return consultas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Consulta> ConsultasPorMascotaEntreFechas(string codigoMascota, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<Consulta> consultas = new List<Consulta>();
                var query = hundeDB.usp_ConsultasPorMascotaEntreFechas(codigoMascota, fechaIni, fechaFin);

                foreach (var i in query)
                {
                    Consulta consulta = new Consulta();
                    consulta.cod_cita = Convert.ToInt16(i.cod_cita);
                    consulta.fec_consulta = i.fecha.ToString().Substring(0, 10);
                    consulta.hora_consulta = i.hora.ToString().Substring(0, 5);
                    consulta.cod_emp = i.cod_emp;
                    consulta.nom_emp = i.medico;
                    consulta.cod_pac = i.cod_pac;
                    consulta.nom_pac = i.mascota;
                    consulta.tipo_pac = i.tipo;
                    consulta.raza_pac = i.raza;
                    consulta.color_pac = i.color;
                    consulta.cod_cli = i.cod_cli;
                    consulta.nom_cli = i.lo_trajo;
                    consulta.conduta = i.conducta;
                    consulta.est_nutricional = i.est_nutricional;
                    consulta.actividad = i.actividad;
                    consulta.observaciones = i.observaciones;

                    consultas.Add(consulta);
                }
                return consultas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Consulta> ConsultasPorMedico(string codigoMedico)
        {
            try
            {
                List<Consulta> consultas = new List<Consulta>();
                var query = hundeDB.usp_ConsultasPorMedico(codigoMedico);

                foreach (var i in query)
                {
                    Consulta consulta = new Consulta();
                    consulta.cod_cita = Convert.ToInt16(i.cod_cita);
                    consulta.fec_consulta = i.fecha.ToString().Substring(0, 10);
                    consulta.hora_consulta = i.hora.ToString().Substring(0, 5);
                    consulta.cod_emp = i.cod_emp;
                    consulta.nom_emp = i.medico;
                    consulta.cod_pac = i.cod_pac;
                    consulta.nom_pac = i.mascota;
                    consulta.tipo_pac = i.tipo;
                    consulta.raza_pac = i.raza;
                    consulta.color_pac = i.color;
                    consulta.cod_cli = i.cod_cli;
                    consulta.nom_cli = i.lo_trajo;
                    consulta.conduta = i.conducta;
                    consulta.est_nutricional = i.est_nutricional;
                    consulta.actividad = i.actividad;
                    consulta.observaciones = i.observaciones;

                    consultas.Add(consulta);
                }
                return consultas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Consulta> ConsultasPorMedicoEntreFechas(string codigoMedico, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<Consulta> consultas = new List<Consulta>();
                var query = hundeDB.usp_ConsultasPorMedicoEntreFechas(codigoMedico, fechaIni, fechaFin);

                foreach (var i in query)
                {
                    Consulta consulta = new Consulta();
                    consulta.cod_cita = Convert.ToInt16(i.cod_cita);
                    consulta.fec_consulta = i.fecha.ToString().Substring(0, 10);
                    consulta.hora_consulta = i.hora.ToString().Substring(0, 5);
                    consulta.cod_emp = i.cod_emp;
                    consulta.nom_emp = i.medico;
                    consulta.cod_pac = i.cod_pac;
                    consulta.nom_pac = i.mascota;
                    consulta.tipo_pac = i.tipo;
                    consulta.raza_pac = i.raza;
                    consulta.color_pac = i.color;
                    consulta.cod_cli = i.cod_cli;
                    consulta.nom_cli = i.lo_trajo;
                    consulta.conduta = i.conducta;
                    consulta.est_nutricional = i.est_nutricional;
                    consulta.actividad = i.actividad;
                    consulta.observaciones = i.observaciones;

                    consultas.Add(consulta);
                }
                return consultas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Consulta> EntreFechas(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<Consulta> consultas = new List<Consulta>();
                var query = hundeDB.usp_ConsultasEntreFechas(fechaIni, fechaFin);

                foreach (var i in query)
                {
                    Consulta consulta = new Consulta();
                    consulta.cod_cita = Convert.ToInt16(i.cod_cita);
                    consulta.fec_consulta = i.fecha.ToString().Substring(0, 10);
                    consulta.hora_consulta = i.hora.ToString().Substring(0, 5);
                    consulta.cod_emp = i.cod_emp;
                    consulta.nom_emp = i.medico;
                    consulta.cod_pac = i.cod_pac;
                    consulta.nom_pac = i.mascota;
                    consulta.tipo_pac = i.tipo;
                    consulta.raza_pac = i.raza;
                    consulta.color_pac = i.color;
                    consulta.cod_cli = i.cod_cli;
                    consulta.nom_cli = i.lo_trajo;
                    consulta.conduta = i.conducta;
                    consulta.est_nutricional = i.est_nutricional;
                    consulta.actividad = i.actividad;
                    consulta.observaciones = i.observaciones;

                    consultas.Add(consulta);
                }
                return consultas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
