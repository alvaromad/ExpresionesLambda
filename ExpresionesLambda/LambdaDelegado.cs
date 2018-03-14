using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpresionesLambda
{
    public partial class LambdaDelegado : Form
    {
        public LambdaDelegado()
        {
            InitializeComponent();
        }

        List<int> numeros = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        delegate int del(int i);


        private void btnmostrar_Click(object sender, EventArgs e)
        {

            foreach (var num in numeros)
            {
                del delegado = z => z * z;
                this.txtmostrar.Text += delegado(num) + ",";

            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.txtmostrar.Clear();
        }
    }
}
