using JogoCorrida;

namespace JogoCorridaWinFormsApp
{
    public partial class FormJogoCorrida : Form
    {
        Jogo jogo;
        DateTime tempoUltimaMovimentaca = DateTime.Now;
        List<PictureBox> pictureBoxes = [];

        public FormJogoCorrida()
        {
            InitializeComponent();
            jogo = new Jogo
            {
                Faixa1Inicio = 2,
                Faixa1Fim = 198,
                Faixa2Inicio = 202,
                Faixa2Fim = 398
            };

            jogo.YMax = 550;
            jogo.IniciarJogo();
            jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            jogo.Velociade = 900;

            foreach (var ob in jogo.Obstaculos) // CRIANDO OBSTACULOS
            {
                var picOb = new PictureBox();
                picOb.BackColor = Color.Transparent;
                picOb.BackgroundImage = Properties.Resources.Carro_Obstaculo_Laranja;
                picOb.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBoxes.Add(picOb); // ADICIONA A IMAGEM NA LISTA INTERNA
                this.Controls.Add(picOb); // ADICIONA A IMAGEM NO FORMULARIO
            }
            TimerJogo.Enabled = true;
        }



        private void PicObstaculo_Click(object sender, EventArgs e)
        {

        }

        private void PicCarro_Click(object sender, EventArgs e)
        {

        }

        private void FormJogoCorrida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            }

            if (e.KeyCode == Keys.Right)
            {

                jogo.Carro.PosicaoX = jogo.PosicionaObjeto(2);
            }


        }

        private void TimerJogo_Tick(object sender, EventArgs e)
        {
            PicCarro.Location = new Point(jogo.Carro.PosicaoX, jogo.Carro.PosicaoY);
            var i = 0;

            foreach (var ob in jogo.Obstaculos)
            {
                if (ob.PosicaoY >= 0)
                {
                    pictureBoxes[i].Location = new Point(ob.PosicaoX, ob.PosicaoY);
                }
                i++;
            }
                if((DateTime.Now - tempoUltimaMovimentaca).Milliseconds >= jogo.Velociade){
                
                tempoUltimaMovimentaca = DateTime.Now;
                jogo.MovimentaObstaculos();
            }
            if (jogo.ChecarColisao())
            {
                // GamerOver();
                // TocarSom();
                Application.Exit();
            }
            Application.Exit();
        }
    }
}
