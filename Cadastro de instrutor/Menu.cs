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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExercicio_Click(object sender, EventArgs e)
        {
            cadastroExercicio newcadex = new cadastroExercicio();
            newcadex.ShowDialog();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            cadastroPaciente newcadpaciente = new cadastroPaciente();
            newcadpaciente.ShowDialog();
        }

        private void btnInstrutor_Click(object sender, EventArgs e)
        {
            frmcaduser newfrmcaduser = new frmcaduser();
            newfrmcaduser.ShowDialog();
        }
    }
}
