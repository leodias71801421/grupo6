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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmar.Text)
            {
                sql = string.Format("insert into usuario(NOM_USUARIO, EMAIL_USUARIO,SENHA_USUARIO,TIPO_USUARIO) values('{0}','{1}','{2}', '{3}')", txtNome.Text, txtEmail.Text, txtSenha.Text, 2);
                bd.AlterarDados(sql);
                MessageBox.Show("Cadastro Concluído com sucesso!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
            else
            {
                MessageBox.Show("Cadastro não efetuado! Favor verificar se as senhas estão iguais.", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void limpar()
        {
            txtNome.Clear();
            txtConfirmar.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
