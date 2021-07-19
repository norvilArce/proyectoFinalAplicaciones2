using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioRaza" en el código y en el archivo de configuración a la vez.
    public class ServicioRaza : IServicioRaza
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public List<Raza> listarRazas()
        {
            List<Raza> razas = new List<Raza>();
            try
            {
                var query = (from r in hundeDB.Tb_Raza
                             select r);

                foreach (var i in query)
                {
                    Raza raza = new Raza();

                    raza.cod_raza = Convert.ToInt16(i.cod_raza);
                    raza.nom_raza = i.nom_raza;
                    raza.cod_tipo = Convert.ToInt16(i.cod_tipo);

                    razas.Add(raza);
                }
                return razas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Raza> listarRazasPorTipo(short codTipo)
        {
            List<Raza> razas = new List<Raza>();
            try
            {
                var query = (from r in hundeDB.Tb_Raza
                             where r.cod_tipo == codTipo
                             select r);

                foreach (var i in query)
                {
                    Raza raza = new Raza();

                    raza.cod_raza = Convert.ToInt16(i.cod_raza);
                    raza.nom_raza = i.nom_raza;
                    raza.cod_tipo = Convert.ToInt16(i.cod_tipo);

                    razas.Add(raza);
                }
                return razas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
