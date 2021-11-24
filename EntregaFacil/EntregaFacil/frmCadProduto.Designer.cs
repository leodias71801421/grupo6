
namespace EntregaFacil
{
    partial class frmCadProduto
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtDscProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(163, 12);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(323, 20);
            this.txtProduto.TabIndex = 12;
            // 
            // txtDscProduto
            // 
            this.txtDscProduto.Location = new System.Drawing.Point(196, 38);
            this.txtDscProduto.Name = "txtDscProduto";
            this.txtDscProduto.Size = new System.Drawing.Size(290, 20);
            this.txtDscProduto.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descrição do Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do Produto:";
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.Location = new System.Drawing.Point(322, 81);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(164, 44);
            this.btnCadastrarProd.TabIndex = 16;
            this.btnCadastrarProd.Text = "Cadastrar";
            this.btnCadastrarProd.UseVisualStyleBackColor = true;
            this.btnCadastrarProd.Click += new System.EventHandler(this.btnCadastrarProd_Click);
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 129);
            this.Controls.Add(this.btnCadastrarProd);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtDscProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadProduto";
            this.Text = "Cadastro de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtDscProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarProd;
    }
}