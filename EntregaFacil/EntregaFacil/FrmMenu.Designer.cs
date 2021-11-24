
namespace EntregaFacil
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnRota = new System.Windows.Forms.Button();
            this.BtnCadFunc = new System.Windows.Forms.Button();
            this.BtnListProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Location = new System.Drawing.Point(12, 12);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(122, 83);
            this.btnCadProduto.TabIndex = 0;
            this.btnCadProduto.Text = "Cadastro de Produtos";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnRota
            // 
            this.btnRota.Location = new System.Drawing.Point(140, 12);
            this.btnRota.Name = "btnRota";
            this.btnRota.Size = new System.Drawing.Size(122, 83);
            this.btnRota.TabIndex = 1;
            this.btnRota.Text = "Rotas";
            this.btnRota.UseVisualStyleBackColor = true;
            this.btnRota.Click += new System.EventHandler(this.btnRota_Click);
            // 
            // BtnCadFunc
            // 
            this.BtnCadFunc.Location = new System.Drawing.Point(140, 101);
            this.BtnCadFunc.Name = "BtnCadFunc";
            this.BtnCadFunc.Size = new System.Drawing.Size(122, 83);
            this.BtnCadFunc.TabIndex = 2;
            this.BtnCadFunc.Text = "Cadastro de funcionário";
            this.BtnCadFunc.UseVisualStyleBackColor = true;
            this.BtnCadFunc.Click += new System.EventHandler(this.BtnCadFunc_Click);
            // 
            // BtnListProduto
            // 
            this.BtnListProduto.Location = new System.Drawing.Point(12, 101);
            this.BtnListProduto.Name = "BtnListProduto";
            this.BtnListProduto.Size = new System.Drawing.Size(122, 83);
            this.BtnListProduto.TabIndex = 3;
            this.BtnListProduto.Text = "Listagem de Produtos";
            this.BtnListProduto.UseVisualStyleBackColor = true;
            this.BtnListProduto.Click += new System.EventHandler(this.BtnListProduto_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 204);
            this.Controls.Add(this.BtnListProduto);
            this.Controls.Add(this.BtnCadFunc);
            this.Controls.Add(this.btnRota);
            this.Controls.Add(this.btnCadProduto);
            this.Name = "FrmMenu";
            this.Text = "Menu - Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnRota;
        private System.Windows.Forms.Button BtnCadFunc;
        private System.Windows.Forms.Button BtnListProduto;
    }
}