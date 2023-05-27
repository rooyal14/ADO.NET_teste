
namespace ViewProject
{
    partial class FormLojaCliente
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fmGenero = new System.Windows.Forms.TextBox();
            this.fmEstoque = new System.Windows.Forms.TextBox();
            this.fmNome = new System.Windows.Forms.TextBox();
            this.fmNr = new System.Windows.Forms.TextBox();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCarrinho = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fmPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.carrinhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.fmAutores = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(12, 42);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(691, 290);
            this.dgv.TabIndex = 22;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número:";
            // 
            // fmGenero
            // 
            this.fmGenero.Enabled = false;
            this.fmGenero.Location = new System.Drawing.Point(224, 493);
            this.fmGenero.Name = "fmGenero";
            this.fmGenero.Size = new System.Drawing.Size(202, 20);
            this.fmGenero.TabIndex = 17;
            // 
            // fmEstoque
            // 
            this.fmEstoque.Enabled = false;
            this.fmEstoque.Location = new System.Drawing.Point(244, 461);
            this.fmEstoque.Name = "fmEstoque";
            this.fmEstoque.Size = new System.Drawing.Size(182, 20);
            this.fmEstoque.TabIndex = 16;
            // 
            // fmNome
            // 
            this.fmNome.Enabled = false;
            this.fmNome.Location = new System.Drawing.Point(217, 389);
            this.fmNome.Name = "fmNome";
            this.fmNome.Size = new System.Drawing.Size(209, 20);
            this.fmNome.TabIndex = 15;
            // 
            // fmNr
            // 
            this.fmNr.Enabled = false;
            this.fmNr.Location = new System.Drawing.Point(226, 351);
            this.fmNr.Name = "fmNr";
            this.fmNr.Size = new System.Drawing.Size(200, 20);
            this.fmNr.TabIndex = 14;
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToResizeColumns = false;
            this.dgvCarrinho.AllowUserToResizeRows = false;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarrinho.Location = new System.Drawing.Point(866, 39);
            this.dgvCarrinho.MultiSelect = false;
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCarrinho.Size = new System.Drawing.Size(523, 290);
            this.dgvCarrinho.TabIndex = 27;
            this.dgvCarrinho.SelectionChanged += new System.EventHandler(this.dgvCarrinho_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantidade adicionada ao carrinho:";
            // 
            // numQtd
            // 
            this.numQtd.Enabled = false;
            this.numQtd.Location = new System.Drawing.Point(355, 574);
            this.numQtd.Name = "numQtd";
            this.numQtd.Size = new System.Drawing.Size(71, 20);
            this.numQtd.TabIndex = 29;
            // 
            // btnAddToCarrinho
            // 
            this.btnAddToCarrinho.Location = new System.Drawing.Point(305, 608);
            this.btnAddToCarrinho.Name = "btnAddToCarrinho";
            this.btnAddToCarrinho.Size = new System.Drawing.Size(121, 36);
            this.btnAddToCarrinho.TabIndex = 30;
            this.btnAddToCarrinho.Text = "Adicionar Item";
            this.btnAddToCarrinho.UseVisualStyleBackColor = true;
            this.btnAddToCarrinho.Click += new System.EventHandler(this.btnAddToCarrinho_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Valor Unitário:";
            // 
            // fmPrecoUnitario
            // 
            this.fmPrecoUnitario.Enabled = false;
            this.fmPrecoUnitario.Location = new System.Drawing.Point(252, 424);
            this.fmPrecoUnitario.Name = "fmPrecoUnitario";
            this.fmPrecoUnitario.Size = new System.Drawing.Size(174, 20);
            this.fmPrecoUnitario.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1141, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1209, 351);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 25);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "XX.XX";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Enabled = false;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(176, 608);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(123, 36);
            this.btnRemoveFromCart.TabIndex = 35;
            this.btnRemoveFromCart.Text = "Remover Item";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // carrinhoBindingSource
            // 
            this.carrinhoBindingSource.DataSource = typeof(ModelProject.Carrinho);
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(1146, 408);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(136, 36);
            this.btnConfirmarCompra.TabIndex = 36;
            this.btnConfirmarCompra.Text = "Confimar Compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Autores:";
            // 
            // fmAutores
            // 
            this.fmAutores.Enabled = false;
            this.fmAutores.Location = new System.Drawing.Point(226, 532);
            this.fmAutores.Name = "fmAutores";
            this.fmAutores.Size = new System.Drawing.Size(200, 20);
            this.fmAutores.TabIndex = 37;
            // 
            // FormLojaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 665);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fmAutores);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fmPrecoUnitario);
            this.Controls.Add(this.btnAddToCarrinho);
            this.Controls.Add(this.numQtd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCarrinho);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fmGenero);
            this.Controls.Add(this.fmEstoque);
            this.Controls.Add(this.fmNome);
            this.Controls.Add(this.fmNr);
            this.Name = "FormLojaCliente";
            this.Text = "FormLojaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fmGenero;
        private System.Windows.Forms.TextBox fmEstoque;
        private System.Windows.Forms.TextBox fmNome;
        private System.Windows.Forms.TextBox fmNr;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQtd;
        private System.Windows.Forms.BindingSource carrinhoBindingSource;
        private System.Windows.Forms.Button btnAddToCarrinho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fmPrecoUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fmAutores;
    }
}