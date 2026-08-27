namespace JogoCorridaWinFormsApp
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpboxDificuldade = new GroupBox();
            bntJogar = new Button();
            bntDificil = new Button();
            bntMedio = new Button();
            btnFacil = new Button();
            gpboxDificuldade.SuspendLayout();
            SuspendLayout();
            // 
            // gpboxDificuldade
            // 
            gpboxDificuldade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gpboxDificuldade.BackColor = Color.White;
            gpboxDificuldade.Controls.Add(bntJogar);
            gpboxDificuldade.Controls.Add(bntDificil);
            gpboxDificuldade.Controls.Add(bntMedio);
            gpboxDificuldade.Controls.Add(btnFacil);
            gpboxDificuldade.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpboxDificuldade.ForeColor = Color.Black;
            gpboxDificuldade.Location = new Point(163, 37);
            gpboxDificuldade.Name = "gpboxDificuldade";
            gpboxDificuldade.Size = new Size(469, 227);
            gpboxDificuldade.TabIndex = 4;
            gpboxDificuldade.TabStop = false;
            gpboxDificuldade.Text = "SELECIONE A  DIFICULDADE";
            gpboxDificuldade.Enter += gpboxDificuldade_Enter;
            // 
            // bntJogar
            // 
            bntJogar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntJogar.Location = new Point(177, 186);
            bntJogar.Name = "bntJogar";
            bntJogar.Size = new Size(103, 35);
            bntJogar.TabIndex = 3;
            bntJogar.Text = "SAIR";
            bntJogar.UseVisualStyleBackColor = true;
            bntJogar.Click += btnSair_Click;
            // 
            // bntDificil
            // 
            bntDificil.BackColor = Color.Red;
            bntDificil.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntDificil.Location = new Point(309, 75);
            bntDificil.Name = "bntDificil";
            bntDificil.Size = new Size(120, 50);
            bntDificil.TabIndex = 2;
            bntDificil.Text = "DIFÍCIL";
            bntDificil.UseVisualStyleBackColor = false;
            bntDificil.Click += btnDificil_Click;
            // 
            // bntMedio
            // 
            bntMedio.BackColor = Color.Yellow;
            bntMedio.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntMedio.Location = new Point(177, 75);
            bntMedio.Name = "bntMedio";
            bntMedio.Size = new Size(103, 58);
            bntMedio.TabIndex = 1;
            bntMedio.Text = "MÉDIO";
            bntMedio.UseVisualStyleBackColor = false;
            bntMedio.Click += bntMedio_Click;
            // 
            // btnFacil
            // 
            btnFacil.BackColor = Color.ForestGreen;
            btnFacil.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacil.Location = new Point(38, 75);
            btnFacil.Name = "btnFacil";
            btnFacil.Size = new Size(103, 58);
            btnFacil.TabIndex = 0;
            btnFacil.Text = "FÁCIL";
            btnFacil.UseVisualStyleBackColor = false;
            btnFacil.Click += btnFacil_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpboxDificuldade);
            Name = "FormInicio";
            Text = "FormInicio";
            gpboxDificuldade.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpboxDificuldade;
        private Button bntDificil;
        private Button bntMedio;
        private Button btnFacil;
        private Button bntJogar;
    }
}