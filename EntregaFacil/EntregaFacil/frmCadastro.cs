using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaFacil
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmar.Text)
            {
                sql = string.Format("insert into usuario(NOM_USUARIO, EMAIL_USUARIO,SENHA_USUARIO,TIPO_USUARIO) values('{0}','{1}','{2}', '{3}')", txtNome.Text, txtEmail.Text, txtSenha.Text, 1) ;
                bd.AlterarDados(sql);
                MessageBox.Show("Cadastro Concluído com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpar()
        {
            txtNome.Clear();
            txtConfirmar.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
        }
    }
}
