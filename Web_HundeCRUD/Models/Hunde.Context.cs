﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HundeDBEntities : DbContext
    {
        public HundeDBEntities()
            : base("name=HundeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Cita> Tb_Cita { get; set; }
        public virtual DbSet<Tb_Cliente> Tb_Cliente { get; set; }
        public virtual DbSet<Tb_Consulta> Tb_Consulta { get; set; }
        public virtual DbSet<Tb_Empleado> Tb_Empleado { get; set; }
        public virtual DbSet<Tb_Estado> Tb_Estado { get; set; }
        public virtual DbSet<Tb_Medicina> Tb_Medicina { get; set; }
        public virtual DbSet<Tb_Paciente> Tb_Paciente { get; set; }
        public virtual DbSet<Tb_Proveedor> Tb_Proveedor { get; set; }
        public virtual DbSet<Tb_Tratamiento> Tb_Tratamiento { get; set; }
        public virtual DbSet<Tb_Ubigeo> Tb_Ubigeo { get; set; }
        public virtual DbSet<Tb_unidad_medida> Tb_unidad_medida { get; set; }
        public virtual DbSet<Tb_Usuario> Tb_Usuario { get; set; }
        public virtual DbSet<Tb_Detalle_Consulta> Tb_Detalle_Consulta { get; set; }
        public virtual DbSet<vw_ClientesPacientes> vw_ClientesPacientes { get; set; }
    }
}
