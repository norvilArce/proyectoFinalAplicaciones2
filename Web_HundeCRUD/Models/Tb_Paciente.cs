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
    
    public partial class Tb_Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Paciente()
        {
            this.Tb_Consulta = new HashSet<Tb_Consulta>();
        }
    
        public string cod_pac { get; set; }
        public string nom_pac { get; set; }
        public string tipo_pac { get; set; }
        public string raza { get; set; }
        public System.DateTime fec_nac_pac { get; set; }
        public int sexo { get; set; }
        public string color { get; set; }
        public double longitud { get; set; }
        public double peso { get; set; }
        public Nullable<System.DateTime> ult_vis_pac { get; set; }
        public string foto { get; set; }
        public string observaciones_pac { get; set; }
        public int est_pac { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Consulta> Tb_Consulta { get; set; }
    }
}