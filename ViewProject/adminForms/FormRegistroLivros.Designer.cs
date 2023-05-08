
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
            this.fmNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.fmEstoque = new System.Windows.Forms.TextBox();
            this.fmAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fmNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fmPrecoUnitario = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAutorPopup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // fmNome
            // 
            this.fmNome.Enabled = false;
            this.fmNome.Location = new System.Drawing.Point(664, 154);
            this.fmNome.Name = "fmNome";
            this.fmNome.Size = new System.Drawing.Size(209, 20);
            this.fmNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
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
            this.dgv.Size = new System.Drawing.Size(542, 287);
            this.dgv.TabIndex = 8;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(754, 334);
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
            this.btnInsert.Location = new System.Drawing.Point(818, 334);
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
            this.btnChange.Location = new System.Drawing.Point(690, 334);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(58, 23);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(626, 334);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(58, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // fmEstoque
            // 
            this.fmEstoque.Enabled = false;
            this.fmEstoque.Location = new System.Drawing.Point(691, 192);
            this.fmEstoque.Name = "fmEstoque";
            this.fmEstoque.Size = new System.Drawing.Size(182, 20);
            this.fmEstoque.TabIndex = 3;
            // 
            // fmAutor
            // 
            this.fmAutor.Enabled = false;
            this.fmAutor.Location = new System.Drawing.Point(664, 262);
            this.fmAutor.Name = "fmAutor";
            this.fmAutor.Size = new System.Drawing.Size(179, 20);
            this.fmAutor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // fmNr
            // 
            this.fmNr.Enabled = false;
            this.fmNr.Location = new System.Drawing.Point(673, 116);
            this.fmNr.Name = "fmNr";
            this.fmNr.Size = new System.Drawing.Size(200, 20);
            this.fmNr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor Unitário:";
            // 
            // fmPrecoUnitario
            // 
            this.fmPrecoUnitario.Enabled = false;
            this.fmPrecoUnitario.Location = new System.Drawing.Point(702, 294);
            this.fmPrecoUnitario.Name = "fmPrecoUnitario";
            this.fmPrecoUnitario.Size = new System.Drawing.Size(174, 20);
            this.fmPrecoUnitario.TabIndex = 14;
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(676, 227);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(200, 21);
            this.cbxGenero.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(623, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Gênero:";
            // 
            // btnAutorPopup
            // 
            this.btnAutorPopup.Location = new System.Drawing.Point(852, 260);
            this.btnAutorPopup.Name = "btnAutorPopup";
            this.btnAutorPopup.Size = new System.Drawing.Size(24, 23);
            this.btnAutorPopup.TabIndex = 41;
            this.btnAutorPopup.Text = "...";
            this.btnAutorPopup.UseVisualStyleBackColor = true;
            this.btnAutorPopup.Click += new System.EventHandler(this.btnAutorPopup_Click);
            // 
            // FormRegistroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 468);
            this.Controls.Add(this.btnAutorPopup);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fmPrecoUnitario);
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
        private System.Windows.Forms.TextBox fmNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox fmEstoque;
        private System.Windows.Forms.TextBox fmAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fmNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fmPrecoUnitario;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAutorPopup;
    }
}

