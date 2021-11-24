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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        objLogin l = new objLogin();

        private void lkbCad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSenha.Text = "";
            txtUser.Text = "";
            this.Visible = false;
            Cadastrar menu = new Cadastrar();
            menu.ShowDialog();
            this.Visible = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (l.ValidarUsuario(txtUser.Text, txtSenha.Text))
            {
                this.Visible = false;
                FrmMenu inicio = new FrmMenu();
                inicio.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalido...", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
