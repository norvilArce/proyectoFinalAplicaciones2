using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPaciente" en el código y en el archivo de configuración a la vez.
    public class ServicioPaciente : IServicioPaciente
    {
        HundeDBEntities misPacientes = new HundeDBEntities();
        public List<PacienteBE> ConsultarPacientesPorRaza(Int16 codRaza)
        {
            List<PacienteBE> pacientes = new List<PacienteBE>();
            try
            {
                var query = misPacientes.usp_PacientesPorRaza(codRaza);

                foreach (var tb_Paciente in query)
                {
                    PacienteBE paciente = new PacienteBE();

                    paciente.cod_pac = tb_Paciente.cod_pac;
                    paciente.nom_pac = tb_Paciente.nom_pac;
                    paciente.fec_nac_pac = Convert.ToDateTime(tb_Paciente.fec_nac_pac);
                    paciente.sexo = Convert.ToInt16(tb_Paciente.sexo);
                    paciente.cod_color = Convert.ToInt16(tb_Paciente.cod_color);
                    paciente.longitud = tb_Paciente.longitud;
                    paciente.peso = tb_Paciente.peso;
                    paciente.ult_vis_pac = Convert.ToDateTime(tb_Paciente.ult_vis_pac);
                    //paciente.foto = tb_Paciente.foto;
                    paciente.observaciones = tb_Paciente.observaciones_pac;
                    paciente.est_pac = Convert.ToInt16(tb_Paciente.est_pac);   

                    paciente.raza = tb_Paciente.nom_raza;
                    paciente.color = tb_Paciente.nom_color;
                    paciente.tipo = tb_Paciente.nom_tipo;
                    if (tb_Paciente.sexo == 1)
                    {
                        paciente.str_sexo = "Macho";
                    }
                    else if (tb_Paciente.sexo == 2)
                    {
                        paciente.str_sexo = "Hembra";
                    }


                    pacientes.Add(paciente);
                }
                return pacientes;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PacienteBE> ConsultarPacientesPorTratamiento(Int16 codTratamiento)
        {
            List<PacienteBE> objListaPacientesTratBE = new List<PacienteBE>();
            try
            {
                var query = misPacientes.usp_ListarPacientePorTratamiento(codTratamiento);
                foreach (var resultado in query)
                {
                    PacienteBE objPacienteBE = new PacienteBE();
                    objPacienteBE.cod_pac = resultado.cod_pac;
                    objPacienteBE.nom_pac = resultado.nom_pac;
                    objPacienteBE.tipo = resultado.tipo;
                    objPacienteBE.raza = resultado.raza;
                    objPacienteBE.fec_nac_pac = Convert.ToDateTime(resultado.fec_nac_pac);
                    objPacienteBE.cod_pac = resultado.color;
                    objPacienteBE.sexo = Convert.ToInt16(resultado.sexo);
                    objPacienteBE.longitud = resultado.longitud;
                    objPacienteBE.peso = resultado.peso;
                    objPacienteBE.est_pac = resultado.est_pac;

                    objListaPacientesTratBE.Add(objPacienteBE);

                }
                return objListaPacientesTratBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PacienteBE ConsultarPacientes(string strCodPaciente)
        {
            PacienteBE paciente = new PacienteBE();
            try
            {
                Tb_Paciente tb_Paciente = new Tb_Paciente();


                tb_Paciente = (from pac in misPacientes.Tb_Paciente
                               where pac.cod_pac == strCodPaciente
                               select pac).FirstOrDefault();
                if (tb_Paciente != null)
                {
                    paciente.cod_pac = tb_Paciente.cod_pac;
                    paciente.nom_pac = tb_Paciente.nom_pac;
                    paciente.cod_raza = Convert.ToInt16(tb_Paciente.cod_raza);
                    paciente.fec_nac_pac = Convert.ToDateTime(tb_Paciente.fec_nac_pac);
                    paciente.sexo = Convert.ToInt16(tb_Paciente.sexo);
                    paciente.cod_color = Convert.ToInt16(tb_Paciente.cod_color);
                    paciente.longitud = tb_Paciente.longitud;
                    paciente.peso = tb_Paciente.peso;
                    paciente.ult_vis_pac = Convert.ToDateTime(tb_Paciente.ult_vis_pac);
                    paciente.foto = tb_Paciente.foto;
                    paciente.observaciones = tb_Paciente.observaciones_pac;
                    paciente.est_pac = Convert.ToInt16(tb_Paciente.est_pac);

                    paciente.raza = tb_Paciente.Tb_Raza.nom_raza;
                    paciente.color = tb_Paciente.Tb_Color.nom_color;
                    paciente.tipo = tb_Paciente.Tb_Raza.Tb_Tipo_Paciente.nom_tipo;
                    if (tb_Paciente.sexo == 1)
                    {
                        paciente.str_sexo = "Macho";
                    }
                    else if (tb_Paciente.sexo == 2)
                    {
                        paciente.str_sexo = "Hembra";
                    }
                }
                return paciente;
            }
            catch (NullReferenceException)
            {
                return paciente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PacienteBE> ListarPacientesDetallados()
        {
            List<PacienteBE> pacientes = new List<PacienteBE>();
            try
            {
                var query = (from pac in misPacientes.vw_DetallesPaciente
                             select pac);

                foreach (var tb_Paciente in query)
                {
                    PacienteBE paciente = new PacienteBE();
                    paciente.cod_pac = tb_Paciente.codigo;
                    paciente.nom_pac = tb_Paciente.nombre;
                    paciente.fec_nac_pac = Convert.ToDateTime(tb_Paciente.fec_nac_pac);
                    paciente.sexo = Convert.ToInt16(tb_Paciente.sexo);
                    paciente.longitud = Convert.ToDouble(tb_Paciente.longitud);
                    paciente.peso = Convert.ToDouble(tb_Paciente.peso);
                    //paciente.foto = tb_Paciente.foto;
                    paciente.observaciones = tb_Paciente.observaciones;
                    paciente.est_pac = Convert.ToInt16(tb_Paciente.estado);

                    paciente.raza = tb_Paciente.nom_raza;
                    paciente.color = tb_Paciente.color;
                    paciente.tipo = tb_Paciente.tipo;
                    if (tb_Paciente.sexo == 1)
                    {
                        paciente.str_sexo = "Macho";
                    }
                    else if (tb_Paciente.sexo == 2)
                    {
                        paciente.str_sexo = "Hembra";
                    }
                    pacientes.Add(paciente);
                }
                return pacientes;
            }
            catch (NullReferenceException)
            {
                return pacientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool InsertarPaciente(PacienteBE pacienteBE)
        {
            try
            {
                misPacientes.usp_InsertarPaciente(pacienteBE.nom_pac, pacienteBE.cod_raza, pacienteBE.fec_nac_pac, pacienteBE.sexo,
                    pacienteBE.cod_color, Convert.ToDouble(pacienteBE.longitud), Convert.ToDouble(pacienteBE.peso), DateTime.Now, pacienteBE.foto, pacienteBE.observaciones,
                    pacienteBE.est_pac);
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ActualizarPaciente(PacienteBE pacienteBE)
        {
            try
            {
                misPacientes.usp_ActualizarPaciente(pacienteBE.nom_pac, pacienteBE.cod_raza, pacienteBE.fec_nac_pac, pacienteBE.sexo, pacienteBE.cod_color,
                    Convert.ToDouble(pacienteBE.longitud), Convert.ToDouble(pacienteBE.peso), pacienteBE.foto, pacienteBE.observaciones,
                    pacienteBE.est_pac, pacienteBE.cod_pac);
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PacienteBE> ListarPacientes()
        {
            List<PacienteBE> pacientes = new List<PacienteBE>();
            try
            {
                var query = (from pac in misPacientes.Tb_Paciente
                             select pac);

                foreach (var tb_Paciente in query)
                {
                    PacienteBE paciente = new PacienteBE();
                    paciente.cod_pac = tb_Paciente.cod_pac;
                    paciente.nom_pac = tb_Paciente.nom_pac;
                    paciente.fec_nac_pac = Convert.ToDateTime(tb_Paciente.fec_nac_pac);
                    paciente.sexo = Convert.ToInt16(tb_Paciente.sexo);
                    paciente.longitud = tb_Paciente.longitud;
                    paciente.peso = tb_Paciente.peso;
                    //paciente.foto = tb_Paciente.foto;
                    paciente.observaciones = tb_Paciente.observaciones_pac;
                    paciente.est_pac = Convert.ToInt16(tb_Paciente.est_pac);

                    paciente.raza = tb_Paciente.Tb_Raza.nom_raza;
                    paciente.color = tb_Paciente.Tb_Color.nom_color;
                    paciente.tipo = tb_Paciente.Tb_Raza.Tb_Tipo_Paciente.nom_tipo;
                    if (tb_Paciente.sexo == 1)
                    {
                        paciente.str_sexo = "Macho";
                    }
                    else if (tb_Paciente.sexo == 2)
                    {
                        paciente.str_sexo = "Hembra";
                    }
                    pacientes.Add(paciente);
                }
                return pacientes;
            }
            catch (NullReferenceException)
            {
                return pacientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
