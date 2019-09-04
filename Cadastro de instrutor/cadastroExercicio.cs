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
    public partial class cadastroExercicio : Form
    {
        private object ofd1;

        public cadastroExercicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                    cmd.CommandText = "INSERT INTO exercicio (id_exercicio,descricao_exercicio,observacoes_ex,foto_exercicio) VALUES('" + idexercicio.Text + "','" + descexe.Text + "','" + obsexe.Text + "','" + Convert.ToString(fotoEx.Image) + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso.");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                }
            }
        }

        private void mandarImagem_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void enviaimg_Click(object sender, EventArgs e)
        {
            mandarImagem.ShowDialog();
            fotoEx.Image = Image.FromFile(mandarImagem.FileName);
        }
    }
}