//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_HundeCRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Consulta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Consulta()
        {
            this.Tb_Detalle_Consulta = new HashSet<Tb_Detalle_Consulta>();
        }
    
        public string cod_cons { get; set; }
        public System.DateTime fec_cons { get; set; }
        public System.TimeSpan hor_cons { get; set; }
        public string cod_pac { get; set; }
        public string cod_emp { get; set; }
        public int cod_cita { get; set; }
        public int est_cons { get; set; }
    
        public virtual Tb_Cita Tb_Cita { get; set; }
        public virtual Tb_Empleado Tb_Empleado { get; set; }
        public virtual Tb_Paciente Tb_Paciente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Detalle_Consulta> Tb_Detalle_Consulta { get; set; }
    }
}