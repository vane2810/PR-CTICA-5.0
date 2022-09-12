using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRÁCTICA_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Calculadora");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string option = comboOperaciones.Text;
            string nume1 = txtNum1.Text;
            string nume2 = txtNum2.Text;

            if (nume1 == "" || nume2 == "" || option == "")
            {
                MessageBox.Show("Ingresar los datos: ");
            }
            else
            {
                double num1 = double.Parse(nume1);
                double num2 = double.Parse(nume2);

                switch (option)
                {
                    case "Suma":
                        MessageBox.Show("La suma es : " + SUMA(num1,num2));
                        break;

                    case "Resta":
                        MessageBox.Show("La resta es : " + RESTA(num1,num2));
                        break;

                    case "Multiplicación":
                        MessageBox.Show("La multiplicación es : " + MULTI(num1, num2));
                        break;

                    case "División":
                        MessageBox.Show("El división es:  " + DIV(num1, num2));
                        break;
                }
            }
        }

        // Suma
        static double SUMA(double num1, double num2) => num1 + num2;

        // Resta
        static double RESTA(double num1, double num2) => num1 - num2;

        // Multiplicación
        static double MULTI(double num1, double num2) => num1 * num2;

        //División
        static double DIV(double num1, double num2) => num1 / num2;
    }
}
