namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Pentagono
{
    partial class Retangulo : Form
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
            label4 = new Label();
            alturaValue = new TextBox();
            Result = new TextBox();
            label3 = new Label();
            label2 = new Label();
            larguraValue = new TextBox();
            label1 = new Label();
            imagemForma = new PictureBox();
            Mostrar = new Button();
            Perimetro = new Button();
            Area = new Button();
            ((System.ComponentModel.ISupportInitialize)imagemForma).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 59);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 33;
            label4.Text = "Altura";
            // 
            // alturaValue
            // 
            alturaValue.Location = new Point(12, 76);
            alturaValue.Name = "alturaValue";
            alturaValue.Size = new Size(117, 23);
            alturaValue.TabIndex = 31;
            alturaValue.Text = "0";
            // 
            // Result
            // 
            Result.Location = new Point(98, 168);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(100, 23);
            Result.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(98, 168);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 28;
            label2.Text = "Largura";
            // 
            // larguraValue
            // 
            larguraValue.Location = new Point(12, 33);
            larguraValue.Name = "larguraValue";
            larguraValue.Size = new Size(117, 23);
            larguraValue.TabIndex = 27;
            larguraValue.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 26;
            label1.Text = "Resultado: ";
            // 
            // imagemForma
            // 
            imagemForma.Location = new Point(304, 21);
            imagemForma.Name = "imagemForma";
            imagemForma.Size = new Size(170, 170);
            imagemForma.SizeMode = PictureBoxSizeMode.StretchImage;
            imagemForma.TabIndex = 25;
            imagemForma.TabStop = false;
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(144, 91);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(117, 23);
            Mostrar.TabIndex = 24;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // Perimetro
            // 
            Perimetro.Location = new Point(144, 62);
            Perimetro.Name = "Perimetro";
            Perimetro.Size = new Size(117, 23);
            Perimetro.TabIndex = 23;
            Perimetro.Text = "Calcular Perimetro";
            Perimetro.UseVisualStyleBackColor = true;
            Perimetro.Click += Perimetro_Click;
            // 
            // Area
            // 
            Area.Location = new Point(144, 33);
            Area.Name = "Area";
            Area.Size = new Size(117, 23);
            Area.TabIndex = 22;
            Area.Text = "Calcular Área";
            Area.UseVisualStyleBackColor = true;
            Area.Click += Area_Click;
            // 
            // Retangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 225);
            Controls.Add(label4);
            Controls.Add(alturaValue);
            Controls.Add(Result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(larguraValue);
            Controls.Add(label1);
            Controls.Add(imagemForma);
            Controls.Add(Mostrar);
            Controls.Add(Perimetro);
            Controls.Add(Area);
            Name = "Retangulo";
            Text = "Retangulo";
            ((System.ComponentModel.ISupportInitialize)imagemForma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox ladoValue;
        private TextBox alturaValue;
        private TextBox Result;
        private Label label3;
        private Label label2;
        private TextBox larguraValue;
        private Label label1;
        private PictureBox imagemForma;
        private Button Mostrar;
        private Button Perimetro;
        private Button Area;
    }
}