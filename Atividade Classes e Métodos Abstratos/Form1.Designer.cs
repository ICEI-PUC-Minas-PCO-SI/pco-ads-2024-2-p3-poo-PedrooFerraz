namespace Atividade_Classes_e_Métodos_Abstratos
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            calcularAreaToolStripMenuItem = new ToolStripMenuItem();
            formasToolStripMenuItem = new ToolStripMenuItem();
            quadradoToolStripMenuItem = new ToolStripMenuItem();
            círculoToolStripMenuItem = new ToolStripMenuItem();
            retanguloToolStripMenuItem = new ToolStripMenuItem();
            pentágonoToolStripMenuItem = new ToolStripMenuItem();
            triânguloToolStripMenuItem = new ToolStripMenuItem();
            hexágonoToolStripMenuItem = new ToolStripMenuItem();
            octágonoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { calcularAreaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(519, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // calcularAreaToolStripMenuItem
            // 
            calcularAreaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formasToolStripMenuItem });
            calcularAreaToolStripMenuItem.Name = "calcularAreaToolStripMenuItem";
            calcularAreaToolStripMenuItem.Size = new Size(62, 20);
            calcularAreaToolStripMenuItem.Text = "Calcular";
            calcularAreaToolStripMenuItem.Click += calcularAreaToolStripMenuItem_Click;
            // 
            // formasToolStripMenuItem
            // 
            formasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quadradoToolStripMenuItem, círculoToolStripMenuItem, retanguloToolStripMenuItem, pentágonoToolStripMenuItem, triânguloToolStripMenuItem, hexágonoToolStripMenuItem, octágonoToolStripMenuItem });
            formasToolStripMenuItem.Name = "formasToolStripMenuItem";
            formasToolStripMenuItem.Size = new Size(180, 22);
            formasToolStripMenuItem.Text = "Formas";
            // 
            // quadradoToolStripMenuItem
            // 
            quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            quadradoToolStripMenuItem.Size = new Size(180, 22);
            quadradoToolStripMenuItem.Text = "Quadrado";
            quadradoToolStripMenuItem.Click += quadradoToolStripMenuItem_Click;
            // 
            // círculoToolStripMenuItem
            // 
            círculoToolStripMenuItem.Name = "círculoToolStripMenuItem";
            círculoToolStripMenuItem.Size = new Size(180, 22);
            círculoToolStripMenuItem.Text = "Círculo";
            círculoToolStripMenuItem.Click += círculoToolStripMenuItem_Click;
            // 
            // retanguloToolStripMenuItem
            // 
            retanguloToolStripMenuItem.Name = "retanguloToolStripMenuItem";
            retanguloToolStripMenuItem.Size = new Size(180, 22);
            retanguloToolStripMenuItem.Text = "Retângulo";
            retanguloToolStripMenuItem.Click += retanguloToolStripMenuItem_Click;
            // 
            // pentágonoToolStripMenuItem
            // 
            pentágonoToolStripMenuItem.Name = "pentágonoToolStripMenuItem";
            pentágonoToolStripMenuItem.Size = new Size(180, 22);
            pentágonoToolStripMenuItem.Text = "Pentágono";
            pentágonoToolStripMenuItem.Click += pentágonoToolStripMenuItem_Click;
            // 
            // triânguloToolStripMenuItem
            // 
            triânguloToolStripMenuItem.Name = "triânguloToolStripMenuItem";
            triânguloToolStripMenuItem.Size = new Size(180, 22);
            triânguloToolStripMenuItem.Text = "Triângulo";
            triânguloToolStripMenuItem.Click += triânguloToolStripMenuItem_Click;
            // 
            // hexágonoToolStripMenuItem
            // 
            hexágonoToolStripMenuItem.Name = "hexágonoToolStripMenuItem";
            hexágonoToolStripMenuItem.Size = new Size(180, 22);
            hexágonoToolStripMenuItem.Text = "Hexágono";
            hexágonoToolStripMenuItem.Click += hexágonoToolStripMenuItem_Click;
            // 
            // octágonoToolStripMenuItem
            // 
            octágonoToolStripMenuItem.Name = "octágonoToolStripMenuItem";
            octágonoToolStripMenuItem.Size = new Size(180, 22);
            octágonoToolStripMenuItem.Text = "Octágono";
            octágonoToolStripMenuItem.Click += octágonoToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(21, 59);
            label1.Name = "label1";
            label1.Size = new Size(477, 37);
            label1.TabIndex = 1;
            label1.Text = "Selecione a Forma Que Deseja Calcular";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 214);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calcular Formas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem calcularAreaToolStripMenuItem;
        private ToolStripMenuItem formasToolStripMenuItem;
        private ToolStripMenuItem quadradoToolStripMenuItem;
        private ToolStripMenuItem círculoToolStripMenuItem;
        private ToolStripMenuItem retanguloToolStripMenuItem;
        private ToolStripMenuItem pentágonoToolStripMenuItem;
        private ToolStripMenuItem triânguloToolStripMenuItem;
        private ToolStripMenuItem hexágonoToolStripMenuItem;
        private ToolStripMenuItem octágonoToolStripMenuItem;
        private Label label1;
    }
}
