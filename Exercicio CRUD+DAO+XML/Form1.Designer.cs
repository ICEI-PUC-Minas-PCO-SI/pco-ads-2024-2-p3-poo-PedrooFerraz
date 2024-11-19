namespace Exercicio_CRUD_DAO_XML
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
            nameInput = new TextBox();
            emailInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCadastrar = new Button();
            btnDeletar = new Button();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // nameInput
            // 
            nameInput.Location = new Point(42, 63);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(156, 23);
            nameInput.TabIndex = 0;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(42, 114);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(156, 23);
            emailInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 96);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(42, 159);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(156, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(43, 188);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(155, 23);
            btnDeletar.TabIndex = 5;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(268, 22);
            gridView.Name = "gridView";
            gridView.Size = new Size(350, 259);
            gridView.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 305);
            Controls.Add(gridView);
            Controls.Add(btnDeletar);
            Controls.Add(btnCadastrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailInput);
            Controls.Add(nameInput);
            Name = "Form1";
            Text = "CrudDaoXml";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameInput;
        private TextBox emailInput;
        private Label label1;
        private Label label2;
        private Button btnCadastrar;
        private Button btnDeletar;
        private DataGridView gridView;
    }
}
