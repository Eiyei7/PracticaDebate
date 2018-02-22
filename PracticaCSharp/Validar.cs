using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCSharp
{
    class Validar
    {
        public static void SoloNumeros(KeyPressEventArgs V, TextBox x)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (V.KeyChar.ToString().Equals(".") && !x.Text.Contains("."))
            {
                V.Handled = false;
            }
            else if (V.KeyChar.ToString().Equals("-") && x.Text == "" && !x.Text.Contains("-"))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;//esto detiene la escritura y manda un mensaje de alerta al usuario
                MessageBox.Show("Solo numeros y 1 punto decimal en la caja" + x.Name);
            }
        }
        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        public static void SoloNum(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;

            }
            else
            {
                pE.Handled = true;
            }
        }
    }
}
