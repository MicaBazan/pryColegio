
namespace pryColegio
{
    partial class frmQueFrutaLeGustanaUnAlumno
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
            this.btnVer = new System.Windows.Forms.Button();
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.dgvFruta = new System.Windows.Forms.DataGridView();
            this.FRUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(384, 36);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(149, 41);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "VER";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // cbAlumno
            // 
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(115, 42);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(247, 30);
            this.cbAlumno.TabIndex = 3;
            // 
            // dgvFruta
            // 
            this.dgvFruta.AllowUserToAddRows = false;
            this.dgvFruta.AllowUserToDeleteRows = false;
            this.dgvFruta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FRUTA});
            this.dgvFruta.Location = new System.Drawing.Point(34, 109);
            this.dgvFruta.Name = "dgvFruta";
            this.dgvFruta.ReadOnly = true;
            this.dgvFruta.RowHeadersWidth = 51;
            this.dgvFruta.RowTemplate.Height = 24;
            this.dgvFruta.Size = new System.Drawing.Size(499, 300);
            this.dgvFruta.TabIndex = 4;
            // 
            // FRUTA
            // 
            this.FRUTA.HeaderText = "FRUTA";
            this.FRUTA.MinimumWidth = 6;
            this.FRUTA.Name = "FRUTA";
            this.FRUTA.ReadOnly = true;
            // 
            // frmQueFrutaLeGustanaUnAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 443);
            this.Controls.Add(this.dgvFruta);
            this.Controls.Add(this.cbAlumno);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQueFrutaLeGustanaUnAlumno";
            this.Text = "frmQueFrutaLeGustanaUnAlumno";
            this.Load += new System.EventHandler(this.frmQueFrutaLeGustanaUnAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cbAlumno;
        private System.Windows.Forms.DataGridView dgvFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRUTA;
    }
}