namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Octagono
{
    partial class Octagono : Form
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
            Result.Location = new Point(107, 174);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(100, 23);
            Result.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(107, 174);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 34;
            // 
            // Raio
            // 
            Raio.AutoSize = true;
            Raio.Location = new Point(21, 21);
            Raio.Name = "Raio";
            Raio.Size = new Size(106, 15);
            Raio.TabIndex = 33;
            Raio.Text = "Lado do Octagono";
            // 
            // ladoValue
            // 
            ladoValue.Location = new Point(21, 39);
            ladoValue.Name = "ladoValue";
            ladoValue.Size = new Size(117, 23);
            ladoValue.TabIndex = 32;
            ladoValue.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(21, 174);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 31;
            label1.Text = "Resultado: ";
            // 
            // imagemForma
            // 
            imagemForma.Location = new Point(293, 27);
            imagemForma.Name = "imagemForma";
            imagemForma.Size = new Size(170, 170);
            imagemForma.SizeMode = PictureBoxSizeMode.StretchImage;
            imagemForma.TabIndex = 30;
            imagemForma.TabStop = false;
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(21, 128);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(117, 23);
            Mostrar.TabIndex = 29;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // Perimetro
            // 
            Perimetro.Location = new Point(21, 99);
            Perimetro.Name = "Perimetro";
            Perimetro.Size = new Size(117, 23);
            Perimetro.TabIndex = 28;
            Perimetro.Text = "Calcular Perimetro";
            Perimetro.UseVisualStyleBackColor = true;
            Perimetro.Click += Perimetro_Click;
            // 
            // Area
            // 
            Area.Location = new Point(21, 70);
            Area.Name = "Area";
            Area.Size = new Size(117, 23);
            Area.TabIndex = 27;
            Area.Text = "Calcular Área";
            Area.UseVisualStyleBackColor = true;
            Area.Click += Area_Click;
            // 
            // Octagono
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
            Name = "Octagono";
            Text = "Octagono";
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