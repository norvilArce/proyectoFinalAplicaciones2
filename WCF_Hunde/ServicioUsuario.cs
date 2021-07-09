using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hunde
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        HundeDBEntities HundeDBEntities = new HundeDBEntities();
        public Usuario ConsultarUsuario(string strLogin)
        {
            try
            {
                Tb_Usuario tb_Usuario = (from usu in HundeDBEntities.Tb_Usuario
                                         where usu.login_usuario == strLogin
                                         select usu).FirstOrDefault();
                Usuario usuario = new Usuario();

                usuario.login_usuario = tb_Usuario.login_usuario;
                usuario.pass_usuario = tb_Usuario.pass_usuario;
                usuario.niv_usuario = Convert.ToInt16(tb_Usuario.niv_usuario);
                usuario.est_usuario = Convert.ToInt16(tb_Usuario.est_usuario);
                usuario.fec_registro = Convert.ToDateTime(tb_Usuario.fec_registro);
                usuario.usu_reg_usu = tb_Usuario.usu_reg_usu;
                usuario.cod_emp = tb_Usuario.cod_emp;

                return usuario;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
