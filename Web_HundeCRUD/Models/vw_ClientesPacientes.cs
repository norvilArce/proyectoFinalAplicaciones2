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
    
    public partial class vw_ClientesPacientes
    {
        public string cod_cli { get; set; }
        public string dni_cliente { get; set; }
        public string nombre_completo { get; set; }
        public string direccion_cliente { get; set; }
        public string cel_cliente { get; set; }
        public Nullable<int> es_dueno { get; set; }
        public string cod_pac { get; set; }
        public string nom_pac { get; set; }
        public string tipo_pac { get; set; }
        public string raza { get; set; }
        public Nullable<int> estado_cli { get; set; }
        public Nullable<int> est_pac { get; set; }
    }
}
