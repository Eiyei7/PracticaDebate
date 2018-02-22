namespace PracticaCSharp
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureFondo = new System.Windows.Forms.PictureBox();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnNominaInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFondo
            // 
            this.pictureFondo.BackColor = System.Drawing.Color.Black;
            this.pictureFondo.Location = new System.Drawing.Point(118, 152);
            this.pictureFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureFondo.Name = "pictureFondo";
            this.pictureFondo.Size = new System.Drawing.Size(1114, 426);
            this.pictureFondo.TabIndex = 0;
            this.pictureFondo.TabStop = false;
            this.pictureFondo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSalir1
            // 
            this.btnSalir1.BackColor = System.Drawing.Color.Black;
            this.btnSalir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir1.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir1.ForeColor = System.Drawing.Color.White;
            this.btnSalir1.Location = new System.Drawing.Point(88, 657);
            this.btnSalir1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(99, 64);
            this.btnSalir1.TabIndex = 1;
            this.btnSalir1.Text = "Salir";
            this.btnSalir1.UseVisualStyleBackColor = false;
            this.btnSalir1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNominaInicio
            // 
            this.btnNominaInicio.BackColor = System.Drawing.Color.Red;
            this.btnNominaInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnNominaInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNominaInicio.Font = new System.Drawing.Font("Brush Script MT", 46.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNominaInicio.ForeColor = System.Drawing.Color.White;
            this.btnNominaInicio.Location = new System.Drawing.Point(147, 283);
            this.btnNominaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNominaInicio.Name = "btnNominaInicio";
            this.btnNominaInicio.Size = new System.Drawing.Size(1057, 159);
            this.btnNominaInicio.TabIndex = 3;
            this.btnNominaInicio.Text = "Nomina de Trabajadores";
            this.btnNominaInicio.UseVisualStyleBackColor = false;
            this.btnNominaInicio.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1360, 777);
            this.Controls.Add(this.btnNominaInicio);
            this.Controls.Add(this.btnSalir1);
            this.Controls.Add(this.pictureFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFondo;
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnNominaInicio;
    }
}

