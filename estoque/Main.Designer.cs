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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.CheckBox = new System.Windows.Forms.CheckedListBox();
            this.Prodtitle = new System.Windows.Forms.Label();
            this.Confirmar = new System.Windows.Forms.Button();
            this.QuantInput = new System.Windows.Forms.TextBox();
            this.Quant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Estoque = new System.Windows.Forms.Label();
            this.MovimentacaoTable = new System.Windows.Forms.DataGridView();
            this.ProdNameInput = new System.Windows.Forms.TextBox();
            this.ProdNameLB = new System.Windows.Forms.Label();
            this.AdicionarProduto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescLB = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.ProdList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.MovimentacaoTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckBox
            // 
            this.CheckBox.FormattingEnabled = true;
            this.CheckBox.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.CheckBox.Location = new System.Drawing.Point(315, 83);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(69, 34);
            this.CheckBox.TabIndex = 6;
            this.CheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckBox_ItemCheck);
            // 
            // Prodtitle
            // 
            this.Prodtitle.AutoSize = true;
            this.Prodtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prodtitle.Location = new System.Drawing.Point(150, 12);
            this.Prodtitle.Name = "Prodtitle";
            this.Prodtitle.Size = new System.Drawing.Size(206, 25);
            this.Prodtitle.TabIndex = 7;
            this.Prodtitle.Text = "Selecione o Produto";
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(309, 139);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 8;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // QuantInput
            // 
            this.QuantInput.Location = new System.Drawing.Point(197, 83);
            this.QuantInput.Name = "QuantInput";
            this.QuantInput.Size = new System.Drawing.Size(53, 20);
            this.QuantInput.TabIndex = 9;
            // 
            // Quant
            // 
            this.Quant.AutoSize = true;
            this.Quant.Location = new System.Drawing.Point(152, 86);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(39, 13);
            this.Quant.TabIndex = 10;
            this.Quant.Text = "Quant.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo:";
            // 
            // Estoque
            // 
            this.Estoque.AutoSize = true;
            this.Estoque.Location = new System.Drawing.Point(152, 48);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(62, 13);
            this.Estoque.TabIndex = 16;
            this.Estoque.Text = "ESTOQUE:";
            // 
            // MovimentacaoTable
            // 
            this.MovimentacaoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovimentacaoTable.Location = new System.Drawing.Point(12, 180);
            this.MovimentacaoTable.Name = "MovimentacaoTable";
            this.MovimentacaoTable.Size = new System.Drawing.Size(530, 145);
            this.MovimentacaoTable.TabIndex = 17;
            // 
            // ProdNameInput
            // 
            this.ProdNameInput.Location = new System.Drawing.Point(3, 51);
            this.ProdNameInput.Name = "ProdNameInput";
            this.ProdNameInput.Size = new System.Drawing.Size(100, 20);
            this.ProdNameInput.TabIndex = 3;
            // 
            // ProdNameLB
            // 
            this.ProdNameLB.AutoSize = true;
            this.ProdNameLB.Location = new System.Drawing.Point(27, 23);
            this.ProdNameLB.Name = "ProdNameLB";
            this.ProdNameLB.Size = new System.Drawing.Size(50, 13);
            this.ProdNameLB.TabIndex = 4;
            this.ProdNameLB.Text = "Produto :";
            // 
            // AdicionarProduto
            // 
            this.AdicionarProduto.Location = new System.Drawing.Point(16, 87);
            this.AdicionarProduto.Name = "AdicionarProduto";
            this.AdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.AdicionarProduto.TabIndex = 5;
            this.AdicionarProduto.Text = "Adicionar Produto";
            this.AdicionarProduto.UseVisualStyleBackColor = true;
            this.AdicionarProduto.Click += new System.EventHandler(this.AdicionarProduto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdicionarProduto);
            this.groupBox1.Controls.Add(this.ProdNameLB);
            this.groupBox1.Controls.Add(this.ProdNameInput);
            this.groupBox1.Location = new System.Drawing.Point(437, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 131);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar produto";
            // 
            // DescLB
            // 
            this.DescLB.AutoSize = true;
            this.DescLB.Location = new System.Drawing.Point(152, 119);
            this.DescLB.Name = "DescLB";
            this.DescLB.Size = new System.Drawing.Size(58, 13);
            this.DescLB.TabIndex = 18;
            this.DescLB.Text = "Descrição:";
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(155, 139);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(132, 20);
            this.Desc.TabIndex = 19;
            // 
            // ProdList
            // 
            this.ProdList.FormattingEnabled = true;
            this.ProdList.Location = new System.Drawing.Point(12, 12);
            this.ProdList.Name = "ProdList";
            this.ProdList.Size = new System.Drawing.Size(120, 147);
            this.ProdList.TabIndex = 20;
            this.ProdList.SelectedIndexChanged += new System.EventHandler(this.ProdList_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 337);
            this.Controls.Add(this.ProdList);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.DescLB);
            this.Controls.Add(this.MovimentacaoTable);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.QuantInput);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Prodtitle);
            this.Controls.Add(this.CheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.MovimentacaoTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox CheckBox;
        private System.Windows.Forms.Label Prodtitle;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox QuantInput;
        private System.Windows.Forms.Label Quant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Estoque;
        private System.Windows.Forms.DataGridView MovimentacaoTable;
        private System.Windows.Forms.TextBox ProdNameInput;
        private System.Windows.Forms.Label ProdNameLB;
        private System.Windows.Forms.Button AdicionarProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DescLB;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.ListBox ProdList;
    }
}

