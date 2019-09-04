using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_de_instrutor
{
    public partial class frmcaduser : Form
    {
        public frmcaduser()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            string tipo = "usr";
            
            if (radioadm.Checked)
            {
                tipo = "0";

            }
            
            MySqlConnection conn;
            conn = new MySqlConnection ("server=127.0.0.1;database=estudio;uid=root;pwd=;");
            try            {
                conn.Open();
            }
            catch (Exception ex)     {
                MessageBox.Show("Impossível estabelecer conexão. " + ex.Message);
            }
            if (conn.State == ConnectionState.Open)      {
                try
                {
                    
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                   
                    cmd.CommandText = "INSERT INTO usuario (nome_usuario,sobre_usu,id_usuario,nomedeusu,senha_usuario,senha_usuario2,tipo_usuario) VALUES('" + nome.Text + "','" + sobretext.Text + "','" + cpftext.Text + "','" + usuariotext.Text + "','" + senha1text.Text + "','" + senha2text.Text + "','" + tipo + "' )";
                    if (senha1text.Text != senha2text.Text)
                    {
                        MessageBox.Show("As senhas estão diferentes, tente novamente.");
                        conn.Close();
                    }
                        cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso.");
                    nome.Text = ("");
                    sobretext.Text = ("");
                    cpftext.Text = ("");
                    usuariotext.Text = ("");
                    senha1text.Text = ("");
                    senha2text.Text = ("");

                }
                catch (Exception ex){
                    MessageBox.Show("Ocorreu o seguinte erro " + ex.Message);
                }
            }

            
            
            }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
    }
      

    