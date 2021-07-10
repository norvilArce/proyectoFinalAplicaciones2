using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProveedor" en el código y en el archivo de configuración a la vez.
    public class ServicioProveedor : IServicioProveedor
    {
        public List<ProveedorBE> ConsultarProveedores()
        {
            HundeDBEntities misProveedores = new HundeDBEntities();
            List<ProveedorBE> objListProveedor = new List<ProveedorBE>();
            try
            {
                var query = (from prov in misProveedores.Tb_Proveedor
                             select prov);

                foreach (var rs in query)
                {

                    ProveedorBE objProveedorBE = new ProveedorBE();

                    objProveedorBE.cod_prov = rs.cod_prov;
                    objProveedorBE.nom_prov = rs.nom_prov;
                    objProveedorBE.ruc_prov = rs.ruc_prov;
                    objProveedorBE.direccion_prov = rs.direccion_prov;
                    objProveedorBE.tel_prov = rs.tel_prov;
                    objProveedorBE.email_prov = rs.email_prov;
                    objProveedorBE.rep_ven_prov = rs.rep_ven_prov;
                    objProveedorBE.fec_reg_prov = Convert.ToDateTime(rs.fec_reg_prov);
                    objProveedorBE.estado_prov = Convert.ToInt16(rs.estado_prov);

                    objListProveedor.Add(objProveedorBE);
                }
                return objListProveedor;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ProveedorBE ConsultarProveedorPorCodigo(String strCod)
        {
            HundeDBEntities misProveedores = new HundeDBEntities();

            try
            {
            Tb_Proveedor rs = (from prov in misProveedores.Tb_Proveedor
                               where prov.cod_prov == strCod
                               select prov).FirstOrDefault();

            ProveedorBE objProveedorBE = new ProveedorBE();

            objProveedorBE.cod_prov = rs.cod_prov;
            objProveedorBE.nom_prov = rs.nom_prov;
            objProveedorBE.ruc_prov = rs.ruc_prov;
            objProveedorBE.direccion_prov = rs.direccion_prov;
            objProveedorBE.tel_prov = rs.tel_prov;
            objProveedorBE.email_prov = rs.email_prov;
            objProveedorBE.rep_ven_prov = rs.rep_ven_prov;
            objProveedorBE.fec_reg_prov = Convert.ToDateTime(rs.fec_reg_prov);
            objProveedorBE.estado_prov = Convert.ToInt16(rs.estado_prov);

            return objProveedorBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ProveedorBE ConsultarMedicinaProveedor(string srtTipoMedicina)
        {
            HundeDBEntities misProveedores = new HundeDBEntities();

            try
            {
                Tb_Medicina rs = (from prov in misProveedores.Tb_Medicina
                                   where prov.tipo_medicina == srtTipoMedicina
                                   
                                  select prov).FirstOrDefault();

                ProveedorBE objMedcinaBE = new ProveedorBE();
                    objMedcinaBE.tipo_medicina = rs.tipo_medicina;
                    objMedcinaBE.cod_med = rs.cod_med;
                    objMedcinaBE.nombre_medicina = rs.nombre_medicina;


                
                return objMedcinaBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<ProveedorBE> ConsultarSupervisor()
        {

            HundeDBEntities Supervisador = new HundeDBEntities();
            List<ProveedorBE> objListaSupervisor = new List<ProveedorBE>();
             
            try
            {
                var query = (from objSup in Supervisador.Tb_Proveedor
                             select objSup);

                foreach (var objSuper in query)
                {
                    //Creamos una instancia del vendedor para retornar el resultado
                    ProveedorBE objSuperBE = new ProveedorBE();

                    objSuperBE.cod_prov = objSuper.cod_prov;
                    objSuperBE.nom_prov = objSuper.nom_prov;
                    objSuperBE.email_prov = objSuper.email_prov;
                    objSuperBE.direccion_prov = objSuper.direccion_prov;
                    objSuperBE.fec_reg_prov = Convert.ToDateTime(objSuper.fec_reg_prov);
                    objSuperBE.rep_ven_prov = objSuper.rep_ven_prov;

                    objSuperBE.ruc_prov = objSuper.ruc_prov;
                    objSuperBE.tel_prov = objSuper.tel_prov;

                    objListaSupervisor.Add(objSuperBE);
                }
                return objListaSupervisor;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        


        public List<EstadosBE> ConsultarEstadoProveedorMedicina()
        {

            HundeDBEntities misProveedores = new HundeDBEntities();
            List<EstadosBE> objListEstado = new List<EstadosBE>();

            try
            {
                var query = (from objSup in misProveedores.Tb_Medicina
                             select objSup);


                foreach (var rs in query)
                {


                    EstadosBE objMedcinaBE = new EstadosBE();
                    objMedcinaBE.tipo_medicina = rs.tipo_medicina;
                    objMedcinaBE.cod_med = rs.cod_med;
                    objMedcinaBE.nombre_medicina = rs.nombre_medicina;

                    objListEstado.Add(objMedcinaBE);

                }
                return objListEstado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
