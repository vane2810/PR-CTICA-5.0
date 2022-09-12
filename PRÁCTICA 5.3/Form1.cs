using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRÁCTICA_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cálculo del interés simple");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string option = comboOpciones.Text;
            string c = txtNum1.Text;
            string r = txtNum2.Text;
            string t = txtNum3.Text;

            if (c == "" || r == "" || t == "" || option == "")
            {
                MessageBox.Show("Ingresar todos los datos :D ");
            }
            else
            {
                double I;
                double C = double.Parse(c);
                double R = double.Parse(r);
                double T = double.Parse(t);

                switch (option)
                {
                    case "Anual":
                        I = C * (R/100) * T;
                        MessageBox.Show("El interés simple es : " + I);
                        break;

                    case "Mensual":
                        I = C * (R/100) * (T/12);
                        MessageBox.Show("El interés simple es : " + I);
                        break;

                    case "Diario":
                        I = C * (R/100) * (T/365);
                        MessageBox.Show("El interés simple es : " + I);
                        break;
                }
            }
        }
    }
}
