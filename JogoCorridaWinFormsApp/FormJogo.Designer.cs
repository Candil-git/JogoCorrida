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
            PicCarro = new PictureBox();
            PicObstaculo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicCarro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicObstaculo).BeginInit();
            SuspendLayout();
            // 
            // PicCarro
            // 
            PicCarro.BackColor = Color.Transparent;
            PicCarro.BackgroundImage = Properties.Resources.Carro_Corrida_Cinza;
            PicCarro.BackgroundImageLayout = ImageLayout.Stretch;
            PicCarro.Location = new Point(289, 532);
            PicCarro.Name = "PicCarro";
            PicCarro.Size = new Size(103, 113);
            PicCarro.TabIndex = 0;
            PicCarro.TabStop = false;
            PicCarro.Click += PicCarro_Click;
            // 
            // PicObstaculo
            // 
            PicObstaculo.BackColor = Color.Transparent;
            PicObstaculo.BackgroundImage = Properties.Resources.Carro_Obstaculo_Laranja;
            PicObstaculo.BackgroundImageLayout = ImageLayout.Stretch;
            PicObstaculo.Location = new Point(160, 26);
            PicObstaculo.Name = "PicObstaculo";
            PicObstaculo.Size = new Size(100, 103);
            PicObstaculo.TabIndex = 1;
            PicObstaculo.TabStop = false;
            PicObstaculo.Click += PicObstaculo_Click;
            // 
            // FormJogoCorrida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pista_Corrida_SemArvore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(575, 657);
            Controls.Add(PicObstaculo);
            Controls.Add(PicCarro);
            Name = "FormJogoCorrida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JogoCorrida";
            ((System.ComponentModel.ISupportInitialize)PicCarro).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicObstaculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicCarro;
        private PictureBox PicObstaculo;
    }
}
