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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnRota_Click(object sender, EventArgs e)
        {
            frmRotas rota = new frmRotas();
            rota.ShowDialog();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadProduto prod = new frmCadProduto();
            prod.ShowDialog();
        }

        private void BtnListProduto_Click(object sender, EventArgs e)
        {
            frmListProduto listprod = new frmListProduto();
            listprod.ShowDialog();
        }

        private void BtnCadFunc_Click(object sender, EventArgs e)
        {
            frmCadFuncionario cadFunc = new frmCadFuncionario();
            cadFunc.ShowDialog();
        }
    }
}
