using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Estoque.Services;
namespace Estoque.View
{
    public partial class Editar : Form
    {
        decimal precoVenda, precoTotal;
        string strSQL;
        SqlCommand cmd = new SqlCommand();
        ServiceConnection connService = new ServiceConnection();
        SqlDataReader dr;

        public Editar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar conexão com o banco para atualizar o produto
            AtualizaDadosDB();
        }

        public void ConsultaDadosDB()
        {
            try
            {
                //criar conexão com o banco 
                connService.conn.Open();
                cmd.Connection = connService.conn;

                if (string.IsNullOrEmpty(cbProduto.Text))
                {
                    strSQL = "SELECT * FROM ESTOQUE WHERE ID_PRODUTO = '" + txtCodigo.Text + "'";
                    cmd.CommandText = strSQL;
                    dr = cmd.ExecuteReader();
                    if (!dr.HasRows)
                    {
                        NaoCadastrado();
                    }
                    else
                    {
                        dr.Read();
                        ConsultaProdutos();
                    }
                    if (!dr.IsClosed) { dr.Close(); }
                    connService.conn.Close();
                }
                else if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    strSQL = "SELECT * FROM ESTOQUE WHERE NOME_PRODUTO = '" + cbProduto.Text + "'";
                    cmd.CommandText = strSQL;
                    dr = cmd.ExecuteReader();
                    if (!dr.HasRows)
                    {
                        NaoCadastrado();
                    }
                    else
                    {
                        dr.Read();
                        ConsultaProdutos();
                    }
                }
                else
                {
                    NaoCadastrado();
                }
                if (!dr.IsClosed) { dr.Close(); }
                connService.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connService.conn.Close();
            }
        }

        private void ConsultaProdutos()
        {
            string precoCusto = dr["PRECO_CUSTO"].ToString().Replace(",","");
            string lucro = dr["LUCRO_PRODUTO"].ToString();

            //Trata a máscara de Preço Custo
            if(precoCusto.Length < 2)
            {
                mtbPrecoCusto.Text = "0000" + precoCusto;
            }
            else if (precoCusto.Length < 3)
            {
                mtbPrecoCusto.Text = "000" + precoCusto;
            }
            else if (precoCusto.Length < 4)
            {
                mtbPrecoCusto.Text = "00" + precoCusto;
            }
            else if (precoCusto.Length < 5)
            {
                mtbPrecoCusto.Text = "0" + precoCusto;
            }
            else
            {
                mtbPrecoCusto.Text = precoCusto;
            }

            //Trata a máscara de Lucro
            if (lucro.Length == 1)
            {
                mtbLucro.Text = "00" + lucro;
            }
            else if (lucro.Length == 2)
            {
                mtbLucro.Text = "0" + lucro;
            }
            else
            {
                mtbLucro.Text = lucro;
            }

            txtCodigo.Text = dr["ID_PRODUTO"].ToString();
            txtProduto.Text = dr["NOME_PRODUTO"].ToString();
            txtQuantidade.Text = dr["QUANTIDADE_PRODUTO"].ToString();
            cbUnidadeMedida.Text = dr["UND_MEDIDA"].ToString();
            txtPrecoTotal.Text = "R$ " + dr["PRECO_TOTAL"].ToString();
            txtPrecoVenda.Text = "R$ " + dr["PRECO_VENDA"].ToString();
         
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaDadosDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        public void NaoCadastrado()
        {
            MessageBox.Show("Produto não cadastrado!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            CarregaComboBox();
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigo.Clear();
        }

        public void CarregaComboBox()
        {
            strSQL = "SELECT NOME_PRODUTO FROM ESTOQUE ORDER BY NOME_PRODUTO ASC;";
            try
            {
                connService.conn.Open();
                cmd.Connection = connService.conn;

                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();

                DataTable tableCat = new DataTable();
                tableCat.Load(dr);

                DataRow line = tableCat.NewRow();
                line["NOME_PRODUTO"] = "";
                tableCat.Rows.InsertAt(line, 0);

                cbProduto.DataSource = tableCat;
                cbProduto.ValueMember = "NOME_PRODUTO";
                cbProduto.DisplayMember = "NOME_PRODUTO";

                connService.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex}");
                connService.conn.Close();
            }
        }

        public void ValidaDadosEdicao()
        {

            if (mtbLucro.Text == "   %")
            {
                txtPrecoTotal.Clear();
                txtPrecoVenda.Clear();
                return;
            }

            // Captura os dados digitados
            string nomeProduto = txtProduto.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            decimal precoCusto = Convert.ToDecimal(mtbPrecoCusto.Text.Replace("R$", "").Trim());
            decimal lucro = Convert.ToDecimal(mtbLucro.Text.Replace("%", "").Trim());
            string unidadeMedida = cbUnidadeMedida.Text;

            try
            {
                precoVenda = (precoCusto * (lucro / 100) + precoCusto);
                precoTotal = precoVenda * quantidade;
                txtPrecoVenda.Text = "R$ " + precoVenda.ToString("0.00");
                txtPrecoTotal.Text = "R$ " + precoTotal.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }

        }

        private void mtbLucro_Leave(object sender, EventArgs e)
        {
            ValidaDadosEdicao();
        }

        private void mtbPrecoCusto_Leave(object sender, EventArgs e)
        {
            ValidaDadosEdicao();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            ValidaDadosEdicao();
        }

        private void AtualizaDadosDB()
        {
            try
            {
                //criar conexão com o banco
                connService.conn.Open();
                cmd.Connection = connService.conn;

                //string de update no banco de dados
                strSQL = "UPDATE ESTOQUE SET NOME_PRODUTO = @nome_produto, QUANTIDADE_PRODUTO = @quantidade_produto," +
                    "UND_MEDIDA = @und_medida, PRECO_CUSTO = @preco_custo, LUCRO_PRODUTO = @lucro_produto, PRECO_VENDA = @preco_venda," +
                    "PRECO_TOTAL = @preco_total WHERE ID_PRODUTO = " + Convert.ToInt32(txtCodigo.Text);

                cmd.CommandText = strSQL;

                cmd.Parameters.AddWithValue(@"nome_produto", txtProduto.Text);
                cmd.Parameters.AddWithValue(@"quantidade_produto", Convert.ToInt32(txtQuantidade.Text));
                cmd.Parameters.AddWithValue(@"und_medida", cbUnidadeMedida.Text);
                cmd.Parameters.AddWithValue(@"preco_custo", Convert.ToDecimal(mtbPrecoCusto.Text.Replace("R$ ", "").Trim()));
                cmd.Parameters.AddWithValue(@"lucro_produto", Convert.ToInt32(mtbLucro.Text.Replace("%", "").Trim()));
                cmd.Parameters.AddWithValue(@"preco_venda", precoVenda);
                cmd.Parameters.AddWithValue(@"preco_total", precoTotal);

                //Execução do comando
                cmd.ExecuteNonQuery();

                //Fecha conexão  com o banco de dados 
                connService.conn.Close();

                MessageBox.Show("Produto alterado!");

                DialogResult retorno = MessageBox.Show("Deseja editar outro produto?", "Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retorno == DialogResult.Yes)
                {
                    cbUnidadeMedida.ResetText();
                    mtbPrecoCusto.Clear();
                    mtbLucro.Clear();
                    txtProduto.Clear();
                    txtQuantidade.Clear();
                }
                else
                {
                    Close();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message);
            }
            finally
            {
                connService.conn.Close();
            }
        }
    }
}
