
namespace ViewProject
{
    partial class FormRegistroLivros
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
            this.fmNr = new System.Windows.Forms.TextBox();
            this.fmNome = new System.Windows.Forms.TextBox();
            this.fmEstoque = new System.Windows.Forms.TextBox();
            this.fmAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // fmNr
            // 
            this.fmNr.Enabled = false;
            this.fmNr.Location = new System.Drawing.Point(596, 111);
            this.fmNr.Name = "fmNr";
            this.fmNr.Size = new System.Drawing.Size(200, 20);
            this.fmNr.TabIndex = 1;
            // 
            // fmNome
            // 
            this.fmNome.Enabled = false;
            this.fmNome.Location = new System.Drawing.Point(587, 149);
            this.fmNome.Name = "fmNome";
            this.fmNome.Size = new System.Drawing.Size(209, 20);
            this.fmNome.TabIndex = 2;
            // 
            // fmEstoque
            // 
            this.fmEstoque.Enabled = false;
            this.fmEstoque.Location = new System.Drawing.Point(614, 187);
            this.fmEstoque.Name = "fmEstoque";
            this.fmEstoque.Size = new System.Drawing.Size(182, 20);
            this.fmEstoque.TabIndex = 3;
            // 
            // fmAutor
            // 
            this.fmAutor.Enabled = false;
            this.fmAutor.Location = new System.Drawing.Point(584, 223);
            this.fmAutor.Name = "fmAutor";
            this.fmAutor.Size = new System.Drawing.Size(212, 20);
            this.fmAutor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(36, 76);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(441, 290);
            this.dgv.TabIndex = 8;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(674, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(738, 262);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(610, 262);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(58, 23);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(546, 262);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(58, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FormRegistroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 471);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fmAutor);
            this.Controls.Add(this.fmEstoque);
            this.Controls.Add(this.fmNome);
            this.Controls.Add(this.fmNr);
            this.Name = "FormRegistroLivros";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fmNr;
        private System.Windows.Forms.TextBox fmNome;
        private System.Windows.Forms.TextBox fmEstoque;
        private System.Windows.Forms.TextBox fmAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnNew;
    }
}

