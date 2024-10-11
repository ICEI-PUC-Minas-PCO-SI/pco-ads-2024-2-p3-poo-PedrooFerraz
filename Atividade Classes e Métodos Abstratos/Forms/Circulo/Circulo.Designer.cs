namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Circulo
{
    partial class Circulo : Form
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
            raioValue = new TextBox();
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
            Result.Location = new Point(118, 171);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(100, 23);
            Result.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(118, 171);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 16;
            // 
            // Raio
            // 
            Raio.AutoSize = true;
            Raio.Location = new Point(32, 18);
            Raio.Name = "Raio";
            Raio.Size = new Size(88, 15);
            Raio.TabIndex = 15;
            Raio.Text = "Raio do Circulo";
            // 
            // raioValue
            // 
            raioValue.Location = new Point(32, 36);
            raioValue.Name = "raioValue";
            raioValue.Size = new Size(117, 23);
            raioValue.TabIndex = 14;
            raioValue.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(32, 171);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 13;
            label1.Text = "Resultado: ";
            // 
            // imagemForma
            // 
            imagemForma.Location = new Point(304, 24);
            imagemForma.Name = "imagemForma";
            imagemForma.Size = new Size(170, 170);
            imagemForma.SizeMode = PictureBoxSizeMode.StretchImage;
            imagemForma.TabIndex = 12;
            imagemForma.TabStop = false;
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(32, 125);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(117, 23);
            Mostrar.TabIndex = 11;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // Perimetro
            // 
            Perimetro.Location = new Point(32, 96);
            Perimetro.Name = "Perimetro";
            Perimetro.Size = new Size(117, 23);
            Perimetro.TabIndex = 10;
            Perimetro.Text = "Calcular Perimetro";
            Perimetro.UseVisualStyleBackColor = true;
            Perimetro.Click += Perimetro_Click;
            // 
            // Area
            // 
            Area.Location = new Point(32, 67);
            Area.Name = "Area";
            Area.Size = new Size(117, 23);
            Area.TabIndex = 9;
            Area.Text = "Calcular Área";
            Area.UseVisualStyleBackColor = true;
            Area.Click += Area_Click;
            // 
            // Circulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 225);
            Controls.Add(Result);
            Controls.Add(label3);
            Controls.Add(Raio);
            Controls.Add(raioValue);
            Controls.Add(label1);
            Controls.Add(imagemForma);
            Controls.Add(Mostrar);
            Controls.Add(Perimetro);
            Controls.Add(Area);
            Name = "Circulo";
            Text = "Circulo";
            ((System.ComponentModel.ISupportInitialize)imagemForma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Result;
        private Label label3;
        private Label Raio;
        private TextBox raioValue;
        private Label label1;
        private PictureBox imagemForma;
        private Button Mostrar;
        private Button Perimetro;
        private Button Area;
    }
}