
namespace ViewProject
{
    partial class FormCadastroUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fmNome = new System.Windows.Forms.TextBox();
            this.fmEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fmConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fmSenha = new System.Windows.Forms.TextBox();
            this.fmCPF = new System.Windows.Forms.MaskedTextBox();
            this.fmTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label3.Location = new System.Drawing.Point(4, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label4.Location = new System.Drawing.Point(4, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 58);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fmNome
            // 
            this.fmNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fmNome.Font = new System.Drawing.Font("Tahoma", 24F);
            this.fmNome.Location = new System.Drawing.Point(474, 96);
            this.fmNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fmNome.MaxLength = 100;
            this.fmNome.Name = "fmNome";
            this.fmNome.Size = new System.Drawing.Size(969, 65);
            this.fmNome.TabIndex = 3;
            this.fmNome.TextChanged += new System.EventHandler(this.fmNome_TextChanged);
            this.fmNome.Leave += new System.EventHandler(this.fmNome_Leave);
            // 
            // fmEmail
            // 
            this.fmEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.fmEmail.Font = new System.Drawing.Font("Tahoma", 24F);
            this.fmEmail.Location = new System.Drawing.Point(474, 187);
            this.fmEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fmEmail.MaxLength = 100;
            this.fmEmail.Name = "fmEmail";
            this.fmEmail.Size = new System.Drawing.Size(969, 65);
            this.fmEmail.TabIndex = 5;
            this.fmEmail.Leave += new System.EventHandler(this.fmEmail_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(966, 5);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(473, 109);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(4, 5);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(473, 109);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label5.Location = new System.Drawing.Point(4, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 58);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.519F));
            this.tableLayoutPanel1.Controls.Add(this.fmConfirmaSenha, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.fmSenha, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.fmCPF, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fmNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fmEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fmTelefone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(71, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1447, 550);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // fmConfirmaSenha
            // 
            this.fmConfirmaSenha.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmConfirmaSenha.Location = new System.Drawing.Point(474, 460);
            this.fmConfirmaSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fmConfirmaSenha.MaxLength = 10;
            this.fmConfirmaSenha.Name = "fmConfirmaSenha";
            this.fmConfirmaSenha.PasswordChar = '*';
            this.fmConfirmaSenha.Size = new System.Drawing.Size(368, 65);
            this.fmConfirmaSenha.TabIndex = 12;
            this.fmConfirmaSenha.UseSystemPasswordChar = true;
            this.fmConfirmaSenha.TextChanged += new System.EventHandler(this.fmConfirmaSenha_TextChanged);
            this.fmConfirmaSenha.Leave += new System.EventHandler(this.fmConfirmaSenha_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label7.Location = new System.Drawing.Point(4, 455);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 58);
            this.label7.TabIndex = 11;
            this.label7.Text = "Confirme a Senha:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // fmSenha
            // 
            this.fmSenha.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmSenha.Location = new System.Drawing.Point(474, 369);
            this.fmSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fmSenha.MaxLength = 10;
            this.fmSenha.Name = "fmSenha";
            this.fmSenha.PasswordChar = '*';
            this.fmSenha.Size = new System.Drawing.Size(368, 65);
            this.fmSenha.TabIndex = 10;
            this.fmSenha.UseSystemPasswordChar = true;
            this.fmSenha.TextChanged += new System.EventHandler(this.fmSenha_TextChanged);
            this.fmSenha.Leave += new System.EventHandler(this.fmSenha_Leave);
            // 
            // fmCPF
            // 
            this.fmCPF.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmCPF.Location = new System.Drawing.Point(473, 3);
            this.fmCPF.Mask = "000,000,000-00";
            this.fmCPF.Name = "fmCPF";
            this.fmCPF.Size = new System.Drawing.Size(369, 65);
            this.fmCPF.TabIndex = 1;
            this.fmCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.fmCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.fmCPF_MaskInputRejected);
            this.fmCPF.Leave += new System.EventHandler(this.fmCPF_Leave);
            // 
            // fmTelefone
            // 
            this.fmTelefone.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmTelefone.Location = new System.Drawing.Point(473, 276);
            this.fmTelefone.Mask = "(99) 00000-0000";
            this.fmTelefone.Name = "fmTelefone";
            this.fmTelefone.Size = new System.Drawing.Size(369, 65);
            this.fmTelefone.TabIndex = 7;
            this.fmTelefone.Leave += new System.EventHandler(this.fmTelefone_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnLimpar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCadastrar, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(67, 855);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1443, 119);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(485, 5);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(473, 109);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1082, 68);
            this.label6.TabIndex = 15;
            this.label6.Text = "Livraria Visual - Cadastro de Usuários";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(945, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(554, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "A senha deve conter no mínimo 8 e no máximo 10 carateres.";
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1585, 996);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livraria Visual - Cadastro de Usuários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fmNome;
        private System.Windows.Forms.TextBox fmEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox fmTelefone;
        private System.Windows.Forms.MaskedTextBox fmCPF;
        private System.Windows.Forms.TextBox fmSenha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fmConfirmaSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
    }
}