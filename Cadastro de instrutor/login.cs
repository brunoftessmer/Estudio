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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login realizado com sucesso.");
            frmMenu newfrmMenu = new frmMenu();
            newfrmMenu.ShowDialog();
            
         
        }

        private void btncria_Click(object sender, EventArgs e)
        {
            frmcaduser newfrmcaduser = new frmcaduser();
            newfrmcaduser.ShowDialog();
        }
    }
}
