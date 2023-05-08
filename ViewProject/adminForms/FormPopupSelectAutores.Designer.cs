
namespace ViewProject.adminForms
{
    partial class FormPopupSelectAutores
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
            this.fmAutor = new System.Windows.Forms.TextBox();
            this.lbxAutores = new System.Windows.Forms.ListBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fmAutor
            // 
            this.fmAutor.Location = new System.Drawing.Point(253, 35);
            this.fmAutor.Name = "fmAutor";
            this.fmAutor.Size = new System.Drawing.Size(100, 20);
            this.fmAutor.TabIndex = 0;
            this.fmAutor.TextChanged += new System.EventHandler(this.fmAutor_TextChanged);
            // 
            // lbxAutores
            // 
            this.lbxAutores.Location = new System.Drawing.Point(215, 76);
            this.lbxAutores.Name = "lbxAutores";
            this.lbxAutores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxAutores.Size = new System.Drawing.Size(182, 186);
            this.lbxAutores.TabIndex = 1;
            this.lbxAutores.Click += new System.EventHandler(this.lbxAutores_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(322, 278);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FormPopupSelectAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lbxAutores);
            this.Controls.Add(this.fmAutor);
            this.Name = "FormPopupSelectAutores";
            this.Text = "FormPopupSelectAutores";
            this.Load += new System.EventHandler(this.lbxAutores_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fmAutor;
        private System.Windows.Forms.ListBox lbxAutores;
        private System.Windows.Forms.Button btnConfirmar;
    }
}