
namespace pryColegio
{
    partial class frmQueFrutaNoLeGustanAlumno
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.dgvFruta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(116, 45);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(264, 28);
            this.cbNombre.TabIndex = 1;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(403, 37);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(94, 43);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "VER";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // dgvFruta
            // 
            this.dgvFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruta.Location = new System.Drawing.Point(31, 113);
            this.dgvFruta.Name = "dgvFruta";
            this.dgvFruta.RowHeadersWidth = 51;
            this.dgvFruta.RowTemplate.Height = 24;
            this.dgvFruta.Size = new System.Drawing.Size(466, 309);
            this.dgvFruta.TabIndex = 3;
            // 
            // frmQueFrutaNoLeGustanAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 452);
            this.Controls.Add(this.dgvFruta);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQueFrutaNoLeGustanAlumno";
            this.Text = "frmQueFrutaNoLeGustanAlumno";
            this.Load += new System.EventHandler(this.frmQueFrutaNoLeGustanAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView dgvFruta;
    }
}