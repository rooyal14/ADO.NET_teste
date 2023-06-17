
namespace ViewProject
{
    partial class FormRegistroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxIsAdmin = new System.Windows.Forms.CheckBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fmConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fmSenha = new System.Windows.Forms.TextBox();
            this.fmCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fmNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fmEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fmTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gridPesquisa = new System.Windows.Forms.TableLayoutPanel();
            this.fmPesquisa = new System.Windows.Forms.TextBox();
            this.cbxPesquisa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gridPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChange
            // 
            resources.ApplyResources(this.btnChange, "btnChange");
            this.btnChange.Name = "btnChange";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxIsAdmin
            // 
            resources.ApplyResources(this.cbxIsAdmin, "cbxIsAdmin");
            this.cbxIsAdmin.Name = "cbxIsAdmin";
            this.cbxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvClientes, "dgvClientes");
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Text = global::ViewProject.Properties.Settings.Default.teste;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // fmConfirmaSenha
            // 
            resources.ApplyResources(this.fmConfirmaSenha, "fmConfirmaSenha");
            this.fmConfirmaSenha.Name = "fmConfirmaSenha";
            this.fmConfirmaSenha.UseSystemPasswordChar = true;
            this.fmConfirmaSenha.Leave += new System.EventHandler(this.fmConfirmaSenha_Leave);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // fmSenha
            // 
            resources.ApplyResources(this.fmSenha, "fmSenha");
            this.fmSenha.Name = "fmSenha";
            this.fmSenha.UseSystemPasswordChar = true;
            this.fmSenha.Leave += new System.EventHandler(this.fmSenha_Leave);
            // 
            // fmCPF
            // 
            resources.ApplyResources(this.fmCPF, "fmCPF");
            this.fmCPF.Name = "fmCPF";
            this.fmCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.fmCPF.Leave += new System.EventHandler(this.fmCPF_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // fmNome
            // 
            this.fmNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.fmNome, "fmNome");
            this.fmNome.Name = "fmNome";
            this.fmNome.Leave += new System.EventHandler(this.fmNome_Leave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // fmEmail
            // 
            this.fmEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            resources.ApplyResources(this.fmEmail, "fmEmail");
            this.fmEmail.Name = "fmEmail";
            this.fmEmail.Leave += new System.EventHandler(this.fmEmail_Leave);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // fmTelefone
            // 
            resources.ApplyResources(this.fmTelefone, "fmTelefone");
            this.fmTelefone.Name = "fmTelefone";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnVoltar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChange, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnInsert, 0, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnVoltar
            // 
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.cbxIsAdmin, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.dgvClientes, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // gridPesquisa
            // 
            resources.ApplyResources(this.gridPesquisa, "gridPesquisa");
            this.gridPesquisa.Controls.Add(this.fmPesquisa, 0, 0);
            this.gridPesquisa.Controls.Add(this.cbxPesquisa, 0, 1);
            this.gridPesquisa.Name = "gridPesquisa";
            // 
            // fmPesquisa
            // 
            resources.ApplyResources(this.fmPesquisa, "fmPesquisa");
            this.fmPesquisa.Name = "fmPesquisa";
            this.fmPesquisa.TextChanged += new System.EventHandler(this.fmPesquisa_TextChanged);
            // 
            // cbxPesquisa
            // 
            resources.ApplyResources(this.cbxPesquisa, "cbxPesquisa");
            this.cbxPesquisa.FormattingEnabled = true;
            this.cbxPesquisa.Items.AddRange(new object[] {
            resources.GetString("cbxPesquisa.Items"),
            resources.GetString("cbxPesquisa.Items1"),
            resources.GetString("cbxPesquisa.Items2"),
            resources.GetString("cbxPesquisa.Items3"),
            resources.GetString("cbxPesquisa.Items4")});
            this.cbxPesquisa.Name = "cbxPesquisa";
            // 
            // FormRegistroClientes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPesquisa);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormRegistroClientes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gridPesquisa.ResumeLayout(false);
            this.gridPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbxIsAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox fmConfirmaSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fmSenha;
        private System.Windows.Forms.MaskedTextBox fmCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fmNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fmEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox fmTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel gridPesquisa;
        private System.Windows.Forms.TextBox fmPesquisa;
        private System.Windows.Forms.ComboBox cbxPesquisa;
    }
}