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
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;
        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into produto(DSC_PRODUTO, NOM_PRODUTO,DAT_CADASTRO) values('{0}','{1}', Now())", txtProduto.Text, txtDscProduto.Text);
            bd.AlterarDados(sql);
            MessageBox.Show("Cadastro Concluído com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
        }

        public void limpar()
        {
            txtProduto.Clear();
            txtDscProduto.Clear();            
        }
    }
}
