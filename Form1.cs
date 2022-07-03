using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text.ToString();
            string reverse = String.Empty;
            char [] car = new char[texto.Length];
            for (int i = 0; i < texto.Length; i++)
            {
                car[i] = texto[i];
            }
            for (int i = car.Length - 1; i >= 0; i--)
            {
                reverse += car[i];
            }
            label2.Text = reverse;
        }
    }
}
