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
        decimal valor;

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

            if (Producto1TextBox.Text == "")
            {
                errorProvider1.SetError(Producto1TextBox, " Ingrese un producto");
                return;
            }
            errorProvider1.Clear();

            if (Producto2TextBox.Text == "")
            {

                errorProvider1.SetError(Producto2TextBox, " Ingrese un producto");
                return;
            }
            errorProvider1.Clear();

            if (Producto3TextBox.Text == "")
            {
                errorProvider1.SetError(Producto3TextBox, " Ingrese un producto");
                return;
            }
            errorProvider1.Clear();

            if (Producto4TextBox.Text == "")
            {
                errorProvider1.SetError(Producto4TextBox, " Ingrese un producto");
                return;
            }
            errorProvider1.Clear();




            int cantidad1 = Convert.ToInt32(Cantidad1TextBox.Text);
            int cantidad2 = Convert.ToInt32(Cantidad2TextBox.Text);
            int cantidad3 = Convert.ToInt32(Cantidad3TextBox.Text);
            int cantidad4 = Convert.ToInt32(Cantidad4TextBox.Text);


            decimal totalPagar = await CalcularDescuentoAsync(precioProduct1, precioProduct2, precioProduct3, precioProduct4, cantidad1, cantidad2, cantidad3, cantidad4);

            decimal subTotal = (precioProduct1 * cantidad1) + (precioProduct2 * cantidad2) + (precioProduct3 * cantidad3) + (precioProduct4 * cantidad4);
            SubTotalTextBox.Text = subTotal.ToString();
            TotalTextBox.Text = totalPagar.ToString();

        }



        private async Task<decimal> CalcularDescuentoAsync(decimal precio1, decimal precio2, decimal precio3, decimal precio4, int cantidad1, int cantidad2, int cantidad3, int cantidad4)
        {

            decimal totalPagar = await Task.Run(() =>
            {

                decimal subtotal;

                subtotal = (precio1 * cantidad1) + (precio2 * cantidad2) + (precio3 * cantidad3) + (precio4 * cantidad4);
                decimal descuento = (subtotal * 15) / 100;
                totalPagar = subtotal - descuento;

                return totalPagar;

            });

            return totalPagar;
        }

    }
}
