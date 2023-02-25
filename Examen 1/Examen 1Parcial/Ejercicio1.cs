using System;
using System.Windows.Forms;

namespace Examen_1Parcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        String interesMensual;
        double interes;
        decimal CalInteres;
        double total;
        private void CalculoInteresButton_Click(object sender, EventArgs e)
        {
            calculoIntereses(200000, 0.015, 12);
        }

        private void calculoIntereses(double Capital, double tasaIntreses, int meses)
        {

            InteresListBox.Items.Add("Capital: L. " + Capital);
            InteresListBox.Items.Add("");
            InteresListBox.Items.Add("Intereses Acumulados");

            for (int i = 1; i <= meses; i++)
            {
                interes += tasaIntreses * Capital;
                total = Capital + interes;

                if (i == 1)
                {
                    interesMensual = "Enero " + ":           L. " + total.ToString();

                }
                else if (i == 2)
                {
                    interesMensual = "Febrero " + ":       L. " + total.ToString();

                }
                else if (i == 3)
                {
                    interesMensual = "Marzo " + ":           L. " + total.ToString();

                }
                else if (i == 4)
                {
                    interesMensual = "Abril " + ":              L. " + total.ToString();

                }
                else if (i == 5)
                {
                    interesMensual = "Mayo " + ":            L. " + total.ToString();

                }
                else if (i == 6)
                {
                    interesMensual = "Junio " + ":             L. " + total.ToString();

                }
                else if (i == 7)
                {
                    interesMensual = "Julio" + ":               L. " + total.ToString();

                }
                else if (i == 8)
                {
                    interesMensual = "Agosto" + ":          L. " + total.ToString();

                }
                else if (i == 9)
                {
                    interesMensual = "Septiembre" + ": L. " + total.ToString();

                }
                else if (i == 10)
                {
                    interesMensual = "Octubre" + ":         L. " + total.ToString();

                }
                else if (i == 11)
                {
                    interesMensual = "Noviembre" + ":  L. " + total.ToString();

                }
                else if (i == 12)
                {
                    interesMensual = "Diciembre" + ":    L. " + total.ToString();

                }
                InteresListBox.Items.Add(interesMensual);
            }



            return;

        }


    }
}
