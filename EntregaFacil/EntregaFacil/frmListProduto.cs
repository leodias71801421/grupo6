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
    public partial class frmListProduto : Form
    {
        public frmListProduto()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            try
            {
                ConexaoBD bd = new ConexaoBD();
                string sql = string.Format("SELECT COD_PRODUTO ID,NOM_PRODUTO NOME,DSC_PRODUTO AS DESCRIÇÃO  from produto");
                DataTable dt = new DataTable();
                dt = bd.ConsultarDados(sql);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmListProduto_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
