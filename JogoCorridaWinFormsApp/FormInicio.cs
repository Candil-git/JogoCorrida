using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCorridaWinFormsApp
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void bntMedio_Click(object sender, EventArgs e)
        {
            var jogo = new FormJogoCorrida("Medio");
            jogo.ShowDialog();
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            var jogo = new FormJogoCorrida("Facil");
            jogo.ShowDialog();
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            var jogo = new FormJogoCorrida("Dificil");
            jogo.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gpboxDificuldade_Enter(object sender, EventArgs e)
        {

        }
    }
}
