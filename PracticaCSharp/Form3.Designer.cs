namespace PracticaCSharp
{
    partial class frmNomina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNomina));
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblNominaPago = new System.Windows.Forms.Label();
            this.lblNombreTrabajador = new System.Windows.Forms.Label();
            this.txtNombreTrabajador = new System.Windows.Forms.TextBox();
            this.lblSldBase = new System.Windows.Forms.Label();
            this.txtSueldoBase = new System.Windows.Forms.TextBox();
            this.lblSldExtra = new System.Windows.Forms.Label();
            this.txtSueldoExtra = new System.Windows.Forms.TextBox();
            this.lblSldTotal = new System.Windows.Forms.Label();
            this.txtSueldoTotal = new System.Windows.Forms.TextBox();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.Black;
            this.btnSalir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir2.Font = new System.Drawing.Font("Edwardian Script ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.Color.White;
            this.btnSalir2.Location = new System.Drawing.Point(1041, 445);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(99, 64);
            this.btnSalir2.TabIndex = 3;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Black;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(44, 511);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(281, 64);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNominaPago
            // 
            this.lblNominaPago.AutoSize = true;
            this.lblNominaPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNominaPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 37.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNominaPago.Location = new System.Drawing.Point(39, 38);
            this.lblNominaPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNominaPago.Name = "lblNominaPago";
            this.lblNominaPago.Size = new System.Drawing.Size(530, 73);
            this.lblNominaPago.TabIndex = 19;
            this.lblNominaPago.Text = "Nomina de Pago";
            // 
            // lblNombreTrabajador
            // 
            this.lblNombreTrabajador.AutoSize = true;
            this.lblNombreTrabajador.BackColor = System.Drawing.Color.White;
            this.lblNombreTrabajador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTrabajador.Location = new System.Drawing.Point(35, 133);
            this.lblNombreTrabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTrabajador.Name = "lblNombreTrabajador";
            this.lblNombreTrabajador.Size = new System.Drawing.Size(558, 54);
            this.lblNombreTrabajador.TabIndex = 20;
            this.lblNombreTrabajador.Text = "Nombre del trabajador:";
            // 
            // txtNombreTrabajador
            // 
            this.txtNombreTrabajador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTrabajador.Location = new System.Drawing.Point(43, 192);
            this.txtNombreTrabajador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreTrabajador.Multiline = true;
            this.txtNombreTrabajador.Name = "txtNombreTrabajador";
            this.txtNombreTrabajador.ReadOnly = true;
            this.txtNombreTrabajador.Size = new System.Drawing.Size(923, 70);
            this.txtNombreTrabajador.TabIndex = 21;
            this.txtNombreTrabajador.TextChanged += new System.EventHandler(this.txtTrabajador_TextChanged);
            // 
            // lblSldBase
            // 
            this.lblSldBase.AutoSize = true;
            this.lblSldBase.BackColor = System.Drawing.Color.White;
            this.lblSldBase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSldBase.Location = new System.Drawing.Point(35, 299);
            this.lblSldBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSldBase.Name = "lblSldBase";
            this.lblSldBase.Size = new System.Drawing.Size(322, 54);
            this.lblSldBase.TabIndex = 22;
            this.lblSldBase.Text = "Sueldo Base:";
            // 
            // txtSueldoBase
            // 
            this.txtSueldoBase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBase.Location = new System.Drawing.Point(43, 357);
            this.txtSueldoBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSueldoBase.Multiline = true;
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.ReadOnly = true;
            this.txtSueldoBase.Size = new System.Drawing.Size(304, 70);
            this.txtSueldoBase.TabIndex = 23;
            this.txtSueldoBase.TextChanged += new System.EventHandler(this.txtSuBase_TextChanged);
            // 
            // lblSldExtra
            // 
            this.lblSldExtra.AutoSize = true;
            this.lblSldExtra.BackColor = System.Drawing.Color.White;
            this.lblSldExtra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSldExtra.Location = new System.Drawing.Point(486, 299);
            this.lblSldExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSldExtra.Name = "lblSldExtra";
            this.lblSldExtra.Size = new System.Drawing.Size(328, 54);
            this.lblSldExtra.TabIndex = 24;
            this.lblSldExtra.Text = "Sueldo Extra:";
            this.lblSldExtra.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSueldoExtra
            // 
            this.txtSueldoExtra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoExtra.Location = new System.Drawing.Point(486, 357);
            this.txtSueldoExtra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSueldoExtra.Multiline = true;
            this.txtSueldoExtra.Name = "txtSueldoExtra";
            this.txtSueldoExtra.ReadOnly = true;
            this.txtSueldoExtra.Size = new System.Drawing.Size(304, 70);
            this.txtSueldoExtra.TabIndex = 25;
            // 
            // lblSldTotal
            // 
            this.lblSldTotal.AutoSize = true;
            this.lblSldTotal.BackColor = System.Drawing.Color.White;
            this.lblSldTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSldTotal.Location = new System.Drawing.Point(869, 289);
            this.lblSldTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSldTotal.Name = "lblSldTotal";
            this.lblSldTotal.Size = new System.Drawing.Size(322, 54);
            this.lblSldTotal.TabIndex = 26;
            this.lblSldTotal.Text = "Sueldo Total:";
            // 
            // txtSueldoTotal
            // 
            this.txtSueldoTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoTotal.Location = new System.Drawing.Point(858, 347);
            this.txtSueldoTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSueldoTotal.Multiline = true;
            this.txtSueldoTotal.Name = "txtSueldoTotal";
            this.txtSueldoTotal.ReadOnly = true;
            this.txtSueldoTotal.Size = new System.Drawing.Size(363, 70);
            this.txtSueldoTotal.TabIndex = 27;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempo.Location = new System.Drawing.Point(747, 38);
            this.lbTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(139, 29);
            this.lbTiempo.TabIndex = 30;
            this.lbTiempo.Text = "Fecha/Hora";
            this.lbTiempo.Click += new System.EventHandler(this.lbTiempo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1360, 778);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.txtSueldoTotal);
            this.Controls.Add(this.lblSldTotal);
            this.Controls.Add(this.txtSueldoExtra);
            this.Controls.Add(this.lblSldExtra);
            this.Controls.Add(this.txtSueldoBase);
            this.Controls.Add(this.lblSldBase);
            this.Controls.Add(this.txtNombreTrabajador);
            this.Controls.Add(this.lblNombreTrabajador);
            this.Controls.Add(this.lblNominaPago);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblNominaPago;
        private System.Windows.Forms.Label lblNombreTrabajador;
        private System.Windows.Forms.Label lblSldBase;
        private System.Windows.Forms.Label lblSldExtra;
        private System.Windows.Forms.Label lblSldTotal;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txtNombreTrabajador;
        public System.Windows.Forms.TextBox txtSueldoBase;
        public System.Windows.Forms.TextBox txtSueldoExtra;
        public System.Windows.Forms.TextBox txtSueldoTotal;
    }
}