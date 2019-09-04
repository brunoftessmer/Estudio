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
    public partial class cadastroPaciente : Form
    {
        public cadastroPaciente()
        {
            InitializeComponent();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            string tipo = "usr";

            if (masc.Checked)
            {
                tipo = "masculino";

            }

            MySqlConnection conn;
            conn = new MySqlConnection("server=127.0.0.1;database=estudio;uid=root;pwd=;");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível estabelecer conexão. " + ex.Message);
            }
            if (conn.State == ConnectionState.Open)
            {
                try
                {

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO paciente (nome, sobrenome, endereco, email, telefone, cpf, sexo, data_nasc, ocupacao) VALUES('" + textnome.Text + "','" + textsobrenome.Text + "','" + textendereco.Text + "','" + textemail.Text + "','" + texttelefone.Text + "','" + textcpf.Text + "','" + tipo + "','" + data.Text + "','" + textocu.Text + "')";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso.");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro " + ex.Message);
                }
            }
        }

        private void data_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    
