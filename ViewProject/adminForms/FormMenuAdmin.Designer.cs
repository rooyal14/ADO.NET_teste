
namespace ViewProject.adminForms
{
    partial class FormMenuAdmin
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
            this.btnRegistroUsuarios = new System.Windows.Forms.Button();
            this.btnRegistroLivros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroUsuarios
            // 
            this.btnRegistroUsuarios.Location = new System.Drawing.Point(281, 119);
            this.btnRegistroUsuarios.Name = "btnRegistroUsuarios";
            this.btnRegistroUsuarios.Size = new System.Drawing.Size(138, 33);
            this.btnRegistroUsuarios.TabIndex = 0;
            this.btnRegistroUsuarios.Text = "Registro de Usuários";
            this.btnRegistroUsuarios.UseVisualStyleBackColor = true;
            this.btnRegistroUsuarios.Click += new System.EventHandler(this.btnRegistroUsuarios_Click);
            // 
            // btnRegistroLivros
            // 
            this.btnRegistroLivros.Location = new System.Drawing.Point(281, 185);
            this.btnRegistroLivros.Name = "btnRegistroLivros";
            this.btnRegistroLivros.Size = new System.Drawing.Size(138, 33);
            this.btnRegistroLivros.TabIndex = 1;
            this.btnRegistroLivros.Text = "Registro de Livros";
            this.btnRegistroLivros.UseVisualStyleBackColor = true;
            this.btnRegistroLivros.Click += new System.EventHandler(this.btnRegistroLivros_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistroLivros);
            this.Controls.Add(this.btnRegistroUsuarios);
            this.Name = "FormMenuAdmin";
            this.Text = "FormMenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroUsuarios;
        private System.Windows.Forms.Button btnRegistroLivros;
    }
}