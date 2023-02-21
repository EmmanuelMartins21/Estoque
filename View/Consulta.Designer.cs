namespace Estoque.View
{
    partial class Consulta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.label1 = new System.Windows.Forms.Label();
            this.serviceConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DGV = new System.Windows.Forms.DataGridView();
            this.serviceConnectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.UND_MEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceConnectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO_CUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUCRO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.serviceConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceConnectionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceConnectionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serviceConnectionBindingSource
            // 
            this.serviceConnectionBindingSource.DataSource = typeof(Estoque.Services.ServiceConnection);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Produto,
            this.NOME_PRODUTO,
            this.QUANTIDADE_PRODUTO,
            this.PRECO_CUSTO,
            this.LUCRO_PRODUTO,
            this.PRECO_VENDA,
            this.PRECO_TOTAL});
            this.DGV.DataSource = this.serviceConnectionBindingSource2;
            this.DGV.Location = new System.Drawing.Point(-1, 89);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowTemplate.Height = 25;
            this.DGV.Size = new System.Drawing.Size(801, 361);
            this.DGV.TabIndex = 2;
            // 
            // serviceConnectionBindingSource2
            // 
            this.serviceConnectionBindingSource2.DataSource = typeof(Estoque.Services.ServiceConnection);
            // 
            // UND_MEDIDA
            // 
            this.UND_MEDIDA.DataPropertyName = "UND_MEDIDA";
            this.UND_MEDIDA.HeaderText = "Und. Medida";
            this.UND_MEDIDA.Name = "UND_MEDIDA";
            // 
            // serviceConnectionBindingSource1
            // 
            this.serviceConnectionBindingSource1.DataSource = typeof(Estoque.Services.ServiceConnection);
            // 
            // ID_Produto
            // 
            this.ID_Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Produto.DataPropertyName = "ID_PRODUTO";
            this.ID_Produto.HeaderText = "ID";
            this.ID_Produto.Name = "ID_Produto";
            this.ID_Produto.ReadOnly = true;
            this.ID_Produto.Width = 43;
            // 
            // NOME_PRODUTO
            // 
            this.NOME_PRODUTO.DataPropertyName = "NOME_PRODUTO";
            this.NOME_PRODUTO.HeaderText = "Descrição";
            this.NOME_PRODUTO.Name = "NOME_PRODUTO";
            this.NOME_PRODUTO.ReadOnly = true;
            // 
            // QUANTIDADE_PRODUTO
            // 
            this.QUANTIDADE_PRODUTO.DataPropertyName = "QUANTIDADE_PRODUTO";
            this.QUANTIDADE_PRODUTO.HeaderText = "Qauntidade";
            this.QUANTIDADE_PRODUTO.Name = "QUANTIDADE_PRODUTO";
            this.QUANTIDADE_PRODUTO.ReadOnly = true;
            // 
            // PRECO_CUSTO
            // 
            this.PRECO_CUSTO.DataPropertyName = "PRECO_CUSTO";
            this.PRECO_CUSTO.HeaderText = "Custo";
            this.PRECO_CUSTO.Name = "PRECO_CUSTO";
            this.PRECO_CUSTO.ReadOnly = true;
            // 
            // LUCRO_PRODUTO
            // 
            this.LUCRO_PRODUTO.DataPropertyName = "LUCRO_PRODUTO";
            this.LUCRO_PRODUTO.HeaderText = "Lucro";
            this.LUCRO_PRODUTO.Name = "LUCRO_PRODUTO";
            this.LUCRO_PRODUTO.ReadOnly = true;
            // 
            // PRECO_VENDA
            // 
            this.PRECO_VENDA.DataPropertyName = "PRECO_VENDA";
            this.PRECO_VENDA.HeaderText = "Preço Venda";
            this.PRECO_VENDA.Name = "PRECO_VENDA";
            this.PRECO_VENDA.ReadOnly = true;
            // 
            // PRECO_TOTAL
            // 
            this.PRECO_TOTAL.DataPropertyName = "PRECO_TOTAL";
            this.PRECO_TOTAL.HeaderText = "Total Venda";
            this.PRECO_TOTAL.Name = "PRECO_TOTAL";
            this.PRECO_TOTAL.ReadOnly = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceConnectionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceConnectionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private BindingSource serviceConnectionBindingSource;
        private DataGridView DGV;
        private BindingSource serviceConnectionBindingSource2;
        private BindingSource serviceConnectionBindingSource1;
        private DataGridViewTextBoxColumn UND_MEDIDA;
        private DataGridViewTextBoxColumn ID_Produto;
        private DataGridViewTextBoxColumn NOME_PRODUTO;
        private DataGridViewTextBoxColumn QUANTIDADE_PRODUTO;
        private DataGridViewTextBoxColumn PRECO_CUSTO;
        private DataGridViewTextBoxColumn LUCRO_PRODUTO;
        private DataGridViewTextBoxColumn PRECO_VENDA;
        private DataGridViewTextBoxColumn PRECO_TOTAL;
    }
}