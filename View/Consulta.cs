using Estoque.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.View
{
    public partial class Consulta : Form
    {
        string strSQL;
        SqlCommand cmd = new SqlCommand();
        ServiceConnection connService = new ServiceConnection();

        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            DGVLoad();
        }
        public void DGVLoad()
        {
            
            strSQL = "SELECT * FROM ESTOQUE";
            try
            {
                connService.GetStringConnection();
                connService.conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(strSQL, connService.conn);
                DataSet data = new DataSet();

                da.Fill(data);

                DGV.DataSource = data.Tables[0];

                connService.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                connService.conn.Close();
            }
        }
    }
}
