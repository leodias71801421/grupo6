using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EntregaFacil
{
    class objLogin
    {
        private static string nome;
        private static string tipo;

        public bool ValidarUsuario(string usuario, string senha)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql = string.Format("select NOM_USUARIO,SENHA_USUARIO,TIPO_USUARIO  from usuario where NOM_USUARIO = '{0}' and SENHA_USUARIO = '{1}'", usuario, senha);
            DataTable dt = new DataTable();
            dt = bd.ConsultarDados(sql);

            if (dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["NOM_USUARIO"].ToString();
                tipo = dt.Rows[0]["TIPO_USUARIO"].ToString();
                return true;

            }
            else
            {
                return false;
            }
        }
        public string UsuarioLogado()
        {
            return nome;
        }
        public string tipoUsuario()
        {
            return tipo;
        }
    }
}
