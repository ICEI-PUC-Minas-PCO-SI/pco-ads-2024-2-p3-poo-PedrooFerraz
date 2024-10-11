namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Circulo
{
    partial class Hexagono : Form
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
            Result = new TextBox();
            label3 = new Label();
            Raio = new Label();
            ladoValue = new TextBox();
            label1 = new Label();
            imagemForma = new PictureBox();
            Mostrar = new Button();
            Perimetro = new Button();
            Area = new Button();
            ((System.ComponentModel.ISupportInitialize)imagemForma).BeginInit();
            SuspendLayout();
            // 
            // Result
            // 
            Result.Location = new Point(112, 173);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(100, 23);
            Result.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(112, 173);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 25;
            // 
            // Raio
            // 
            Raio.AutoSize = true;
            Raio.Location = new Point(26, 20);
            Raio.Name = "Raio";
            Raio.Size = new Size(108, 15);
            Raio.TabIndex = 24;
            Raio.Text = "Lado do Hexagono";
            // 
            // ladoValue
            // 
            ladoValue.Location = new Point(26, 38);
            ladoValue.Name = "ladoValue";
            ladoValue.Size = new Size(117, 23);
            ladoValue.TabIndex = 23;
            ladoValue.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 173);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 22;
            label1.Text = "Resultado: ";
            // 
            // imagemForma
            // 
            imagemForma.Location = new Point(298, 26);
            imagemForma.Name = "imagemForma";
            imagemForma.Size = new Size(170, 170);
            imagemForma.SizeMode = PictureBoxSizeMode.StretchImage;
            imagemForma.TabIndex = 21;
            imagemForma.TabStop = false;
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(26, 127);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(117, 23);
            Mostrar.TabIndex = 20;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // Perimetro
            // 
            Perimetro.Location = new Point(26, 98);
            Perimetro.Name = "Perimetro";
            Perimetro.Size = new Size(117, 23);
            Perimetro.TabIndex = 19;
            Perimetro.Text = "Calcular Perimetro";
            Perimetro.UseVisualStyleBackColor = true;
            Perimetro.Click += Perimetro_Click;
            // 
            // Area
            // 
            Area.Location = new Point(26, 69);
            Area.Name = "Area";
            Area.Size = new Size(117, 23);
            Area.TabIndex = 18;
            Area.Text = "Calcular Área";
            Area.UseVisualStyleBackColor = true;
            Area.Click += Area_Click;
            // 
            // Hexagono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 225);
            Controls.Add(Result);
            Controls.Add(label3);
            Controls.Add(Raio);
            Controls.Add(ladoValue);
            Controls.Add(label1);
            Controls.Add(imagemForma);
            Controls.Add(Mostrar);
            Controls.Add(Perimetro);
            Controls.Add(Area);
            Name = "Hexagono";
            Text = "Hexagono";
            ((System.ComponentModel.ISupportInitialize)imagemForma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Result;
        private Label label3;
        private Label Raio;
        private TextBox ladoValue;
        private Label label1;
        private PictureBox imagemForma;
        private Button Mostrar;
        private Button Perimetro;
        private Button Area;
    }
}