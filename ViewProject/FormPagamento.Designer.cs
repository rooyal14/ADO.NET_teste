namespace ViewProject
{
    partial class FormPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fmTotalFaltaPagar = new System.Windows.Forms.RichTextBox();
            this.fmDinheiro = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fmTroco = new System.Windows.Forms.RichTextBox();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(6, 6);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(613, 118);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "Voltar ao Pedido";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCarrinho, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 388);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.51546F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1846, 450);
            this.tableLayoutPanel1.TabIndex = 59;
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.AllowUserToOrderColumns = true;
            this.dgvCarrinho.AllowUserToResizeColumns = false;
            this.dgvCarrinho.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCarrinho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCarrinho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarrinho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCarrinho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCarrinho.ColumnHeadersHeight = 34;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrinho.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCarrinho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarrinho.Location = new System.Drawing.Point(6, 6);
            this.dgvCarrinho.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvCarrinho.MultiSelect = false;
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrinho.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCarrinho.RowHeadersWidth = 62;
            this.dgvCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrinho.Size = new System.Drawing.Size(1834, 438);
            this.dgvCarrinho.TabIndex = 31;
            this.dgvCarrinho.Text = global::ViewProject.Properties.Settings.Default.teste;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5369F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.4631F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblNome, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCPF, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTotal, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(634, 177);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1252, 185);
            this.tableLayoutPanel4.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 45);
            this.label9.TabIndex = 42;
            this.label9.Text = "Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 45);
            this.label10.TabIndex = 43;
            this.label10.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Enabled = false;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(191, 0);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(115, 45);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Enabled = false;
            this.lblCPF.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(191, 92);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(286, 45);
            this.lblCPF.TabIndex = 41;
            this.lblCPF.Text = "XXX.XXX.XXX-XX";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(933, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 45);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(792, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 45);
            this.label12.TabIndex = 44;
            this.label12.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 270);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(334, 45);
            this.label13.TabIndex = 64;
            this.label13.Text = "Confira seu pedido.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(522, 80);
            this.label14.TabIndex = 63;
            this.label14.Text = "Bem-Vindo(a)!";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 46);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(913, 80);
            this.label15.TabIndex = 62;
            this.label15.Text = "Livraria Visual - Check Out";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.43414F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.56586F));
            this.tableLayoutPanel2.Controls.Add(this.fmTotalFaltaPagar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.fmDinheiro, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fmTroco, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(46, 871);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1078, 255);
            this.tableLayoutPanel2.TabIndex = 66;
            // 
            // fmTotalFaltaPagar
            // 
            this.fmTotalFaltaPagar.Enabled = false;
            this.fmTotalFaltaPagar.Font = new System.Drawing.Font("Tahoma", 20F);
            this.fmTotalFaltaPagar.Location = new System.Drawing.Point(485, 6);
            this.fmTotalFaltaPagar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fmTotalFaltaPagar.Name = "fmTotalFaltaPagar";
            this.fmTotalFaltaPagar.Size = new System.Drawing.Size(585, 69);
            this.fmTotalFaltaPagar.TabIndex = 75;
            this.fmTotalFaltaPagar.Text = "";
            // 
            // fmDinheiro
            // 
            this.fmDinheiro.Font = new System.Drawing.Font("Tahoma", 20F);
            this.fmDinheiro.Location = new System.Drawing.Point(485, 91);
            this.fmDinheiro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fmDinheiro.Name = "fmDinheiro";
            this.fmDinheiro.Size = new System.Drawing.Size(585, 69);
            this.fmDinheiro.TabIndex = 68;
            this.fmDinheiro.Text = "";
            this.fmDinheiro.TextChanged += new System.EventHandler(this.fmDinheiro_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 57);
            this.label8.TabIndex = 72;
            this.label8.Text = "Troco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 57);
            this.label7.TabIndex = 71;
            this.label7.Text = "Total a Pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 57);
            this.label2.TabIndex = 68;
            this.label2.Text = "Valor Recebido:";
            // 
            // fmTroco
            // 
            this.fmTroco.Enabled = false;
            this.fmTroco.Font = new System.Drawing.Font("Tahoma", 20F);
            this.fmTroco.Location = new System.Drawing.Point(485, 176);
            this.fmTroco.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fmTroco.Name = "fmTroco";
            this.fmTroco.Size = new System.Drawing.Size(585, 72);
            this.fmTroco.TabIndex = 76;
            this.fmTroco.Text = "";
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCompra.Location = new System.Drawing.Point(6, 137);
            this.btnConfirmarCompra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(613, 119);
            this.btnConfirmarCompra.TabIndex = 32;
            this.btnConfirmarCompra.Text = "Finalizar";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnConfirmarCompra, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1272, 862);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(625, 262);
            this.tableLayoutPanel3.TabIndex = 67;
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1963, 1206);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPagamento";
            this.Text = "Livraria Visual - Check Out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox fmDinheiro;
        private System.Windows.Forms.RichTextBox fmTroco;
        private System.Windows.Forms.RichTextBox fmTotalFaltaPagar;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}