namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Triangulo
{
    partial class Triangulo : Form
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
            label2 = new Label();
            baseValue = new TextBox();
            label1 = new Label();
            imagemForma = new PictureBox();
            Mostrar = new Button();
            Perimetro = new Button();
            Area = new Button();
            alturaValue = new TextBox();
            ladoValue = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)imagemForma).BeginInit();
            SuspendLayout();
            // 
            // Result
            // 
            Result.Location = new Point(98, 171);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(100, 23);
            Result.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(98, 171);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 15;
            label2.Text = "Base";
            // 
            // baseValue
            // 
            baseValue.Location = new Point(12, 36);
            baseValue.Name = "baseValue";
            baseValue.Size = new Size(117, 23);
            baseValue.TabIndex = 14;
            baseValue.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 171);
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
            Mostrar.Location = new Point(144, 94);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(117, 23);
            Mostrar.TabIndex = 11;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // Perimetro
            // 
            Perimetro.Location = new Point(144, 65);
            Perimetro.Name = "Perimetro";
            Perimetro.Size = new Size(117, 23);
            Perimetro.TabIndex = 10;
            Perimetro.Text = "Calcular Perimetro";
            Perimetro.UseVisualStyleBackColor = true;
            Perimetro.Click += Perimetro_Click;
            // 
            // Area
            // 
            Area.Location = new Point(144, 36);
            Area.Name = "Area";
            Area.Size = new Size(117, 23);
            Area.TabIndex = 9;
            Area.Text = "Calcular Área";
            Area.UseVisualStyleBackColor = true;
            Area.Click += Area_Click;
            // 
            // alturaValue
            // 
            alturaValue.Location = new Point(12, 79);
            alturaValue.Name = "alturaValue";
            alturaValue.Size = new Size(117, 23);
            alturaValue.TabIndex = 18;
            alturaValue.Text = "0";
            // 
            // ladoValue
            // 
            ladoValue.Location = new Point(12, 123);
            ladoValue.Name = "ladoValue";
            ladoValue.Size = new Size(117, 23);
            ladoValue.TabIndex = 19;
            ladoValue.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 62);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 20;
            label4.Text = "Altura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 21;
            label5.Text = "Lado";
            // 
            // Triangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 225);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ladoValue);
            Controls.Add(alturaValue);
            Controls.Add(Result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(baseValue);
            Controls.Add(label1);
            Controls.Add(imagemForma);
            Controls.Add(Mostrar);
            Controls.Add(Perimetro);
            Controls.Add(Area);
            Name = "Triangulo";
            Text = "Triangulo";
            ((System.ComponentModel.ISupportInitialize)imagemForma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Result;
        private Label label3;
        private Label label2;
        private TextBox baseValue;
        private Label label1;
        private PictureBox imagemForma;
        private Button Mostrar;
        private Button Perimetro;
        private Button Area;
        private TextBox alturaValue;
        private TextBox ladoValue;
        private Label label4;
        private Label label5;
    }
}