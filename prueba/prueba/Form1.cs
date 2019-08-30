using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int multiplicar (int a, int b,int c)
        {
            return a * b *c;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (cbxcoloc.ThreeState=true)
            { 
            MessageBox.Show(multiplicar(int.Parse(num1.Text), int.Parse(num2.Text),950).ToString());
            }
            if(checkBox2.ThreeState=true)
            {
                MessageBox.Show(multiplicar(int.Parse(num1.Text), int.Parse(num2.Text), 500).ToString());
            }
        }
 
    }
}
