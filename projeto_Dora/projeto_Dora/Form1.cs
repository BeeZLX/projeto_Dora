using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_Dora
{
    public partial class Form1 : Form
    {

        #region
        int contador, tipo = 0;
        #endregion
        public Form1()
        {
            InitializeComponent();
            btnAutores.Enabled = true;
            btnComecar.Enabled = false;
            btnReiniciar.Enabled = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            gbxJogo.ForeColor = Color.Red;
            gbxJogo.Text  = "jogo de: "+txtUsuario.Text;
            btnComecar.Enabled = verificaUsuario();
            btnReiniciar.Enabled = verificaUsuario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vinicius de Moraes Regis, " +
                "Juana Isabela, " +
                "Vinicius Scarpit ", "Autores do Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            
            
        }

        Boolean verificaUsuario()
        {
            if (txtUsuario.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
