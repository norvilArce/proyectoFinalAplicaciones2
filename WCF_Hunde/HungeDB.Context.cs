﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual DbSet<Tb_Cliente> Tb_Cliente { get; set; }
        public virtual DbSet<Tb_Empleado> Tb_Empleado { get; set; }
        public virtual DbSet<Tb_Medicina> Tb_Medicina { get; set; }
        public virtual DbSet<Tb_Paciente> Tb_Paciente { get; set; }
        public virtual DbSet<Tb_Proveedor> Tb_Proveedor { get; set; }
        public virtual DbSet<vw_DetallesPaciente> vw_DetallesPaciente { get; set; }
        public virtual DbSet<vw_ProveedorActivo> vw_ProveedorActivo { get; set; }
        public virtual DbSet<vw_ProveedorMedicina> vw_ProveedorMedicina { get; set; }
        public virtual DbSet<Tb_Usuario> Tb_Usuario { get; set; }
    
        public virtual int usp_ActualizarEmpleado(Nullable<int> vrol_emp, string vnom_empleado, string vape_empleado, Nullable<System.DateTime> vfecha_ingreso, Nullable<decimal> vsueldo, string vemail_emp, string vcod_supervisor, string vusu_ult_mod, Nullable<System.DateTime> vfec_ult_mod, Nullable<int> vestado_emp, string vcod_emp)
        {
            var vrol_empParameter = vrol_emp.HasValue ?
                new ObjectParameter("vrol_emp", vrol_emp) :
                new ObjectParameter("vrol_emp", typeof(int));
    
            var vnom_empleadoParameter = vnom_empleado != null ?
                new ObjectParameter("vnom_empleado", vnom_empleado) :
                new ObjectParameter("vnom_empleado", typeof(string));
    
            var vape_empleadoParameter = vape_empleado != null ?
                new ObjectParameter("vape_empleado", vape_empleado) :
                new ObjectParameter("vape_empleado", typeof(string));
    
            var vfecha_ingresoParameter = vfecha_ingreso.HasValue ?
                new ObjectParameter("vfecha_ingreso", vfecha_ingreso) :
                new ObjectParameter("vfecha_ingreso", typeof(System.DateTime));
    
            var vsueldoParameter = vsueldo.HasValue ?
                new ObjectParameter("vsueldo", vsueldo) :
                new ObjectParameter("vsueldo", typeof(decimal));
    
            var vemail_empParameter = vemail_emp != null ?
                new ObjectParameter("vemail_emp", vemail_emp) :
                new ObjectParameter("vemail_emp", typeof(string));
    
            var vcod_supervisorParameter = vcod_supervisor != null ?
                new ObjectParameter("vcod_supervisor", vcod_supervisor) :
                new ObjectParameter("vcod_supervisor", typeof(string));
    
            var vusu_ult_modParameter = vusu_ult_mod != null ?
                new ObjectParameter("vusu_ult_mod", vusu_ult_mod) :
                new ObjectParameter("vusu_ult_mod", typeof(string));
    
            var vfec_ult_modParameter = vfec_ult_mod.HasValue ?
                new ObjectParameter("vfec_ult_mod", vfec_ult_mod) :
                new ObjectParameter("vfec_ult_mod", typeof(System.DateTime));
    
            var vestado_empParameter = vestado_emp.HasValue ?
                new ObjectParameter("vestado_emp", vestado_emp) :
                new ObjectParameter("vestado_emp", typeof(int));
    
            var vcod_empParameter = vcod_emp != null ?
                new ObjectParameter("vcod_emp", vcod_emp) :
                new ObjectParameter("vcod_emp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarEmpleado", vrol_empParameter, vnom_empleadoParameter, vape_empleadoParameter, vfecha_ingresoParameter, vsueldoParameter, vemail_empParameter, vcod_supervisorParameter, vusu_ult_modParameter, vfec_ult_modParameter, vestado_empParameter, vcod_empParameter);
        }
    
        public virtual int usp_InsertarEmpleado(Nullable<int> vrol_emp, string vnom_empleado, string vape_empleado, Nullable<System.DateTime> vfecha_ingreso, Nullable<decimal> vsueldo, string vemail_emp, string vcod_supervisor, Nullable<int> vestado_emp)
        {
            var vrol_empParameter = vrol_emp.HasValue ?
                new ObjectParameter("vrol_emp", vrol_emp) :
                new ObjectParameter("vrol_emp", typeof(int));
    
            var vnom_empleadoParameter = vnom_empleado != null ?
                new ObjectParameter("vnom_empleado", vnom_empleado) :
                new ObjectParameter("vnom_empleado", typeof(string));
    
            var vape_empleadoParameter = vape_empleado != null ?
                new ObjectParameter("vape_empleado", vape_empleado) :
                new ObjectParameter("vape_empleado", typeof(string));
    
            var vfecha_ingresoParameter = vfecha_ingreso.HasValue ?
                new ObjectParameter("vfecha_ingreso", vfecha_ingreso) :
                new ObjectParameter("vfecha_ingreso", typeof(System.DateTime));
    
            var vsueldoParameter = vsueldo.HasValue ?
                new ObjectParameter("vsueldo", vsueldo) :
                new ObjectParameter("vsueldo", typeof(decimal));
    
            var vemail_empParameter = vemail_emp != null ?
                new ObjectParameter("vemail_emp", vemail_emp) :
                new ObjectParameter("vemail_emp", typeof(string));
    
            var vcod_supervisorParameter = vcod_supervisor != null ?
                new ObjectParameter("vcod_supervisor", vcod_supervisor) :
                new ObjectParameter("vcod_supervisor", typeof(string));
    
            var vestado_empParameter = vestado_emp.HasValue ?
                new ObjectParameter("vestado_emp", vestado_emp) :
                new ObjectParameter("vestado_emp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarEmpleado", vrol_empParameter, vnom_empleadoParameter, vape_empleadoParameter, vfecha_ingresoParameter, vsueldoParameter, vemail_empParameter, vcod_supervisorParameter, vestado_empParameter);
        }
    
        public virtual int usp_EliminarEmpleado(string vcod_emp)
        {
            var vcod_empParameter = vcod_emp != null ?
                new ObjectParameter("vcod_emp", vcod_emp) :
                new ObjectParameter("vcod_emp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarEmpleado", vcod_empParameter);
        }
    
        public virtual ObjectResult<usp_ListarEstadoProveedorMedicina_Result> usp_ListarEstadoProveedorMedicina(Nullable<int> estado_prov, string tipo_medicina)
        {
            var estado_provParameter = estado_prov.HasValue ?
                new ObjectParameter("estado_prov", estado_prov) :
                new ObjectParameter("estado_prov", typeof(int));
    
            var tipo_medicinaParameter = tipo_medicina != null ?
                new ObjectParameter("tipo_medicina", tipo_medicina) :
                new ObjectParameter("tipo_medicina", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarEstadoProveedorMedicina_Result>("usp_ListarEstadoProveedorMedicina", estado_provParameter, tipo_medicinaParameter);
        }
    
        public virtual ObjectResult<usp_ListarTipoMedicinaProveedor_Result> usp_ListarTipoMedicinaProveedor(string tipo_medicina)
        {
            var tipo_medicinaParameter = tipo_medicina != null ?
                new ObjectParameter("tipo_medicina", tipo_medicina) :
                new ObjectParameter("tipo_medicina", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarTipoMedicinaProveedor_Result>("usp_ListarTipoMedicinaProveedor", tipo_medicinaParameter);
        }
    
        public virtual ObjectResult<usp_RepresentanteProveedor_Result> usp_RepresentanteProveedor(string rep_ven_prov)
        {
            var rep_ven_provParameter = rep_ven_prov != null ?
                new ObjectParameter("rep_ven_prov", rep_ven_prov) :
                new ObjectParameter("rep_ven_prov", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_RepresentanteProveedor_Result>("usp_RepresentanteProveedor", rep_ven_provParameter);
        }
    
        public virtual int usp_ActualizarCliente(Nullable<int> vtipo_cliente, string vnom_cliente, string vape_pat_cli, string vape_mat_cli, string vdir_cli, string vcel_cli, string vemail_cli, Nullable<int> ves_dueno, string vid_ubigeo, string vdni_cli, string vusu_ult_mod, Nullable<System.DateTime> vfec_ult_mod, Nullable<int> vestado_cli, string vcod_cli)
        {
            var vtipo_clienteParameter = vtipo_cliente.HasValue ?
                new ObjectParameter("vtipo_cliente", vtipo_cliente) :
                new ObjectParameter("vtipo_cliente", typeof(int));
    
            var vnom_clienteParameter = vnom_cliente != null ?
                new ObjectParameter("vnom_cliente", vnom_cliente) :
                new ObjectParameter("vnom_cliente", typeof(string));
    
            var vape_pat_cliParameter = vape_pat_cli != null ?
                new ObjectParameter("vape_pat_cli", vape_pat_cli) :
                new ObjectParameter("vape_pat_cli", typeof(string));
    
            var vape_mat_cliParameter = vape_mat_cli != null ?
                new ObjectParameter("vape_mat_cli", vape_mat_cli) :
                new ObjectParameter("vape_mat_cli", typeof(string));
    
            var vdir_cliParameter = vdir_cli != null ?
                new ObjectParameter("vdir_cli", vdir_cli) :
                new ObjectParameter("vdir_cli", typeof(string));
    
            var vcel_cliParameter = vcel_cli != null ?
                new ObjectParameter("vcel_cli", vcel_cli) :
                new ObjectParameter("vcel_cli", typeof(string));
    
            var vemail_cliParameter = vemail_cli != null ?
                new ObjectParameter("vemail_cli", vemail_cli) :
                new ObjectParameter("vemail_cli", typeof(string));
    
            var ves_duenoParameter = ves_dueno.HasValue ?
                new ObjectParameter("ves_dueno", ves_dueno) :
                new ObjectParameter("ves_dueno", typeof(int));
    
            var vid_ubigeoParameter = vid_ubigeo != null ?
                new ObjectParameter("vid_ubigeo", vid_ubigeo) :
                new ObjectParameter("vid_ubigeo", typeof(string));
    
            var vdni_cliParameter = vdni_cli != null ?
                new ObjectParameter("vdni_cli", vdni_cli) :
                new ObjectParameter("vdni_cli", typeof(string));
    
            var vusu_ult_modParameter = vusu_ult_mod != null ?
                new ObjectParameter("vusu_ult_mod", vusu_ult_mod) :
                new ObjectParameter("vusu_ult_mod", typeof(string));
    
            var vfec_ult_modParameter = vfec_ult_mod.HasValue ?
                new ObjectParameter("vfec_ult_mod", vfec_ult_mod) :
                new ObjectParameter("vfec_ult_mod", typeof(System.DateTime));
    
            var vestado_cliParameter = vestado_cli.HasValue ?
                new ObjectParameter("vestado_cli", vestado_cli) :
                new ObjectParameter("vestado_cli", typeof(int));
    
            var vcod_cliParameter = vcod_cli != null ?
                new ObjectParameter("vcod_cli", vcod_cli) :
                new ObjectParameter("vcod_cli", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarCliente", vtipo_clienteParameter, vnom_clienteParameter, vape_pat_cliParameter, vape_mat_cliParameter, vdir_cliParameter, vcel_cliParameter, vemail_cliParameter, ves_duenoParameter, vid_ubigeoParameter, vdni_cliParameter, vusu_ult_modParameter, vfec_ult_modParameter, vestado_cliParameter, vcod_cliParameter);
        }
    
        public virtual int usp_EliminarCliente(string vcod_cli)
        {
            var vcod_cliParameter = vcod_cli != null ?
                new ObjectParameter("vcod_cli", vcod_cli) :
                new ObjectParameter("vcod_cli", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarCliente", vcod_cliParameter);
        }
    
        public virtual int usp_InsertarCliente(Nullable<int> vtipo_cliente, string vnom_cliente, string vape_pat_cli, string vape_mat_cli, string vdir_cli, string vcel_cli, string vemail_cli, Nullable<int> ves_dueno, string vid_ubigeo, string vdni_cli, string vusu_reg_cli, Nullable<int> vestado_cli)
        {
            var vtipo_clienteParameter = vtipo_cliente.HasValue ?
                new ObjectParameter("vtipo_cliente", vtipo_cliente) :
                new ObjectParameter("vtipo_cliente", typeof(int));
    
            var vnom_clienteParameter = vnom_cliente != null ?
                new ObjectParameter("vnom_cliente", vnom_cliente) :
                new ObjectParameter("vnom_cliente", typeof(string));
    
            var vape_pat_cliParameter = vape_pat_cli != null ?
                new ObjectParameter("vape_pat_cli", vape_pat_cli) :
                new ObjectParameter("vape_pat_cli", typeof(string));
    
            var vape_mat_cliParameter = vape_mat_cli != null ?
                new ObjectParameter("vape_mat_cli", vape_mat_cli) :
                new ObjectParameter("vape_mat_cli", typeof(string));
    
            var vdir_cliParameter = vdir_cli != null ?
                new ObjectParameter("vdir_cli", vdir_cli) :
                new ObjectParameter("vdir_cli", typeof(string));
    
            var vcel_cliParameter = vcel_cli != null ?
                new ObjectParameter("vcel_cli", vcel_cli) :
                new ObjectParameter("vcel_cli", typeof(string));
    
            var vemail_cliParameter = vemail_cli != null ?
                new ObjectParameter("vemail_cli", vemail_cli) :
                new ObjectParameter("vemail_cli", typeof(string));
    
            var ves_duenoParameter = ves_dueno.HasValue ?
                new ObjectParameter("ves_dueno", ves_dueno) :
                new ObjectParameter("ves_dueno", typeof(int));
    
            var vid_ubigeoParameter = vid_ubigeo != null ?
                new ObjectParameter("vid_ubigeo", vid_ubigeo) :
                new ObjectParameter("vid_ubigeo", typeof(string));
    
            var vdni_cliParameter = vdni_cli != null ?
                new ObjectParameter("vdni_cli", vdni_cli) :
                new ObjectParameter("vdni_cli", typeof(string));
    
            var vusu_reg_cliParameter = vusu_reg_cli != null ?
                new ObjectParameter("vusu_reg_cli", vusu_reg_cli) :
                new ObjectParameter("vusu_reg_cli", typeof(string));
    
            var vestado_cliParameter = vestado_cli.HasValue ?
                new ObjectParameter("vestado_cli", vestado_cli) :
                new ObjectParameter("vestado_cli", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarCliente", vtipo_clienteParameter, vnom_clienteParameter, vape_pat_cliParameter, vape_mat_cliParameter, vdir_cliParameter, vcel_cliParameter, vemail_cliParameter, ves_duenoParameter, vid_ubigeoParameter, vdni_cliParameter, vusu_reg_cliParameter, vestado_cliParameter);
        }
    
        public virtual ObjectResult<usp_ListarPacientesPorRaza_Result> usp_ListarPacientesPorRaza(string vraza)
        {
            var vrazaParameter = vraza != null ?
                new ObjectParameter("vraza", vraza) :
                new ObjectParameter("vraza", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPacientesPorRaza_Result>("usp_ListarPacientesPorRaza", vrazaParameter);
        }
    
        public virtual ObjectResult<usp_ListarPacientePorTratamiento_Result> usp_ListarPacientePorTratamiento(string tipo_tratamiento)
        {
            var tipo_tratamientoParameter = tipo_tratamiento != null ?
                new ObjectParameter("tipo_tratamiento", tipo_tratamiento) :
                new ObjectParameter("tipo_tratamiento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPacientePorTratamiento_Result>("usp_ListarPacientePorTratamiento", tipo_tratamientoParameter);
        }
    
        public virtual ObjectResult<usp_ListarPacientesPorRaza1_Result> usp_ListarPacientesPorRaza1(string vraza)
        {
            var vrazaParameter = vraza != null ?
                new ObjectParameter("vraza", vraza) :
                new ObjectParameter("vraza", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPacientesPorRaza1_Result>("usp_ListarPacientesPorRaza1", vrazaParameter);
        }
    
        public virtual ObjectResult<usp_ListarPacientePorTratamiento1_Result> usp_ListarPacientePorTratamiento1(string tipo_tratamiento)
        {
            var tipo_tratamientoParameter = tipo_tratamiento != null ?
                new ObjectParameter("tipo_tratamiento", tipo_tratamiento) :
                new ObjectParameter("tipo_tratamiento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPacientePorTratamiento1_Result>("usp_ListarPacientePorTratamiento1", tipo_tratamientoParameter);
        }
    
        public virtual ObjectResult<usp_ListarProveedor_Result> usp_ListarProveedor(string cod_prov)
        {
            var cod_provParameter = cod_prov != null ?
                new ObjectParameter("cod_prov", cod_prov) :
                new ObjectParameter("cod_prov", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarProveedor_Result>("usp_ListarProveedor", cod_provParameter);
        }
    
        public virtual ObjectResult<usp_ListarEmpleado_Result> usp_ListarEmpleado()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarEmpleado_Result>("usp_ListarEmpleado");
        }
    
        public virtual int usp_ActualizarPaciente(string vnom_pac, string vtipo_pac, string vraza, Nullable<System.DateTime> vfec_nac_pac, Nullable<int> vsexo, string vcolor, Nullable<double> vlongitud, Nullable<double> vpeso, Nullable<System.DateTime> vult_vis_pac, string vfoto, string vobservaciones_pac, Nullable<int> vest_pac, string vcod_pac)
        {
            var vnom_pacParameter = vnom_pac != null ?
                new ObjectParameter("vnom_pac", vnom_pac) :
                new ObjectParameter("vnom_pac", typeof(string));
    
            var vtipo_pacParameter = vtipo_pac != null ?
                new ObjectParameter("vtipo_pac", vtipo_pac) :
                new ObjectParameter("vtipo_pac", typeof(string));
    
            var vrazaParameter = vraza != null ?
                new ObjectParameter("vraza", vraza) :
                new ObjectParameter("vraza", typeof(string));
    
            var vfec_nac_pacParameter = vfec_nac_pac.HasValue ?
                new ObjectParameter("vfec_nac_pac", vfec_nac_pac) :
                new ObjectParameter("vfec_nac_pac", typeof(System.DateTime));
    
            var vsexoParameter = vsexo.HasValue ?
                new ObjectParameter("vsexo", vsexo) :
                new ObjectParameter("vsexo", typeof(int));
    
            var vcolorParameter = vcolor != null ?
                new ObjectParameter("vcolor", vcolor) :
                new ObjectParameter("vcolor", typeof(string));
    
            var vlongitudParameter = vlongitud.HasValue ?
                new ObjectParameter("vlongitud", vlongitud) :
                new ObjectParameter("vlongitud", typeof(double));
    
            var vpesoParameter = vpeso.HasValue ?
                new ObjectParameter("vpeso", vpeso) :
                new ObjectParameter("vpeso", typeof(double));
    
            var vult_vis_pacParameter = vult_vis_pac.HasValue ?
                new ObjectParameter("vult_vis_pac", vult_vis_pac) :
                new ObjectParameter("vult_vis_pac", typeof(System.DateTime));
    
            var vfotoParameter = vfoto != null ?
                new ObjectParameter("vfoto", vfoto) :
                new ObjectParameter("vfoto", typeof(string));
    
            var vobservaciones_pacParameter = vobservaciones_pac != null ?
                new ObjectParameter("vobservaciones_pac", vobservaciones_pac) :
                new ObjectParameter("vobservaciones_pac", typeof(string));
    
            var vest_pacParameter = vest_pac.HasValue ?
                new ObjectParameter("vest_pac", vest_pac) :
                new ObjectParameter("vest_pac", typeof(int));
    
            var vcod_pacParameter = vcod_pac != null ?
                new ObjectParameter("vcod_pac", vcod_pac) :
                new ObjectParameter("vcod_pac", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarPaciente", vnom_pacParameter, vtipo_pacParameter, vrazaParameter, vfec_nac_pacParameter, vsexoParameter, vcolorParameter, vlongitudParameter, vpesoParameter, vult_vis_pacParameter, vfotoParameter, vobservaciones_pacParameter, vest_pacParameter, vcod_pacParameter);
        }
    
        public virtual int usp_ActualizarProveedor(string vnom_prov, string vruc_prov, string vdireccion_prov, string vtel_prov, string vemail_prov, string vrep_ven_prov, string vusu_ult_mod, Nullable<System.DateTime> vfecha_ult_mod, Nullable<int> vestado_prov, string vcod_prov)
        {
            var vnom_provParameter = vnom_prov != null ?
                new ObjectParameter("vnom_prov", vnom_prov) :
                new ObjectParameter("vnom_prov", typeof(string));
    
            var vruc_provParameter = vruc_prov != null ?
                new ObjectParameter("vruc_prov", vruc_prov) :
                new ObjectParameter("vruc_prov", typeof(string));
    
            var vdireccion_provParameter = vdireccion_prov != null ?
                new ObjectParameter("vdireccion_prov", vdireccion_prov) :
                new ObjectParameter("vdireccion_prov", typeof(string));
    
            var vtel_provParameter = vtel_prov != null ?
                new ObjectParameter("vtel_prov", vtel_prov) :
                new ObjectParameter("vtel_prov", typeof(string));
    
            var vemail_provParameter = vemail_prov != null ?
                new ObjectParameter("vemail_prov", vemail_prov) :
                new ObjectParameter("vemail_prov", typeof(string));
    
            var vrep_ven_provParameter = vrep_ven_prov != null ?
                new ObjectParameter("vrep_ven_prov", vrep_ven_prov) :
                new ObjectParameter("vrep_ven_prov", typeof(string));
    
            var vusu_ult_modParameter = vusu_ult_mod != null ?
                new ObjectParameter("vusu_ult_mod", vusu_ult_mod) :
                new ObjectParameter("vusu_ult_mod", typeof(string));
    
            var vfecha_ult_modParameter = vfecha_ult_mod.HasValue ?
                new ObjectParameter("vfecha_ult_mod", vfecha_ult_mod) :
                new ObjectParameter("vfecha_ult_mod", typeof(System.DateTime));
    
            var vestado_provParameter = vestado_prov.HasValue ?
                new ObjectParameter("vestado_prov", vestado_prov) :
                new ObjectParameter("vestado_prov", typeof(int));
    
            var vcod_provParameter = vcod_prov != null ?
                new ObjectParameter("vcod_prov", vcod_prov) :
                new ObjectParameter("vcod_prov", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarProveedor", vnom_provParameter, vruc_provParameter, vdireccion_provParameter, vtel_provParameter, vemail_provParameter, vrep_ven_provParameter, vusu_ult_modParameter, vfecha_ult_modParameter, vestado_provParameter, vcod_provParameter);
        }
    
        public virtual int usp_EliminarPaciente(string vcod_pac)
        {
            var vcod_pacParameter = vcod_pac != null ?
                new ObjectParameter("vcod_pac", vcod_pac) :
                new ObjectParameter("vcod_pac", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarPaciente", vcod_pacParameter);
        }
    
        public virtual int usp_EliminarProveedor(string vcod_prov)
        {
            var vcod_provParameter = vcod_prov != null ?
                new ObjectParameter("vcod_prov", vcod_prov) :
                new ObjectParameter("vcod_prov", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarProveedor", vcod_provParameter);
        }
    
        public virtual int usp_InsertarPaciente(string vnom_pac, string vtipo_pac, string vraza, Nullable<System.DateTime> vfec_nac_pac, Nullable<int> vsexo, string vcolor, Nullable<double> vlongitud, Nullable<double> vpeso, Nullable<System.DateTime> vult_vis_pac, string vfoto, string vobservaciones_pac, Nullable<int> vest_pac)
        {
            var vnom_pacParameter = vnom_pac != null ?
                new ObjectParameter("vnom_pac", vnom_pac) :
                new ObjectParameter("vnom_pac", typeof(string));
    
            var vtipo_pacParameter = vtipo_pac != null ?
                new ObjectParameter("vtipo_pac", vtipo_pac) :
                new ObjectParameter("vtipo_pac", typeof(string));
    
            var vrazaParameter = vraza != null ?
                new ObjectParameter("vraza", vraza) :
                new ObjectParameter("vraza", typeof(string));
    
            var vfec_nac_pacParameter = vfec_nac_pac.HasValue ?
                new ObjectParameter("vfec_nac_pac", vfec_nac_pac) :
                new ObjectParameter("vfec_nac_pac", typeof(System.DateTime));
    
            var vsexoParameter = vsexo.HasValue ?
                new ObjectParameter("vsexo", vsexo) :
                new ObjectParameter("vsexo", typeof(int));
    
            var vcolorParameter = vcolor != null ?
                new ObjectParameter("vcolor", vcolor) :
                new ObjectParameter("vcolor", typeof(string));
    
            var vlongitudParameter = vlongitud.HasValue ?
                new ObjectParameter("vlongitud", vlongitud) :
                new ObjectParameter("vlongitud", typeof(double));
    
            var vpesoParameter = vpeso.HasValue ?
                new ObjectParameter("vpeso", vpeso) :
                new ObjectParameter("vpeso", typeof(double));
    
            var vult_vis_pacParameter = vult_vis_pac.HasValue ?
                new ObjectParameter("vult_vis_pac", vult_vis_pac) :
                new ObjectParameter("vult_vis_pac", typeof(System.DateTime));
    
            var vfotoParameter = vfoto != null ?
                new ObjectParameter("vfoto", vfoto) :
                new ObjectParameter("vfoto", typeof(string));
    
            var vobservaciones_pacParameter = vobservaciones_pac != null ?
                new ObjectParameter("vobservaciones_pac", vobservaciones_pac) :
                new ObjectParameter("vobservaciones_pac", typeof(string));
    
            var vest_pacParameter = vest_pac.HasValue ?
                new ObjectParameter("vest_pac", vest_pac) :
                new ObjectParameter("vest_pac", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarPaciente", vnom_pacParameter, vtipo_pacParameter, vrazaParameter, vfec_nac_pacParameter, vsexoParameter, vcolorParameter, vlongitudParameter, vpesoParameter, vult_vis_pacParameter, vfotoParameter, vobservaciones_pacParameter, vest_pacParameter);
        }
    
        public virtual int usp_InsertarProveedor(string vnom_prov, string vruc_prov, string vdireccion_prov, string vtel_prov, string vemail_prov, string vrep_ven_prov, string vusu_reg_prov, Nullable<int> vestado_prov)
        {
            var vnom_provParameter = vnom_prov != null ?
                new ObjectParameter("vnom_prov", vnom_prov) :
                new ObjectParameter("vnom_prov", typeof(string));
    
            var vruc_provParameter = vruc_prov != null ?
                new ObjectParameter("vruc_prov", vruc_prov) :
                new ObjectParameter("vruc_prov", typeof(string));
    
            var vdireccion_provParameter = vdireccion_prov != null ?
                new ObjectParameter("vdireccion_prov", vdireccion_prov) :
                new ObjectParameter("vdireccion_prov", typeof(string));
    
            var vtel_provParameter = vtel_prov != null ?
                new ObjectParameter("vtel_prov", vtel_prov) :
                new ObjectParameter("vtel_prov", typeof(string));
    
            var vemail_provParameter = vemail_prov != null ?
                new ObjectParameter("vemail_prov", vemail_prov) :
                new ObjectParameter("vemail_prov", typeof(string));
    
            var vrep_ven_provParameter = vrep_ven_prov != null ?
                new ObjectParameter("vrep_ven_prov", vrep_ven_prov) :
                new ObjectParameter("vrep_ven_prov", typeof(string));
    
            var vusu_reg_provParameter = vusu_reg_prov != null ?
                new ObjectParameter("vusu_reg_prov", vusu_reg_prov) :
                new ObjectParameter("vusu_reg_prov", typeof(string));
    
            var vestado_provParameter = vestado_prov.HasValue ?
                new ObjectParameter("vestado_prov", vestado_prov) :
                new ObjectParameter("vestado_prov", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarProveedor", vnom_provParameter, vruc_provParameter, vdireccion_provParameter, vtel_provParameter, vemail_provParameter, vrep_ven_provParameter, vusu_reg_provParameter, vestado_provParameter);
        }
    
        public virtual ObjectResult<usp_ListarClientes_Result> usp_ListarClientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarClientes_Result>("usp_ListarClientes");
        }
    
        public virtual ObjectResult<usp_ListarPacientePorTratamiento2_Result> usp_ListarPacientePorTratamiento2(string tipo_tratamiento)
        {
            var tipo_tratamientoParameter = tipo_tratamiento != null ?
                new ObjectParameter("tipo_tratamiento", tipo_tratamiento) :
                new ObjectParameter("tipo_tratamiento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPacientePorTratamiento2_Result>("usp_ListarPacientePorTratamiento2", tipo_tratamientoParameter);
        }
    
        public virtual ObjectResult<usp_ListarPacientes_Result> usp_ListarPacientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPacientes_Result>("usp_ListarPacientes");
        }
    
        public virtual ObjectResult<usp_ListarPacientesPorCliente_Result> usp_ListarPacientesPorCliente(string vcod_cli)
        {
            var vcod_cliParameter = vcod_cli != null ?
                new ObjectParameter("vcod_cli", vcod_cli) :
                new ObjectParameter("vcod_cli", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPacientesPorCliente_Result>("usp_ListarPacientesPorCliente", vcod_cliParameter);
        }
    
        public virtual ObjectResult<usp_ListarPacientesPorRaza2_Result> usp_ListarPacientesPorRaza2(string vraza)
        {
            var vrazaParameter = vraza != null ?
                new ObjectParameter("vraza", vraza) :
                new ObjectParameter("vraza", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPacientesPorRaza2_Result>("usp_ListarPacientesPorRaza2", vrazaParameter);
        }
    
        public virtual ObjectResult<usp_ListarProveedores_Result> usp_ListarProveedores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarProveedores_Result>("usp_ListarProveedores");
        }
    }
}
