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
        public ProveedorBE ConsultarProveedor(string strCod)
        {
            HundeDBEntities misProveedores = new HundeDBEntities();
            try
            {
                Tb_Proveedor objConsulta = (from objProv in misProveedores.Tb_Proveedor
                                            where objProv.cod_prov == strCod
                                            select objProv).FirstOrDefault();

                ProveedorBE objProveedorBE = new ProveedorBE();

                objProveedorBE.cod_prov = objConsulta.cod_prov;
                objProveedorBE.nom_prov = objConsulta.nom_prov;
                objProveedorBE.ruc_prov = objConsulta.ruc_prov;
                objProveedorBE.direccion_prov = objConsulta.direccion_prov;
                objProveedorBE.tel_prov = objConsulta.tel_prov;
                objProveedorBE.email_prov = objConsulta.email_prov;
                objProveedorBE.rep_ven_prov = objConsulta.rep_ven_prov;
                objProveedorBE.fec_reg_prov = Convert.ToDateTime(objConsulta.fec_reg_prov);
                objProveedorBE.estado_prov = Convert.ToInt16(objConsulta.estado_prov);


                if (objConsulta.estado_prov == 1)
                {
                    objProveedorBE.estado_prov = 1;
                }
                else
                {
                    objProveedorBE.estado_prov = 0;
                }


                return objProveedorBE;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ProveedorBE> ConsultarSupervisor(string strRepVenProv)
        {

            HundeDBEntities misProveedores = new HundeDBEntities();
            List<ProveedorBE> objListaProveedor = new List<ProveedorBE>();

            try
            {

                var query = misProveedores.usp_RepresentanteProveedor(strRepVenProv);
                foreach (var rs in query)
                {
                    ProveedorBE objListaProveedores = new ProveedorBE();
                    objListaProveedores.cod_prov = rs.cod_prov;
                    objListaProveedores.rep_ven_prov = rs.rep_ven_prov;
                    objListaProveedores.nom_prov = rs.nom_prov;

                    objListaProveedor.Add(objListaProveedores);

                }
                return objListaProveedor;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EstadosBE> GetAllEstadoProveedorMedicina(short strEstadoProveedor, string strTipoMedicina)
        {

            HundeDBEntities misProveedores = new HundeDBEntities();
            List<EstadosBE> objListEstado = new List<EstadosBE>();

            try
            {
                var query = misProveedores.usp_ListarEstadoProveedorMedicina(strEstadoProveedor, strTipoMedicina);
                foreach (var rs in query)
                {
                    EstadosBE objEstado = new EstadosBE();
                    objEstado.cod_prov = rs.cod_prov;
                    objEstado.cod_med = rs.cod_med;
                    objEstado.nom_prov = rs.nom_prov;
                    objEstado.nombre_medicina = rs.nombre_medicina;
                    objEstado.tipo_medicina = rs.tipo_medicina;
                    objEstado.estado_prov = Convert.ToInt16(rs.estado_prov);

                    objListEstado.Add(objEstado);

                }
                return objListEstado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ProveedorBE> GetAllMedicinaProveedor(string srtTipoMedicina)
        {
            HundeDBEntities misProveedores = new HundeDBEntities();
            List<ProveedorBE> objListaMedicinaBE = new List<ProveedorBE>();

            try
            {

                var query = misProveedores.usp_ListarTipoMedicinaProveedor(srtTipoMedicina);
                foreach (var rs in query)
                {
                    ProveedorBE objMedcinaBE = new ProveedorBE();
                    objMedcinaBE.cod_prov = rs.cod_prov;
                    objMedcinaBE.cod_med = rs.cod_med;
                    objMedcinaBE.nom_prov = rs.nom_prov;
                    objMedcinaBE.email_prov = rs.email_prov;
                    objMedcinaBE.tel_prov = rs.tel_prov;
                    objMedcinaBE.nombre_medicina = rs.nombre_medicina;
                    objMedcinaBE.tipo_medicina = rs.tipo_medicina;

                    objListaMedicinaBE.Add(objMedcinaBE);

                }
                return objListaMedicinaBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
