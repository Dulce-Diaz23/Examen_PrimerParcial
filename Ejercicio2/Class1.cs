namespace Ejercicio2
{
    public class Compras
    {
        private string nombre;
        private decimal precio;
        private int cantidad;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Compras()
        {

        }

        public Compras(string _nombre, int _cantidad, decimal _precio)
        {
            Nombre = _nombre;
            Precio = _precio;
            Cantidad = _cantidad;
        }

        //metodos

        public string DevolverFactura()
        {
            return "Nombre: " + Nombre + "Precio: " + Precio + "Cantidad:" + Cantidad;
        }
    }
}
