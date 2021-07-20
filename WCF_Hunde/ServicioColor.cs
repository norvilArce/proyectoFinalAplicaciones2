using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioColor" en el código y en el archivo de configuración a la vez.
    public class ServicioColor : IServicioColor
    {
        HundeDBEntities hundeDB = new HundeDBEntities();
        public List<Color> ListarColores()
        {
            List<Color> colores = new List<Color>();
            try
            {
                var query = (from col in hundeDB.Tb_Color
                             select col);

                foreach (var i in query)
                {
                    Color color = new Color();
                    color.cod_color = Convert.ToInt16(i.cod_color);
                    color.nom_color = i.nom_color;
                    colores.Add(color);
                }
                return colores;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
