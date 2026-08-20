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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogoCorrida));
            PicCarro = new PictureBox();
            PicObstaculo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicCarro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicObstaculo).BeginInit();
            SuspendLayout();
            // 
            // PicCarro
            // 
            PicCarro.BackColor = SystemColors.ActiveCaptionText;
            PicCarro.BackgroundImage = Properties.Resources.CarroCorrida;
            PicCarro.BackgroundImageLayout = ImageLayout.Stretch;
            PicCarro.Location = new Point(312, 532);
            PicCarro.Name = "PicCarro";
            PicCarro.Size = new Size(100, 103);
            PicCarro.TabIndex = 0;
            PicCarro.TabStop = false;
            // 
            // PicObstaculo
            // 
            PicObstaculo.BackColor = SystemColors.ActiveCaptionText;
            PicObstaculo.BackgroundImage = Properties.Resources.Obstaculo;
            PicObstaculo.BackgroundImageLayout = ImageLayout.Stretch;
            PicObstaculo.Location = new Point(108, 59);
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
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(549, 657);
            Controls.Add(PicObstaculo);
            Controls.Add(PicCarro);
            Name = "FormJogoCorrida";
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
