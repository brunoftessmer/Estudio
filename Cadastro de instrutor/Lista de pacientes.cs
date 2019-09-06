using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_instrutor
{
    public partial class Lista_de_pacientes : Form
    {
        private MySqlConnection conn;
        private object dataGridView1;
        private DataSet connDataset;

        public Lista_de_pacientes()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection("server=127.0.0.1;database=estudio;uid=root;pwd=;");
                conn.Open();
                MySqlCommand objCmd = new MySqlCommand("SELECT nome_usuario from usuario WHERE id_usuario = 123", conn);
                objCmd.Parameters.Clear();
                conn.Open();
                MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT * FROM usuario ORDER BY nome_usuario", conn);
                conexaoAdapter.Fill(connDataset, "tbcliente");
                dataGridView2.DataSource = connDataset;
                dataGridView2.DataMember = "usuario";
            }
            catch(Exception erro){
                MessageBox.Show("Erro fatal." +erro);
            }
        }

        private void listusu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
