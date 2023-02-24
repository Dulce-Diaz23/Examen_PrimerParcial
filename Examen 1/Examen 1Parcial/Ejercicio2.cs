using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1Parcial
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private async void CalcularDescuentoButton_Click(object sender, EventArgs e)
        {
            decimal precioProduct1 = Convert.ToDecimal(PrecioProducto1TextBox.Text);
            decimal precioProduct2 = Convert.ToDecimal(PrecioProducto2TextBox.Text);
            decimal precioProduct3 = Convert.ToDecimal(PrecioProducto3TextBox.Text);
            decimal precioProduct4 = Convert.ToDecimal(PrecioProducto4TextBox.Text);

            string nombProducto1 = Producto1TextBox.Text;
            string nombProducto2 = Producto2TextBox.Text;
            string nombProducto3 = Producto3TextBox.Text;
            string nombProducto4 = Producto4TextBox.Text;

            decimal totalPagar = await CalcularDescuentoAsync(precioProduct1, precioProduct2, precioProduct3, precioProduct4);


            TotalPagarTextBox.Text = totalPagar.ToString();

        }



        private async Task<decimal> CalcularDescuentoAsync(decimal precio1, decimal precio2, decimal precio3, decimal precio4)
        {
            decimal totalPagar = await Task.Run(() =>
            {


                decimal subtotal = precio1 + precio2 + precio3 + precio4;
                decimal descuento = (subtotal * 15) / 100;
                totalPagar = subtotal - descuento;
                return totalPagar;
            });

            return totalPagar;
        }
    }
}
