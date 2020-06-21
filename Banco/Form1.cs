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

namespace Banco
{
    public partial class Form1 : Form
    {
        private DataSet mDataSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            SqlDataReader dados;

            string cod = txbCodigo.Text;

            clsConexao conec = new clsConexao();
            dados = conec.Consulta("select nome from pessoas codigo = " + cod);


            while (dados.Read())
             {
            
                txtName.Text = dados.GetString(0);
             
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txbNewName.Text;
            string result;

            

            clsConexao con = new clsConexao();

            result = con.InserirDados("Insert pessoas (nome) values ('" + nome + "')");
            MessageBox.Show(result);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
