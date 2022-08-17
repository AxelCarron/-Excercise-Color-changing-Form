using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_N_3._1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            
        }

        bool Mostrar = true;


        private void frmInicio_DoubleClick(object sender, EventArgs e)
        {
            frmSecundario F1 = new frmSecundario();
            
            if (Mostrar == true)
            {
                F1.Show();
                Mostrar = false;
            }
        }

        private void frmInicio_MouseClick_1(object sender, MouseEventArgs e)
        {
            Random generador = new Random();
            int r = generador.Next(0, 256);
            int g = generador.Next(0, 256);
            int b = generador.Next(0, 256);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
    
}
