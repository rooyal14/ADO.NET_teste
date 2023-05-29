
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnRegistroVendas = new System.Windows.Forms.Button();
            this.btnRegistroGeneros = new System.Windows.Forms.Button();
            this.btnRegistroLivros = new System.Windows.Forms.Button();
            this.btnRegistroAutores = new System.Windows.Forms.Button();
            this.btnRegistroUsuarios = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRelatorios
            // 
            resources.ApplyResources(this.btnRelatorios, "btnRelatorios");
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnRegistroVendas
            // 
            resources.ApplyResources(this.btnRegistroVendas, "btnRegistroVendas");
            this.btnRegistroVendas.Name = "btnRegistroVendas";
            this.btnRegistroVendas.UseVisualStyleBackColor = true;
            this.btnRegistroVendas.Click += new System.EventHandler(this.btnRegistroVendas_Click);
            // 
            // btnRegistroGeneros
            // 
            resources.ApplyResources(this.btnRegistroGeneros, "btnRegistroGeneros");
            this.btnRegistroGeneros.Name = "btnRegistroGeneros";
            this.btnRegistroGeneros.UseVisualStyleBackColor = true;
            this.btnRegistroGeneros.Click += new System.EventHandler(this.btnRegistroGeneros_Click);
            // 
            // btnRegistroLivros
            // 
            resources.ApplyResources(this.btnRegistroLivros, "btnRegistroLivros");
            this.btnRegistroLivros.Name = "btnRegistroLivros";
            this.btnRegistroLivros.UseVisualStyleBackColor = true;
            this.btnRegistroLivros.Click += new System.EventHandler(this.btnRegistroLivros_Click);
            // 
            // btnRegistroAutores
            // 
            resources.ApplyResources(this.btnRegistroAutores, "btnRegistroAutores");
            this.btnRegistroAutores.Name = "btnRegistroAutores";
            this.btnRegistroAutores.UseVisualStyleBackColor = true;
            this.btnRegistroAutores.Click += new System.EventHandler(this.btnRegistroAutores_Click);
            // 
            // btnRegistroUsuarios
            // 
            resources.ApplyResources(this.btnRegistroUsuarios, "btnRegistroUsuarios");
            this.btnRegistroUsuarios.Name = "btnRegistroUsuarios";
            this.btnRegistroUsuarios.UseVisualStyleBackColor = true;
            this.btnRegistroUsuarios.Click += new System.EventHandler(this.btnRegistroUsuarios_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnRegistroUsuarios, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRelatorios, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistroLivros, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistroVendas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistroAutores, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistroGeneros, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // FormMenuAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnRegistroVendas;
        private System.Windows.Forms.Button btnRegistroGeneros;
        private System.Windows.Forms.Button btnRegistroLivros;
        private System.Windows.Forms.Button btnRegistroAutores;
        private System.Windows.Forms.Button btnRegistroUsuarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}