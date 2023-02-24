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
        decimal cantidad = 200000;
        decimal interes;
        decimal CalInteres;
        decimal total;
        private void CalculoInteresButton_Click(object sender, EventArgs e)
        {
            calculoIntereses();
        }

        private decimal calculoIntereses()
        {
            for (int i = 1; i <= 12; i++)
            {




                interes = (decimal)(1.5 / 100);
                CalInteres = cantidad * interes * i;
                total += CalInteres + cantidad;
                InteresListBox.Items.Add("Mes" + (i) + ". " + total);
            }




            return total;
        }


    }
}
