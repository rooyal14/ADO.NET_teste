
namespace ViewProject.adminForms
{
    partial class FormRelatorioVenda
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
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dgvItensVendidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeColumns = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVendas.Location = new System.Drawing.Point(12, 55);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(471, 296);
            this.dgvVendas.TabIndex = 0;
            this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged);
            // 
            // dgvItensVendidos
            // 
            this.dgvItensVendidos.AllowUserToAddRows = false;
            this.dgvItensVendidos.AllowUserToDeleteRows = false;
            this.dgvItensVendidos.AllowUserToResizeColumns = false;
            this.dgvItensVendidos.AllowUserToResizeRows = false;
            this.dgvItensVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVendidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItensVendidos.Location = new System.Drawing.Point(514, 55);
            this.dgvItensVendidos.MultiSelect = false;
            this.dgvItensVendidos.Name = "dgvItensVendidos";
            this.dgvItensVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensVendidos.Size = new System.Drawing.Size(525, 296);
            this.dgvItensVendidos.TabIndex = 1;
            // 
            // FormRelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 457);
            this.Controls.Add(this.dgvItensVendidos);
            this.Controls.Add(this.dgvVendas);
            this.Name = "FormRelatorioVenda";
            this.Text = "FormRelatorioVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridView dgvItensVendidos;
    }
}