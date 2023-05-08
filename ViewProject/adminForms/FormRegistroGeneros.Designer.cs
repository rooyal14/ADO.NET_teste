
namespace ViewProject.adminForms
{
    partial class FormRegistroGeneros
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
            this.label1 = new System.Windows.Forms.Label();
            this.fmIdGenero = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fmNome = new System.Windows.Forms.TextBox();
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código do Gênero:";
            // 
            // fmIdGenero
            // 
            this.fmIdGenero.Enabled = false;
            this.fmIdGenero.Location = new System.Drawing.Point(336, 349);
            this.fmIdGenero.Name = "fmIdGenero";
            this.fmIdGenero.Size = new System.Drawing.Size(151, 20);
            this.fmIdGenero.TabIndex = 35;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(237, 401);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(58, 23);
            this.btnNew.TabIndex = 34;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(301, 401);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(58, 23);
            this.btnChange.TabIndex = 33;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(429, 401);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 23);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(365, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome:";
            // 
            // fmNome
            // 
            this.fmNome.Enabled = false;
            this.fmNome.Location = new System.Drawing.Point(278, 375);
            this.fmNome.Name = "fmNome";
            this.fmNome.Size = new System.Drawing.Size(209, 20);
            this.fmNome.TabIndex = 29;
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.AllowUserToAddRows = false;
            this.dgvGeneros.AllowUserToDeleteRows = false;
            this.dgvGeneros.AllowUserToResizeColumns = false;
            this.dgvGeneros.AllowUserToResizeRows = false;
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGeneros.Location = new System.Drawing.Point(169, 30);
            this.dgvGeneros.MultiSelect = false;
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.ReadOnly = true;
            this.dgvGeneros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGeneros.Size = new System.Drawing.Size(441, 290);
            this.dgvGeneros.TabIndex = 28;
            this.dgvGeneros.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // FormRegistroGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fmIdGenero);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fmNome);
            this.Controls.Add(this.dgvGeneros);
            this.Name = "FormRegistroGeneros";
            this.Text = "FormRegistroGeneros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fmIdGenero;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fmNome;
        private System.Windows.Forms.DataGridView dgvGeneros;
    }
}