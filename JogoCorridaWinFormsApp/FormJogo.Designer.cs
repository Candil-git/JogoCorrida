namespace JogoCorridaWinFormsApp
{
    partial class FormJogoCorrida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PicCarro = new PictureBox();
            PicObstaculo = new PictureBox();
            TimerJogo = new System.Windows.Forms.Timer(components);
            lblPontuacao = new Label();
            picGalao = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicCarro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicObstaculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGalao).BeginInit();
            SuspendLayout();
            // 
            // PicCarro
            // 
            PicCarro.BackColor = Color.Transparent;
            PicCarro.BackgroundImage = Properties.Resources.Carro_Corrida_Cinza;
            PicCarro.BackgroundImageLayout = ImageLayout.Stretch;
            PicCarro.Location = new Point(285, 550);
            PicCarro.Name = "PicCarro";
            PicCarro.Size = new Size(103, 113);
            PicCarro.TabIndex = 0;
            PicCarro.TabStop = false;
            // 
            // PicObstaculo
            // 
            PicObstaculo.BackColor = Color.Transparent;
            PicObstaculo.BackgroundImage = Properties.Resources.Carro_Obstaculo_Laranja;
            PicObstaculo.BackgroundImageLayout = ImageLayout.Stretch;
            PicObstaculo.Location = new Point(159, 26);
            PicObstaculo.Name = "PicObstaculo";
            PicObstaculo.Size = new Size(103, 113);
            PicObstaculo.TabIndex = 1;
            PicObstaculo.TabStop = false;
            PicObstaculo.Visible = false;
            // 
            // TimerJogo
            // 
            TimerJogo.Interval = 20;
            TimerJogo.Tick += TimerJogo_Tick;
            // 
            // lblPontuacao
            // 
            lblPontuacao.AutoSize = true;
            lblPontuacao.Location = new Point(452, 26);
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Size = new Size(76, 15);
            lblPontuacao.TabIndex = 2;
            lblPontuacao.Text = "Pontuação: 0";
            // 
            // picGalao
            // 
            picGalao.BackColor = Color.Transparent;
            picGalao.BackgroundImageLayout = ImageLayout.Stretch;
            picGalao.Image = Properties.Resources.Galao_Combustivel;
            picGalao.Location = new Point(304, 285);
            picGalao.Name = "picGalao";
            picGalao.Size = new Size(73, 54);
            picGalao.SizeMode = PictureBoxSizeMode.StretchImage;
            picGalao.TabIndex = 3;
            picGalao.TabStop = false;
            // 
            // FormJogoCorrida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pista_Corrida_SemArvore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(575, 657);
            Controls.Add(picGalao);
            Controls.Add(lblPontuacao);
            Controls.Add(PicObstaculo);
            Controls.Add(PicCarro);
            Name = "FormJogoCorrida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JogoCorrida";
            KeyDown += FormJogoCorrida_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PicCarro).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicObstaculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGalao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicCarro;
        private PictureBox PicObstaculo;
        private System.Windows.Forms.Timer TimerJogo;
        private Label lblPontuacao;
        private PictureBox picGalao;
    }
}
