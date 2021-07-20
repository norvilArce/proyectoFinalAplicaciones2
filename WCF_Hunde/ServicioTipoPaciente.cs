using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTipoPaciente" en el código y en el archivo de configuración a la vez.
    public class ServicioTipoPaciente : IServicioTipoPaciente
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public List<TipoPaciente> listarTipos()
        {
            List<TipoPaciente> tipos = new List<TipoPaciente>();
            try
            {
                var query = from tipo in hundeDB.Tb_Tipo_Paciente
                            select tipo;
                foreach (var i in query)
                {
                    TipoPaciente tipo = new TipoPaciente();
                    tipo.cod_tipo = Convert.ToInt16(i.cod_tipo);
                    tipo.nom_tipo = i.nom_tipo;
                    tipos.Add(tipo);
                }
                return tipos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoPaciente TipoPorRaza(Int16 codRaza)
        {
            TipoPaciente tipo = new TipoPaciente();
            try
            {
                Tb_Raza raza = (from r in hundeDB.Tb_Raza
                                where r.cod_raza == codRaza
                                select r).FirstOrDefault();

                tipo.cod_tipo = Convert.ToInt16(raza.cod_tipo);
                tipo.nom_tipo = raza.Tb_Tipo_Paciente.nom_tipo;
                return tipo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
