namespace mercado
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
            produto = new Label();
            txtproduto = new TextBox();
            Quantidade = new Label();
            txtqtd = new TextBox();
            Valor = new Label();
            txtvalor = new TextBox();
            txttotal = new TextBox();
            btninserir = new Button();
            btnfechar = new Button();
            btnlimpar = new Button();
            lista = new ListBox();
            total = new Label();
            SuspendLayout();
            // 
            // produto
            // 
            produto.AutoSize = true;
            produto.Location = new Point(195, 67);
            produto.Name = "produto";
            produto.Size = new Size(50, 15);
            produto.TabIndex = 0;
            produto.Text = "produto";
            // 
            // txtproduto
            // 
            txtproduto.Location = new Point(322, 59);
            txtproduto.Name = "txtproduto";
            txtproduto.Size = new Size(155, 23);
            txtproduto.TabIndex = 1;
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.Location = new Point(195, 120);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(69, 15);
            Quantidade.TabIndex = 2;
            Quantidade.Text = "Quantidade";
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(322, 112);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(155, 23);
            txtqtd.TabIndex = 3;
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(195, 169);
            Valor.Name = "Valor";
            Valor.Size = new Size(33, 15);
            Valor.TabIndex = 4;
            Valor.Text = "Valor";
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(322, 166);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(155, 23);
            txtvalor.TabIndex = 5;
            // 
            // txttotal
            // 
            txttotal.Enabled = false;
            txttotal.Location = new Point(304, 358);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(234, 23);
            txttotal.TabIndex = 6;
            // 
            // btninserir
            // 
            btninserir.Location = new Point(366, 229);
            btninserir.Name = "btninserir";
            btninserir.Size = new Size(75, 23);
            btninserir.TabIndex = 7;
            btninserir.Text = "Inserir";
            btninserir.UseVisualStyleBackColor = true;
            btninserir.Click += btninserir_Click;
            // 
            // btnfechar
            // 
            btnfechar.Location = new Point(485, 397);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(75, 23);
            btnfechar.TabIndex = 8;
            btnfechar.Text = "fechar";
            btnfechar.UseVisualStyleBackColor = true;
            btnfechar.Click += btnfechar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(189, 397);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 9;
            btnlimpar.Text = "limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(341, 258);
            lista.Name = "lista";
            lista.Size = new Size(120, 94);
            lista.TabIndex = 10;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(190, 366);
            total.Name = "total";
            total.Size = new Size(31, 15);
            total.TabIndex = 11;
            total.Text = "total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(total);
            Controls.Add(lista);
            Controls.Add(btnlimpar);
            Controls.Add(btnfechar);
            Controls.Add(btninserir);
            Controls.Add(txttotal);
            Controls.Add(txtvalor);
            Controls.Add(Valor);
            Controls.Add(txtqtd);
            Controls.Add(Quantidade);
            Controls.Add(txtproduto);
            Controls.Add(produto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label produto;
        private TextBox txtproduto;
        private Label Quantidade;
        private TextBox txtqtd;
        private Label Valor;
        private TextBox txtvalor;
        private TextBox txttotal;
        private Button btninserir;
        private Button btnfechar;
        private Button btnlimpar;
        private ListBox lista;
        private Label total;
    }
}
