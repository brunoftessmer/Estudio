using MySql.Data.MySqlClient;
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
using System.Data.OleDb;

namespace Cadastro_de_instrutor
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM usuario WHERE nomedeusu=@nomedeusu AND senha_usuario=@senha_usuario";
            Conexão conexao = new Conexão();
            conexao.conectar();



            MySqlCommand cmd = new MySqlCommand(query, conexao.cn);

            cmd.Parameters.AddWithValue("@nomedeusu", textlogin.Text);
            cmd.Parameters.AddWithValue("@senha_usuario", textsenha.Text);

            MySqlDataReader dr = ExecuteReader();

            if (dr.Read())
            {
                Autenticação.logar(dr["login"].ToString(), dr["senha"].ToString(), Convert.ToInt32(dr["nivel"]));
                MessageBox.Show("Login realizado.");
                frmcaduser newfrmcaduser = new frmcaduser();
                newfrmcaduser.ShowDialog();
            }
            else {
                MessageBox.Show("Usuário ou senha inválidos.");

            }

        }

        private MySqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }

        private void btncria_Click(object sender, EventArgs e)
        {
            frmcaduser newfrmcaduser = new frmcaduser();
            newfrmcaduser.ShowDialog();
           
        }
    }
}
