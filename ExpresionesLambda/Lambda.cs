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
    public partial class Lambda : Form
    {
        public Lambda()
        {
            InitializeComponent();
        }



        List<int> numeros = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


        private void btnmostrar_Click(object sender, EventArgs e)
        {

            List<int> NumerosPares = numeros.FindAll(i => i % 2 == 0);
    

            foreach (var num in numeros)
            {
                this.txtmostrar.Text += num.ToString() + ",";
            }
        }
         private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.txtmostrar.Clear();
        }
    }
}  
