namespace estoque
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProdList = new System.Windows.Forms.ListBox();
            this.SaidaList = new System.Windows.Forms.ListBox();
            this.EntradaList = new System.Windows.Forms.ListBox();
            this.ProdNameInput = new System.Windows.Forms.TextBox();
            this.ProdNameLB = new System.Windows.Forms.Label();
            this.AdicionarProduto = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.CheckedListBox();
            this.Prodtitle = new System.Windows.Forms.Label();
            this.Confirmar = new System.Windows.Forms.Button();
            this.QuantInput = new System.Windows.Forms.TextBox();
            this.Quant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Estoque = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProdList
            // 
            this.ProdList.FormattingEnabled = true;
            this.ProdList.Location = new System.Drawing.Point(12, 12);
            this.ProdList.Name = "ProdList";
            this.ProdList.Size = new System.Drawing.Size(251, 303);
            this.ProdList.TabIndex = 0;
            this.ProdList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SaidaList
            // 
            this.SaidaList.FormattingEnabled = true;
            this.SaidaList.Location = new System.Drawing.Point(287, 220);
            this.SaidaList.Name = "SaidaList";
            this.SaidaList.Size = new System.Drawing.Size(127, 95);
            this.SaidaList.TabIndex = 1;
            // 
            // EntradaList
            // 
            this.EntradaList.FormattingEnabled = true;
            this.EntradaList.Location = new System.Drawing.Point(426, 220);
            this.EntradaList.Name = "EntradaList";
            this.EntradaList.Size = new System.Drawing.Size(127, 95);
            this.EntradaList.TabIndex = 2;
            // 
            // ProdNameInput
            // 
            this.ProdNameInput.Location = new System.Drawing.Point(74, 16);
            this.ProdNameInput.Name = "ProdNameInput";
            this.ProdNameInput.Size = new System.Drawing.Size(100, 20);
            this.ProdNameInput.TabIndex = 3;
            // 
            // ProdNameLB
            // 
            this.ProdNameLB.AutoSize = true;
            this.ProdNameLB.Location = new System.Drawing.Point(18, 19);
            this.ProdNameLB.Name = "ProdNameLB";
            this.ProdNameLB.Size = new System.Drawing.Size(50, 13);
            this.ProdNameLB.TabIndex = 4;
            this.ProdNameLB.Text = "Produto :";
            // 
            // AdicionarProduto
            // 
            this.AdicionarProduto.Location = new System.Drawing.Point(180, 13);
            this.AdicionarProduto.Name = "AdicionarProduto";
            this.AdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.AdicionarProduto.TabIndex = 5;
            this.AdicionarProduto.Text = "Adicionar Produto";
            this.AdicionarProduto.UseVisualStyleBackColor = true;
            this.AdicionarProduto.Click += new System.EventHandler(this.AdicionarProduto_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.FormattingEnabled = true;
            this.CheckBox.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.CheckBox.Location = new System.Drawing.Point(350, 140);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(69, 34);
            this.CheckBox.TabIndex = 6;
            this.CheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckBox_ItemCheck);
            // 
            // Prodtitle
            // 
            this.Prodtitle.AutoSize = true;
            this.Prodtitle.Location = new System.Drawing.Point(347, 67);
            this.Prodtitle.Name = "Prodtitle";
            this.Prodtitle.Size = new System.Drawing.Size(103, 13);
            this.Prodtitle.TabIndex = 7;
            this.Prodtitle.Text = "Selecione o Produto";
            this.Prodtitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(478, 151);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 8;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // QuantInput
            // 
            this.QuantInput.Location = new System.Drawing.Point(350, 101);
            this.QuantInput.Name = "QuantInput";
            this.QuantInput.Size = new System.Drawing.Size(100, 20);
            this.QuantInput.TabIndex = 9;
            // 
            // Quant
            // 
            this.Quant.AutoSize = true;
            this.Quant.Location = new System.Drawing.Point(294, 108);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(39, 13);
            this.Quant.TabIndex = 10;
            this.Quant.Text = "Quant.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Produto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdicionarProduto);
            this.groupBox1.Controls.Add(this.ProdNameLB);
            this.groupBox1.Controls.Add(this.ProdNameInput);
            this.groupBox1.Location = new System.Drawing.Point(287, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 42);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Saidas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Entradas";
            // 
            // Estoque
            // 
            this.Estoque.AutoSize = true;
            this.Estoque.Location = new System.Drawing.Point(456, 67);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(62, 13);
            this.Estoque.TabIndex = 16;
            this.Estoque.Text = "ESTOQUE:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 337);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.QuantInput);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Prodtitle);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.EntradaList);
            this.Controls.Add(this.SaidaList);
            this.Controls.Add(this.ProdList);
            this.Name = "Main";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProdList;
        private System.Windows.Forms.ListBox SaidaList;
        private System.Windows.Forms.ListBox EntradaList;
        private System.Windows.Forms.TextBox ProdNameInput;
        private System.Windows.Forms.Label ProdNameLB;
        private System.Windows.Forms.Button AdicionarProduto;
        private System.Windows.Forms.CheckedListBox CheckBox;
        private System.Windows.Forms.Label Prodtitle;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox QuantInput;
        private System.Windows.Forms.Label Quant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Estoque;
    }
}

