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
    using System.Collections.Generic;
    
    public partial class Tb_Cita
    {
        public int cod_cita { get; set; }
        public System.DateTime fec_reserva { get; set; }
        public System.DateTime fec_cita { get; set; }
        public System.TimeSpan hor_cita { get; set; }
        public int est_cita { get; set; }
        public string cod_cli { get; set; }
    
        public virtual Tb_Cliente Tb_Cliente { get; set; }
    }
}
