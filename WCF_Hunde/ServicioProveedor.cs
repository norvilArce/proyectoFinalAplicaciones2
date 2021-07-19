using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProveedor" en el código y en el archivo de configuración a la vez.
    public class ServicioProveedor : IServicioProveedor
    {
        HundeDBEntities misProveedores = new HundeDBEntities();
        public List<ProveedorBE> ConsultarProveedores()
        {
            List<ProveedorBE> objListProveedor = new List<ProveedorBE>();
            try
            {
                var query = (from prov in misProveedores.Tb_Proveedor
                             select prov);

                foreach (var rs in query)
                {

                    ProveedorBE objProveedorBE = new ProveedorBE();

                    objProveedorBE.cod_prov = rs.cod_prov;
                    objProveedorBE.raz_soc = rs.raz_soc;
                    objProveedorBE.ruc_prov = rs.ruc_prov;
                    objProveedorBE.dir_prov = rs.direccion_prov;
                    objProveedorBE.id_ubigeo = rs.id_ubigeo;
                    objProveedorBE.tel_prov = rs.tel_prov;
                    objProveedorBE.email_prov = rs.email_prov;
                    objProveedorBE.rep_ven_prov = rs.rep_ven_prov;
                    objProveedorBE.usu_reg = rs.usu_reg_prov;
                    objProveedorBE.fec_reg_prov = Convert.ToDateTime(rs.fec_reg_prov);
                    objProveedorBE.usu_ult_mod = rs.usu_ult_modificacion_prov;
                    objProveedorBE.fec_ult_mod = Convert.ToDateTime(rs.fecha_ult_modificacion_prov);
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
            ProveedorBE objProveedorBE = new ProveedorBE();
            try
            {
                Tb_Proveedor rs = (from prov in misProveedores.Tb_Proveedor
                                   where prov.cod_prov == strCod
                                   select prov).FirstOrDefault();
                if (rs != null)
                {
                    objProveedorBE.cod_prov = rs.cod_prov;
                    objProveedorBE.raz_soc = rs.raz_soc;
                    objProveedorBE.ruc_prov = rs.ruc_prov;
                    objProveedorBE.dir_prov = rs.direccion_prov;
                    objProveedorBE.id_ubigeo = rs.id_ubigeo;
                    objProveedorBE.tel_prov = rs.tel_prov;
                    objProveedorBE.email_prov = rs.email_prov;
                    objProveedorBE.rep_ven_prov = rs.rep_ven_prov;
                    objProveedorBE.usu_reg = rs.usu_reg_prov;
                    objProveedorBE.fec_reg_prov = Convert.ToDateTime(rs.fec_reg_prov);
                    objProveedorBE.usu_ult_mod = rs.usu_ult_modificacion_prov;
                    objProveedorBE.fec_ult_mod = Convert.ToDateTime(rs.fecha_ult_modificacion_prov);
                    objProveedorBE.estado_prov = Convert.ToInt16(rs.estado_prov);
                }
                return objProveedorBE;

            }
            catch (NullReferenceException)
            {
                return objProveedorBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
