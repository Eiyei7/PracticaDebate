using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCSharp
{
    public partial class frmSueldo : Form
    {
        
        frmNomina chek = new frmNomina();
        public frmSueldo()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNomina f = new frmNomina();
            

            f.txtNombreTrabajador.Text = txtNombre.Text;
            f.txtSueldoBase.Text = txtSldBa.Text;
            f.txtSueldoExtra.Text = txtSueldoE.Text;
            f.txtSueldoTotal.Text = (Convert.ToSingle(txtSueldoE.Text) + Convert.ToSingle(txtSueldo.Text)).ToString();
            f.Show();
        }
        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtSueldoE.Text = (Convert.ToSingle(txtHorasE.Text) * 100).ToString();
            txtSueldo.Text = (Convert.ToSingle(txtSldBa.Text) * Convert.ToSingle(txtDias.Text)).ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDias.Clear();
            txtHorasE.Clear();
            txtSldBa.Clear();
            txtSueldoE.Clear();
            txtSueldo.Clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNum(e);
        }

        private void txtSb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e,txtSldBa);
        }

        private void txtHorasE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNum(e);
        }

        private void txtSueldoE_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblsb_Click(object sender, EventArgs e)
        {

        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
Q9/