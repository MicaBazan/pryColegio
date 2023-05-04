
namespace pryColegio
{
    partial class frmFrutasGustanAlumno
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
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.cbFruta = new System.Windows.Forms.ComboBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblFruta = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAlumno
            // 
            this.cbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(25, 54);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(448, 33);
            this.cbAlumno.TabIndex = 0;
            // 
            // cbFruta
            // 
            this.cbFruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFruta.FormattingEnabled = true;
            this.cbFruta.Location = new System.Drawing.Point(25, 158);
            this.cbFruta.Name = "cbFruta";
            this.cbFruta.Size = new System.Drawing.Size(448, 33);
            this.cbFruta.TabIndex = 1;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(25, 26);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(79, 25);
            this.lblAlumno.TabIndex = 2;
            this.lblAlumno.Text = "Alumno";
            // 
            // lblFruta
            // 
            this.lblFruta.AutoSize = true;
            this.lblFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruta.Location = new System.Drawing.Point(25, 130);
            this.lblFruta.Name = "lblFruta";
            this.lblFruta.Size = new System.Drawing.Size(57, 25);
            this.lblFruta.TabIndex = 3;
            this.lblFruta.Text = "Fruta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(314, 224);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 45);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmFrutasGustanAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 295);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFruta);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.cbFruta);
            this.Controls.Add(this.cbAlumno);
            this.Name = "frmFrutasGustanAlumno";
            this.Text = "Frutas que le gustan";
            this.Load += new System.EventHandler(this.frmFrutasGustanAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAlumno;
        private System.Windows.Forms.ComboBox cbFruta;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblFruta;
        private System.Windows.Forms.Button btnGuardar;
    }
}