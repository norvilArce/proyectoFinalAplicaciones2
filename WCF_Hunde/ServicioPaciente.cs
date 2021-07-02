using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPaciente" en el código y en el archivo de configuración a la vez.
    public class ServicioPaciente : IServicioPaciente
    {
        public List<PacienteBE> ConsultarPacientesPorRaza(string srtRazaPaciente)
        {

            HundeDBEntities misPacientes = new HundeDBEntities();
            List<PacienteBE> objListaPacientesRazaBE = new List<PacienteBE>();

            try
            {

                var query = misPacientes.usp_ListarPacientesPorRaza(srtRazaPaciente);
                foreach (var objPacienteRaza in query)
                {
                    PacienteBE objPacienteRazaBE = new PacienteBE();
                    objPacienteRazaBE.Cod_pac = objPacienteRaza.cod_pac;
                    objPacienteRazaBE.Nom_pac = objPacienteRaza.nom_pac;
                    objPacienteRazaBE.Tipo_pac = objPacienteRaza.tipo_pac;
                    objPacienteRazaBE.Raza = objPacienteRaza.raza;
                    objPacienteRazaBE.Fec_nac_pac = Convert.ToDateTime(objPacienteRaza.fec_nac_pac);
                    objPacienteRazaBE.Sexo = Convert.ToInt16(objPacienteRaza.sexo);
                    objPacienteRazaBE.Color = objPacienteRaza.color;
                    objPacienteRazaBE.Longitud = Convert.ToDecimal(objPacienteRaza.longitud);
                    objPacienteRazaBE.Peso = Convert.ToDecimal(objPacienteRaza.peso);
                    objPacienteRazaBE.Ult_vis_pac = Convert.ToDateTime(objPacienteRaza.ult_vis_pac);
                    objPacienteRazaBE.Foto = objPacienteRaza.foto;
                    objPacienteRazaBE.Observaciones = objPacienteRaza.observaciones_pac;
                    objPacienteRazaBE.Est_pac = Convert.ToInt16(objPacienteRaza.est_pac);

                    objListaPacientesRazaBE.Add(objPacienteRazaBE);

                }
                return objListaPacientesRazaBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<PacienteBE> ConsultarPacientesPorFecha(String strCod, DateTime fecini, DateTime fecfin)
        {
            HundeDBEntities misPacientes = new HundeDBEntities();
            List<PacienteBE> objListaPacientesFechaBE = new List<PacienteBE>();

            try
            {
                var query = (from Pac in misPacientes.Tb_Paciente
                             where Pac.cod_pac == strCod && Pac.ult_vis_pac <= fecfin
                             select Pac);

                foreach (var resultado in query)
                {
                    PacienteBE objPacienteBE = new PacienteBE();
                    objPacienteBE.Cod_pac = resultado.cod_pac;
                    objPacienteBE.Nom_pac = resultado.nom_pac;
                    objPacienteBE.Tipo_pac = resultado.tipo_pac;
                    objPacienteBE.Raza = resultado.raza;
                    objPacienteBE.Fec_nac_pac = Convert.ToDateTime(resultado.fec_nac_pac);
                    objPacienteBE.Sexo = resultado.sexo;
                    objPacienteBE.Color = resultado.color;
                    objPacienteBE.Longitud = Convert.ToDecimal(resultado.longitud);
                    objPacienteBE.Peso = Convert.ToDecimal(resultado.peso);
                    objPacienteBE.Ult_vis_pac = Convert.ToDateTime(resultado.ult_vis_pac);
                    objPacienteBE.Observaciones = resultado.observaciones_pac;
                    objPacienteBE.Est_pac = resultado.est_pac;

                    objListaPacientesFechaBE.Add(objPacienteBE);
                }

                return objListaPacientesFechaBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<PacienteBE> ConsultarPacientesPorTratamiento(string srtTipoTratamiento)
        {
            HundeDBEntities misPacientes = new HundeDBEntities();
            List<PacienteBE> objListaPacientesTratBE = new List<PacienteBE>();

            try
            {
                var query = misPacientes.usp_ListarPacientePorTratamiento(srtTipoTratamiento);
                foreach (var resultado in query)
                {
                    PacienteBE objPacienteBE = new PacienteBE();
                    objPacienteBE.Cod_pac = resultado.cod_pac;
                    objPacienteBE.Nom_pac = resultado.nom_pac;
                    objPacienteBE.Tipo_pac = resultado.tipo_pac;
                    objPacienteBE.Raza = resultado.raza;
                    objPacienteBE.Fec_nac_pac = Convert.ToDateTime(resultado.fec_nac_pac);
                    objPacienteBE.Sexo = resultado.sexo;
                    //objPacienteBE.Color = resultado.color;
                    objPacienteBE.Longitud = Convert.ToDecimal(resultado.longitud);
                    objPacienteBE.Peso = Convert.ToDecimal(resultado.peso);
                    objPacienteBE.Ult_vis_pac = Convert.ToDateTime(resultado.ult_vis_pac);
                    objPacienteBE.Observaciones = resultado.observaciones_pac;
                    objPacienteBE.Est_pac = resultado.est_pac;

                    objListaPacientesTratBE.Add(objPacienteBE);

                }
                return objListaPacientesTratBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
