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
    
    public partial class Tb_Usuario
    {
        public string login_usuario { get; set; }
        public string pass_usuario { get; set; }
        public Nullable<int> niv_usuario { get; set; }
        public Nullable<int> est_usuario { get; set; }
        public Nullable<System.DateTime> fec_registro { get; set; }
        public string usu_reg_usu { get; set; }
        public string cod_emp { get; set; }
    
        public virtual Tb_Empleado Tb_Empleado { get; set; }
    }
}