using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Estoque.Services;
namespace Estoque.View
{
    public partial class Cadastro : Form
    {
        // Variaveis globais
        decimal precoVenda = 0, precoTotal = 0;
        string strSQL;
        ServiceConnection connService = new ServiceConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public Cadastro()
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
            if (string.IsNullOrEmpty(txtProduto.Text))
            {
                MessageBox.Show("O nome do produto não pode ser vazio!");
            }
            if (cbUnidadeMedida.Text != null && mtbLucro.Text != null && mtbPrecoCusto.Text != null &&
                txtProduto.Text != null && txtPrecoTotal.Text != null && txtPrecoVenda.Text != null && 
                txtQuantidade.Text != null)
            {
                GravarDadosDB();   
            }
        }

        public void ValidaDadosCadastro()
        {
            if(mtbLucro.Text == "   %")
            {
                txtPrecoTotal.Clear();
                txtPrecoVenda.Clear();
                return;
            }
            // Captura os dados digitados
            string nomeProduto = txtProduto.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            decimal precoCusto = Convert.ToDecimal(mtbPrecoCusto.Text.Replace("R$ ","").Trim());
            decimal lucro = Convert.ToDecimal(mtbLucro.Text.Replace("%","").Trim());
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
                MessageBox.Show("Ocorreu um erro ao validar os dados: " + ex.Message);
            }
        }

        private void mtbLucro_KeyUp(object sender, KeyEventArgs e)
        {
            ValidaDadosCadastro();

            //BuscarProximoId();
        }

        private void GravarDadosDB()
        {                   
            try
            {
                //criar conexão com o banco e verificar se produto ja está cadastrado
                connService.conn.Open();               
                strSQL = "SELECT NOME_PRODUTO FROM ESTOQUE WHERE NOME_PRODUTO = '" + txtProduto.Text + "'";
                cmd.Connection = connService.conn;
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Há um produto com o mesmo nome cadastrado!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                { 
                    //Verifica se o DataReader ainda está aberto e realiza o fechamento
                    if (!dr.IsClosed) { dr.Close(); }

                    //string de inserção no banco de dados
                    strSQL = "INSERT INTO ESTOQUE([NOME_PRODUTO],[QUANTIDADE_PRODUTO],[UND_MEDIDA],[PRECO_CUSTO],[LUCRO_PRODUTO],[PRECO_VENDA],[PRECO_TOTAL])VALUES(@nome_produto,@quantidade_produto,@und_medida,@preco_custo,@lucro_produto,@preco_venda,@preco_total)";

                    cmd.CommandText = strSQL;
                    //Insere os dados dos elementos da tela no comando sql
                    cmd.Parameters.Add(@"nome_produto",SqlDbType.VarChar).Value = txtProduto.Text;
                    cmd.Parameters.Add(@"quantidade_produto", SqlDbType.Int).Value = Convert.ToInt32(txtQuantidade.Text);
                    cmd.Parameters.Add(@"und_medida", SqlDbType.VarChar).Value = cbUnidadeMedida.Text;
                    cmd.Parameters.Add(@"preco_custo", SqlDbType.Real).Value = Convert.ToDecimal(mtbPrecoCusto.Text.Replace("R$ ", "").Trim());
                    cmd.Parameters.Add(@"lucro_produto",SqlDbType.Int).Value = Convert.ToInt32(mtbLucro.Text.Replace("%", "").Trim());
                    cmd.Parameters.Add(@"preco_venda",SqlDbType.Real).Value = precoVenda;
                    cmd.Parameters.Add(@"preco_total",SqlDbType.Real).Value = precoTotal;

                    //Execução do comando
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();

                    //Fecha conexão  com o banco de dados 
                    connService.conn.Close();

                    MessageBox.Show("Produto Cadastrado!");

                    DialogResult retorno = MessageBox.Show("Deseja cadastrar outro produto?", "Cadastrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message);
            }
            finally
            {
                connService.conn.Close();
            }
        }

        private void BuscarProximoId()
        {
            try
            {
                //Abre conexão  com o banco de dados 
                connService.conn.Open();

                //string de inserção no banco de dados
                strSQL = "SELECT MAX(ID_PRODUTO)+1 AS NextID FROM ESTOQUE";
                cmd.Connection = connService.conn;
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();

                //Execução do comando


                //Implementar a visualização dos dados
                
                //Fecha conexão  com o banco de dados 
                connService.conn.Close();
                          
            }
            catch (SqlException ex)
            { 
                MessageBox.Show("Ocorreu um erro na execução: " + ex.Message); 
            }
            finally 
            {
                //Fecha conexão  com o banco de dados 
                connService.conn.Close();
            }
        }
    }
}
