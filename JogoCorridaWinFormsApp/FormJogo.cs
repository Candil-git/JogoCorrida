using JogoCorrida;
using System.Drawing.Text;
using System.Media;

namespace JogoCorridaWinFormsApp
{
    public partial class FormJogoCorrida : Form
    {
        Jogo jogo;
        DateTime tempoUltimaMovimentaca = DateTime.Now;
        DateTime tempoUltimaPontuacao = DateTime.Now;
        List<PictureBox> pictureBoxes = [];

        public FormJogoCorrida(String Nivel)
        {
            InitializeComponent();

            SomJogoCorrida();

            // Faz parar de piscar
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            jogo = new Jogo
            {
                Faixa1Inicio = 129,
                Faixa1Fim = 198,
                Faixa2Inicio = 258,
                Faixa2Fim = 325
            };

            jogo.YMax = 696;
            jogo.IniciarJogo();
            jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            //jogo.Velociade = 50;

            if(Nivel == "Facil")
            {
                jogo.Velociade = 100;

            }else if (Nivel == "Medio")
            {
                jogo.Velociade = 150;
            }
            else
            {
                jogo.Velociade = 200;
            }

            foreach (var ob in jogo.Obstaculos) // CRIANDO OBSTACULOS
            {
                var picOb = new PictureBox();
                picOb.BackColor = Color.Transparent;
                picOb.BackgroundImage = Properties.Resources.Carro_Obstaculo_Laranja;
                picOb.BackgroundImageLayout = ImageLayout.Stretch;
                picOb.Size = new Size(PicCarro.Width, PicCarro.Height);
                pictureBoxes.Add(picOb); // ADICIONA A IMAGEM NA LISTA INTERNA
                this.Controls.Add(picOb); // ADICIONA A IMAGEM NO FORMULARIO
            }
            TimerJogo.Enabled = true;
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
                if (i < pictureBoxes.Count)
                {
                    pictureBoxes[i].Visible = true; // PROBLEMA NO CARRO DO LADO ESQUERDO TRAVADO
                    pictureBoxes[i].Location = new Point(ob.PosicaoX, ob.PosicaoY);
                }
                else
                {
                    pictureBoxes[i].Visible = false;
                }

                i++;
            }

            if (jogo.Galao != null)
            {
                picGalao.Location = new Point(jogo.Galao.PosicaoX, jogo.Galao.PosicaoY);
            }

            
            if ((DateTime.Now - tempoUltimaMovimentaca).TotalMilliseconds >= jogo.Velociade)
            {
                tempoUltimaMovimentaca = DateTime.Now;

                jogo.MovimentaObstaculos();
                jogo.MovimentaMoeda();

                
                if (jogo.ChecarColetaGalao())
                {
                    jogo.Pontuacao += 50; 
                    lblPontuacao.Text = $"Pontuação: {jogo.Pontuacao}";
                    jogo.ResetarGalao(); 
                }
            }

            if ((DateTime.Now - tempoUltimaPontuacao).TotalMilliseconds >= 5000)
            {
                jogo.Pontuacao += 2;
                tempoUltimaPontuacao = DateTime.Now; 
                lblPontuacao.Text = $"Pontuação: {jogo.Pontuacao}";
            }

            if ((DateTime.Now - tempoUltimaMovimentaca).TotalMilliseconds >= jogo.Velociade)
            {
                tempoUltimaMovimentaca = DateTime.Now;
                jogo.MovimentaObstaculos();

                lblPontuacao.Text = $"Pontuação: {jogo.Pontuacao}";
            }

            if (jogo.ChecarColisao())
            {
                GameOver();
                Application.Exit();
            }

        }

        private async void GameOver()
        {
            // 1. Para o timer do jogo imediatamente
            TimerJogo.Enabled = false;

            // 2. Toca o som em segundo plano (com Play())
            TocarSomBatida();

            // 3. EFEITO PISCAR ASSÍNCRONO: Pisca o carro sem congelar a tela
            for (int i = 0; i < 6; i++)
            {
                PicCarro.Visible = false;
                await Task.Delay(120); // Espera 120ms liberando a interface gráfica

                PicCarro.Visible = true;
                await Task.Delay(120);
            }

            // 4. Pausa final para o som terminar de tocar
            await Task.Delay(500);

            // 5. Fecha o jogo
            Close();
        }


        private void TocarSomBatida()
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.EfeitoSonoro_BatidaCarro);
            sp.PlaySync();
        }

        private void SomJogoCorrida()
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.MúsicaTema);
            sp.Load();
            sp.Play();
        }

    }
}

