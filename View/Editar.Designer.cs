namespace Estoque.View
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbPrecoCusto = new System.Windows.Forms.MaskedTextBox();
            this.mtbLucro = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edição";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(71, 103);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(284, 23);
            this.cbProduto.TabIndex = 2;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(446, 103);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(579, 103);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição: ";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(82, 174);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(273, 23);
            this.txtProduto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unidade de Medida:";
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Items.AddRange(new object[] {
            "UN",
            "CX",
            "PC",
            "G",
            "KG",
            "L",
            "ML",
            "CM",
            "M"});
            this.cbUnidadeMedida.Location = new System.Drawing.Point(510, 174);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(121, 23);
            this.cbUnidadeMedida.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(90, 215);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(118, 23);
            this.txtQuantidade.TabIndex = 11;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Preço de Custo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Lucro (%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Preço de Venda:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Preço Total:";
            // 
            // mtbPrecoCusto
            // 
            this.mtbPrecoCusto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtbPrecoCusto.Location = new System.Drawing.Point(108, 257);
            this.mtbPrecoCusto.Mask = "$ 000.00";
            this.mtbPrecoCusto.Name = "mtbPrecoCusto";
            this.mtbPrecoCusto.RejectInputOnFirstFailure = true;
            this.mtbPrecoCusto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbPrecoCusto.Size = new System.Drawing.Size(100, 23);
            this.mtbPrecoCusto.TabIndex = 16;
            this.mtbPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbPrecoCusto.Leave += new System.EventHandler(this.mtbPrecoCusto_Leave);
            // 
            // mtbLucro
            // 
            this.mtbLucro.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbLucro.Location = new System.Drawing.Point(82, 294);
            this.mtbLucro.Mask = "000%";
            this.mtbLucro.Name = "mtbLucro";
            this.mtbLucro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbLucro.Size = new System.Drawing.Size(126, 23);
            this.mtbLucro.TabIndex = 17;
            this.mtbLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbLucro.Leave += new System.EventHandler(this.mtbLucro_Leave);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(510, 215);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.ReadOnly = true;
            this.txtPrecoVenda.Size = new System.Drawing.Size(121, 23);
            this.txtPrecoVenda.TabIndex = 18;
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(510, 257);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.ReadOnly = true;
            this.txtPrecoTotal.Size = new System.Drawing.Size(121, 23);
            this.txtPrecoTotal.TabIndex = 19;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Location = new System.Drawing.Point(626, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(707, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.mtbLucro);
            this.Controls.Add(this.mtbPrecoCusto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbUnidadeMedida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbProduto;
        private Label label3;
        private TextBox txtCodigo;
        private Button btnPesquisar;
        private Label label4;
        private TextBox txtProduto;
        private Label label5;
        private ComboBox cbUnidadeMedida;
        private Label label6;
        private TextBox txtQuantidade;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private MaskedTextBox mtbPrecoCusto;
        private MaskedTextBox mtbLucro;
        private TextBox txtPrecoVenda;
        private TextBox txtPrecoTotal;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}