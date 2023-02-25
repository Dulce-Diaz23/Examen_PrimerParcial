using System;
using System.Windows.Forms;

namespace Examen_1Parcial
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }



        private void MostrarButton_Click(object sender, EventArgs e)
        {

            MostrarNombreReemplazandoNumeros();

        }

        private void MostrarNombreReemplazandoNumeros()
        {
            for (int numero = 1; numero <= 100; numero++)
            {
                string nomb = "Dulce_Diaz";


                if (numero % 3 == 0 && numero % 5 == 0)
                {
                    NumerosListBox.Items.Add("Dulce_Diaz");
                }

                else if (numero % 3 == 0)
                {
                    NumerosListBox.Items.Add("Dulce");
                }

                else if (numero % 5 == 0)
                {
                    NumerosListBox.Items.Add("Diaz");
                }


                else if (numero % 3 != 0 && numero % 5 != 0)
                {
                    NumerosListBox.Items.Add(numero);
                }

                else if (numero % 3 == 0 && numero % 5 == 0)
                {
                    NumerosListBox.Items.Add("Dulce_Diaz");
                }

            }
        }


    }
}

