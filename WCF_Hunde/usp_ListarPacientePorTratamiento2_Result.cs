//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Hunde
{
    using System;
    
    public partial class usp_ListarPacientePorTratamiento2_Result
    {
        public string cod_pac { get; set; }
        public string nom_pac { get; set; }
        public string tipo_pac { get; set; }
        public string raza { get; set; }
        public System.DateTime fec_nac_pac { get; set; }
        public string color { get; set; }
        public int sexo { get; set; }
        public double longitud { get; set; }
        public double peso { get; set; }
        public Nullable<System.DateTime> ult_vis_pac { get; set; }
        public string observaciones_pac { get; set; }
        public int est_pac { get; set; }
        public int cod_trat { get; set; }
        public string nombre_trat { get; set; }
        public string tipo_trat { get; set; }
        public Nullable<int> estado_trat { get; set; }
    }
}
