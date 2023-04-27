
namespace ViewProject.adminForms
{
    partial class FormRegistroAutores
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
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fmNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fmIdAutor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.AllowUserToResizeColumns = false;
            this.dgvAutores.AllowUserToResizeRows = false;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAutores.Location = new System.Drawing.Point(290, 55);
            this.dgvAutores.MultiSelect = false;
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutores.Size = new System.Drawing.Size(441, 290);
            this.dgvAutores.TabIndex = 9;
            this.dgvAutores.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(347, 429);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(58, 23);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(411, 429);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(58, 23);
            this.btnChange.TabIndex = 24;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(539, 429);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 23);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(475, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // fmNome
            // 
            this.fmNome.Enabled = false;
            this.fmNome.Location = new System.Drawing.Point(388, 403);
            this.fmNome.Name = "fmNome";
            this.fmNome.Size = new System.Drawing.Size(209, 20);
            this.fmNome.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Código de Autor:";
            // 
            // fmIdAutor
            // 
            this.fmIdAutor.Enabled = false;
            this.fmIdAutor.Location = new System.Drawing.Point(436, 377);
            this.fmIdAutor.Name = "fmIdAutor";
            this.fmIdAutor.Size = new System.Drawing.Size(161, 20);
            this.fmIdAutor.TabIndex = 26;
            // 
            // FormRegistroAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fmIdAutor);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fmNome);
            this.Controls.Add(this.dgvAutores);
            this.Name = "FormRegistroAutores";
            this.Text = "FormRegistroAutores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fmNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fmIdAutor;
    }
}