
namespace ADO.NET_teste
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.fmNr = new System.Windows.Forms.TextBox();
            this.fmNome = new System.Windows.Forms.TextBox();
            this.fmEstoque = new System.Windows.Forms.TextBox();
            this.fmAutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmNr
            // 
            this.fmNr.Location = new System.Drawing.Point(260, 54);
            this.fmNr.Name = "fmNr";
            this.fmNr.Size = new System.Drawing.Size(100, 20);
            this.fmNr.TabIndex = 1;
            // 
            // fmNome
            // 
            this.fmNome.Location = new System.Drawing.Point(260, 105);
            this.fmNome.Name = "fmNome";
            this.fmNome.Size = new System.Drawing.Size(100, 20);
            this.fmNome.TabIndex = 2;
            // 
            // fmEstoque
            // 
            this.fmEstoque.Location = new System.Drawing.Point(260, 153);
            this.fmEstoque.Name = "fmEstoque";
            this.fmEstoque.Size = new System.Drawing.Size(100, 20);
            this.fmEstoque.TabIndex = 3;
            // 
            // fmAutor
            // 
            this.fmAutor.Location = new System.Drawing.Point(260, 192);
            this.fmAutor.Name = "fmAutor";
            this.fmAutor.Size = new System.Drawing.Size(100, 20);
            this.fmAutor.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fmAutor);
            this.Controls.Add(this.fmEstoque);
            this.Controls.Add(this.fmNome);
            this.Controls.Add(this.fmNr);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fmNr;
        private System.Windows.Forms.TextBox fmNome;
        private System.Windows.Forms.TextBox fmEstoque;
        private System.Windows.Forms.TextBox fmAutor;
    }
}

