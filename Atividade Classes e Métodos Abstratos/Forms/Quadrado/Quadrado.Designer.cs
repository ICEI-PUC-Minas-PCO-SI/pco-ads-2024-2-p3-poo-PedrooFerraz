namespace Atividade_Classes_e_Métodos_Abstratos.Forms
{
    partial class Quadrado : Form
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
            Area = new Button();
            Perimetro = new Button();
            Mostrar = new Button();
            imagemForma = new PictureBox();
            label1 = new Label();
            ladoValue = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Result = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imagemForma).BeginInit();
            SuspendLayout();
            // 
            // Area
            // 
            Area.Location = new Point(31, 62);
            Area.Name = "Area";
            Area.Size = new Size(117, 23);
            Area.TabIndex = 0;
            Area.Text = "Calcular Área";
            Area.UseVisualStyleBackColor = true;
            Area.Click += Area_Click;
            // 
            // Perimetro
            // 
            Perimetro.Location = new Point(31, 91);
            Perimetro.Name = "Perimetro";
            Perimetro.Size = new Size(117, 23);
            Perimetro.TabIndex = 1;
            Perimetro.Text = "Calcular Perimetro";
            Perimetro.UseVisualStyleBackColor = true;
            Perimetro.Click += Perimetro_Click;
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(31, 120);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(117, 23);
            Mostrar.TabIndex = 2;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // imagemForma
            // 
            imagemForma.Location = new Point(305, 19);
            imagemForma.Name = "imagemForma";
            imagemForma.Size = new Size(170, 170);
            imagemForma.SizeMode = PictureBoxSizeMode.StretchImage;
            imagemForma.TabIndex = 3;
            imagemForma.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(31, 166);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 4;
            label1.Text = "Resultado: ";
            // 
            // ladoValue
            // 
            ladoValue.Location = new Point(31, 31);
            ladoValue.Name = "ladoValue";
            ladoValue.Size = new Size(117, 23);
            ladoValue.TabIndex = 5;
            ladoValue.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 13);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 6;
            label2.Text = "Lado do Quadrado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(117, 166);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 7;
            // 
            // Result
            // 
            Result.Location = new Point(117, 166);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(100, 23);
            Result.TabIndex = 8;
            // 
            // Quadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 225);
            Controls.Add(Result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ladoValue);
            Controls.Add(label1);
            Controls.Add(imagemForma);
            Controls.Add(Mostrar);
            Controls.Add(Perimetro);
            Controls.Add(Area);
            Name = "Quadrado";
            Text = "Quadrado";
            ((System.ComponentModel.ISupportInitialize)imagemForma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Area;
        private Button Perimetro;
        private Button Mostrar;
        private PictureBox imagemForma;
        private Label label1;
        private TextBox ladoValue;
        private Label label2;
        private Label label3;
        private TextBox Result;
    }
}