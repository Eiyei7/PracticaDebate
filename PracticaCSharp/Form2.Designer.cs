namespace PracticaCSharp
{
    partial class frmSueldo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblsb = new System.Windows.Forms.Label();
            this.lblhextra = new System.Windows.Forms.Label();
            this.lblsextra = new System.Windows.Forms.Label();
            this.lblsueldo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtSldBa = new System.Windows.Forms.TextBox();
            this.txtHorasE = new System.Windows.Forms.TextBox();
            this.txtSueldoE = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(25, 696);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 64);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Red;
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblname.Font = new System.Drawing.Font("Brush Script MT", 37.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(60, 36);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(182, 79);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Nombre";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.BackColor = System.Drawing.Color.Red;
            this.lbldays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldays.Font = new System.Drawing.Font("Brush Script MT", 37.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.ForeColor = System.Drawing.Color.White;
            this.lbldays.Location = new System.Drawing.Point(60, 157);
            this.lbldays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(370, 79);
            this.lbldays.TabIndex = 5;
            this.lbldays.Text = "Dias trabajados";
            // 
            // lblsb
            // 
            this.lblsb.AutoSize = true;
            this.lblsb.BackColor = System.Drawing.Color.Red;
            this.lblsb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsb.Font = new System.Drawing.Font("Brush Script MT", 37.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsb.ForeColor = System.Drawing.Color.White;
            this.lblsb.Location = new System.Drawing.Point(899, 157);
            this.lblsb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsb.Name = "lblsb";
            this.lblsb.Size = new System.Drawing.Size(420, 79);
            this.lblsb.TabIndex = 6;
            this.lblsb.Text = "Sueldo base C/dia";
            this.lblsb.Click += new System.EventHandler(this.lblsb_Click);
            // 
            // lblhextra
            // 
            this.lblhextra.AutoSize = true;
            this.lblhextra.BackColor = System.Drawing.Color.Red;
            this.lblhextra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblhextra.Font = new System.Drawing.Font("Brush Script MT", 37.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhextra.ForeColor = System.Drawing.Color.White;
            this.lblhextra.Location = new System.Drawing.Point(509, 251);
            this.lblhextra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhextra.Name = "lblhextra";
            this.lblhextra.Size = new System.Drawing.Size(294, 79);
            this.lblhextra.TabIndex = 7;
            this.lblhextra.Text = "Horas extras";
            // 
            // lblsextra
            // 
            this.lblsextra.AutoSize = true;
            this.lblsextra.BackColor = System.Drawing.Color.Red;
            this.lblsextra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsextra.Font = new System.Drawing.Font("Brush Script MT", 37.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsextra.ForeColor = System.Drawing.Color.White;
            this.lblsextra.Location = new System.Drawing.Point(40, 461);
            this.lblsextra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsextra.Name = "lblsextra";
            this.lblsextra.Size = new System.Drawing.Size(292, 79);
            this.lblsextra.TabIndex = 8;
            this.lblsextra.Text = "Sueldo extra";
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.BackColor = System.Drawing.Color.Red;
            this.lblsueldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsueldo.Font = new System.Drawing.Font("Brush Script MT", 37.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsueldo.ForeColor = System.Drawing.Color.White;
            this.lblsueldo.Location = new System.Drawing.Point(1049, 461);
            this.lblsueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(178, 79);
            this.lblsueldo.TabIndex = 9;
            this.lblsueldo.Text = "Sueldo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(280, 56);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(674, 59);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1325, 665);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(60, 270);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4);
            this.txtDias.Multiline = true;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(296, 60);
            this.txtDias.TabIndex = 1;
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // txtSldBa
            // 
            this.txtSldBa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSldBa.Location = new System.Drawing.Point(964, 270);
            this.txtSldBa.Margin = new System.Windows.Forms.Padding(4);
            this.txtSldBa.Multiline = true;
            this.txtSldBa.Name = "txtSldBa";
            this.txtSldBa.Size = new System.Drawing.Size(314, 60);
            this.txtSldBa.TabIndex = 2;
            this.txtSldBa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSldBa.TextChanged += new System.EventHandler(this.txtSb_TextChanged);
            this.txtSldBa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSb_KeyPress);
            // 
            // txtHorasE
            // 
            this.txtHorasE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasE.Location = new System.Drawing.Point(509, 357);
            this.txtHorasE.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorasE.Multiline = true;
            this.txtHorasE.Name = "txtHorasE";
            this.txtHorasE.Size = new System.Drawing.Size(294, 61);
            this.txtHorasE.TabIndex = 3;
            this.txtHorasE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHorasE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasE_KeyPress);
            // 
            // txtSueldoE
            // 
            this.txtSueldoE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoE.Location = new System.Drawing.Point(49, 564);
            this.txtSueldoE.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldoE.Multiline = true;
            this.txtSueldoE.Name = "txtSueldoE";
            this.txtSueldoE.ReadOnly = true;
            this.txtSueldoE.Size = new System.Drawing.Size(268, 56);
            this.txtSueldoE.TabIndex = 15;
            this.txtSueldoE.TextChanged += new System.EventHandler(this.txtSueldoE_TextChanged);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(987, 564);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Multiline = true;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(304, 56);
            this.txtSueldo.TabIndex = 16;
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.BackColor = System.Drawing.Color.Red;
            this.btnImprimirTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTicket.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTicket.ForeColor = System.Drawing.Color.White;
            this.btnImprimirTicket.Location = new System.Drawing.Point(1069, 695);
            this.btnImprimirTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(281, 64);
            this.btnImprimirTicket.TabIndex = 17;
            this.btnImprimirTicket.Text = "Imrimir Ticket";
            this.btnImprimirTicket.UseVisualStyleBackColor = false;
            this.btnImprimirTicket.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.BackColor = System.Drawing.Color.Black;
            this.btnCalcularSalario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcularSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularSalario.Font = new System.Drawing.Font("Brush Script MT", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSalario.ForeColor = System.Drawing.Color.White;
            this.btnCalcularSalario.Location = new System.Drawing.Point(509, 508);
            this.btnCalcularSalario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(299, 64);
            this.btnCalcularSalario.TabIndex = 19;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = false;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Black;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Brush Script MT", 27F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(509, 656);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(299, 64);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1360, 771);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.btnImprimirTicket);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtSueldoE);
            this.Controls.Add(this.txtHorasE);
            this.Controls.Add(this.txtSldBa);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblsueldo);
            this.Controls.Add(this.lblsextra);
            this.Controls.Add(this.lblhextra);
            this.Controls.Add(this.lblsb);
            this.Controls.Add(this.lbldays);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSueldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblsb;
        private System.Windows.Forms.Label lblhextra;
        private System.Windows.Forms.Label lblsextra;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtSldBa;
        private System.Windows.Forms.TextBox txtHorasE;
        private System.Windows.Forms.TextBox txtSueldoE;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnImprimirTicket;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Button btnNuevo;
    }
}